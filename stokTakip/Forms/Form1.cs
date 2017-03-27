using stokTakip.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace stokTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserRepository r = new UserRepository();
            int result = r.LoginControl(tbUserName.Text, tbPassword.Text);

            if (result == 1)
            {
                MainForm frm = new MainForm();
                frm.Show();
            }
        }
    }
}
