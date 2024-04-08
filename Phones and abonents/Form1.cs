using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phones_and_abonents
{
    public partial class Form1 : Form
    {
        Thread ex;
        public string a = "admin";
        public string d = "admin";
        Form2 f2= new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pas.PasswordChar = '*';
        }

        private void vxod_Click(object sender, EventArgs e)
        {
            Phone.Visible= false;
            akk.Visible = true;
            podsk.Visible = true;
            admin.Visible = true;
            user.Visible = true;
            vxod.Visible = false;
        }

        private void podsk_Click(object sender, EventArgs e)
        {
            podsk.Visible = false;
            akk.Visible = false;
            ybrat.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
        }

        private void ybrat_Click(object sender, EventArgs e)
        {
            podsk.Visible = true;
            akk.Visible = true;
            ybrat.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }

        private void admin_Click(object sender, EventArgs e)
        {
            podsk.Visible = false;
            akk.Visible = false;
            admin.Visible = false;
            user.Visible = false;
            pass.Visible = true;
            login.Visible = true;
            password.Visible = true;
            log.Visible = true;
            pas.Visible = true;
            back.Visible = true;
            label1 .Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            ybrat .Visible = false;

        }

        private void back_Click(object sender, EventArgs e)
        {
            podsk.Visible = true;
            akk.Visible = true;
            admin.Visible = true;
            user.Visible = true;
            pass.Visible = false;
            login.Visible = false;
            password.Visible = false;
            log.Visible = false;
            pas.Visible = false;
            back.Visible = false;
        }

        private void pass_Click(object sender, EventArgs e)
        {
            if (log.Text != a || pas.Text != d)
            {
                MessageBox.Show("Неправильно введён логин или пароль, попробуйте ввести заново", "Ошибка");
            }
            else
            {
                f2.intr = "0";
                f2.ShowDialog();
            }
        }
        

        private void user_Click(object sender, EventArgs e)
        {
            f2.intr = "1";
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
