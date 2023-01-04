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
    public partial class UC_Jobs : UserControl
    {
        DataBase dataBaseJobs = new DataBase();//CD
        int selectedRow;//CD
        //List<Sotrudnik> sotrudniks = new List<Sotrudnik>();
        //List<Otdel> otdels = new List<Otdel>();

        public UC_Jobs()
        {
            InitializeComponent();
        }

        private void UC_Jobs_Load(object sender, EventArgs e)
        {
            CreateColumns();
            refreshOtdel();
            RefreshDataGridJobs(dgwJobs);
            //cbProjectJobs.SelectedIndex = -1;
            
        }

        private void btnNewJob_Click(object sender, EventArgs e)
        {
            Forms.AddJobs AddJobs = new Forms.AddJobs();
            this.Show();
            AddJobs.ShowDialog();
            this.Show();
        }

        private void CreateColumns()//CD: Создаем колонки в ДГВ
        {
            dgwJobs.Columns.Add("IDЗадачи", "№ п/п");//0
            dgwJobs.Columns.Add("IDОбъектаСтроительства", "№ проекта");//1
            dgwJobs.Columns.Add("IDСотрудника", "Табельный №");//2
            dgwJobs.Columns.Add("УсловиеЗадачи", "Задача");//3
            dgwJobs.Columns.Add("ДатаПостановкиЗадачи", "Дата постановки");//4
            dgwJobs.Columns.Add("ДатаИсполнения", "Дата исполнения");//5
            dgwJobs.Columns.Add("СрокИсполнения", "Срок");//6
            dgwJobs.Columns.Add("СтатусЗадачи", "Статус");//7
            //dgwJobs.Columns[0].FillWeight = 5;
            //dgwJobs.Columns[1].FillWeight = 5;
            //dgwJobs.Columns[2].FillWeight = 20;
            //dgwJobs.Columns[3].FillWeight = 5;
            //dgwJobs.Columns[4].FillWeight = 10;
            //dgwJobs.Columns[5].FillWeight = 25;
            //dgwJobs.Columns[6].FillWeight = 6;
            //dgwJobs.Columns[7].FillWeight = 8;
            //dgwJobs.Columns[8].FillWeight = 8;
            //dgwJobs.Columns[9].FillWeight = 8;
            dgwJobs.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 8);
            dgwJobs.DefaultCellStyle.Font = new Font("Roboto", 8);
            //dgwEmployees.Columns.Add("IsNew", String.Empty);
            //dgwEmployees.Columns[11].Visible = false;
            //dgwEmployees.AutoResizeColumnHeadersHeight();
            dgwJobs.AutoResizeColumnHeadersHeight();

        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)//CD
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetString(3), record.GetDateTime(4), record.GetDateTime(5), record.GetDateTime(6), record.GetString(7));
        }

        private void RefreshDataGridJobs(DataGridView dgw)//CD: Метод для выведения данных в датагридвью
        {
            dgw.Rows.Clear();
            string queryString = $"select * FROM Задачи";
            SqlCommand command = new SqlCommand(queryString, dataBaseJobs.getConnection());
            dataBaseJobs.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void refreshOtdel()
        {
            string queryString = $"select * from [dbo].[ОбъектСтроительства]";
            SqlCommand cmd = new SqlCommand(queryString, dataBaseJobs.getConnection());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataBaseJobs.closeConnection();
            cbProjectJobs.DisplayMember = "НаименованиеОбъектаСтроительства";
            cbProjectJobs.ValueMember = "[IDОбъектаСтроительства]";
            cbProjectJobs.DataSource = dt;
            cbOtdelJobs.Enabled = true;
            cbSotrudnikJobs.Enabled = true;
        }

        //private string[] GetSotrudnikById(int id)//каскадное обновление combobox
        //{
        //    return sotrudniks.Where(line => line.id_otdel == id).Select(l => l.Family).ToArray();
        //}

        //[Serializable]
        //class Otdel
        //{
        //    public int id { get; set; }
        //    public string NameOtdel { get; set; }
        //}
        //[Serializable]
        //class Sotrudnik
        //{
        //    public int id { get; set; }
        //    public string Family { get; set; }
        //    public int id_otdel { get; set; }
        //}

        private void btnSaveAddJ_Click(object sender, EventArgs e)
        {
            dataBaseJobs.openConnection();
            var NameProject = cbProjectJobs.Text;
            var NameOtdel = cbOtdelJobs.Text;
            var NameSotrud = cbSotrudnikJobs.Text;
            var StartTime = dtpStartJobs.Value;
            var DLine = dtpDLineJobs.Value;
            var FinishTime = dtpFinishJobs.Value;
            var Zadanie = tbZadanieJobs.Text;
        }

        private void cbProjectJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProjectJobs.SelectedValue.ToString() != null)
            {
                //string queryString3 = $"select * from [dbo].[Отдел] where [IDОтдела]=@[IDОтдела]";
                string queryString = $"select * from [dbo].[Отдел]";
                SqlCommand cmd = new SqlCommand(queryString, dataBaseJobs.getConnection());
                // cmd.Parameters.AddWithValue("@[IDОтдела]", comboBox2.SelectedValue.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //dgwJobs.DataSource = dt;
                dataBaseJobs.closeConnection();
                cbOtdelJobs.DisplayMember = "НазваниеОтдела";
                cbOtdelJobs.ValueMember = "IDОтдела";
                cbOtdelJobs.DataSource = dt;
                cbOtdelJobs.Enabled = true;
                cbSotrudnikJobs.Enabled = true;
                //(dgwJobs.DataSource as DataTable).DefaultView.RowFilter = $"select * from [dbo].[Отдел] where [IDОтдела]=@[IDОтдела] like '%{cbOtdelJobs.Text}%'";
            }
            
        }

        private void cbOtdelJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryString = $"select * from [dbo].[Сотрудники] where IDОтдела=@IDОтдела";
            SqlCommand cmd = new SqlCommand(queryString, dataBaseJobs.getConnection());
            cmd.Parameters.AddWithValue("@IDОтдела", cbOtdelJobs.SelectedValue.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //dgwJobs.DataSource = dt;
            dataBaseJobs.closeConnection();
            cbSotrudnikJobs.DisplayMember = "ФамилияСотрудника";
            cbSotrudnikJobs.ValueMember = "IDСотрудника";
            cbSotrudnikJobs.DataSource = dt;
            cbOtdelJobs.Enabled = true;
            cbSotrudnikJobs.Enabled = true;
        }

        private void cbSotrudnikJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int id = (int)cbSotrudnikJobs.SelectedValue;
            //string commandText = "select IDЗадачи as '№п.п', IDОбъектаСтроительства as '№Объекта', IDСотрудника as '№Сотрудника', УсловиеЗадачи as 'УсловиеЗадачи', ДатаПостановкиЗадачи as 'ДатаПостановкиЗадачи', ДатаИсполнения as 'ДатаИсполнения', СрокИсполнения as 'СрокИсполнения', СтатусЗадачи as 'СтатусЗадачи'  from Задачи where IDСотрудника =" + id;
            //SqlDataAdapter adapter = new SqlDataAdapter(commandText, dataBaseJobs.getConnection());
           //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            //dgwJobs.DataSource = dt;

            //(dgwJobs.DataSource as DataTable).DefaultView.RowFilter = $" select IDСотрудника from Сотрудники where IDСотрудника like '%{cbSotrudnikJobs.ValueMember}%' ";
        }
        /*where IDСотрудника like '%{cbSotrudnikJobs.ValueMember}%'*/
        /*select * from [dbo].[Сотрудники] where*/

        private void btnChangeObj_Click(object sender, EventArgs e)
        {
            //var st = new SaveInfo
            //{
            //    //IDСотрудника = int.Parse(tbIDСотрудника.Text),
            //    //УсловиеЗадачи = 
            //}
        }

        private void dgwJobs_CellClick(object sender, DataGridViewCellEventArgs e)//CD: Заносим данные из ДГВ в ТБ
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgwJobs.Rows[selectedRow];

                //dgwJobs.Columns.Add("IDЗадачи", "№ п/п");//0
                //dgwJobs.Columns.Add("IDОбъектаСтроительства", "№ проекта");//1
                //dgwJobs.Columns.Add("IDСотрудника", "Табельный №");//2
                //dgwJobs.Columns.Add("УсловиеЗадачи", "Задача");//3
                //dgwJobs.Columns.Add("ДатаПостановкиЗадачи", "Дата постановки");//4
                //dgwJobs.Columns.Add("ДатаИсполнения", "Дата исполнения");//5
                //dgwJobs.Columns.Add("СрокИсполнения", "Срок");//6
                //dgwJobs.Columns.Add("СтатусЗадачи", "Статус");//7

               
                //cbProjectJobs.Text = row.Cells[1].Value.ToString();
                tbiDОбъектаСтроительства.Text = row.Cells[1].Value.ToString();
                //cbOtdelJobs.Text = row.Cells[1].Value.ToString();
                tbIDСотрудника.Text = row.Cells[2].Value.ToString();
                tbZadanieJobs.Text = row.Cells[3].Value.ToString();
                dtpStartJobs.Text = row.Cells[4].Value.ToString();
                dtpFinishJobs.Text = row.Cells[5].Value.ToString();
                dtpDLineJobs.Text = row.Cells[6].Value.ToString();
                cbStatus.Text = row.Cells[7].Value.ToString();





                //iDОбъектаСтроительстваTextBox.Text = row.Cells[0].Value.ToString();
                //наименованиеОбъектаСтроительстваTextBox.Text = row.Cells[1].Value.ToString();
                //датаРегистрацииЗаявленияDateTimePicker.Text = row.Cells[2].Value.ToString();
                //датаИнспирацииDateTimePicker.Text = row.Cells[3].Value.ToString();
                //наименованиеЗаказчикаTextBox.Text = row.Cells[4].Value.ToString();
                //источникtСредствComboBox.Text = row.Cells[5].Value.ToString();
            }
        }

        private void cbProjectJobs_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Cursor.Current = Cursors.WaitCursor;

            //string queryString = $"select * from [dbo].[Задачи]";
            //SqlCommand cmd = new SqlCommand(queryString, dataBaseJobs.getConnection());
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dataBaseJobs.closeConnection();

            //dt obj = cbProjectJobs.SelectedItem as Category;
            //if (obj != null)
            //{
            //    tbiDОбъектаСтроительства.Text = obj.IDОбъектаСтроительства.ToString();
            //    tbIDСотрудника.Text = obj.IDСотрудника.ToString();

            //}
            //Cursor.Current = Cursors.Default;
        }

        private void label5_TextChanged(object sender, EventArgs e)
        {
            //using (SqlConnection conn = new SqlConnection(dataBaseJobs.getConnection))
            //{
            //    SqlCommand command = new SqlCommand();
            //    command.Connection = conn;
            //    command.CommandType = CommandType.StoredProcedure;
            //    command.CommandText = "GetCount";
            //    conn.Open();
            //    int count = (int)command.ExecuteScalar();
            //    lblCount.Text = count.ToString();
            //}
        }

        private void btnDelJob_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveJobs_Click(object sender, EventArgs e)
        {

        }





        //private void CbOtdelJobs_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}


//!!!! Добавил cbSotrudnikJobs_SelectedIndexChanged и в другие селектединдексченж добавил заполнение в DGW
//https://www.youtube.com/watch?v=8Nwc2IUHRBU - пробовать фильтровать по ссылке