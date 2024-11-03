using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTrainingApplication.ViewModels
{
    internal class Prompts
    {
        public static string HowCanILearn(string _subject, string _learnLevel)
        {
            string prompt = $"C# dilinde {_subject} konusunu bana {_learnLevel} " +
                "seviyesinde olanların rahatlıkla anlayacağı bir dilde anlat. Aralara örnekler ekleyebilirsin.";
            return prompt;
        }
        public static string TestYourself(List<string> _subjectList, string _difficutlyLevel)
        {
            string subjects = "";
            foreach (string item in _subjectList)
                subjects += item + (item != _subjectList.Last() ? "," : " ");

            string prompt = $"C# yazılım bilgilerimi sınamak istiyorum. Şimdiye kadar ({subjects}) bu konuları öğrendim." +
                             $"Beni {_difficutlyLevel} seviyede zorla. Sonradan ürettiğin örneğin, yazdığım koda göre puanlamanı isteyeceğimden örneğin kodunu yazma.";
            return prompt;
        }
        public static string TestYourself(string _subjects, string _difficutlyLevel)
        {
            string prompt = $"C# yazılım bilgilerimi sınamak istiyorum. Şimdiye kadar ({_subjects}) bu konuları öğrendim." +
                             $"Beni {_difficutlyLevel} seviyede zorla. Sonradan ürettiğin örneğin, yazdığım koda göre puanlamanı isteyeceğimden örneğin kodunu yazma.";
            return prompt;
        }
        public static string ControlYourTest(string _questionPrompt, string _answer)
        {
            string prompt = $"Soru: {_questionPrompt} \n \n \n" +
                            $"Örneğine karşılık böyle bir kod yazdım. Benim Cevabımda belirtildiği gibi." +
                            $"Benim Cevabım:\n" +
                            $"```{_answer}```" +
                            $"Senden Soruya göre yazdığım kodu puanlamanı istiyorum." +
                            $"Kodlama Becerisi, Algoritma ve Mantık, Kod Okunabilirliği, Performans ve Verililik, Hata Yönetimi " +
                            $"başlıkları altından 0 - 10 aralığında(ondalıklı sayılar dahil) bir puan vermeni istiyorum. \n" +
                            $"Sonrasında hatalarımı, eksiklerimi ve nelerimin geliştirmem gerektiğini bana anlat.";
            return prompt;
        }
        public static string CreateApplication(string _prompt, string _detailLevel)
        {

            string prompt = $"Senden C# dilini kullanarak söyleyeceğim konulara ve seviyeye göre uygulama kodu yazmanı isteyeceğim.\n" +
                            $"{_prompt} tarzında bir uygulama yapmanı istiyorum." +
                            $"{_detailLevel} detay seviyesinde bana c# kodu yaz. Yazdığın kodu açıklamayı en sona bırak.";
            return prompt;
        }
        public static string CodeRun(List<string> _values, string _code)
        {
            string values = "";
            if (_values != null)
                _values.ForEach(b => values = "\n" + b.ToString());
            string prompt = "Sana göndereceğim c# kodunu simüle etmeni istiyorum. Kodda ufak bir ';' hatası olsa bile çıktı olarak hatanın nerede olduğunu göster. Eğer sana kodda kullanıcıdan istenen verileri atmadıysam sen bir değer ver." +
                            $"{values} \n " +
                            $"```{_code}```" +
                            $"\n kodun çıktısını kod bloğu olarak göster.";

            return prompt;
        }
        public static string CodeFixIt(string _code)
        {
            string prompt = "Sana atacağım kodda bulunan hataları düzenle ve kod bloğu olarak tekrar bana at.\n" +
                            $"```{_code}```";
            return prompt;
        }
        public static string RequestCodeFromAI(string _prompt)
        {
            string prompt = $"C# dilindeki metnimi vereceğim. Metindeki '//ask: ' sonrasındaki o satırda bulunan metin kullanıcı isteklerini belirtiyor." +
                            "Bu istekleri dikkate alarak gerekli eklemeleri, çıkarmaları yapıp düzenlenmiş metni kod bloğunda gönder.\n" +
                            "Kullanıcı kod dışında bir şey isterse, kullanıcı isteğinin yerine // açıklama satırı şeklinde kısaca neden yapamayacağına dair mesaj yaz." +
                            $"Metin:" + _prompt;
            return prompt;
        }

    }
}
