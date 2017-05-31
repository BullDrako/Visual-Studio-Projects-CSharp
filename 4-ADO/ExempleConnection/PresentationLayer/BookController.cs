using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLayer
{
    public class BookController
    {
        public static DataSet getAll()
        {
            BookADO helper = new BookADO();
            return helper.getAll();
        }
        public static String newBook(String title, String author, String publishing, long isbn, String gender, double price, int quantity)
        {
            String message = "";
            int result;
            BookADO helper = new BookADO();
            Book book = new Book(title, author, publishing, isbn, gender, price, quantity);
            result = helper.insertBook(book);
            if (result == 1)
            {
                message = "Book successfully added";
            }
            else if (result == 0)
            {
                message = "Book not added.";
            }
            else if (result == -1)
            {
                message = "Book not added error.";
            }
            return message;
        }

        /**
         * @return message with the result of delete user.
         */
        public static string deleteBook(long isbn) {
            string message = "";
            BookADO helper = new BookADO();
            int result = helper.deleteByIsbn(isbn);
            if (result == 1)
            {
                message = "Book successfully deleted.";
            }
            else if (result == 0)
            {
                message = "Book not deleted.";
            }
            else if (result == -1)
            {
                message = "Book not deleted error.";
            }
            return message;
        }

        public static DataSet getFromISBN(long isbn)
        {
            BookADO helper = new BookADO();
            return helper.getFromISBN(isbn);
        }

        public static string modifyBook(string title, string author, string publishing, long isbn, string gender, double price, int quantity)
        {
            BookADO helper = new BookADO();
            Book book = new Book(title, author, publishing, isbn, gender, price, quantity);
            int result = helper.updateBook(book);

            String message = "";
            if (result == 1)
            {
                message = "Book successfully modified.";
            }
            else if (result == 0)
            {
                message = "Book not modified.";
            }
            else if (result == -1)
            {
                message = "Book not modified error.";
            }
            return message;
        }
    }
}
