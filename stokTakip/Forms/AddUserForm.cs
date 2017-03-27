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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbEmail.Text) || String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbPassword.Text) || String.IsNullOrEmpty(tbRePassword.Text) || String.IsNullOrEmpty(tbSurname.Text) || String.IsNullOrEmpty(tbUserName.Text))
                MessageBox.Show("Boş alan bırakamazsınız", "Hata");
            else
            {
                if (tbPassword.Text != tbRePassword.Text)
                    MessageBox.Show("Girilen şifreler uyuşmuyor", "Hata");
                else
                {
                    User u1 = new User();
                    u1.Name = tbName.Text;
                    u1.SurName = tbSurname.Text;
                    u1.Email = tbEmail.Text;
                    u1.UserName = tbUserName.Text;
                    u1.Password = tbPassword.Text;
                    UserRepository r = new UserRepository();
                    r.AddUser(u1);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
