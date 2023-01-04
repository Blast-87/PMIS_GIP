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

namespace GIPv1._2.Forms
{
    public partial class AddJobs : Form
    {
        DataBase dataBase = new DataBase();//CD

        List<Sotrudnik> sotrudniks = new List<Sotrudnik>();
        List<Otdel> otdels = new List<Otdel>();
        public AddJobs()
        {
            InitializeComponent();
        }

        private void btnCloseAddJ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddJobs_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "_GIPv1_7DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter1.Fill(this._GIPv1_7DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_GIPv1_7DataSet.Отдел". При необходимости она может быть перемещена или удалена.
            this.отделTableAdapter1.Fill(this._GIPv1_7DataSet.Отдел);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_GIPv1_7DataSet.ОбъектСтроительства". При необходимости она может быть перемещена или удалена.
            this.объектСтроительстваTableAdapter1.Fill(this._GIPv1_7DataSet.ОбъектСтроительства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_GIPv1_5DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.

            string searchString = $"select * from Отдел";//каскадное обновление combobox
            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
            dataBase.openConnection();
                SqlDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    cbOtdel.Items.Add(read["НазваниеОтдела"]);
                otdels.Add(new Otdel() {
                    id = ((int)read["IDОтдела"]),
                    NameOtdel = read["НазваниеОтдела"] as string,
                });

                }
                read.Close();

                string searchString1 = $"select * from Сотрудники";
                SqlCommand com1 = new SqlCommand(searchString1, dataBase.getConnection());
                dataBase.openConnection();
                SqlDataReader read1 = com1.ExecuteReader();
                while (read1.Read())
                {
                sotrudniks.Add(new Sotrudnik()
                {
                    id = ((int)read1["IDСотрудника"]),
                    Family = read1["ФамилияСотрудника"] as string,
                    id_otdel = ((int)read1["IDОтдела"])
                });

                }
                read1.Close();

        }
        private string [] GetSotrudnikById(int id)//каскадное обновление combobox
        {
            return sotrudniks.Where(line => line.id_otdel == id).Select(l => l.Family).ToArray();
        }
            
            [Serializable]
        class Otdel
        {
            public int id { get; set; } 
            public string NameOtdel { get; set; }
        }
        [Serializable]
        class Sotrudnik
        {
            public int id { get; set; }
            public string Family { get; set; }
            public int id_otdel { get; set; }
        }

        private void btnSaveAddJ_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            //comboBox1.SelectedValue = int.Parse(textBox1.Text)


            //textBox1.Text = cbProject.SelectedValue.ToString();
            //textBox2.Text = cbSotrudnik.SelectedValue.ToString();

            //var IdObject = textBox1.Text;
            //var IdCustomers = textBox2.Text;


            var IdObj = cbProject.SelectedValue.ToString() ;
            var IdCustomer = cbSotrudnik.SelectedValue.ToString();
            var Condition = tbZadanie.Text;
            var DateOfProduction = dtpStart.Value;
            var PeriodOfExecution = dtpDLine.Value;
            



            //var id = tbIDZadachi.Text;
            //var IdObj = tbiDОбъектаСтроительства.Text;
            //var IdCustomer = tbIDСотрудника.Text;
            //var Condition = tbZadanieJobs.Text;
            //var DateOfProduction = dtpStartJobs.Value;
            //var DateOfDiy = dtpFinishJobs.Value;
            //var PeriodOfExecution = dtpDLineJobs.Value;
            //var Status = cbStatus.Text;

            if (dtpDLine.Value.Ticks > dtpStart.Value.Ticks)
            {
                var addQuery = $"insert into Задачи (IDОбъектаСтроительства, IDСотрудника, УсловиеЗадачи, ДатаПостановкиЗадачи, СрокИсполнения) values ('{IdObj}', '{IdCustomer}','{Condition}','{DateOfProduction}','{PeriodOfExecution}')";
                //var command = new SqlCommand(addQuery, dataBase.getConnection());
                //var addQuery = $"update Задачи set IDОбъектаСтроительства = '{IdObj}', IDСотрудника = '{IdCustomer}', УсловиеЗадачи = '{Condition}', ДатаПостановкиЗадачи = '{DateOfProduction}', ДатаИсполнения = '{DateOfDiy}', СрокИсполнения = '{PeriodOfExecution}', СтатусЗадачи = '{Status}' where IDЗадачи ='{id}'";
                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Новые данные сохранены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Проверьте введенные даты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataBase.closeConnection();
        }

        private void cbOtdel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSotrudnik.Items.Clear();
            int id = otdels[cbOtdel.SelectedIndex].id;
            foreach (string name in GetSotrudnikById(id))
            {
                this.cbSotrudnik.Items.Add(name);
            }
        }





        // string Strsql = "SELECT Table1.*,Table2.*,Table3.* FROM  Table1 WHERE ( Familiya +  LIKE "'"+ textBox.Text + "%')";
        //if (dtpStart.Value.Ticks > dtpFinish.Value.Ticks)
        //{

        //string searchString = $"select * from ОбъектСтроительства where ИсточникСредств like '%{cbSearch.SelectedValue.ToString()}%'";
        //string searchString = $"select * from ОбъектСтроительства where ИсточникСредств = '" + cbSearch.SelectedValue.ToString() + "'";










        //            if (датаИнспирацииDateTimePicker.Value.Ticks > датаРегистрацииЗаявленияDateTimePicker.Value.Ticks)
        //            {
        //                var addQuery = $"insert into ОбъектСтроительства (НаименованиеОбъектаСтроительства, ДатаРегистрацииЗаявления, ДатаИнспирации, НаименованиеЗаказчика, ИсточникСредств) values ('{Name}', '{DateRef}', '{DateInsp}', '{Customer}', '{Funds}')";
        //                var command = new SqlCommand(addQuery, dataBaseAddp.getConnection());
        //                command.ExecuteNonQuery();

        //                MessageBox.Show("Новые данные сохранены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Проверьте введенные даты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //            dataBaseAddp.closeConnection();


        //            --Выдача кол - во рабочих по отделу + (count)
        //  CREATE PROCEDURE[dbo].[Выдача кол - во рабочих по отделу + (count)]

        //    @otdel int
        //AS  BEGIN
        //    SELECT DISTINCT dbo.Сотрудники.ФИОСотрудника, COUNT(dbo.Сотрудники.ФИОСотрудника) AS 'Кол-во рабочих в отделах' /*считаем количество сотрудников функцией count*/

        //    FROM dbo.Сотрудники
        //    WHERE   dbo.Сотрудники.[IDОтдела] = @otdel  /*находим записи, где Номер отдела равен введенному параметру @otdel  */

        //    GROUP BY dbo.Сотрудники.ФИОСотрудника /*группируем сотрудников по полю Должность  */
        //END


    }


    //private void cbOtdel_SelectedIndexChanged(object sender, EventArgs e)//каскадное обновление combobox
    //    //{

    //    //    cbSotrudnik.Items.Clear();
    //    //    int id = otdels[cbOtdel.SelectedIndex].id;
    //    //    foreach (string name in GetSotrudnikById(id))
    //    //    {
    //    //        this.cbSotrudnik.Items.Add(name);
    //    //    }
    //    //}
    }


//39:00 выборка из таблиц БД