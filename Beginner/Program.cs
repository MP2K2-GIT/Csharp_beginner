using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class Program
    {
        static void Main(string[] args)
        {
            /*create an object of class by create instance of class*/
            Book book1 = new Book("Teddy","KP",200);
            Console.WriteLine(book1.Pages);
            Console.WriteLine(book1.isFull());
            Console.WriteLine(Book.BookCount);
            Console.WriteLine(book1.GetBookCount());
            /*normal class can create instance of class*/
            Usefultool tool = new Usefultool();
            Usefultool.SayHi("Phat");
            /*static class can not create instance of class*/
            StaticClass.Today("Monday");

            /*Inheritance*/
            chef chef = new chef();
            chef.MakeChicken();
            chef.MakePizza();
            Italianchef italianchef = new Italianchef();
            italianchef.MakeChicken();
            italianchef.MakePasta();
            italianchef.MakePizza();
            Console.ReadKey();
        }
        
    }
}
