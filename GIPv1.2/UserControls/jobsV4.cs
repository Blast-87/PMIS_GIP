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
    public partial class jobsV4 : UserControl
    {
        int selectedRow;//CD
        DataBase dataBaseJobs = new DataBase();

        public jobsV4()
        {
            cbProjectJobsMethod();
        }

        private void cbProjectJobsMethod()
        {
            InitializeComponent();
            string query1 = $"select * from [dbo].[ОбъектСтроительства]";
        SqlCommand cmd = new SqlCommand(query1, dataBaseJobs.getConnection());
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        dataBaseJobs.openConnection();
            DataTable dt = new DataTable();
        da.Fill(dt);
            cbProjectJobs.DisplayMember = "НаименованиеОбъектаСтроительства";
            cbProjectJobs.ValueMember = "IDОбъектаСтроительства";
            cbProjectJobs.DataSource = dt;
            //dataBaseJobs.closeConnection();
            cbOtdelJobs.Enabled = false;
            cbSotrudnikJobs.Enabled = false;
            btnChoose.Enabled = false;
            this.btnChoose.BackColor = System.Drawing.Color.LightGray;
            this.btnChoose.ForeColor = System.Drawing.Color.WhiteSmoke;
        }

        private void display_datagrid()
        {
            SqlCommand queryDGW = new SqlCommand("select Задачи.IDЗадачи as Код, Задачи.IDОбъектаСтроительства as NОбъекта, ОбъектСтроительства.НаименованиеОбъектаСтроительства as Объект, Задачи.IDСотрудника as Табельный, Сотрудники.ФамилияСотрудника AS Фамилия, Задачи.УсловиеЗадачи as Условие, Задачи.ДатаПостановкиЗадачи as ДатаПостановки, Задачи.ДатаИсполнения as ДатаИсполнения, Задачи.СрокИсполнения as СрокИсполнения, Задачи.СтатусЗадачи as СтатусЗадачи from Задачи  JOIN ОбъектСтроительства ON Задачи.IDОбъектаСтроительства = ОбъектСтроительства.IDОбъектаСтроительства JOIN Сотрудники ON Задачи.IDСотрудника = Сотрудники.IDСотрудника", dataBaseJobs.getConnection());

            SqlDataAdapter da2 = new SqlDataAdapter();
            DataTable dt2 = new DataTable();
            da2.SelectCommand = queryDGW;
            dt2.Clear();
            da2.Fill(dt2);
            dgwJobs.DataSource = dt2;
            ///РАБОЧИЙ ВАРИАНТ  
        }

        private void jobsV4_Load(object sender, EventArgs e)
        {
            display_datagrid();
            tbIDZadachi.Enabled = false;
        }

        
        private void cbProjectJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProjectJobs.SelectedValue.ToString() != null)
            {
                string queryString = $"select * from [dbo].[Отдел]";
                SqlCommand cmd = new SqlCommand(queryString, dataBaseJobs.getConnection());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //dgwJobs.DataSource = dt;
                dataBaseJobs.closeConnection();
                cbOtdelJobs.DisplayMember = "НазваниеОтдела";
                cbOtdelJobs.ValueMember = "IDОтдела";
                cbOtdelJobs.DataSource = dt;
                cbOtdelJobs.Enabled = true;
                cbSotrudnikJobs.Enabled = false;
                btnChoose.Enabled = false;
                this.btnChoose.BackColor = System.Drawing.Color.LightGray;
                this.btnChoose.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void cbOtdelJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOtdelJobs.SelectedValue.ToString() != null)
            {
                string queryString = $"select * from [dbo].[Сотрудники] where IDОтдела=@IDОтдела";
                SqlCommand cmd = new SqlCommand(queryString, dataBaseJobs.getConnection());
                cmd.Parameters.AddWithValue("@IDОтдела", cbOtdelJobs.SelectedValue.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataBaseJobs.closeConnection();
                cbSotrudnikJobs.DisplayMember = "ФамилияСотрудника";
                cbSotrudnikJobs.ValueMember = "IDСотрудника";
                cbSotrudnikJobs.DataSource = dt;
                cbSotrudnikJobs.Enabled = true;
                btnChoose.Enabled = true;
                this.btnChoose.BackColor = System.Drawing.Color.Olive;
                this.btnChoose.ForeColor = System.Drawing.Color.White;
            }
        }

        //private void ReadSingleRow(DataGridView dgwJobs, IDataRecord record)//CD
        //{
        //    //dgwJobs.Rows.Add(record.GetInt32(1), record.GetInt32(3), record.GetString(5), record.GetDateTime(6), record.GetDateTime(7), record.GetDateTime(8), record.GetString(9), RowState.ModifiedNew);
        //    dgwJobs.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2),/* record.GetInt32(3), record.GetString(4), record.GetString(5), record.GetDateTime(6), record.GetDateTime(7), record.GetDateTime(8), record.GetString(9),*/ RowState.ModifiedNew); 
        //}

        //private void RefreshDataGrid(DataGridView dgwJobs)//CD: Метод для выведения данных в датагридвью
        //{
        //    dgwJobs.Rows.Clear();
        //    string queryString = $"select * from Задачи";
        //    SqlCommand command = new SqlCommand(queryString, dataBaseJobs.getConnection());
        //    dataBaseJobs.openConnection();

        //    SqlDataReader reader = command.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        ReadSingleRow(dgwJobs, reader);
        //    }
        //    reader.Close();
        //}
       
        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    ////SqlCommand queryDGW = new SqlCommand("select* FROM Задачи", dataBaseJobs.getConnection());

        //    ////SqlCommand queryDGW = new SqlCommand("select Задачи.IDЗадачи as Код, Задачи.IDОбъектаСтроительства as NОбъекта, ОбъектСтроительства.НаименованиеОбъектаСтроительства as Объект, Задачи.IDСотрудника as Табельный, Сотрудники.ФамилияСотрудника AS Фамилия, Задачи.УсловиеЗадачи as Условие, Задачи.ДатаПостановкиЗадачи as ДатаПостановки, Задачи.ДатаИсполнения as ДатаИсполнения, Задачи.СрокИсполнения as СрокИсполнения, Задачи.СтатусЗадачи as СтатусЗадачи from Задачи  JOIN ОбъектСтроительства ON Задачи.IDОбъектаСтроительства = ОбъектСтроительства.IDОбъектаСтроительства JOIN Сотрудники ON Задачи.IDСотрудника = Сотрудники.IDСотрудника where  Задачи.IDСотрудника LIKE '" + cbSotrudnikJobs.SelectedValue + "' and Задачи.IDОбъектаСтроительства like '" + cbProjectJobs.SelectedValue + "' ", dataBaseJobs.getConnection());
        //    //SqlCommand queryDGW = new SqlCommand("select Задачи.IDЗадачи, Задачи.IDОбъектаСтроительства, ОбъектСтроительства.НаименованиеОбъектаСтроительства, Задачи.IDСотрудника, Сотрудники.ФамилияСотрудника, Задачи.УсловиеЗадачи, Задачи.ДатаПостановкиЗадачи, Задачи.ДатаИсполнения, Задачи.СрокИсполнения, Задачи.СтатусЗадачи from Задачи  JOIN ОбъектСтроительства ON Задачи.IDОбъектаСтроительства = ОбъектСтроительства.IDОбъектаСтроительства JOIN Сотрудники ON Задачи.IDСотрудника = Сотрудники.IDСотрудника where  Задачи.IDСотрудника LIKE '" + cbSotrudnikJobs.SelectedValue + "' and Задачи.IDОбъектаСтроительства like '" + cbProjectJobs.SelectedValue + "' ", dataBaseJobs.getConnection());
        //    //SqlDataAdapter da2 = new SqlDataAdapter();
        //    //DataTable dt2 = new DataTable();
        //    //da2.SelectCommand = queryDGW;
        //    //dt2.Clear();
        //    //da2.Fill(dt2);
        //    //dgwJobs.DataSource = dt2;

        //    //Change();
        //    Update();
        //}

        private void dgwJobs_CellClick(object sender, DataGridViewCellEventArgs e)//Заполняем текстбоксы из DGW
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgwJobs.Rows[selectedRow];
                tbIDZadachi.Text = row.Cells[0].Value.ToString();
                tbiDОбъектаСтроительства.Text = row.Cells[1].Value.ToString();
                cbProjectJobs.Text = row.Cells[2].Value.ToString();
                tbIDСотрудника.Text = row.Cells[3].Value.ToString();
                tbZadanieJobs.Text = row.Cells[5].Value.ToString();
                dtpStartJobs.Text = row.Cells[6].Value.ToString();
                dtpFinishJobs.Text = row.Cells[7].Value.ToString();
                dtpDLineJobs.Text = row.Cells[8].Value.ToString();
                cbStatus.Text = row.Cells[9].Value.ToString();
            }
        }

        private void btnNewJob_Click(object sender, EventArgs e)
        {
            Forms.AddJob AddJob = new Forms.AddJob();
            this.Show();
            AddJob.ShowDialog();
            this.Show();
        }

        private void deleteRow()//CD
        {
            dataBaseJobs.openConnection();


            var id = tbIDZadachi.Text;
            var IdObj = tbiDОбъектаСтроительства.Text;
            var IdCustomer = tbIDСотрудника.Text;
            var Condition = tbZadanieJobs.Text;
            var DateOfProduction = dtpStartJobs.Value;
            var DateOfDiy = dtpFinishJobs.Value;
            var PeriodOfExecution = dtpDLineJobs.Value;
            var Status = cbStatus.Text;

            if (tbIDZadachi.Text != "")
            {
                var addQuery = $"delete FROM Задачи where IDЗадачи ='{id}'";
                var command = new SqlCommand(addQuery, dataBaseJobs.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Строка удалена", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            dataBaseJobs.closeConnection();

        }

        private void ClearFields()
        {
            tbIDZadachi.Text = " ";
            tbiDОбъектаСтроительства.Text = " ";
            tbIDСотрудника.Text = " ";
            tbZadanieJobs.Text = " ";
            dtpStartJobs.Value = DateTime.Now;
            dtpFinishJobs.Value = DateTime.Now;
            dtpDLineJobs.Value = DateTime.Now;
            cbStatus.Text = " ";
        }



        private void Choose()
        {
            SqlCommand queryDGW = new SqlCommand("select Задачи.IDЗадачи, Задачи.IDОбъектаСтроительства, ОбъектСтроительства.НаименованиеОбъектаСтроительства, Задачи.IDСотрудника, Сотрудники.ФамилияСотрудника, Задачи.УсловиеЗадачи, Задачи.ДатаПостановкиЗадачи, Задачи.ДатаИсполнения, Задачи.СрокИсполнения, Задачи.СтатусЗадачи from Задачи  JOIN ОбъектСтроительства ON Задачи.IDОбъектаСтроительства = ОбъектСтроительства.IDОбъектаСтроительства JOIN Сотрудники ON Задачи.IDСотрудника = Сотрудники.IDСотрудника where  Задачи.IDСотрудника LIKE '" + cbSotrudnikJobs.SelectedValue + "' and Задачи.IDОбъектаСтроительства like '" + cbProjectJobs.SelectedValue + "' ", dataBaseJobs.getConnection());
            SqlDataAdapter da2 = new SqlDataAdapter();
            DataTable dt2 = new DataTable();
            da2.SelectCommand = queryDGW;
            dt2.Clear();
            da2.Fill(dt2);
            dgwJobs.DataSource = dt2;
        }

        //private void Update() //CD
        //{
        //    //dataBaseJobs.openConnection();
        //    //for (int index = 0; index < dgwJobs.Rows.Count; index++)
        //    //{
        //    //    var rowState = (RowState)dgwJobs.Rows[index].Cells[10].Value;
        //    //    if (rowState == RowState.Existed)
        //    //        continue;
        //    //    if (rowState == RowState.Deleted)
        //    //    {
        //    //        var id = Convert.ToInt32(dgwJobs.Rows[index].Cells[0].Value); //Если RowState=Deleted, то передаем SQL запрос, и  создаем перем id которая содержит индекс удаляемой строки и значение нулевого столбца, т.е. id, 
        //    //        var deleteQuery = $"delete from dbo.Задачи where IDЗадачи = {id}";
        //    //        var command = new SqlCommand(deleteQuery, dataBaseJobs.getConnection());
        //    //        command.ExecuteNonQuery();
        //    //    }
        //    //    if (rowState == RowState.Modified)
        //    //    {
        //    //        var Id = dgwJobs.Rows[index].Cells[0].Value.ToString();
        //    //        var IdObj = dgwJobs.Rows[index].Cells[1].Value.ToString();
        //    //        var IdCustomer = dgwJobs.Rows[index].Cells[3].Value.ToString();
        //    //        var Condition = dgwJobs.Rows[index].Cells[5].Value.ToString();
        //    //        var DateOfProduction = dgwJobs.Rows[index].Cells[6].Value.ToString();
        //    //        var DateOfDiy = dgwJobs.Rows[index].Cells[7].Value.ToString();
        //    //        var PeriodOfExecution = dgwJobs.Rows[index].Cells[8].Value.ToString();
        //    //        var Status = dgwJobs.Rows[index].Cells[9].Value.ToString();

        //    //        var changeQuery = $"update Задачи set IDЗадачи = '{Id}', IDОбъектаСтроительства = '{IdObj}', IDСотрудника = '{IdCustomer}', УсловиеЗадачи = '{Condition}', ДатаПостановкиЗадачи = '{DateOfProduction}', ДатаИсполнения = '{DateOfDiy}', СрокИсполнения = '{PeriodOfExecution}', СрокИсполнения = '{PeriodOfExecution}', СтатусЗадачи = '{Status}' where IDЗадач] = '{Id}' ";
        //    //        var command = new SqlCommand(changeQuery, dataBaseJobs.getConnection());
        //    //        command.ExecuteNonQuery();
        //    //    }
        //    //}
        //    //dataBaseJobs.closeConnection();
        //}

        private void Change()
        {
            dataBaseJobs.openConnection();


            var id = tbIDZadachi.Text;
            var IdObj = tbiDОбъектаСтроительства.Text;
            var IdCustomer = tbIDСотрудника.Text;
            var Condition = tbZadanieJobs.Text;
            var DateOfProduction = dtpStartJobs.Value;
            var DateOfDiy = dtpFinishJobs.Value;
            var PeriodOfExecution = dtpDLineJobs.Value;
            var Status = cbStatus.Text;

            if (dtpDLineJobs.Value.Ticks > dtpStartJobs.Value.Ticks)
            {
                //var addQuery = $"insert into Задачи (IDОбъектаСтроительства, IDСотрудника, УсловиеЗадачи, ДатаПостановкиЗадачи, ДатаИсполнения, СрокИсполнения, СтатусЗадачи) values ('{IdObj}', '{IdCustomer}','{Condition}','{DateOfProduction}','{DateOfDiy}','{PeriodOfExecution}','{Status}')";
                //var command = new SqlCommand(addQuery, dataBaseJobs.getConnection());
                var addQuery = $"update Задачи set IDОбъектаСтроительства = '{IdObj}', IDСотрудника = '{IdCustomer}', УсловиеЗадачи = '{Condition}', ДатаПостановкиЗадачи = '{DateOfProduction}', ДатаИсполнения = '{DateOfDiy}', СрокИсполнения = '{PeriodOfExecution}', СтатусЗадачи = '{Status}' where IDЗадачи ='{id}'";
                var command = new SqlCommand(addQuery, dataBaseJobs.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Новые данные сохранены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Проверьте введенные даты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataBaseJobs.closeConnection();
        }

        private void btnDelJob_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
            display_datagrid();
        }

        private void btnChangeObj_Click(object sender, EventArgs e)
        {
            Change();
            display_datagrid();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            Choose();
        }

        private void btnClearChange_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            display_datagrid();
            ClearFields();
        }

        private void dtpStartJobs_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode==Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpStartJobs.CustomFormat = " ";
            }
        }










        //using (SqlConnection conn = new SqlConnection()
        //{
        //    //int id = (int)dgwJobs.CurrentRow.Cells[0].Value;
        //    //int idProject = (int)dgwJobs.CurrentRow.Cells[1].Value;
        //    //int idCustomer = (int)dgwJobs.CurrentRow.Cells[3].Value;
        //    //string Condition = dgwJobs.CurrentRow.Cells[5].Value.ToString();
        //    //string DateOfProduction = dgwJobs.CurrentRow.Cells[6].Value.ToString();
        //    //string DateOfDiy = dgwJobs.CurrentRow.Cells[7].Value.ToString();
        //    //string PeriodOfExecution = dgwJobs.CurrentRow.Cells[8].Value.ToString();
        //    //string Status = dgwJobs.CurrentRow.Cells[9].Value.ToString();

        //    var IdObj = tbiDОбъектаСтроительства.Text;
        //    var IdCustomer = tbIDСотрудника.Text;
        //    var Condition = tbZadanieJobs.Text;
        //    var DateOfProduction = dtpStartJobs.Value;
        //    var DateOfDiy = dtpFinishJobs.Value;
        //    var PeriodOfExecution = dtpDLineJobs.Value;
        //    var Status = cbStatus.Text;

        //string queryString = $"update Задачи set IdObj=@IDОбъектаСтроительства, IdCustomer=@IDСотрудника, Condition=@УсловиеЗадачи, DateOfProduction=@ДатаПостановкиЗадачи, DateOfDiy=@ДатаИсполнения, PeriodOfExecution=@СрокИсполнения, Status=@СтатусЗадачи  where id=@IDЗадачи";
        //SqlCommand cmd = new SqlCommand(queryString, dataBaseJobs.getConnection());
        //cmd.Parameters.AddWithValue("@IDОбъектаСтроительства", IdObj);
        //cmd.Parameters.AddWithValue("@IDСотрудника", IdCustomer);
        //cmd.Parameters.AddWithValue("@УсловиеЗадачи", Condition);
        //cmd.Parameters.AddWithValue("@ДатаПостановкиЗадачи", DateOfProduction);
        //cmd.Parameters.AddWithValue("@ДатаИсполнения", DateOfDiy);
        //cmd.Parameters.AddWithValue("@СрокИсполнения", PeriodOfExecution);
        //cmd.Parameters.AddWithValue("@СтатусЗадачи", Status);
        //cmd.Parameters.AddWithValue("@IDЗадачи", id);

        //    command.Connection = conn;
        //    conn.Open();
        //    try
        //    {
        //        command.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return;
        //    }
        //}
    }
           









        //EditEmpl ee = new EditEmpl(id, fio, sal, dep);
        //    if (ee.ShowDialog() == DialogResult.OK)
        //    {
        //        string commandText = "select id as Код, name as ФИО, salary as Зарплата, department as Подразделение from staff";
        //        SqlDataAdapter adapter = new SqlDataAdapter(commandText, CommonData.ConnectionString);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        dataGridView1.DataSource = dt;
            }
