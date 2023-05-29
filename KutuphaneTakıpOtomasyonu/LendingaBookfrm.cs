using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneTakıpOtomasyonu
{
    public partial class LendingaBookfrm : Form
    {
        public LendingaBookfrm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1RJ39LD\\SQLEXPRESS;Initial Catalog=KutuphaneTakıpOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into basket(barcodeno,bookname,authorname,publisher,numberofpages,numberofbooks,deliverydate,returndate) values(@barcodeno,@bookname,@authorname,@publisher,@numberofpages,@numberofbooks,@deliverydate,@returndate)", connection);
            command.Parameters.AddWithValue("@barcodeno", txtBarcodeNo.Text);
            command.Parameters.AddWithValue("@bookname", txtBookName.Text);
            command.Parameters.AddWithValue("@authorname", txtAuthorName.Text);
            command.Parameters.AddWithValue("@numberofpages", txtNumberofPages.Text);
            command.Parameters.AddWithValue("@numberofbooks", int.Parse(txtNumberofBooks.Text));
            command.Parameters.AddWithValue("@deliverydate", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@returndate", dateTimePicker2.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Book(s) added to basket", "Adding Process");
            daset.Tables["basket"].Clear();
            basketList();
            lblNumberofbooks.Text = "";
            numberofbooks();

            foreach (Control item in grpBookInformation.Controls)
            {
                if (item != txtNumberofBooks)
                {
                    item.Text = "";
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void basketList()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from basket", connection);
            adtr.Fill(daset, "basket");
            dataGridView1.DataSource = daset.Tables["member"];
            connection.Close();

        }
        private void numberofbooks()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select sum(numberofbooks) from basket", connection);
            lblNumberofbooks.Text = command.ExecuteScalar().ToString();
            connection.Close();
        }




        private void LendingaBookfrm_Load(object sender, EventArgs e)
        {
            basketList();
        }

        private void txtTcSearch_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select *from member where tc like '" + txtTcSearch + "'", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                txtNameSurname.Text = read["namesurname"].ToString();
                txtAge.Text = read["age"].ToString();
                txtPhoneNumber.Text = read["phonenumber"].ToString();
            }
            connection.Close();

            connection.Open();
            SqlCommand command2 = new SqlCommand("select sum(numberofbooks) from loanbooks", connection);
            lblNumberofbooks.Text = command2.ExecuteScalar().ToString();
            connection.Close();

            if (txtTcSearch.Text == "")
            {
                foreach (Control item in grpMemberInformation.Controls)
                {
                    if(item is TextBox)
                    {
                        item.Text = "";
                        lblNumberofRegisteredBooks.Text = "";
                    }
                    
                }
            }


        }

        private void txtBarcodeNo_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select *from book where barcodeno like'" + txtBarcodeNo + "'", connection); 
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                txtBookName.Text = read["bookname"].ToString();
                txtAuthorName.Text = read["authorname"].ToString();
                txtPublisher.Text = read["publisher"].ToString();
                txtNumberofPages.Text = read["numberofpages"].ToString();
            }
            connection.Close();

            if (txtBarcodeNo.Text =="")
            {
                foreach (Control item in grpBookInformation.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtNumberofPages)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete *from basket where barcodeno='" + dataGridView1.CurrentRow.Cells["barcodeno"].Value.ToString() + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Deletion has taken place", "Deletion process");
            daset.Tables["basket"].Clear();
            basketList();
            lblNumberofbooks.Text = "";
            numberofbooks();


        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            if (lblNumberofbooks.Text != "")
            {
                if (lblNumberofRegisteredBooks.Text == "" && int.Parse(lblNumberofbooks.Text) <= 3 || lblNumberofRegisteredBooks.Text != "" && int.Parse(lblNumberofRegisteredBooks.Text) + int.Parse(lblNumberofbooks.Text) <= 3)
                {
                    if (txtTcSearch.Text != "" && txtNameSurname.Text != "" && txtAge.Text != "" && txtPhoneNumber.Text != "")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            SqlCommand command = new SqlCommand("insert into loanbooks(tc,namesurname,age,phonenumber,barcodno,bookname,authorname,publisher,numberofpages,numberofbooks,deliverydate,returndate) value(@tc,@namesurname,@age,@phonenumber,@barcodno,@bookname,@authorname,@publisher,@numberofpages,@numberofbooks,@deliverydate,@returndate)", connection);
                            command.Parameters.AddWithValue("@tc", txtTcSearch.Text);
                            command.Parameters.AddWithValue("@namesurname", txtNameSurname.Text);
                            command.Parameters.AddWithValue("@age", txtAge.Text);
                            command.Parameters.AddWithValue("@phonenumber", txtPhoneNumber.Text);
                            command.Parameters.AddWithValue("barcodeno", dataGridView1.Rows[i].Cells["barcodeno"].Value.ToString());
                            command.Parameters.AddWithValue("bookname", dataGridView1.Rows[i].Cells["bookname"].Value.ToString());
                            command.Parameters.AddWithValue("authorname", dataGridView1.Rows[i].Cells["authorname"].Value.ToString());
                            command.Parameters.AddWithValue("publisher", dataGridView1.Rows[i].Cells["publisher"].Value.ToString());
                            command.Parameters.AddWithValue("numberofpages", int.Parse(dataGridView1.Rows[i].Cells["numberofpages"].Value.ToString()));
                            command.Parameters.AddWithValue("numberofbooks", dataGridView1.Rows[i].Cells["numberofbooks"].Value.ToString());
                            command.Parameters.AddWithValue("deliverydate", dataGridView1.Rows[i].Cells["deliverydate"].Value.ToString());
                            command.Parameters.AddWithValue("returndate", dataGridView1.Rows[i].Cells["returndate"].Value.ToString());
                            command.ExecuteNonQuery();
                            SqlCommand command2 = new SqlCommand("update member set numberofbooks = numberofbooks + '" + int.Parse(dataGridView1.Rows[i].Cells["numberofbooks"].Value.ToString()) + "' where tc= '" + txtTcSearch.Text + "' ", connection);
                            command2.ExecuteNonQuery();
                            SqlCommand command3 = new SqlCommand("update book set numberofstocks = numberofstocks - '" + int.Parse(dataGridView1.Rows[i].Cells["numberofbooks"].Value.ToString()) + "' where barcodeno= '" + dataGridView1.Rows[i].Cells["barcodeno"].Value.ToString() + "' ", connection);
                            command3.ExecuteNonQuery();
                            connection.Close();
                        }
                        connection.Open();
                        SqlCommand command4 = new SqlCommand("delete from basket", connection);
                        command4.ExecuteNonQuery();
                        connection.Close();
                        connection.Close();
                        MessageBox.Show("Book(s) were loaned");
                        daset.Tables["basket"].Clear();
                        basketList();
                        txtTcSearch.Text = "";
                        lblNumberofbooks.Text = "";
                        numberofbooks();
                        lblNumberofRegisteredBooks.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Select Member Name", "Warning");
                    }

                }
                else
                {
                    MessageBox.Show("The number of borrowed books must be at most 3", "Warning");
                }

            }
            else
            {
                MessageBox.Show("Add book to basket", "Warning");
            }
        }
       
    }
}
