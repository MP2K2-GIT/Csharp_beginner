using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class Book
    {
        /*Attribute of class*/
        public string title;
        public string author;
        private int pages;
        /*Static attribute of class*/ // Attribute of class not belong to object of class
        /* There are 2 ways to access static attributes.( Class.static attribute or create object 
         * method call static attribute and object of class will call this object method
         */ 
        public static int BookCount;
        /*constructor*/
        public Book(string aTitle,string aAuthor,int aPages) 
        {
            title = aTitle;
            author = aAuthor;
            Pages = aPages;
            BookCount++;
        }
        public int GetBookCount()
        {
            return BookCount;
        }
        /*getter and setter*/
        public int Pages
        {
            get { return pages; }
            set
            {
                if (value == 500 || value == 700 || value == 900)
                {
                    pages = value;
                }
                else
                {
                    pages = 222;
                }
            }
        }
        /*object method*/ 
        public bool isFull()
        {
            if (pages > 500)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
