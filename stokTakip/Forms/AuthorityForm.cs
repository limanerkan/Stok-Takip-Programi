using stokTakip.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace stokTakip.Forms
{
    public partial class AuthorityForm : Form
    {
        public AuthorityForm()
        {
            InitializeComponent();
            GetCombobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool[] authoritys = new bool[12];
            authoritys[0] = checkBox1.Checked;
            authoritys[1] = checkBox2.Checked;
            authoritys[2] = checkBox3.Checked;
            authoritys[3] = checkBox4.Checked;
            authoritys[4] = checkBox5.Checked;
            authoritys[5] = checkBox6.Checked;
            authoritys[6] = checkBox7.Checked;
            authoritys[7] = checkBox8.Checked;
            authoritys[8] = checkBox9.Checked;
            authoritys[9] = checkBox10.Checked;
            authoritys[10] = checkBox11.Checked;
            authoritys[11] = checkBox12.Checked;
            Authority a1 = new Authority();
            a1.DeleteAuthority((int)comboBox1.SelectedValue);
            for (int i = 0; i < 12; i++)
                a1.AddAuthority((int)comboBox1.SelectedValue, i + 1, authoritys[i]);

            MessageBox.Show("Yetkiler Güncellendi");
        }


        void GetCombobox()
        {
            UserRepository u1 = new UserRepository();
            DataSet result = u1.ListAll();
            comboBox1.DataSource = result.Tables[0];
            comboBox1.DisplayMember = "UserName";
            comboBox1.ValueMember = "ID";
        }

        void GetAuthority(int userId)
        {
            List<bool> a = new List<bool>();
            Authority a1 = new Authority();
            a = a1.AouthorityList(userId);

            try
            {
                checkBox1.Checked = a[0];
                checkBox2.Checked = a[1];
                checkBox3.Checked = a[2];
                checkBox4.Checked = a[3];
                checkBox5.Checked = a[4];
                checkBox6.Checked = a[5];
                checkBox7.Checked = a[6];
                checkBox8.Checked = a[7];
                checkBox9.Checked = a[8];
                checkBox10.Checked = a[9];
                checkBox11.Checked = a[10];
                checkBox12.Checked = a[11];

            }
            catch (Exception)
            {


            }
        }


        void ClerCheckBox()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ClerCheckBox();
                GetAuthority((int)comboBox1.SelectedValue);
            }
            catch (Exception)
            {



            }
        }
    }
}
