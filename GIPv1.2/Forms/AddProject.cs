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
    public partial class AddProject : Form
    {
        DataBase dataBaseAddp = new DataBase();//CD
        public AddProject()
        {
            InitializeComponent();
        }

        private void btnSaveAddPr_Click(object sender, EventArgs e)//CD
        {
            dataBaseAddp.openConnection();

            var Name = наименованиеОбъектаСтроительстваTextBox.Text;
            var DateRef = датаРегистрацииЗаявленияDateTimePicker.Value;
            var DateInsp = датаИнспирацииDateTimePicker.Value;
            var Customer = наименованиеЗаказчикаTextBox.Text;
            var Funds = источникСредствComboBox.Text;

                if (датаИнспирацииDateTimePicker.Value.Ticks > датаРегистрацииЗаявленияDateTimePicker.Value.Ticks)
                {
                var addQuery = $"insert into ОбъектСтроительства (НаименованиеОбъектаСтроительства, ДатаРегистрацииЗаявления, ДатаИнспирации, НаименованиеЗаказчика, ИсточникСредств) values ('{Name}', '{DateRef}', '{DateInsp}', '{Customer}', '{Funds}')";
                var command = new SqlCommand(addQuery, dataBaseAddp.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Новые данные сохранены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                MessageBox.Show("Проверьте введенные даты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataBaseAddp.closeConnection();
        }
    }
}
