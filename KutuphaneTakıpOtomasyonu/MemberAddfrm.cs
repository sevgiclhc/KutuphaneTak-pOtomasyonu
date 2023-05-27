using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KutuphaneTakıpOtomasyonu
{
    public partial class MemberAddfrm : Form
    {
        public MemberAddfrm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1RJ39LD\\SQLEXPRESS;Initial Catalog=KutuphaneTakıpOtomasyonu;Integrated Security=True");

        private void MemberAddfrm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into member(tc,namesurname,age,gender,phonenumber,address,email,numberofbookread) values(@tc,@namesurname,@age,@gender,@phonenumber,@address,@email,@numberofbookread)", connection);
            command.Parameters.AddWithValue("@tc", txtTc.Text);
            command.Parameters.AddWithValue("@namesurname", txtNameSurname.Text);
            command.Parameters.AddWithValue("@age", txtAge.Text);
            command.Parameters.AddWithValue("@gender", comboGender.Text);
            command.Parameters.AddWithValue("@phonenumber", txtPhoneNumber.Text);
            command.Parameters.AddWithValue("@address", txtAddress.Text);
            command.Parameters.AddWithValue("@email", txtEmail.Text);
            command.Parameters.AddWithValue("@numberofbookread", txtNumberofBookRead.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show(" Member Registration Completed ");
            foreach (Control item in Controls) //temizleme işlemi
            {
                if (item is TextBox)
                {
                    if (item != txtNumberofBookRead)
                    {
                        item.Text = "";
                    }
                }

            }
        }
    }
}

