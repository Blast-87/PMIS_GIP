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
    public partial class AddJob : Form
    {
        DataBase dataBaseJobs = new DataBase();

        public AddJob()
        {
            InitializeComponent();
            //cbProjectJobsMethod();
        }

        private void cbProjectJobsMethod()
        {
            string querystr = $"select * from [dbo].[ОбъектСтроительства]";
            SqlCommand cmda = new SqlCommand(querystr, dataBaseJobs.getConnection());
            SqlDataAdapter daa = new SqlDataAdapter(cmda);
            dataBaseJobs.openConnection();
            DataTable dta = new DataTable();
            daa.Fill(dta);
            cbProjectJobs.DisplayMember = "НаименованиеОбъектаСтроительства";
            cbProjectJobs.ValueMember = "IDОбъектаСтроительства";
            cbProjectJobs.DataSource = dta;
            //dataBaseJobs.closeConnection();
            cbOtdelJobs.Enabled = false;
            cbSotrudnikJobs.Enabled = false;
            //btnSaveAddJ.Enabled = false;
            //this.btnSaveAddJ.BackColor = System.Drawing.Color.LightGray;
            //this.btnSaveAddJ.ForeColor = System.Drawing.Color.WhiteSmoke;
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
                dataBaseJobs.closeConnection();
                cbOtdelJobs.DisplayMember = "НазваниеОтдела";
                cbOtdelJobs.ValueMember = "IDОтдела";
                cbOtdelJobs.DataSource = dt;
                cbOtdelJobs.Enabled = true;
                cbSotrudnikJobs.Enabled = false;
                btnSaveAddJ.Enabled = false;
                this.btnSaveAddJ.BackColor = System.Drawing.Color.LightGray;
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
                btnSaveAddJ.Enabled = true;
                this.btnSaveAddJ.BackColor = System.Drawing.Color.DodgerBlue;
            }
        }

        private void AddJob_Load(object sender, EventArgs e)
        {
            cbProjectJobsMethod();
        }

        private void btnSaveAddJ_Click(object sender, EventArgs e)
        {
            dataBaseJobs.openConnection();
            var id = cbProjectJobs.SelectedValue;
            var IdObj = cbOtdelJobs.SelectedValue;
            var IdCustomer = cbSotrudnikJobs.SelectedValue;
            var Condition = tbZadanieJobs.Text;
            var DateOfProduction = dtpStartJobs.Value;
            var PeriodOfExecution = dtpDLineJobs.Value;

            if (dtpDLineJobs.Value.Ticks > dtpStartJobs.Value.Ticks)
            {
                var addQuery = $"insert into Задачи (IDОбъектаСтроительства, IDСотрудника, УсловиеЗадачи, ДатаПостановкиЗадачи, СрокИсполнения) values ('{IdObj}', '{IdCustomer}','{Condition}','{DateOfProduction}','{PeriodOfExecution}')";
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
    }
}
