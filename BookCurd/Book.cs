using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCurd
{
    public class Book
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string  author{ get; set; }

    }
    public class BookCurd
    {
        private List<Book> books;

        public BookCurd()
        {
            books= new List<Book>();
        }
        public void AddBook(Book b)
        {
            books.Add(b);
        }
        public List<Book> GetAllBooks()
        {
            return books;
        }

        //Console.WriteLine(=========Update==============);

        public void UpdateBook(Book b1)
        {
           foreach(Book b in books) 
            {
               if(b.Id == b1.Id)
                {
                    b.name = b1.name;
                    b.author=b1.author;
                }
            }
        }

        public void DeleteBook(int id)
        {
            foreach(Book b in books)
            {
                if(b.Id == id)
                {
                    books.Remove(b);
                    break;
                }
            }
        }

    }
}
