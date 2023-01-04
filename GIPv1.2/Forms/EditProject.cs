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
    public partial class EditProject : Form
    {
        DataBase dataBaseAddp = new DataBase();//CD
        public EditProject()
        {
            InitializeComponent();
        }

        private void btnSaveEditF_Click(object sender, EventArgs e)
        {
            dataBaseAddp.openConnection();

            var Name = наименованиеОбъектаСтроительстваTextBox.Text;
            var DateRef = датаРегистрацииЗаявленияDateTimePicker.Value;
            var DateInsp = датаИнспирацииDateTimePicker.Value;
            var Customer = наименованиеЗаказчикаTextBox.Text;
            var Funds = источникСредствComboBox.Text;

            if (датаИнспирацииDateTimePicker.Value.Ticks > датаРегистрацииЗаявленияDateTimePicker.Value.Ticks)
            {
                var addQuery = $"update ОбъектСтроительства set (НаименованиеОбъектаСтроительства, ДатаРегистрацииЗаявления, ДатаИнспирации, НаименованиеЗаказчика, ИсточникСредств) values ('{Name}', '{DateRef}', '{DateInsp}', '{Customer}', '{Funds}')";
                var command = new SqlCommand(addQuery, dataBaseAddp.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Данные изменены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Проверьте введенные даты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataBaseAddp.closeConnection();
        }

        private void EditProject_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_GIPv1_5DataSet.Отдел". При необходимости она может быть перемещена или удалена.
            this.отделTableAdapter.Fill(this._GIPv1_5DataSet.Отдел);

        }
    }
}
