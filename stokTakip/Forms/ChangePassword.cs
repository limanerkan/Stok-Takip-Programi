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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbOldPassword.Text) || String.IsNullOrEmpty(tbNewPassword.Text) | String.IsNullOrEmpty(tbReNewPassword.Text))
                MessageBox.Show("Boş alan bırakamazsınız", "Hata");
            else
            {
                if(tbNewPassword.Text!=tbReNewPassword.Text)
                    MessageBox.Show("Şifreler uyuşmuyor", "Hata");
                else
                {
                    UserRepository u1 = new UserRepository();
                    u1.UpdatePassword(UserRepository.user.Id, tbOldPassword.Text, tbNewPassword.Text);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
