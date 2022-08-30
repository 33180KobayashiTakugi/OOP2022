using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TextFileProcessor;

namespace Exercise1 {
    class ToHankakuProcessor : TextProcessor {
        private int _count;

        protected override void Execute(string line) {
            string s = Regex.Replace(line, "[0-9]", p => ((char)(p.Value[0] - '0' + '0')).ToString());
            Console.WriteLine(s);
        }
        protected override void Initialize(string fname) {
            _count = 0;
        }

        protected override void Terminate() {
            Console.WriteLine("{0} 行", _count);
        }
    }
 }
