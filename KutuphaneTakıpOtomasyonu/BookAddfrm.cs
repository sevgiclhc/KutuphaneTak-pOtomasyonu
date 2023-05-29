using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneTakıpOtomasyonu
{
    public partial class BookAddfrm : Form
    {
        public BookAddfrm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1RJ39LD\\SQLEXPRESS;Initial Catalog=KutuphaneTakıpOtomasyonu;Integrated Security=True");

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookAddfrm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into book(bookbarcodeno,bookname,theauthor,publisher,numberofpages,type,numberofstocks,shelfnumber,explanation,dateofregistration) values(@bookbarcodeno,@bookname,@theauthor,@publisher,@numberofpages,@type,@numberofstocks,@shelfnumber,@explanation,@dateofregistration)", connection);
            command.Parameters.AddWithValue("@bookbarcodeno",txtBookBarcodeNo.Text);
            command.Parameters.AddWithValue("@bookname", txtBookName.Text);
            command.Parameters.AddWithValue("@theauthor", txtTheAuthor.Text);
            command.Parameters.AddWithValue("@publisher",txtPublisher.Text);
            command.Parameters.AddWithValue("@numberofpages", txtNumberofPages.Text);
            command.Parameters.AddWithValue("@type", comboType.Text);
            command.Parameters.AddWithValue("@numberofstocks", txtNumberofStocks.Text);
            command.Parameters.AddWithValue("@shelfnumber", txtShelfNumber.Text);
            command.Parameters.AddWithValue("@explanation", txtExplanation.Text);
            command.Parameters.AddWithValue("@dateofregistration",DateTime.Now.ToShortDateString());
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show(" Book Registration Completed ");
            foreach (Control item in Controls) //temizleme işlemi
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }
    }
}
