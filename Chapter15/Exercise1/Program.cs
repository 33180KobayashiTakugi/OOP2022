using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books.Max(b => b.Price);
            var book = Library.Books.First(b => b.Price == max);
                Console.WriteLine(book);
            
        }


        private static void Exercise1_3() {
            var groups = Library.Books.GroupBy(b => b.PublishedYear)
                                      .OrderBy(g => g.Key);
            foreach (var g in groups.OrderBy(b=>b.Key)) {
                Console.WriteLine($"{g.Key}年 {g.Count()}冊");
            }                                 
        }

        private static void Exercise1_4() {
            var selected = Library.Books
                                  .Join(Library.Categories,     
                                        book => book.CategoryId, 
                                        category => category.Id, 
                                        (book, category) => new {
                                            book.Title,
                                            book.PublishedYear,
                                            book.Price,
                                            CategoryName= category.Name
                                        })
                                 .OrderByDescending(x => x.PublishedYear)
                                 .ThenByDescending(x => x.Price);
            foreach (var item in selected)
                Console.WriteLine("{0}年{1}円{2}({3})",
                                    item.PublishedYear,
                                    item.Price,
                                    item.Title,
                                    item.CategoryName);
                                
        }

        private static void Exercise1_5() {
            var names = Library.Books.Where(b => b.PublishedYear == 2016)
                                     .Join(Library.Categories,
                                           book => book.CategoryId,
                                           category => category.Id,
                                           (book, category) => category.Name)
                                     .Distinct();
            foreach (var name in names) {
                Console.WriteLine(name);
            }
        }

        private static void Exercise1_6() {
        
        }

        private static void Exercise1_7() {
        
        }

        private static void Exercise1_8() {
        
        }
    }
}
