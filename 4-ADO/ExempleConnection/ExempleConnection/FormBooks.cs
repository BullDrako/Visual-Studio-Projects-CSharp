using ControllerLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormBooks : Form
    {
        private int rowIndex = 0;
        public FormBooks()
        {
            InitializeComponent();
        }
        private void FormBooks_Load(object sender, EventArgs e)
        {
            DataSet llistat = new DataSet();
            llistat = ControllerLayer.BookController.getAll();
            if (llistat == null)
            {
                MessageBox.Show("No data found.");
            }
            else
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = llistat.Tables[0];

            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (!textBoxTitle.Equals("") && !textBoxAuthor.Equals("") && !textBoxPublishing.Equals("") && !textBoxISBN.Equals("") && !textBoxGender.Equals("") && !textBoxPrice.Equals("") && !textBoxQuantity.Equals(""))
            {
                String title = textBoxTitle.Text;
                String author = textBoxAuthor.Text;
                String publishing = textBoxPublishing.Text;
                long ISBN = long.Parse(textBoxISBN.Text);
                String gender = textBoxGender.Text;
                double price = double.Parse(textBoxPrice.Text);
                int quantity = int.Parse(textBoxQuantity.Text);

                String message = BookController.newBook(title, author, publishing, ISBN, gender, price, quantity);

                MessageBox.Show(message);
                //dataGridView1.Update();
                //dataGridView1.Refresh();
                FormBooks_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Fill all fields with any data.");
            }
        }

       

        private void buttonFind_Click(object sender, EventArgs e)
        {
            long isbn = 0;
            try
            {
                isbn = long.Parse(textBoxIsbnToFind.Text.ToString());
                if (isbn > 0)
                {
                    DataSet llistat = new DataSet();
                    llistat = ControllerLayer.BookController.getFromISBN(isbn);
                    dataGridView2.AutoGenerateColumns = false;
                    dataGridView2.DataSource = llistat.Tables[0];
                    
                    dataGridView2.Update();
                    dataGridView2.Refresh();
                    if (dataGridView2.RowCount <= 0)
                    {
                        MessageBox.Show("No data found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the field with positive number.");
                }
            } catch(FormatException) {
            
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
           
               
                //Getting the selected row by index.
               
                try
                {
                    //Getting the data of selected row.
                    String title = dataGridView2.Rows[0].Cells[0].Value.ToString();
                    String author = dataGridView2.Rows[0].Cells[1].Value.ToString();
                    String publishing = dataGridView2.Rows[0].Cells[2].Value.ToString();
                    long isbn = long.Parse(dataGridView2.Rows[0].Cells[3].Value.ToString());
                    String gender = dataGridView2.Rows[0].Cells[4].Value.ToString();
                    double price = Double.Parse(dataGridView2.Rows[0].Cells[5].Value.ToString());
                    int quantity = Int32.Parse(dataGridView2.Rows[0].Cells[6].Value.ToString());
                   
                    if (isbn > 0 && price > 0 && quantity > 0)
                    {
                        //Do the modify.
                        String message = BookController.modifyBook(title, author, publishing, isbn, gender, price, quantity);
                        MessageBox.Show(message);
                        //Do the select of all books and fill the dataGridView1
                        FormBooks_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Please put positive numbers.");
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridView1.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }

        }

        private void deleteARowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dataGridView1.Rows[this.rowIndex].IsNewRow)
            {
                //this.dataGridView1.Rows.RemoveAt(this.rowIndex);
                long isbn = long.Parse(dataGridView1.Rows[this.rowIndex].Cells["isbn"].Value.ToString());
                String message = BookController.deleteBook(isbn);
                FormBooks_Load(sender, e);
            }


        }

        

       

       

    }
}