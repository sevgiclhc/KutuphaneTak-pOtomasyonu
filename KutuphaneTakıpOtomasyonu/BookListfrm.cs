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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace KutuphaneTakıpOtomasyonu
{
    public partial class BookListfrm : Form
    {
        public BookListfrm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1RJ39LD\\SQLEXPRESS;Initial Catalog=KutuphaneTakıpOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        private void booklist()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select *from book", connection);
            adtr.Fill(daset, "book");
            dataGridView1.DataSource = daset.Tables["book"];
            connection.Close();
        }
        private void BookListfrm_Load(object sender, EventArgs e)
        {
            booklist();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Do you want to delete this registration?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from book where bookbarkodno=@bookbarkodno", connection);
                command.Parameters.AddWithValue("@bookbarkodno", dataGridView1.CurrentRow.Cells["bookbarkodno"].Value.ToString());
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Deletion has taken place");
                daset.Tables["book"].Clear();
                booklist();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookBarcodeNo.Text = dataGridView1.CurrentRow.Cells["bookbarcodeno"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update book set bookname=@bookname, theauthor=@theauthor, publisher=@publisher, numberofpages=@numberofpages, type=@type, numberofstocks=@numberofstocks, shelfnumber=@shelfnumber, explanation=@explanation, where bookbarkodno=@bookbarkodno", connection);
            command.Parameters.AddWithValue("@bookbarcodeno", txtBookBarcodeNo.Text);
            command.Parameters.AddWithValue("@bookname", txtBookName.Text);
            command.Parameters.AddWithValue("@theauthor", txtTheAuthor.Text);
            command.Parameters.AddWithValue("@publisher", txtPublisher.Text);
            command.Parameters.AddWithValue("@numberofpages", txtNumberofPages.Text);
            command.Parameters.AddWithValue("@type", comboType.Text);           
            command.Parameters.AddWithValue("@numberofstocks", txtNumberofStocks.Text);
            command.Parameters.AddWithValue("@shelfnumber", txtShelfNumber.Text);
            command.Parameters.AddWithValue("@explanation", txtExplanation.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("The update has taken place");
            daset.Tables["book"].Clear();
            booklist();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txtBookBarcodeNo_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select *from book where bookbarcodeno like '" + txtBookBarcodeNo.Text + "'", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                txtBookName.Text = read["bookname"].ToString();
                txtTheAuthor.Text = read["theauthor"].ToString();
                txtPublisher.Text = read["publisher"].ToString();
                txtNumberofPages.Text = read["numberofpages"].ToString();
                comboType.Text = read["type"].ToString();
                txtNumberofStocks.Text = read["numberofstocks"].ToString();
                txtShelfNumber.Text = read["shelfnumber"].ToString();
                txtExplanation.Text = read["explanation"].ToString();


            }
            connection.Close();

        }
      
        private void txtBarcodeSearch_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["book"].Clear();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select *from book where bookbarcodeno like'%" +txtBookBarcodeNoSearch.Text+ "%'", connection);
            adtr.Fill(daset,"book");
            dataGridView1.DataSource = daset.Tables["book"];
            connection.Close();
        }
    }
}
