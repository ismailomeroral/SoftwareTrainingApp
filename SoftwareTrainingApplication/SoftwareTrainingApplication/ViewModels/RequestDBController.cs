using SoftwareTrainingApplication.EntityModels;
using SoftwareTrainingApplication.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.ViewModels
{
    internal class RequestDBController
    {
        static RequestDBController()
        {
            requests = BreakUpDataBase();
        }

        private static List<string> patternList = new List<string>
        {
            @"<request>(.*?)</request>",
            @"<id>(.*?)</id>",
            @"<content>(.*?)</content>",
            @"<user>(.*?)</user>",
            @"<title>(.*?)</title>",
        };
        private static List<Request> requests = new List<Request>();
        public static List<Request> ToList()
        {
            return requests;
        }
        private static List<Request> BreakUpDataBase()
        {
            string db = File.ReadAllText(DirInfo.requestStoragePath, Encoding.UTF8).Trim();

            var requestlist = Regex.Matches(db, patternList[0], RegexOptions.IgnoreCase | RegexOptions.Singleline);
            List<Request> list = new List<Request>();
            foreach (Match request in requestlist)
            {
                string id = PatternController.LearnPattern(request.Groups[1].Value, patternList[1]).Groups[1].Value;
                string title = PatternController.LearnPattern(request.Groups[1].Value, patternList[4]).Groups[1].Value;

                var contentlist = PatternController.LearnPatterns(request.Groups[1].Value, patternList[2]);
                List<Chat> cont = new List<Chat>();
                foreach (Match content in contentlist)
                {
                    string user = PatternController.LearnPattern(content.Groups[1].Value, patternList[3]).Groups[1].Value;
                    string value = PatternController.ReplacePattern(content.Groups[1].Value, patternList[3], "");
                    cont.Add(new Chat { user = user, message = value });
                }
                list.Add(new Request { id = id,title = title, chats = cont });
            }
            return list;
        }
        public static void AddRequest(Request _request)
        {
            string key = GenerateController.GenerateRandomKey(16);
            _request.id = key;
            requests.Add(_request);
            SaveChanges();
        }
        public static void UpdateRequest(Request _request)
        {
            Request rq = FindRequest(_request.id);
            rq.title = _request.title;
            rq.chats = _request.chats;
            SaveChanges();
        }
        public static void RemoveRequest(string _deleteRequesId)
        {
            requests.Remove(requests.Where(b => b.id == _deleteRequesId).First());
            SaveChanges();
        }

        public static Request FindRequest(string _id)
        {
            return requests.Find(b => b.id == _id);
        }
        public static void SaveChanges()
        {
            string dbSavedText = "";
            foreach (var request in requests)
            {
                string stadbBody = $"\n<request>\n" +
                                             $"   <id>{request.id}</id>\n" +
                                             $"   <title>{request.title}</title>\n";
                foreach (var content in request.chats)
                {
                    stadbBody += $"<content>" +
                                 $"<user>{content.user}</user>" +
                                 $"{content.message}" +
                                 $"</content>\n";
                }
                stadbBody += $"</request>\n";
                dbSavedText += stadbBody;
            }
            File.WriteAllText(DirInfo.requestStoragePath, dbSavedText);
        }
    }
}
