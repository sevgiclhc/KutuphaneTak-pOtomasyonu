using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneTakıpOtomasyonu
{
    public partial class AnaSayfafrm : Form
    {
        public AnaSayfafrm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookAddfrm bookadd = new BookAddfrm();
            bookadd.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BookListfrm booklist = new BookListfrm();
            booklist.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LendingaBookfrm lendingabook = new LendingaBookfrm();
            lendingabook.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnMemberAdditions_Click(object sender, EventArgs e)
        {
            MemberAddfrm memberadd = new MemberAddfrm();
            memberadd.ShowDialog();
        }

        private void btnMemberListAddition_Click(object sender, EventArgs e)
        {
            MemberListfrm memberlist = new MemberListfrm();
            memberlist.ShowDialog();
        }
    }
}
