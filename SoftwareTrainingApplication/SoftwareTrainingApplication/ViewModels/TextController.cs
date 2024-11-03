using Newtonsoft.Json.Linq;
using SoftwareTrainingApplication.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SoftwareTrainingApplication.ViewModels
{
    internal class TextController
    {


        public static List<Chat> SplitTextIntoCodeAndMessage(string _input)
        {
            List<Chat> list = new List<Chat>();

            List<string> lines = _input.Split('\n').ToList();
            bool isInCodeBlock = false;
            string textBlock = "";
            string codeBlock = "";
            foreach (string line in lines)
            {
                string trimmedLine = line.Trim();
                if (string.IsNullOrWhiteSpace(trimmedLine)) continue; // Boş satırları atla

                if (trimmedLine.StartsWith("```"))
                {
                    // Kod bloğu başladığında ya da bittiğinde, mevcut metni ekle
                    if (!string.IsNullOrEmpty(textBlock))
                    {
                        list.Add(new Chat { user = "text", message = textBlock });
                        textBlock = "";
                    }

                    isInCodeBlock = !isInCodeBlock;

                    if (!isInCodeBlock)
                    {
                        list.Add(new Chat { user = "code", message = codeBlock });
                        codeBlock = "";
                    }
                    continue;
                }
                if (isInCodeBlock)
                    codeBlock += line + "\n";
                else
                    textBlock += line + "\n";

            }

            // Son kalan metin bloğunu ekle
            if (!string.IsNullOrEmpty(textBlock))
            {
                list.Add(new Chat { user = "text", message = textBlock });
                textBlock = "";
            }


            return list;
        }


        public static FormatedText RemoveMarksAndFindLocations(string _text, string _startMark, string _endMark, string _processName, List<(int Start, int Length, string Process)> locations = null)
        {
            if (locations == null)
                locations = new List<(int Start, int Length, string Process)>(); // Liste null ise yeni liste oluştur
            int currentIndex = 0;
            while ((currentIndex = _text.IndexOf(_startMark, currentIndex)) != -1)
            {
                int endIndex = _text.IndexOf(_endMark, currentIndex + _startMark.Length);
                if (endIndex == -1) break;

                // İşaretler arasındaki metin için başlangıç ve uzunluk bilgisi
                int contentStart = currentIndex + _startMark.Length / 2;
                int contentLength = endIndex - currentIndex + _endMark.Length / 2;

                // Konumu kaydet
                locations.Add((contentStart, contentLength, _processName));

                // İşaretlerin yerini boşluklarla değiştir
                if (_endMark != "\n")
                    _text = _text.Remove(endIndex, _endMark.Length).Insert(endIndex, new string(' ', _endMark.Length));

                _text = _text.Remove(currentIndex, _startMark.Length).Insert(currentIndex, new string(' ', _startMark.Length));

                // Sonraki işarete geç
                currentIndex += contentLength;
            }

            return new FormatedText { text = _text, locations = locations };
        }

        public static List<int> FindWordPositions(string _text, string _word)
        {
            List<int> positions = new List<int>();
            int index = _text.IndexOf(_word, StringComparison.OrdinalIgnoreCase);

            while (index != -1)
            {
                positions.Add(index);
                index = _text.IndexOf(_word, index + _word.Length, StringComparison.OrdinalIgnoreCase);
            }

            return positions;
        }

        public static void AdjustTextBoxHeight(RichTextBox textBox)
        {
            int lineCount = textBox.GetLineFromCharIndex(textBox.Text.Length) + 1;
            int lineHeight = TextRenderer.MeasureText("A", textBox.Font).Height;
            int desiredHeight = (lineCount) * lineHeight;

            //  MessageBox.Show($"{lineCount} + {lineHeight} = {desiredHeight}");
            textBox.Parent.Height = desiredHeight + 10;
        }
    }
}
