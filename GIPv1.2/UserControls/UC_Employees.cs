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
    enum RowStateEmpl //CD
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class UC_Employees : UserControl
    {
        DataBase dataBaseEmpl = new DataBase();//CD
        int selectedRow1;//CD
        public UC_Employees()
        {
            InitializeComponent();
        }
        
        private void CreateColumns()//CD: Создаем колонки в ДГВ
        {
            dgwEmployees.Columns.Add("IDСотрудника", "№ п/п");
            dgwEmployees.Columns.Add("ФамилияСотрудника", "Фамилия");
            dgwEmployees.Columns.Add("ИмяСотрудника", "Имя");
            dgwEmployees.Columns.Add("ОтчествоСотрудника", "Отчество");
            dgwEmployees.Columns.Add("Должность", "Должность");
            dgwEmployees.Columns.Add("ДатаРождения", "Дата рождения");
            dgwEmployees.Columns.Add("ТарифнаяСтавка", "Тарифная ставка");
            dgwEmployees.Columns.Add("IDОтдела", "№ отдела");
            dgwEmployees.Columns.Add("Login", "Login");
            dgwEmployees.Columns.Add("Password", "Password");
            dgwEmployees.Columns.Add("is_admin", "Администратор");
            dgwEmployees.Columns.Add("IsNew", String.Empty);
            dgwEmployees.Columns[11].Visible = false;
            dgwEmployees.Columns[0].FillWeight = 2;
            dgwEmployees.Columns[1].FillWeight = 14;
            dgwEmployees.Columns[2].FillWeight = 12;
            dgwEmployees.Columns[3].FillWeight = 11;
            dgwEmployees.Columns[4].FillWeight = 10;
            dgwEmployees.Columns[5].FillWeight = 5;
            dgwEmployees.Columns[6].FillWeight = 6;
            dgwEmployees.Columns[7].FillWeight = 4;
            dgwEmployees.Columns[8].FillWeight = 8;
            dgwEmployees.Columns[9].FillWeight = 8;
            dgwEmployees.Columns[10].FillWeight = 7;
            dgwEmployees.AutoResizeColumnHeadersHeight();
        }
        private void ReadSingleRow1(DataGridView dgw1, IDataRecord record)//CD
        {
            dgw1.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetDateTime(5), record.GetInt32(6), record.GetInt32(7), record.GetString(8), record.GetString(9), record.GetBoolean(10), RowStateEmpl.ModifiedNew);
        }

        private void RefreshDataGrid1(DataGridView dgw1)//CD: Метод для выведения данных в датагридвью
        {
            dgw1.Rows.Clear();
            string queryStringEmpl = $"select * from Сотрудники";
            SqlCommand command = new SqlCommand(queryStringEmpl, dataBaseEmpl.getConnection());
            dataBaseEmpl.openConnection();

            SqlDataReader readerEmpl = command.ExecuteReader();

            while (readerEmpl.Read())
            {
                ReadSingleRow1(dgw1, readerEmpl);
            }
            readerEmpl.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid1(dgwEmployees);
            ClearFields();
        }

        private void btnNewEmpl_Click(object sender, EventArgs e)
        {
            Forms.AddEmpoyee AddEmpl = new Forms.AddEmpoyee();
            this.Show();
            AddEmpl.ShowDialog();
            this.Show();
        }
        private void dataGridViewEmpl_CellClick(object sender, DataGridViewCellEventArgs e)//CD: Заносим данные из ДГВ в ТБ
        {
            selectedRow1 = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgwEmployees.Rows[selectedRow1];
                iDСотрудникаTextBox.Text = row.Cells[0].Value.ToString();
                фамилияСотрудникаTextBox.Text = row.Cells[1].Value.ToString();
                имяСотрудникаTextBox.Text = row.Cells[2].Value.ToString();
                отчествоСотрудникаTextBox.Text = row.Cells[3].Value.ToString();
                должностьTextBox.Text = row.Cells[4].Value.ToString();
                датаРожденияDateTimePicker.Text = row.Cells[5].Value.ToString();
                тарифнаяСтавкаTextBox.Text = row.Cells[6].Value.ToString();
                iDОтделаTextBox.Text = row.Cells[7].Value.ToString();
                loginTextBox.Text = row.Cells[8].Value.ToString();
                passwordTextBox.Text = row.Cells[9].Value.ToString();
                is_adminComboBox.Text = row.Cells[10].Value.ToString();
            }
        }

        private void UC_Employees_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid1(dgwEmployees);
            //cbSearch.SelectedIndex = 1;
            CbSearch();
            Update();
           // display_datagrid();
        }
        private void Search(DataGridView dgw1)//функция поиска по фамилии
        {
            dgw1.Rows.Clear();
            //string searchString = $"select * from ОбъектСтроительства where НаименованиеОбъектаСтроительства = '" + tbSearch.Text + "'";
            string searchString = $"select * from Сотрудники where ФамилияСотрудника like '%{tbSearch.Text}%'";
            SqlCommand com = new SqlCommand(searchString, dataBaseEmpl.getConnection());
            dataBaseEmpl.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow1(dgw1, read);
            }
            read.Close();
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dgwEmployees);
        }

        //-------------------------------------------------------------------------------------
        private void deleteRow()//CD
        {
            int index = dgwEmployees.CurrentCell.RowIndex;
            dgwEmployees.Rows[index].Visible = false;
            if (dgwEmployees.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dgwEmployees.Rows[index].Cells[11].Value = RowState.Deleted;//если ячейка пустая после удаления, ей присваивается Deleted
                return;
            }
            dgwEmployees.Rows[index].Cells[11].Value = RowState.Deleted;
        }
        private void btnDelEmpl_Click(object sender, EventArgs e)
        {
           deleteRow();
           ClearFields();
        }
        private void btnSaveEmpl_Click(object sender, EventArgs e)
        {
            Update();
        }
        private void Change()
        {
            var selectedRowIndex = dgwEmployees.CurrentCell.RowIndex;
            var Id = iDСотрудникаTextBox.Text;
            var Family = фамилияСотрудникаTextBox.Text;
            var Name = имяСотрудникаTextBox.Text;
            var Patronymic = отчествоСотрудникаTextBox.Text;
            var Function = должностьTextBox.Text;
            var BirthDay = датаРожденияDateTimePicker.Value;
            int TariffRate;
            //var Department = OtdelcBox.SelectedIndex.ToString();
            /////////////////////////////////////////////////
            var Department = iDОтделаTextBox.Text;
            var Login = loginTextBox.Text;
            var Password = passwordTextBox.Text;
            var Is_Admin = is_adminComboBox.Text;//(!!!!!!!!!!!!!!!!!!!!!!!!!!!)
            if (dgwEmployees.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)//проверка не пустой ли id
            {

                if (int.TryParse(тарифнаяСтавкаTextBox.Text, out TariffRate))//проверка на корректность введенного числа =int
                {
                    dgwEmployees.Rows[selectedRowIndex].SetValues(Id, Family, Name, Patronymic, Function, BirthDay, TariffRate, Department, Login, Password, Is_Admin);
                    dgwEmployees.Rows[selectedRowIndex].Cells[11].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Проверьте корректность введенных данных в графу 'Тарифная ставка'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnChangeEmpl_Click(object sender, EventArgs e)
        {
            Change();
            Update();
            RefreshDataGrid1(dgwEmployees);
        }
        private void ClearFields()
        {
            iDСотрудникаTextBox.Text = " ";
            фамилияСотрудникаTextBox.Text = " ";
            имяСотрудникаTextBox.Text = " ";
            отчествоСотрудникаTextBox.Text = " ";
            должностьTextBox.Text = " ";
            датаРожденияDateTimePicker.Value = DateTime.Now;
            тарифнаяСтавкаTextBox.Text = " ";
            loginTextBox.Text = " ";
            passwordTextBox.Text = " ";
            is_adminComboBox.Text = " ";//(!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!)
            //is_adminCheckBox.Checked = false;
        }
        private void btnClearChange_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void Update() //CD
        {
            dataBaseEmpl.openConnection();
            for (int index = 0; index < dgwEmployees.Rows.Count; index++)
            {
                var rowState = (RowState)dgwEmployees.Rows[index].Cells[11].Value;
                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dgwEmployees.Rows[index].Cells[0].Value); //Если RowState=Deleted, то передаем SQL запрос, и  создаем перем id которая содержит индекс удаляемой строки и значение нулевого столбца, т.е. id, 
                    var deleteQuery = $"delete from dbo.Сотрудники where IDСотрудника = {id}";
                    var command = new SqlCommand(deleteQuery, dataBaseEmpl.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified)
                {
                    var Id = dgwEmployees.Rows[index].Cells[0].Value.ToString();
                    var Family = dgwEmployees.Rows[index].Cells[1].Value.ToString();
                    var Name = dgwEmployees.Rows[index].Cells[2].Value.ToString();
                    var Patronymic = dgwEmployees.Rows[index].Cells[3].Value.ToString();
                    var Function = dgwEmployees.Rows[index].Cells[4].Value.ToString();
                    var BirthDay = dgwEmployees.Rows[index].Cells[5].Value.ToString();
                    var TariffRate = dgwEmployees.Rows[index].Cells[6].Value.ToString();
                    //var Department = OtdelcBox.SelectedIndex.ToString();
                    /////////////////////////////////////////////////
                    var Department = dgwEmployees.Rows[index].Cells[7].Value.ToString();
                    var Login = dgwEmployees.Rows[index].Cells[8].Value.ToString();
                    var Password = dgwEmployees.Rows[index].Cells[9].Value.ToString();
                    var Is_Admin = dgwEmployees.Rows[index].Cells[10].Value.ToString();
                    var changeQuery = $"update [dbo].[Сотрудники] set [ФамилияСотрудника] = '{Family}', [ИмяСотрудника] = '{Name}', [ОтчествоСотрудника] = '{Patronymic}', [Должность] = '{Function}', [ДатаРождения] = '{BirthDay}',[ТарифнаяСтавка] = '{TariffRate}',[IDОтдела] = '{Department}',[Login]= '{Login}',[Password] = '{Password}',[is_admin] = '{Is_Admin}' where [IDСотрудника] = '{Id}' ";
                    var command = new SqlCommand(changeQuery, dataBaseEmpl.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBaseEmpl.closeConnection();
        }

        //private void SearcCbOtdels(DataGridView dgw)
        //{
        //    dataBaseEmpl.openConnection();

        //}
        //private void CbSearchOtdel_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    SearcCbOtdels(dgwEmployees);
        //}

        private void CbSearch()
        {
            //string query1 = "Select distinct НазваниеОтдела from Отдел";
            //SqlDataAdapter da = new SqlDataAdapter(query1, dataBaseEmpl.getConnection());
            //dataBaseEmpl.openConnection();
            //DataSet dt = new DataSet();
            //da.Fill(dt, "НазваниеОтдела");
            //CbSearchOtdel.DisplayMember = "НазваниеОтдела";
            //CbSearchOtdel.ValueMember = "IDОтдела";
            //CbSearchOtdel.DataSource = dt.Tables["НазваниеОтдела"];
            //dataBaseEmpl.closeConnection();
            //if (CbSearchOtdel.Items.Count > 1)
            //{
            //    CbSearchOtdel.SelectedIndex = -1;
            //}
        }
        private void CbSearchOtdel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display_datagrid();
            //int val;
            //Int32.TryParse(CbSearchOtdel.SelectedValue.ToString(), out val);
            //string query = "Select * from [dbo].[Сотрудники] where [dbo].[Сотрудники].[IDОтдела]=" + val;
            //SqlDataAdapter da2 = new SqlDataAdapter();
            //DataSet dt2 = new DataSet();
            //da2.SelectCommand = query2;
            //dt2.Clear();
            //da2.Fill(dt2);
            //dgwEmployees.DataSource = dt2;

            //dataBaseEmpl.openConnection();

        }
        //private void display_datagrid()
        //{

        //    dgwEmployees.Rows.Clear();
        //    if (CbSearchOtdel.Text == CbSearchOtdel.DisplayMember)
        //    {
        //        SqlCommand query2 = new SqlCommand("select * FROM [dbo].[Сотрудники] where [IDОтдела]='"+ CbSearchOtdel.DataSource + "'");
        //        SqlDataAdapter da2 = new SqlDataAdapter();
        //        DataSet dt2 = new DataSet();
        //        da2.SelectCommand = query2;
        //        dt2.Clear();
        //        da2.Fill(dt2);
        //        dgwEmployees.DataSource = dt2;

        //        dataBaseEmpl.openConnection();

        //    }


    }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //SqlCommand com = new SqlCommand("Select *  from [dbo].[Отдел]");
        //}

        //private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    //SqlCommand com = new SqlCommand("Select *  from [dbo].[Отдел]");
        //}




























    ////SqlCommand query2 = new SqlCommand("Select  [dbo].[Сотрудники].[IDОтдела], [dbo].[Отдел].[НазваниеОтдела] from [dbo].[Сотрудники] join [dbo].[Отдел] on [dbo].[Сотрудники].[IDОтдела] = [dbo].[Отдел].[НазваниеОтдела] where [Отдел].[НазваниеОтдела] like '%" + CbSearchOtdel.Text + "'", dataBaseEmpl.getConnection());

    ////SqlCommand query2 = new SqlCommand("Select [dbo].[Сотрудники].[IDСотрудника],[dbo].[Отдел].[НазваниеОтдела] from [dbo].[Сотрудники] JOIN [dbo].[Отдел] on [dbo].[Сотрудники].[IDОтдела]= [dbo].[Отдел].[IDОтдела] where [Отдел].[НазваниеОтдела] like '%" + CbSearchOtdel.Text + "'", dataBaseEmpl.getConnection());

    ////SqlCommand query2 = new SqlCommand("Select * from [dbo].[Сотрудники] JOIN [dbo].[Отдел] on [dbo].[Сотрудники].[IDОтдела]= [dbo].[Отдел].[IDОтдела] where [Отдел].[НазваниеОтдела] like '%" + CbSearchOtdel.Text + "'", dataBaseEmpl.getConnection());

    ////SqlCommand query2 = new SqlCommand("Select [Отдел].[НазваниеОтдела], [Задачи].[IDОтдела] from [dbo].[Отдел] join [dbo].[Задачи] on [Задачи].[IDОтдела] = [Отдел].[IDОтдела] where [Отдел].[НазваниеОтдела] like '%" + CbSearchOtdel.Text + "'", dataBaseEmpl.getConnection());

    //select t1.key, t2.name from table1 t1 join table2 t2 on t1.key = t2.key
    //    SqlDataAdapter da2 = new SqlDataAdapter();
    //    DataSet dt2 = new DataSet();
    //    da2.SelectCommand = query2;
    //    dt2.Clear();
    //    da2.Fill(dt2);
    //    dgwEmployees.DataSource = dt2;
    //}

    ////string searchString = $"select * from ОбъектСтроительства where ИсточникСредств like '%{cbSearch.Text}%'";
    //private void CbSearchOtdel_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    display_datagrid();
    //}
    //private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    SearchCbOtdel(dgwEmployees);
    //}

    //private void SearchCbOtdel(DataGridView dgw)
    //{
    //    dgw.Rows.Clear();
    //}

    //private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
    //{

    //    SearchCB(dgwProjects);
    //}
    //private void SearchCB(DataGridView dgw)
    //{

    //    dgw.Rows.Clear();
    //    if (cbSearch.Text == "ИсточникСредств")
    //    {
    //        string searchString = $"select * from ОбъектСтроительства where ИсточникСредств like '%%' ";
    //        SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
    //        dataBase.openConnection();
    //        SqlDataReader read1 = com.ExecuteReader();
    //        while (read1.Read())
    //        {
    //            ReadSingleRow(dgw, read1);
    //        }
    //        read1.Close();
    //    }
    //    else if (cbSearch.Text == "Бюджет")
    //    {
    //        string searchString = $"select * from ОбъектСтроительства where ИсточникСредств like '%{cbSearch.Text}%'";
    //        //string searchString = $"select * from ОбъектСтроительства where ИсточникСредств like '%{cbSearch.SelectedValue.ToString()}%'";
    //        //string searchString = $"select * from ОбъектСтроительства where ИсточникСредств = '" + cbSearch.SelectedValue.ToString() + "'";
    //        SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
    //        dataBase.openConnection();
    //        SqlDataReader read1 = com.ExecuteReader();
    //        while (read1.Read())
    //        {
    //            ReadSingleRow(dgw, read1);
    //        }
    //        read1.Close();
    //    }
    //    else if (cbSearch.Text == "Средства заказчика")
    //    {
    //        string searchString = $"select * from ОбъектСтроительства where ИсточникСредств like '%{cbSearch.Text}%'";
    //        SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
    //        dataBase.openConnection();
    //        SqlDataReader read1 = com.ExecuteReader();
    //        while (read1.Read())
    //        {
    //            ReadSingleRow(dgw, read1);
    //        }
    //        read1.Close();
    //    }
    //    else if (cbSearch.Text == "Резервный фонд президента")
    //    {
    //        string searchString = $"select * from ОбъектСтроительства where ИсточникСредств like '%{cbSearch.Text}%'";
    //        SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
    //        dataBase.openConnection();
    //        SqlDataReader read1 = com.ExecuteReader();
    //        while (read1.Read())
    //        {
    //            ReadSingleRow(dgw, read1);
    //        }
    //        read1.Close();
    //    }

//}


    //}
}
