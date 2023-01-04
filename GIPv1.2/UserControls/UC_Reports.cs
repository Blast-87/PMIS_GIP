using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace GIPv1._2.UserControls
{
   
    public partial class UC_Reports : UserControl
    {
        DataBase dataBase = new DataBase();//CD
       
        public UC_Reports()
        {
            InitializeComponent();
        }

        private void CreateColumns()//CD: Создаем колонки в ДГВ
        {
            dgwReports.Columns.Add("[IDОбъектаСтроительства]", "№ п/п");
            dgwReports.Columns.Add("[НаименованиеОбъектаСтроительства]", "Наименование объекта");
            dgwReports.Columns.Add("[ДатаРегистрацииЗаявления]", "Дата регистрации");
            dgwReports.Columns.Add("[ДатаИнспирации]", "Дата инспирации");
            dgwReports.Columns.Add("[НаименованиеЗаказчика]", "Наименование заказчика");
            dgwReports.Columns.Add("[ИсточникСредств]", "Источник средств");
            dgwReports.Columns.Add("[СтоимостьПИР]", "Стоимость ПИР, руб");
            dgwReports.Columns.Add("[СтоимостьПОС]", "Стоимость ПОС, руб");
            dgwReports.Columns.Add("[СтоимостьГСЭ]", "Стоимость ГСЭ, руб");
            dgwReports.Columns[0].FillWeight = 5;
            dgwReports.Columns[1].FillWeight = 28;
            dgwReports.Columns[2].FillWeight = 9;
            dgwReports.Columns[3].FillWeight = 9;
            dgwReports.Columns[4].FillWeight = 15;
            dgwReports.Columns[5].FillWeight = 10;
            dgwReports.Columns[6].FillWeight = 8;
            dgwReports.Columns[7].FillWeight = 8;
            dgwReports.Columns[8].FillWeight = 8;
            //dataGridViewRep.AutoResizeColumnHeadersHeight();
        }

        private void UC_Reports_Load(object sender, EventArgs e)
        {
            this.объектСтроительстваTableAdapter.FillBy(this._GIPv1_7DataSet.ОбъектСтроительства);
            CreateColumns();
        }

        private void cbObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("Select *  from [dbo].[ОбъектСтроительства]");
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            dgwReports.Rows.Add(iDОбъектаСтроительстваTextBox1.Text, наименованиеОбъектаСтроительстваTextBox1.Text, датаРегистрацииЗаявленияDateTimePicker1.Value, датаИнспирацииDateTimePicker.Value, наименованиеЗаказчикаTextBox.Text, источникСредствTextBox.Text, стоимостьПИРTextBox.Text, стоимостьПОСTextBox.Text, стоимостьГСЭTextBox.Text);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Информация по проектируемым объектам строительства";
            printer.SubTitle = string.Format("Информация на " + "дату:{0}", DateTime.Now, printer.SubTitleColor = Color.Silver, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;
            printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.Porportional;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Проектный отдел";
            printer.FooterSpacing = 15;
            printer.PageSettings.Margins = new System.Drawing.Printing.Margins(5, 5, 5, 5);
           
            printer.PrintPreviewDataGridView(dgwReports);
        }

        private void ClearFields()
        {
            iDОбъектаСтроительстваTextBox1.Text = " ";
            наименованиеОбъектаСтроительстваTextBox1.Text = " ";
            датаРегистрацииЗаявленияDateTimePicker1.Value = DateTime.Now;
            датаИнспирацииDateTimePicker.Value = DateTime.Now;
            наименованиеЗаказчикаTextBox.Text = " ";
            источникСредствTextBox.Text = " ";
            стоимостьПИРTextBox.Text = " ";
            стоимостьПОСTextBox.Text = " ";
            стоимостьГСЭTextBox.Text = " ";
        }
        private void btnClearRow_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        
    }
}
