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
    enum RowState //CD
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class UC_Projects : UserControl
    {
        DataBase dataBase = new DataBase();//CD
        int selectedRow;//CD
        public UC_Projects()
        {
            InitializeComponent();
        }

        private void CreateColumns()//CD: Создаем колонки в ДГВ
        {
            dgwProjects.Columns.Add("IDОбъектаСтроительства", "№ п/п");
            dgwProjects.Columns.Add("НаименованиеОбъектаСтроительства", "Наименование проекта");
            dgwProjects.Columns.Add("ДатаРегистрацииЗаявления", "Дата регистрации");
            dgwProjects.Columns.Add("ДатаИнспирации", "Дата инспирации");
            dgwProjects.Columns.Add("НаименованиеЗаказчика", "Наименование заказчика");
            dgwProjects.Columns.Add("ИсточникСредств", "Источник средств");
            dgwProjects.Columns.Add("IsNew", String.Empty);
            dgwProjects.Columns[6].Visible = false;
            dgwProjects.Columns[0].FillWeight = 5;
            dgwProjects.Columns[1].FillWeight = 50;
            dgwProjects.Columns[2].FillWeight = 8;
            dgwProjects.Columns[3].FillWeight = 8;
            dgwProjects.Columns[4].FillWeight = 13;
            dgwProjects.Columns[5].FillWeight = 16;
            dgwProjects.AutoResizeColumnHeadersHeight();
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)//CD
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetDateTime(2), record.GetDateTime(3), record.GetString(4), record.GetString(5), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)//CD: Метод для выведения данных в датагридвью
        {
            dgw.Rows.Clear();
            string queryString = $"select * from ОбъектСтроительства";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void UC_Jobs_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dgwProjects);
            cbSearch.SelectedIndex = 1;
            Update();

        }
        private void btnNewObj_Click(object sender, EventArgs e)//вызвваем форму для добавления нового объекта
        {
            Forms.AddProject AddPr = new Forms.AddProject();
            this.Show();
            AddPr.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//CD: Заносим данные из ДГВ в ТБ
        {
            selectedRow = e.RowIndex;
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = dgwProjects.Rows[selectedRow];
                iDОбъектаСтроительстваTextBox.Text = row.Cells[0].Value.ToString();
                наименованиеОбъектаСтроительстваTextBox.Text = row.Cells[1].Value.ToString();
                датаРегистрацииЗаявленияDateTimePicker.Text= row.Cells[2].Value.ToString();
                датаИнспирацииDateTimePicker.Text = row.Cells[3].Value.ToString();
                наименованиеЗаказчикаTextBox.Text = row.Cells[4].Value.ToString();
                источникСредствComboBox.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dgwProjects);
            ClearFields();
        }
        //------------------------------------------------------------------------------------------
        private void Search(DataGridView dgw)//функция поиска
        {
            dgw.Rows.Clear();
            //string searchString = $"select * from ОбъектСтроительства where НаименованиеОбъектаСтроительства = '" + tbSearch.Text + "'";
            string searchString = $"select * from ОбъектСтроительства where НаименованиеОбъектаСтроительства like '%{tbSearch.Text}%'";
            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dgwProjects);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search(dgwProjects);
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            SearchCB(dgwProjects);
        }
        private void SearchCB(DataGridView dgw)
        {

            dgw.Rows.Clear();
            if (cbSearch.Text == "ИсточникСредств")
            {
                string searchString = $"select * from ОбъектСтроительства where ИсточникСредств like '%%' ";
                SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
                dataBase.openConnection();
                SqlDataReader read1 = com.ExecuteReader();
                while (read1.Read())
                {
                    ReadSingleRow(dgw, read1);
                }
                read1.Close();
            }
            else if (cbSearch.Text == "Бюджет")
            {
                string searchString = $"select * from ОбъектСтроительства where ИсточникСредств like '%{cbSearch.Text}%'";
                //string searchString = $"select * from ОбъектСтроительства where ИсточникСредств like '%{cbSearch.SelectedValue.ToString()}%'";
                //string searchString = $"select * from ОбъектСтроительства where ИсточникСредств = '" + cbSearch.SelectedValue.ToString() + "'";
                SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
                dataBase.openConnection();
                SqlDataReader read1 = com.ExecuteReader();
                while (read1.Read())
                {
                    ReadSingleRow(dgw, read1);
                }
                read1.Close();
            }
            else if (cbSearch.Text == "Средства заказчика")
            {
                string searchString = $"select * from ОбъектСтроительства where ИсточникСредств like '%{cbSearch.Text}%'";
                SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
                dataBase.openConnection();
                SqlDataReader read1 = com.ExecuteReader();
                while (read1.Read())
                {
                    ReadSingleRow(dgw, read1);
                }
                read1.Close();
            }
            else if (cbSearch.Text == "Резервный фонд президента")
            {
                string searchString = $"select * from ОбъектСтроительства where ИсточникСредств like '%{cbSearch.Text}%'";
                SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
                dataBase.openConnection();
                SqlDataReader read1 = com.ExecuteReader();
                while (read1.Read())
                {
                    ReadSingleRow(dgw, read1);
                }
                read1.Close();
            }
            
        }

        //------------------------------------------------------------------------------------------
        private void deleteRow()//CD
        {
            int index = dgwProjects.CurrentCell.RowIndex;
            dgwProjects.Rows[index].Visible = false;
            if (dgwProjects.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dgwProjects.Rows[index].Cells[6].Value = RowState.Deleted;//если ячейка пустая после удаления, ей присваивается Deleted
                return ;
            }
            dgwProjects.Rows[index].Cells[6].Value = RowState.Deleted;
        }

        private void Update() //CD
        {
            dataBase.openConnection();
            for(int index=0; index<dgwProjects.Rows.Count; index++)
            {
                var rowState = (RowState)dgwProjects.Rows[index].Cells[6].Value;
                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dgwProjects.Rows[index].Cells[0].Value); //Если RowState=Deleted, то передаем SQL запрос, и  создаем перем id которая содержит индекс удаляемой строки и значение нулевого столбца, т.е. id, 
                    var deleteQuery = $"delete from dbo.ОбъектСтроительства where IDОбъектаСтроительства = {id}";
                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified ) 
                {
                    var Id=dgwProjects.Rows[index].Cells[0].Value.ToString();
                    var Name = dgwProjects.Rows[index].Cells[1].Value.ToString();
                    var DateRef = dgwProjects.Rows[index].Cells[2].Value.ToString();
                    var DateInsp = dgwProjects.Rows[index].Cells[3].Value.ToString();
                    var Customer = dgwProjects.Rows[index].Cells[4].Value.ToString();
                    var Funds = dgwProjects.Rows[index].Cells[5].Value.ToString();
                    var changeQuery = $"update ОбъектСтроительства set НаименованиеОбъектаСтроительства = '{Name}', ДатаРегистрацииЗаявления = '{DateRef}', ДатаИнспирации = '{DateInsp}', НаименованиеЗаказчика= '{Customer}', ИсточникСредств = '{Funds}' where IDОбъектаСтроительства = '{Id}' ";
                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }
        private void btnDelObj_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void Change()
        {
            var selectedRowIndex = dgwProjects.CurrentCell.RowIndex;
            var Id = iDОбъектаСтроительстваTextBox.Text;
            var Name = наименованиеОбъектаСтроительстваTextBox.Text;
            var DateRef = датаРегистрацииЗаявленияDateTimePicker.Value;
            var DateInsp = датаИнспирацииDateTimePicker.Value;
            var Customer = наименованиеЗаказчикаTextBox.Text;
            var Funds = источникСредствComboBox.Text;

            if (dgwProjects.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)//проверка не пустой ли id
            {

                if (датаИнспирацииDateTimePicker.Value.Ticks > датаРегистрацииЗаявленияDateTimePicker.Value.Ticks)//проверка на корректность введенной даты
                {
                    dgwProjects.Rows[selectedRowIndex].SetValues(Id, Name, DateRef, DateInsp, Customer, Funds);
                    dgwProjects.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Проверьте введенные даты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnChangeObj_Click_1(object sender, EventArgs e)
        {
          Change();
          Update();
        }

        private void ClearFields()
        {
            iDОбъектаСтроительстваTextBox.Text = " ";
            наименованиеОбъектаСтроительстваTextBox.Text = " ";
            датаРегистрацииЗаявленияDateTimePicker.Value = DateTime.Now;
            датаИнспирацииDateTimePicker.Value = DateTime.Now;
            наименованиеЗаказчикаTextBox.Text = " ";
            источникСредствComboBox.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        //private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        if (string.IsNullOrEmpty(tbSearch.Text))
        //            объектСтроительстваBindingSource.Filter = string.Empty;
        //        else
        //        {
        //            объектСтроительстваBindingSource.Filter = string.Format("{0}='{1}'", cbSearch.Text, tbSearch.Text);
        //        }
        //    }
        //}
    }
}


