using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            var file = "sports.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            //Exercise1_4(file, newfile);

            //確認用
            var text = File.ReadAllText(newfile);
            Console.WriteLine(text);
        }



        private static void Exercise1_1(string file) {

            var xdoc = XDocument.Load(file);
            var ballSports = xdoc.Root.Elements()
                                         .Select(x => new {
                                             Name = x.Element("name"),
                                             Teammembers = x.Element("teammembers").Value
                                         });
            foreach (var ballSport in ballSports) {
                Console.WriteLine("{0} {1}",
                                   ballSport.Name, ballSport.Teammembers);
            }
        }

        private static void Exercise1_2(string file) {

            var xdoc = XDocument.Load(file);
            var ballSports = xdoc.Root.Elements()
                                         .Select(x => new {
                                             Firstplayed = x.Element("firstplayed").Value,
                                             Name = x.Element("name").Attribute("kanji").Value

                                         })
                                         .OrderBy(x => int.Parse(x.Firstplayed));
            foreach (var ballSport in ballSports) {

                Console.WriteLine("{0} ({1})",
                                   ballSport.Name, ballSport.Firstplayed);
            }
        }

        private static void Exercise1_3(string file) {

            var xdoc = XDocument.Load(file);
            var ballSport = xdoc.Root.Elements()
                                 .Select(x => new {
                                     Name = x.Element("name").Value,
                                     Teammembers = x.Element("teammembers").Value,

                                 })
                                         .OrderByDescending(x => int.Parse(x.Teammembers)).First();

                Console.WriteLine("{0} ({1}人)",
                                   ballSport.Name, ballSport.Teammembers);
            
        }

        private static void Exercise1_4(string file, string newfile) {

            var element = new XElement("ballsport",
                    new XElement("name", "サッカー",new XAttribute("kanji","蹴球")),
                    new XElement("teammembers", "11"),
                    new XElement("firstplayed", "1863")
                    );
            var xdoc = XDocument.Load(file);
            xdoc.Root.Add(element);
            //保存
            xdoc.Save(newfile);
        }
    }
}


