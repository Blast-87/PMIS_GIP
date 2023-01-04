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
    public partial class AddEmpoyee : Form
    {
        DataBase dataBaseAddEmpl = new DataBase();//CD
        enum RowState
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
            Deleted
        }

        public AddEmpoyee()
        {
            InitializeComponent();
        }

        private void AddEmpoyee_Load(object sender, EventArgs e)
        {
            this.отделTableAdapter.Fill(this._GIPv1_7DataSet.Отдел);//this.сотрудникиTableAdapter.Fill(this._GIPv1_7DataSet.Сотрудники);
        }

        private void btnCloseAddEmpl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAddEmpl_Click(object sender, EventArgs e)
        {
            dataBaseAddEmpl.openConnection();
            var Family = tbFamily.Text;
            var Name = tbName.Text;
            var Patronymic = tbPatronymic.Text;
            var Function = tbFunction.Text;
            var BirthDay = tbBirthDay.Value;
            int TariffRate;
            var Department = cbChoiseDepartment.SelectedValue.ToString();
            var Login = tbLogin.Text;
            var Password = tbPassword.Text;
            var Is_Admin = is_adminCheckBox.Checked.ToString();
                
                if (int.TryParse(tbTariffRate.Text, out TariffRate))
                {
                var addQuery = $"insert into Сотрудники (ФамилияСотрудника, ИмяСотрудника, ОтчествоСотрудника, Должность, ДатаРождения, ТарифнаяСтавка, IDОтдела, Login, Password, is_admin) values ('{Family}', '{Name}','{Patronymic}','{Function}','{BirthDay}','{TariffRate}','{Department}','{Login}','{Password}','{Is_Admin}')";
                var command = new SqlCommand(addQuery, dataBaseAddEmpl.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Новые данные сохранены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                }
                else
                {
                MessageBox.Show("Проверьте корректность введенных данных в графу 'Тарифная ставка'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
            dataBaseAddEmpl.closeConnection();
        }
    }
}
//DataBase dataBaseAddp = new DataBase();//CD
//public AddProject()
//{
//    InitializeComponent();
//}

//private void btnSaveAddPr_Click(object sender, EventArgs e)//CD
//{
//    dataBaseAddp.openConnection();

//    var Name = наименованиеОбъектаСтроительстваTextBox.Text;
//    var DateRef = датаРегистрацииЗаявленияDateTimePicker.Value;
//    var DateInsp = датаИнспирацииDateTimePicker.Value;
//    var Customer = наименованиеЗаказчикаTextBox.Text;
//    var Funds = источникСредствComboBox.Text;

//    if (датаИнспирацииDateTimePicker.Value.Ticks > датаРегистрацииЗаявленияDateTimePicker.Value.Ticks)
//    {
//        var addQuery = $"insert into ОбъектСтроительства (НаименованиеОбъектаСтроительства, ДатаРегистрацииЗаявления, ДатаИнспирации, НаименованиеЗаказчика, ИсточникСредств) values ('{Name}', '{DateRef}', '{DateInsp}', '{Customer}', '{Funds}')";
//        var command = new SqlCommand(addQuery, dataBaseAddp.getConnection());
//        command.ExecuteNonQuery();

//        MessageBox.Show("Новые данные сохранены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
//    }
//    else
//    {
//        MessageBox.Show("Проверьте введенные даты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    }
//    dataBaseAddp.closeConnection();
//}