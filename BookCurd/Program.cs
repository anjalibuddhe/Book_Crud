using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCurd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookCurd bookCurd = new BookCurd();
            int option = 0;
            do
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Update Book");
                Console.WriteLine("3. Delete Book");
                Console.WriteLine("4. Display Book");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        //Add Book
                        Book book = new Book();
                        Console.WriteLine("Enter Book id");
                        book.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Book name");
                        book.name = Console.ReadLine();
                        Console.WriteLine("Enter author name");
                        book.author=Console.ReadLine();

                        bookCurd.AddBook(book);
                        break;
                    case 2:
                        //Update
                        Book book2 = new Book();
                        Console.WriteLine("Enter id to Modify");
                        book2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Book Name");
                        book2.name=Console.ReadLine();
                        Console.WriteLine("Enter Author name");
                        book2.author=Console.ReadLine();

                        bookCurd.UpdateBook(book2);

                        break;
                    case 3:
                        Console.WriteLine("Enter id to Delete");
                        int id = Convert.ToInt32(Console.ReadLine());
                        bookCurd.DeleteBook(id);
                        break;
                    case 4:
                        //Display all Products
                        List<Book> books = bookCurd.GetAllBooks();
                        foreach(Book b in books)
                        {
                            Console.WriteLine($"{b.Id}-{b.name}-{b.author}");
                        }
                        break;
                }
                Console.WriteLine("Press 1 for Continue");
                option = Convert.ToInt32(Console.ReadLine());
            }
            while (option == 1);
        }
    }
}
