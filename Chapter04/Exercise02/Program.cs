using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {


            //4/2/1
            var ymCollection = new YearMonth[] {
                new YearMonth(1990,1),
                new YearMonth(1991,2),
                new YearMonth(1992,3),
                new YearMonth(1993,4),
                new YearMonth(2010,5),
            };

            //4.2.2
            Exercise2_2(ymCollection);
                Console.WriteLine("-----");
            
            //4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("-----");

            //4.2.5
            Exercise2_5(ymCollection);

            Exercise2_6(ymCollection);
        }

        private static void Exercise2_6(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection.OrderByDescending(ym => ym.Year)) {
                Console.WriteLine(ym);
            }
           
        }

        //4.2.3
        //最初に見つかった２１世紀のオブジェクトを返す
        //見つからなかった場合はnull
        static YearMonth FindFirst21C(YearMonth[] yms) {
            foreach (var ym in yms) {
                if (ym.Is21Century) {
                    return ym;
                }
            }
            return null;
        }
        private static void Exercise2_2(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection ) {
                Console.WriteLine(ym);
            }
        }
        private static void Exercise2_4(YearMonth[] ymCollection) {
            var yearmonth =  FindFirst21C(ymCollection);

            if(yearmonth != null) {
                Console.WriteLine(yearmonth);
            }
            else {
                Console.WriteLine("21世紀のデータはありません");
            }
        }
        private static void Exercise2_5(YearMonth[] ymCollection) {
           var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach (var ym in array) {
                Console.WriteLine(ym);
            }
        }
    }
   }

