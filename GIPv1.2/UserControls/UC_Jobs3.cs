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

namespace GIPv1._2.UserControls
{
    public partial class UC_Jobs3 : UserControl
    {
        DataBase dataBaseJobs3 = new DataBase();
        int idOtdel;
        
        public UC_Jobs3()
        {
            InitializeComponent();
            //refereshOtdel();

        }

        private void UC_Jobs3_Load(object sender, EventArgs e)
        {
            //Из ЛАБ
            //string commandText1 = "select IDЗадачи as '№п.п', IDОбъектаСтроительства as '№Объекта', IDСотрудника as '№Сотрудника', УсловиеЗадачи as 'УсловиеЗадачи', ДатаПостановкиЗадачи as 'ДатаПостановкиЗадачи', ДатаИсполнения as 'ДатаИсполнения', СрокИсполнения as 'СрокИсполнения', СтатусЗадачи as 'СтатусЗадачи'  from Задачи";
            //SqlDataAdapter adapter = new SqlDataAdapter(commandText1, dataBaseJobs3.getConnection());
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //dataGridView1.DataSource = dt;


            //string commandText2 = "select IDОбъектаСтроительства, НаименованиеОбъектаСтроительства from ОбъектСтроительства";
            //SqlDataAdapter adapter2 = new SqlDataAdapter(commandText2, dataBaseJobs3.getConnection());
            //DataTable dt2 = new DataTable();
            //adapter2.Fill(dt2);
            //comboBox1.DataSource = dt2;
            //comboBox1.DisplayMember = "НаименованиеОбъектаСтроительства";
            //comboBox1.ValueMember = "IDОбъектаСтроительства";
            //comboBox1.SelectedIndex = -1;
            //comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            //string commandText3 = "select IDСотрудника, ФамилияСотрудника from Сотрудники";
            //SqlDataAdapter adapter3 = new SqlDataAdapter(commandText3, dataBaseJobs3.getConnection());
            //DataTable dt3 = new DataTable();
            //adapter2.Fill(dt3);
            //comboBox3.DataSource = dt3;
            //comboBox3.DisplayMember = "ФамилияСотрудника";
            //comboBox3.ValueMember = "IDСотрудника";
            //comboBox3.SelectedIndex = -1;
            //comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;


            //Из лаб















            refreshOtdel();
        }

        private void refreshOtdel()
        {
            string queryString3 = $"select * from [dbo].[ОбъектСтроительства]";
            SqlCommand cmd = new SqlCommand(queryString3, dataBaseJobs3.getConnection());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataBaseJobs3.closeConnection();
            comboBox1.DisplayMember = "НаименованиеОбъектаСтроительства";
            comboBox1.ValueMember = "[IDОбъектаСтроительства]";
            comboBox1.DataSource = dt;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != null)
            {
                //string queryString3 = $"select * from [dbo].[Отдел] where [IDОтдела]=@[IDОтдела]";
                string queryString3 = $"select * from [dbo].[Отдел]";
                SqlCommand cmd = new SqlCommand(queryString3, dataBaseJobs3.getConnection());
                // cmd.Parameters.AddWithValue("@[IDОтдела]", comboBox2.SelectedValue.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataBaseJobs3.closeConnection();
                comboBox2.DisplayMember = "НазваниеОтдела";
                comboBox2.ValueMember = "IDОтдела";
                comboBox2.DataSource = dt;
                comboBox2.Enabled = true;
                comboBox3.Enabled = false;
            }
         
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryString3 = $"select * from [dbo].[Сотрудники] where IDОтдела=@IDОтдела";
            SqlCommand cmd = new SqlCommand(queryString3, dataBaseJobs3.getConnection());
            cmd.Parameters.AddWithValue("@IDОтдела", comboBox2.SelectedValue.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataBaseJobs3.closeConnection();
            comboBox3.DisplayMember = "ФамилияСотрудника";
            comboBox3.ValueMember = "IDСотрудника";
            comboBox3.DataSource = dt;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
        }

        private void задачиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.задачиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._GIPv1_17DataSet);

        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)//CD
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetString(3), record.GetBoolean(4), record.GetDateTime(5), record.GetDateTime(6), record.GetDateTime(7));
        }
        private void RefreshDataGridJobs(DataGridView dgw)//CD: Метод для выведения данных в датагридвью
        {
            dgw.Rows.Clear();
            string queryStringEmpl = $"select * from Задачи";
            SqlCommand command = new SqlCommand(queryStringEmpl, dataBaseJobs3.getConnection());
            dataBaseJobs3.openConnection();

            SqlDataReader readerEmpl = command.ExecuteReader();

            while (readerEmpl.Read())
            {
                ReadSingleRow(dgw, readerEmpl);
            }
            readerEmpl.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //без использования Parameters
            int id = (int)comboBox3.SelectedValue;
            string commandText = "select IDЗадачи as '№п.п', IDОбъектаСтроительства as '№Объекта', IDСотрудника as '№Сотрудника', УсловиеЗадачи as 'УсловиеЗадачи', ДатаПостановкиЗадачи as 'ДатаПостановкиЗадачи', ДатаИсполнения as 'ДатаИсполнения', СрокИсполнения as 'СрокИсполнения', СтатусЗадачи as 'СтатусЗадачи'  from Задачи where IDСотрудника =" + id;
            SqlDataAdapter adapter = new SqlDataAdapter(commandText, dataBaseJobs3.getConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
