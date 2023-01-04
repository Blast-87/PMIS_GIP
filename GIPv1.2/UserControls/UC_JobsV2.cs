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
    public partial class UC_JobsV2 : UserControl
    {
        DataBase dataBaseJobs2 = new DataBase();
        public UC_JobsV2()
        {
            InitializeComponent();

        }

        private void UC_JobsV2_Load(object sender, EventArgs e)
        {
            //SqlConnection sqlconn = new SqlConnection();
            string sqlquery = "select * from [dbo].[ОбъектСтроительства]";
            SqlCommand qslcomm = new SqlCommand(sqlquery, dataBaseJobs2.getConnection());
            dataBaseJobs2.openConnection();
            SqlDataAdapter sda = new SqlDataAdapter(qslcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cbObjektlJobs2.ValueMember = "[IDОбъектаСтроительства]";
            cbObjektlJobs2.DisplayMember = "[НаименованиеОбъектаСтроительства]";
            cbObjektlJobs2.DataSource = dt;
            cbOtdelJobs2.Enabled = false;
            cbSotrudJobs2.Enabled = false;
        }
    }
}
