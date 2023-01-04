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

namespace GIPv1._2.Forms
{
    enum RowState
    { 
    Existed,
    New,
    Modified,
    ModifiedNew,
    Deleted

    }
    public partial class WorkObjects : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        public WorkObjects()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("IDОбъектаСтроительства", "ID");
            dataGridView1.Columns.Add("НаименованиеОбъектаСтроительства", "Наименование Объекта");
            dataGridView1.Columns.Add("ДатаРегистрацииЗаявления", "Дата создания");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetDateTime(2), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
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

        //private void WorkObjects_Load(object sender, EventArgs e)
        //{
        //    // TODO: данная строка кода позволяет загрузить данные в таблицу "_GIPv1_5DataSet.ОбъектСтроительства". При необходимости она может быть перемещена или удалена.
        //    this.объектСтроительстваTableAdapter.Fill(this._GIPv1_5DataSet.ОбъектСтроительства);
        //    CreateColumns();
        //    RefreshDataGrid(dataGridView1);
        //}

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                tbIDObj.Text = row.Cells[0].Value.ToString();
                tbNameObj.Text = row.Cells[1].Value.ToString();
                tbDateCreate.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        //private void btnNewObj_Click(object sender, EventArgs e)
        //{
        //    AddWork addfrm = new AddWork();
        //    addfrm.Show();
        //}
        private void btnNewObj_Click(object sender, EventArgs e)
        {
            AddProject1 addfrmprojects = new AddProject1();
            addfrmprojects.Show();
        }

        //private void объектСтроительстваBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.объектСтроительстваBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this._GIPv1_5DataSet);

        //}
    }
}
