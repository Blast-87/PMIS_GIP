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
    public partial class UC_Payment : UserControl
    {
        DataBase dataBasePaym = new DataBase();//CD
        int selectedRow;//CD
        public UC_Payment()
        {
            InitializeComponent();
        }

        private void display_datagrid()
        {
            SqlCommand queryDGW = new SqlCommand("select ТЭП.IDКомплектаПроектДок as 'N п/п', ТЭП.IDОбъектаСтроительства as '№ Объекта', ОбъектСтроительства.НаименованиеОбъектаСтроительства as Объект, ТЭП.СтоимостьПИР as 'Стоимость ПИР', ТЭП.СтоимостьПОС AS 'Продолжительность по ПОС', ТЭП.СтоимостьГСЭ as 'СтоимостьГСЭ', ТЭП.СтатусГСЭ as 'Статус ГСЭ' from ТЭП  JOIN ОбъектСтроительства ON ТЭП.IDОбъектаСтроительства = ОбъектСтроительства.IDОбъектаСтроительства ", dataBasePaym.getConnection());

            SqlDataAdapter da2 = new SqlDataAdapter();
            DataTable dt2 = new DataTable();
            da2.SelectCommand = queryDGW;
            dt2.Clear();
            da2.Fill(dt2);
            dgwPayment.DataSource = dt2;
            dgwPayment.Columns[0].FillWeight = 5;
            dgwPayment.Columns[1].FillWeight = 5;
            dgwPayment.Columns[2].FillWeight = 30;
            dgwPayment.Columns[3].FillWeight = 15;
            dgwPayment.Columns[4].FillWeight = 20;
            dgwPayment.Columns[5].FillWeight = 15;
            dgwPayment.Columns[6].FillWeight = 10;
        }

        //private void объектСтроительстваBindingSource_CurrentChanged(object sender, EventArgs e)
        //{

        //}

        private void cbProjectPaymMethod()
        {
            string query1 = $"select * from [dbo].[ОбъектСтроительства]";
            SqlCommand cmd = new SqlCommand(query1, dataBasePaym.getConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dataBasePaym.openConnection();
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbObjects.DisplayMember = "НаименованиеОбъектаСтроительства";
            cbObjects.ValueMember = "IDОбъектаСтроительства";
            cbObjects.DataSource = dt;
        }

        private void UC_Payment_Load(object sender, EventArgs e)
        {
            display_datagrid();
            cbProjectPaymMethod();
        }

        private void cbObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbiObj.Text = (string)(cbObjects.SelectedValue.ToString());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            double TotalArea, RoofArea, FasadesArea, UGrndArea, ImprArea, LenghtNtw, DemolitArea;
            TotalArea = double.Parse(tbTotalArea.Text);
            RoofArea = double.Parse(tbRoofArea.Text); ;
            FasadesArea = double.Parse(tbFasadesArea.Text); ;
            UGrndArea = double.Parse(tbUGrndArea.Text); ;
            ImprArea = double.Parse(tbImprArea.Text); ;
            LenghtNtw = double.Parse(tbLenghtNtw.Text); ;
            DemolitArea = double.Parse(tbDemolitArea.Text); ;


        }
    }
}
