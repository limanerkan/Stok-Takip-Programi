using stokTakip.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stokTakip.Forms
{
    public partial class DeleteUserForm : Form
    {
        public DeleteUserForm()
        {
            InitializeComponent();
            GetCbUser();
        }
        UserRepository r1 = new UserRepository();
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            r1.DeleteUser((int)cbUser.SelectedValue);
            GetCbUser();
        }

        void GetCbUser()
        {
            
            DataSet result = r1.ListAll();
            cbUser.DataSource = result.Tables[0];
            cbUser.DisplayMember = "UserName";
            cbUser.ValueMember = "ID";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
