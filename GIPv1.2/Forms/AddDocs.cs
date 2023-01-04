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
    public partial class AddDocs : Form
    {
        DataBase dataBaseDoc = new DataBase();
        public AddDocs()
        {
            InitializeComponent();
        }


        private void btnCloseAddJ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDocs_Load(object sender, EventArgs e)
        {
            cbProjectDocMethod();
            cbSignDocMethod();
        }
        private void btnSaveAddJ_Click(object sender, EventArgs e)
        {
            SaveData();
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
            cbIDProjectDoc.DisplayMember = "IDОбъектаСтроительства";
            cbIDProjectDoc.ValueMember = "IDОбъектаСтроительства";
            cbProjectDoc.DataSource = dt;
            cbIDProjectDoc.DataSource = dt;
            cbTitlelDoc.Enabled = false;
            cbIDProjectDoc.Enabled = false;
            cbSotrudnikDoc.Enabled = false;
            cbIDSignatory.Enabled = false;
        }

        private void cbSignDocMethod()
        {
            string query1 = $"select * from [dbo].[Подписант]";
            SqlCommand cmd = new SqlCommand(query1, dataBaseDoc.getConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dataBaseDoc.openConnection();
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbSotrudnikDoc.DisplayMember = "ФИО";
            cbSotrudnikDoc.ValueMember = "IDПодписанта";
            cbIDSignatory.DisplayMember = "IDПодписанта";
            cbIDSignatory.ValueMember = "IDПодписанта";
            cbSotrudnikDoc.DataSource = dt;
            cbIDSignatory.DataSource = dt;
        }

        private void cbProjectDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProjectDocForSign();
        }

        private void cbProjectDocForSign()
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
                cbSotrudnikDoc.DisplayMember = "ФИО";
                cbSotrudnikDoc.ValueMember = "IDПодписанта";
                cbIDSignatory.DisplayMember = "IDПодписанта";
                cbIDSignatory.ValueMember = "IDПодписанта";
                cbTitlelDoc.DataSource = dt;
                cbSotrudnikDoc.DataSource = dt;
                cbIDSignatory.DataSource = dt;
                cbTitlelDoc.Enabled = true;
            }
        }

        private void SaveData()
        {
            dataBaseDoc.openConnection();

            var id = tbIDDoc.Text;
            var IdObj = cbIDProjectDoc.Text;
            var IDSignatory = cbIDSignatory.Text;
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

    }
}
