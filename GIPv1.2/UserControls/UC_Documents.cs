using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace GIPv1._2.UserControls
{
    public partial class UC_Documents : UserControl
    {
        DataBase dataBaseDoc = new DataBase();
        int selectedRow;
        public UC_Documents()
        {
            InitializeComponent();
            //cbProjectDocMethod();
        }

        private void UC_Documents_Load(object sender, EventArgs e)
        {
            cbProjectDocMethod();
            display_datagrid();
            DocDateControl();
            lblDocDateControl.Visible = false;
        }

        private void btnNewDoc_Click(object sender, EventArgs e)
        {
            Forms.AddDocs AddDocs = new Forms.AddDocs();
            this.Show();
            AddDocs.ShowDialog();
            this.Show();
        }

        private void cbProjectDocMethod()
        {
            string query1 = $"select * from [dbo].[ОбъектСтроительства]";
            SqlCommand cmd = new SqlCommand(query1, dataBaseDoc.getConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dataBaseDoc.openConnection();
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbProjectDoc.DisplayMember = "НаименованиеОбъектаСтроительства";
            cbProjectDoc.ValueMember = "IDОбъектаСтроительства";
            cbProjectDoc.DataSource = dt;
            cbTitlelDoc.Enabled = false;
            btnSelectSign.Enabled = false;
            this.btnSelectSign.BackColor = System.Drawing.Color.LightGray;
            this.btnSelectSign.ForeColor = System.Drawing.Color.WhiteSmoke;
        }

        private void cbProjectDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProjectDoc.SelectedValue.ToString() != null)
            {
                string queryString = $"select * from [dbo].[Подписант]";
                SqlCommand cmd = new SqlCommand(queryString, dataBaseDoc.getConnection());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataBaseDoc.closeConnection();
                cbTitlelDoc.DisplayMember = "Должность";
                cbTitlelDoc.ValueMember = "IDПодписанта";
                cbTitlelDoc.DataSource = dt;
                cbTitlelDoc.Enabled = true;
                btnSelectSign.Enabled = true;
                this.btnSelectSign.BackColor = System.Drawing.Color.SeaGreen;
            }
        }

        private void display_datagrid()
        {
            SqlCommand queryDoc = new SqlCommand("Select РазрешительныйДокумент.IDРазрешДокумента as NДок, РазрешительныйДокумент.IDОбъектаСтроительства as NОбъекта,  ОбъектСтроительства.НаименованиеОбъектаСтроительства as Объект, РазрешительныйДокумент.IDПодписанта as NПодписанта, Подписант.Должность as Должность, РазрешительныйДокумент.НаименованиеРазрешДокумента as Документ, РазрешительныйДокумент.ДатаВыдачиДокумента as ДатаВыдачи, РазрешительныйДокумент.Срок_действия_документа as СрокДействия FROM РазрешительныйДокумент JOIN ОбъектСтроительства ON РазрешительныйДокумент.IDОбъектаСтроительства = ОбъектСтроительства.IDОбъектаСтроительства JOIN Подписант ON РазрешительныйДокумент.IDПодписанта = Подписант.IDПодписанта ", dataBaseDoc.getConnection());
            SqlDataAdapter da2 = new SqlDataAdapter();
            DataTable dt2 = new DataTable();
            da2.SelectCommand = queryDoc;
            dt2.Clear();
            da2.Fill(dt2);
            dgwDoc.DataSource = dt2;
        }

        private void SelectObject()
        {
            SqlCommand queryDGW = new SqlCommand("Select РазрешительныйДокумент.IDРазрешДокумента, РазрешительныйДокумент.IDОбъектаСтроительства,  ОбъектСтроительства.НаименованиеОбъектаСтроительства, РазрешительныйДокумент.IDПодписанта, Подписант.Должность, РазрешительныйДокумент.НаименованиеРазрешДокумента, РазрешительныйДокумент.ДатаВыдачиДокумента, РазрешительныйДокумент.Срок_действия_документа FROM РазрешительныйДокумент JOIN ОбъектСтроительства ON РазрешительныйДокумент.IDОбъектаСтроительства = ОбъектСтроительства.IDОбъектаСтроительства JOIN Подписант ON РазрешительныйДокумент.IDПодписанта = Подписант.IDПодписанта WHERE РазрешительныйДокумент.IDОбъектаСтроительства LIKE '" + cbProjectDoc.SelectedValue + "'", dataBaseDoc.getConnection());

            SqlDataAdapter da2 = new SqlDataAdapter();
            DataTable dt2 = new DataTable();
            da2.SelectCommand = queryDGW;
            dt2.Clear();
            da2.Fill(dt2);
            dgwDoc.DataSource = dt2;
        }

        private void SelectSignature()
        {
            SqlCommand queryDGW = new SqlCommand("Select РазрешительныйДокумент.IDРазрешДокумента, РазрешительныйДокумент.IDОбъектаСтроительства,  ОбъектСтроительства.НаименованиеОбъектаСтроительства, РазрешительныйДокумент.IDПодписанта, Подписант.Должность, РазрешительныйДокумент.НаименованиеРазрешДокумента, РазрешительныйДокумент.ДатаВыдачиДокумента, РазрешительныйДокумент.Срок_действия_документа FROM РазрешительныйДокумент JOIN ОбъектСтроительства ON РазрешительныйДокумент.IDОбъектаСтроительства = ОбъектСтроительства.IDОбъектаСтроительства JOIN Подписант ON РазрешительныйДокумент.IDПодписанта = Подписант.IDПодписанта WHERE РазрешительныйДокумент.IDПодписанта LIKE '" + cbTitlelDoc.SelectedValue + "'", dataBaseDoc.getConnection());

            SqlDataAdapter da2 = new SqlDataAdapter();
            DataTable dt2 = new DataTable();
            da2.SelectCommand = queryDGW;
            dt2.Clear();
            da2.Fill(dt2);
            dgwDoc.DataSource = dt2;
        }

        private void dgwDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgwDoc.Rows[selectedRow];
                tbIDDoc.Text = row.Cells[0].Value.ToString();
                tbiDОбъектаСтроительства.Text = row.Cells[1].Value.ToString();
                cbProjectDoc.Text = row.Cells[2].Value.ToString();
                tbIDSignatory.Text = row.Cells[3].Value.ToString();
                cbTitlelDoc.Text = row.Cells[4].Value.ToString();
                tbDocContent.Text = row.Cells[5].Value.ToString();
                dtDateOfIssue.Text = row.Cells[6].Value.ToString();
                tbValidity.Text = row.Cells[7].Value.ToString();

                int dt1 = Convert.ToInt32(tbValidity.Text);
                dtValidDate.Value = dtDateOfIssue.Value.AddMonths(dt1);
            }
        }

        private void ClearFields()
        {
            tbIDDoc.Text = " ";
            tbiDОбъектаСтроительства.Text = " ";
            cbProjectDoc.Text = " ";
            tbIDSignatory.Text = " ";
            cbTitlelDoc.Text = " ";
            tbDocContent.Text = " ";
            dtDateOfIssue.Value = DateTime.Now;
            tbValidity.Text =  " ";
            dtValidDate.Value = DateTime.Now;
        }

        private void deleteRow()//CD
        {
            dataBaseDoc.openConnection();


            var id = tbIDDoc.Text;
            var IdObj = tbiDОбъектаСтроительства.Text;
            var IDSignatory = tbIDSignatory.Text;
            var DocContent = tbDocContent.Text;
            var DateOfIssue = dtDateOfIssue.Value;
            var Validity = tbValidity.Text;
            if (tbIDDoc.Text != " ")
            {
                var addQuery = $"delete FROM РазрешительныйДокумент where IDЗадачи ='{id}'";
                var command = new SqlCommand(addQuery, dataBaseDoc.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Строка удалена", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataBaseDoc.closeConnection();
        }

        private void SaveData()
        {
            dataBaseDoc.openConnection();

            var id = tbIDDoc.Text;
            var IdObj = tbiDОбъектаСтроительства.Text;
            var IDSignatory = tbIDSignatory.Text;
            var DocContent = tbDocContent.Text;
            var DateOfIssue = dtDateOfIssue.Value;
            var Validity = tbValidity.Text;

            if (dtDateOfIssue.Value.Ticks < dtDateOfIssue.Value.AddMonths(Convert.ToInt32(tbValidity.Text)).Ticks)
            {
                var addQuery = $"update РазрешительныйДокумент set IDОбъектаСтроительства = '{IdObj}',  IDПодписанта = '{IDSignatory}', НаименованиеРазрешДокумента = '{DocContent}', ДатаВыдачиДокумента = '{DateOfIssue}', Срок_действия_документа = '{Validity}'  where IDРазрешДокумента ='{id}'";
                var command = new SqlCommand(addQuery, dataBaseDoc.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Новые данные сохранены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Проверьте введенные даты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataBaseDoc.closeConnection();
        }

        private void DocDateControl()
        {
            if (dtValidDate.Value< dtDateOfIssue.Value)
            {
                lblDocDateControl.Visible = true;
            }
        }

        private void btnSelectObj_Click(object sender, EventArgs e)
        {
            SelectObject();
        }

        private void btnSelectSign_Click(object sender, EventArgs e)
        {
            SelectSignature();
        }

        private void btnDelJob_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
            display_datagrid();
        }

        private void btnClearChange_Click(object sender, EventArgs e)
        {
            ClearFields();
            display_datagrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            display_datagrid();
            ClearFields();
        }

        private void btnChangeObj_Click(object sender, EventArgs e)
        {
            SaveData();
            display_datagrid();
        }

        private void btnEditSign_Click(object sender, EventArgs e)
        {
            Forms.EditSign EditSign = new Forms.EditSign();
            this.Show();
            EditSign.ShowDialog();
            this.Show();
        }
    }
}
