using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Book
    {
        private string title;
        private string author;
        private string publishing;
        private long isbn;
        private string gender;
        private double price;
        private int quantity;

        public Book(string title, string author, string publishing, long isbn, string gender, double price, int quantity)
        {
            // TODO: Complete member initialization
            this.title = title;
            this.author = author;
            this.publishing = publishing;
            this.isbn = isbn;
            this.gender = gender;
            this.price = price;
            this.quantity = quantity;
        }
        //Accessors
        #region Accessors
        public String Title
        {
            get { return title; }
            set { title = value; }
        }
        public String Author
        {
            get { return author; }
            set { author = value; }
        }
        public String Publishing
        {
            get { return publishing; }
            set { publishing = value; }
        }
        public long Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public String Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        #endregion
    }
}
