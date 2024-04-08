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
using System.Security.Cryptography;
using System.Threading;

namespace Phones_and_abonents
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Form2 : Form
    {
        Thread ex;
        DB db = new DB();
        int selectedRow; int f=0;
        public string intr;
        public Form2()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Fio_abonents", "Фио абонента");
            dataGridView1.Columns.Add("Number_phone", "Номер телефона");
            dataGridView1.Columns.Add("ID_region", "Номер региона");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            this.dataGridView1.Columns["IsNew"].Visible = false;
            dataGridView2.Columns.Add("id", "Номер региона");
            dataGridView2.Columns.Add("Name_region", "Название региона");
            dataGridView2.Columns.Add("Cod_region", "Код региона");
            dataGridView2.Columns.Add("IsNew", String.Empty);
            this.dataGridView2.Columns["IsNew"].Visible = false;
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record) 
        {
            dgw.Rows.Add(record.GetInt32(0),record.GetString(1), record.GetString(2),record.GetInt32(3), RowState.ModifiedNew);
        }
        private void ReadSingleRow2(DataGridView dgw2, IDataRecord record)
        {
            dgw2.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw, DataGridView dgw2)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from abonents1";
            SqlCommand command = new SqlCommand(queryString,db.getConnection());
            db.openconect();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw,reader);
            }
            reader.Close();
            dgw2.Rows.Clear();
            string querystring = $"select * from Region";
            SqlCommand com = new SqlCommand(querystring, db.getConnection());
            db.openconect();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow2(dgw2, read);
            }
            read.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (f == 0)
            {
                CreateColumns();
                RefreshDataGrid(dataGridView1, dataGridView2);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
                if (intr == "1")
                {
                    buttonenewzap.Visible = false;
                    buttonydal.Visible = false;
                    buttonizmen.Visible = false;
                    buttonzap.Visible = false;
                    textFIO.ReadOnly = true;
                }
                else
                {
                    buttonenewzap.Visible = true;
                    buttonydal.Visible = true;
                    buttonizmen.Visible = true;
                    buttonzap.Visible = true;
                    textFIO.ReadOnly = false;
                }
            
            f = 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textID.Text = row.Cells[0].Value.ToString();
                textFIO.Text = row.Cells[1].Value.ToString();
                textnumtel.Text = row.Cells[2].Value.ToString();
                textReg.Text = row.Cells[3].Value.ToString();
            }
        }

        private void buttonobntab_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1, dataGridView2);
            Clear();
        }

        private void buttonenewzap_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void textpoisk_TextChanged(object sender, EventArgs e)
        {
            search(dataGridView1);
        }
        private void search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchStr = $"select * from abonents1 where concat (id, Fio_abonents, Number_phone, ID_region) like '%" + textpoisk.Text +"%'";
            SqlCommand com = new SqlCommand(searchStr, db.getConnection());
            db.openconect();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }
        private void delete()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString()==string.Empty)
            {
                dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[4].Value= RowState.Deleted;
        }

        private void buttonydal_Click(object sender, EventArgs e)
        {
            delete();
            Clear();
        }
        private void update()
        {
            db.openconect();
            for (int index=0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[4].Value;
                if (rowState == RowState.Existed)
                {
                    continue;
                }
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from abonents1 where id = {id}";
                    var command = new SqlCommand(deleteQuery,db.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value;
                    var fio = dataGridView1.Rows[index].Cells[1].Value;
                    var num = dataGridView1.Rows[index].Cells[2].Value;
                    var reg = dataGridView1.Rows[index].Cells[3].Value;
                    var ID = id.ToString();
                    var FIO = fio.ToString();
                    var NUM = num.ToString();
                    var REG = reg.ToString();
                    var change = $"update abonents1 set Fio_abonents = '{FIO}', Number_phone= '{NUM}', ID_region='{REG}' where id= '{ID}'";
                    var com = new SqlCommand(change, db.getConnection());
                    com.ExecuteNonQuery();
                }
            }
            db.closenconect();
        }

        private void buttonzap_Click(object sender, EventArgs e)
        {
            update();
        }

        private void buttonizmen_Click(object sender, EventArgs e)
        {
            izmen();
        }
        private void izmen()
        {
            
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = textID.Text;
            var FIO = textFIO.Text; 
            var NUM = textnumtel.Text;
            var REG= textReg.Text; 
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (textFIO.Text == "" || textID.Text == "" || textnumtel.Text == "" || textReg.Text == "")
                {
                    MessageBox.Show("Не все поля заполнены", "Ошибка");
                    return;
                }
                dataGridView1.Rows[selectedRowIndex].SetValues(id, FIO, NUM, REG);
                dataGridView1.Rows[selectedRowIndex].Cells[4].Value = RowState.Modified;
                Clear();

            }
        }
        private void Clear()
        {
            textFIO.Text = "";
            textID.Text = "";
            textnumtel.Text = "";
            textReg.Text = "";
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        
         

        private void телефонаяКнигаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        
    }
}
