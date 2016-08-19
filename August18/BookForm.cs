using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace August18
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            displayBooks(Book.all());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] forms = getForms();
            Book book = new Book(0, forms[1], forms[2], Convert.ToInt32(forms[3]), forms[4], Convert.ToInt32(forms[5]), forms[6]);
            book.save();

            displayBooks(Book.all());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (TextBox tbx in this.Controls.OfType<TextBox>())
            {
                tbx.Clear();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string[] forms = getForms();
            Book book = new Book(Convert.ToInt32(forms[0]), forms[1], forms[2], Convert.ToInt32(forms[3]), forms[4], Convert.ToInt32(forms[5]), forms[6]);
            book.delete();

            displayBooks(Book.all());
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string[] forms = getForms();

            Book book = new Book(Convert.ToInt32(forms[0]), forms[1], forms[2], Convert.ToInt32(forms[3]), forms[4], Convert.ToInt32(forms[5]), forms[6]);
            book.save();

            displayBooks(Book.all());
        }

        private void resultLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ListViewItem item = resultLv.FocusedItem;
            idTbx.Text = item.SubItems[0].Text;
            titleTbx.Text = item.SubItems[1].Text;
            authorTbx.Text = item.SubItems[2].Text;
            isbnTbx.Text = item.SubItems[3].Text;
            publisherTbx.Text = item.SubItems[4].Text;
            priceTbx.Text = item.SubItems[5].Text;
            categoryTbx.Text = item.SubItems[6].Text;
        }

        private void displayBooks(List<Book> books)
        {
            resultLv.Clear();

            for (int i = 0; i < Book.PROPERTY_NAMES.Length; i++)
            {
                resultLv.Columns.Add(Book.PROPERTY_NAMES[i], 80, HorizontalAlignment.Left);
            }

            foreach (Book book in books)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(book.ID));
                item.SubItems.Add(book.Title);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(Convert.ToString(book.ISBN));
                item.SubItems.Add(book.Publisher);
                item.SubItems.Add(Convert.ToString(book.Price));
                item.SubItems.Add(book.Category);

                resultLv.Items.Add(item);
            }

        }

        private string[] getForms()
        {
            string[] forms = new string[7];
            forms[0] = idTbx.Text;
            forms[1] = titleTbx.Text;
            forms[2] = authorTbx.Text;
            forms[3] = isbnTbx.Text;
            forms[4] = publisherTbx.Text;
            forms[5] = priceTbx.Text;
            forms[6] = categoryTbx.Text;

            return forms;
        }
    }
}
