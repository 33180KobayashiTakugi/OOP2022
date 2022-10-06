using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {
        static void Main(string[] args) {


            var years = new List<int>();
            int year;



            Console.WriteLine("出力したい西暦を入力(終了：-1)");
            year = int.Parse(Console.ReadLine());



            while (year != -1) {

                years.Add(year);
                year = int.Parse(Console.ReadLine());

            }



            Console.Write("昇順:1 降順:2 => ");
            int select = int.Parse(Console.ReadLine());
            if (select == 1) {
                var books = Library.Books
                       .Where(b => years.Contains(b.PublishedYear)).OrderBy(b => b.PublishedYear);
                foreach (var book in books) {
                    Console.WriteLine(book);
                }
            }
            if (select == 2) {
                var books = Library.Books
                       .Where(b => years.Contains(b.PublishedYear)).OrderByDescending(b => b.PublishedYear);
                foreach (var book in books) {
                    Console.WriteLine(book);
                }
            }


            Console.WriteLine();
            //var groups = Library.Books
            //                     .Where(b => years.Contains(b.PublishedYear)).GroupBy(b => b.PublishedYear)
            //                     .OrderBy(g => g.Key);
            //foreach (var g in groups) {
            //    Console.WriteLine("");
            //    Console.WriteLine($"{g.Key}年");
            //    foreach (var book in g) {
            //        Console.WriteLine($" {book}");
            //    }
            //}
            var selected = Library.Books
                                 .Where(b => years.Contains(b.PublishedYear))
                                 .Join(Library.Categories,      //結合する2番目のシーケンス
                                       book => book.CategoryId, //対象シーケンスの結合キー
                                       category => category.Id, //2番目のシーケンスの結合キー
                                       (book,category) => new {
                                           Title = book.Title,
                                           Category = category.Name,
                                           PublishedYear = book.PublishedYear,
                                           price = book.Price,
                                       });
            foreach (var book in selected
                                 .OrderByDescending(x=>x.PublishedYear)
                                 .ThenBy(x=>x.Category))
                {
                //Console.WriteLine($" {book.PublishedYear}年 ");
                //var category = Library.Categories.Where(b => b.Id == book.CategoryId).First();
                Console.WriteLine($" タイトル:{book.Title},出版年:{book.PublishedYear},カテゴリ:{book.Category},{book.price} 円");
            }
            Console.WriteLine($"金額の合計{selected.Sum(b => b.price)}円");
        }
    }
}

