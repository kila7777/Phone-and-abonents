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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace Phones_and_abonents
{
    public partial class Form3 : Form
    {

        DB db = new DB();
        public Form3()
        {
            InitializeComponent();
            Con = new Functions();
            GetRegion();
        }
        Functions Con;
        private void GetRegion()
        {
            string Query = "Select * from Region";
            comboBox1.ValueMember = Con.GetData(Query).Columns["Name_region"].ToString();
            comboBox1.DisplayMember = Con.GetData(Query).Columns["Name_region"].ToString();
            comboBox1.DataSource = Con.GetData(Query);
        }
        private void RegPrive()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8TL1AD\SQLEXPRESS;Initial Catalog=PHONE;Integrated Security = True");
            con.Open();
            if (comboBox1.Text != "")
            {
                SqlCommand cmd = new SqlCommand("select id from Region where Name_region = @Name_region", con);
                cmd.Parameters.AddWithValue("@Name_region", comboBox1.SelectedValue.ToString());
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    textBox2.Text = da.GetValue(0).ToString();
                }
                con.Close();
            }
        }
        private void buttonzap_Click(object sender, EventArgs e)
        {
            if (textFIO.Text == "" || textBox1.Text=="" || textBox2.Text == "")
            {
                MessageBox.Show("Некоторые из полей пустые, необходимо чтобы она были все заполнены", "Ошибка");
                return;
            }
            db.openconect();
            Int64 lol;
            var fio = textFIO.Text;
            var num = textBox1.Text;
            var reg= textBox2.Text; 
            var proverka = num;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string p = $"Select * from abonents1 where Number_phone='{proverka}' ";
            SqlCommand command1 = new SqlCommand(p, db.getConnection());
            adapter.SelectCommand = command1;
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                if ((Int64.TryParse(textBox1.Text, out lol)) && (num.Length == 12))
                {
                    {
                        var add = $"insert into abonents1 (Fio_abonents, Number_phone, ID_region) values ('{fio}', '{num}', '{reg}')";
                        var command = new SqlCommand(add, db.getConnection());
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно создана", "Задача выполнена");
                    }
                }
                else
                {
                    MessageBox.Show("Телефоный номер должен начинатся с +7 и не иметь латинский букв, также номер состоит из 11 цифр", "Ошибка");
                }
            }
            else 
            {
                MessageBox.Show("Такой номер уже есть", "Ошибка");
            }
            db.closenconect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textFIO.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RegPrive();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8TL1AD\SQLEXPRESS;Initial Catalog=PHONE;Integrated Security = True");
            con.Open();
            if (textBox2.Text != "")
            {
                SqlCommand cmd = new SqlCommand("select Cod_region from Region where id = @id", con);
                cmd.Parameters.AddWithValue("@id", int.Parse(textBox2.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    textBox1.Text = "+7" + da.GetValue(0).ToString();
                }
                con.Close();
            }
        }
    }
}
