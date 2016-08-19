using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August18
{
    class Book
    {
        static ADODB.Connection adoConnection = new ADODB.Connection();
        static ADODB.Recordset adoRecordset = new ADODB.Recordset();
        static String connectString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=../../August18.accdb";

        public static string[] PROPERTY_NAMES = new string[] {"ID", "TITLE", "AUTHOR", "ISBN", "PUBLISHER", "PRICE", "CATEGORY"};

        private int _id;
        private string _title;
        private string _author;
        private int _isbn;
        private string _publisher;
        private int _price;
        private string _category;

        public Book(int id, string title, string author, int isbn, string publisher, int price, string category) {
            _id = id;
            _title = title;
            _author = author;
            _isbn = isbn;
            _publisher = publisher;
            _price = price;
            _category = category;
        }

        public static List<Book> all()
        {
            adoConnection.Open(connectString);
            adoRecordset.Open("select * from books;", adoConnection);

            List<Book> books = new List<Book>();

            int index = 0;
            while (!adoRecordset.EOF)
            {
                Book book = new Book(
                    adoRecordset.Fields["id"].Value,
                    adoRecordset.Fields["title"].Value,
                    adoRecordset.Fields["author"].Value,
                    adoRecordset.Fields["isbn"].Value,
                    adoRecordset.Fields["publisher"].Value,
                    adoRecordset.Fields["price"].Value,
                    adoRecordset.Fields["category"].Value
                );

                books.Add(book);
                adoRecordset.MoveNext();
                index++;
            }
            adoConnection.Close();

            return books;
        }

        public bool save() {
            adoConnection.Open(connectString);
            if (isNew())
            {
                adoRecordset.Open("insert into books (title, author, isbn, publisher, price, category) values ('" + this.Title + "', '" + this.Author + "', " + this.ISBN + ", '" + this.Publisher + "', " + this.Price + ", '" + this.Category + "');", adoConnection);
            }
            else
            {
                String updateQuery = "update books set title = '" + this.Title + "', author = '" + this.Author + "', isbn = " + this.ISBN + ", publisher = '" + this.Publisher + "', price = " + this.Price + ", category = '" + this.Category + "' where id = " + this.ID + ";";
                adoRecordset.Open(updateQuery, adoConnection);
            }
            adoConnection.Close();
            return true;
        }

        public bool delete()
        {
            adoConnection.Open(connectString);
            adoRecordset.Open("delete from books where id = " + this.ID + ";", adoConnection);
            adoConnection.Close();

            return true;
        }

        private bool isNew()
        {
            if (this.ID != 0)
            {
                return false;
            }
            return true;
        }
        
        public int ID
        {
            get
            {
                return _id;
            }
        }
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }
        public int ISBN
        {
            get
            {
                return _isbn;
            }
            set
            {
                _isbn = value;
            }
        }
        public string Publisher
        {
            get
            {
                return _publisher;
            }
            set
            {
                _publisher = value;
            }
        }
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }
    }
}
