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
    public partial class MemberListfrm : Form
    {
        public MemberListfrm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1RJ39LD\\SQLEXPRESS;Initial Catalog=KutuphaneTakıpOtomasyonu;Integrated Security=True");

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select *from member where tc like '" + txtTc.Text + "'", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                txtNameSurname.Text = read["namesurname"].ToString();
                txtAge.Text = read["age"].ToString();
                comboGender.Text = read["gender"].ToString();
                txtPhoneNumber.Text = read["phonenumber"].ToString();
                txtAddress.Text = read["address"].ToString();
                txtEmail.Text = read["email"].ToString();
                txtNumberofBookRead.Text = read["numberofbookread"].ToString();

            }
            connection.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }
        DataSet daset = new DataSet();
        private void txtSearchTc_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["member"].Clear();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select *from member where tc like'%"+txtSearchTc.Text+"%'", connection);
            adtr.Fill(daset, "member");
            dataGridView1.DataSource = daset.Tables["member"];
            connection.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Do you want to delete this registration?","Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog== DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from member where tc=@tc", connection);
                command.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Deletion has taken place");
                daset.Tables["member"].Clear();
                memberlist();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }

            }


        }
        private void memberlist()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select *from member", connection);
            adtr.Fill(daset, "member");
            dataGridView1.DataSource = daset.Tables["member"];
            connection.Close();
        }
        private void MemberListfrm_Load(object sender, EventArgs e)
        {
            memberlist();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update member set namesurname=@namesurname, age=@age, gender=@gender, phonenumber=@phonenumber, address=@address, email=@email, numberofbookread=@numberofbookread where tc=@tc", connection);
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
            MessageBox.Show("The update has taken place");
            daset.Tables["member"].Clear();
            memberlist();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
