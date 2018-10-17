using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Windows.System.RemoteSystems;

namespace BindData.Models
{
    public class Book
    {

        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Title = "Vulpate", Author = "Futurum", CoverImage = "Assets/Books/1.png" });
            books.Add(new Book { BookId = 2, Title = "Mazim", Author = "Sequiter Que", CoverImage = "Assets/Books/2.png" });
            books.Add(new Book { BookId = 3, Title = "Elit", Author = "Tempor", CoverImage = "Assets/Books/3.png" });
            books.Add(new Book { BookId = 4, Title = "Etiam", Author = "Option", CoverImage = "Assets/Books/4.png" });
            books.Add(new Book { BookId = 5, Title = "Feugait Eros Libex", Author = "Accumsan", CoverImage = "Assets/Books/5.png" });
            books.Add(new Book { BookId = 6, Title = "Nonummy Erat", Author = "Legunt Xaepius", CoverImage = "Assets/Books/6.png" });
            books.Add(new Book { BookId = 7, Title = "Nostrud", Author = "Eleifend", CoverImage = "Assets/Books/7.png" });
            books.Add(new Book { BookId = 8, Title = "Per Modo", Author = "Tuffy Tibbles", CoverImage = "Assets/Books/8.png" });
            books.Add(new Book { BookId = 9, Title = "Suscripit", Author = "Volupat", CoverImage = "Assets/Books/9.png" });
            books.Add(new Book { BookId = 10, Title = "Decima", Author = "Est Possim", CoverImage = "Assets/Books/10.png" });
            books.Add(new Book { BookId = 11, Title = "Erat", Author = "Magna", CoverImage = "Assets/Books/11.png" });
            books.Add(new Book { BookId = 11, Title = "Consequat", Author = "Accumsan", CoverImage = "Assets/Books/12.png" });
            books.Add(new Book { BookId = 11, Title = "Aliquip", Author = "Legunt", CoverImage = "Assets/Books/13.png" });

            return books;
        }
    }
}
