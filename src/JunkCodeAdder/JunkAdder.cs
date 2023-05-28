using HtmlAgilityPack;
using MS.WindowsAPICodePack.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace JunkCodeAdder
{
    public class JunkAdder
    {
        string path;
        public bool[] options = { false };
        public int[] files;
        public JunkAdder(string path) { 
            this.path = path;
        }

        public void AddJunkCode()
        {
            for(int i = 0; i < files[0]; i++)
            {
                string code = getJunkCode();
                if (code == null)
                    return;
                File.WriteAllText(Path.Combine(path, RandomString(random.Next(5, 15)) + ".cpp"), System.Net.WebUtility.HtmlDecode(code));
            }
            if (!options[0])
                return;
            foreach (string dir in Directory.GetDirectories(path, "*", System.IO.SearchOption.AllDirectories))
            {
                for (int i = 0; i < files[1]; i++)
                {
                    string code = getJunkCode();
                    if (code == null)
                        return;
                    File.WriteAllText(Path.Combine(dir, RandomString(random.Next(5, 15)) + ".cpp"), System.Net.WebUtility.HtmlDecode(code));
                }
            }
        }

        private string getJunkCode()
        {
            WebRequest request = WebRequest.CreateHttp("https://junkcode.gehaxelt.in/");
            WebResponse response = request.GetResponse();
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = null;


            readStream = new StreamReader(receiveStream);

            string data = readStream.ReadToEnd();

            response.Dispose();
            readStream.Dispose();

            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(data);
            string result = htmlDoc.DocumentNode.InnerText;

            return result;
        }

        

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
