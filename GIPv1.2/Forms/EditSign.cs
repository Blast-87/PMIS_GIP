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
    
    public partial class EditSign : Form
    {
        int selectedRow;
        DataBase dataBaseSign = new DataBase();//CD
        public EditSign()
        {
            InitializeComponent();
        }

        private void btnCloseAddJ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAddJ_Click(object sender, EventArgs e)
        {
            savedata();
            display_datagrid();
        }

        private void savedata()
        {
            dataBaseSign.openConnection();
            var Title = tbTitle.Text;
            var Family = tbFamily.Text;

            if (tbTitle.Text != String.Empty || tbFamily.Text != String.Empty)
            {
                var addQuery = $"insert into Подписант (ФИО, Должность) values ('{Family}', '{Title}')";
                var command = new SqlCommand(addQuery, dataBaseSign.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Новые данные сохранены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Заполните строки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataBaseSign.closeConnection();
        }

        private void display_datagrid()
        {
            SqlCommand queryDoc = new SqlCommand("Select IDПодписанта as '№ п/п', ФИО as Фамилия, Должность as Должность FROM Подписант ", dataBaseSign.getConnection());
            SqlDataAdapter da2 = new SqlDataAdapter();
            DataTable dt2 = new DataTable();
            da2.SelectCommand = queryDoc;
            dt2.Clear();
            da2.Fill(dt2);
            dgwSign.DataSource = dt2;
        }

        private void deleteRow()//CD
        {
            dataBaseSign.openConnection();


            var id = tbID.Text;
            var Title = tbTitle.Text;
            var Family = tbFamily.Text;
            if (tbID.Text != "")
            {
                    var addQuery = $"delete FROM Подписант where IDПодписанта ='{id}'";
                    var command = new SqlCommand(addQuery, dataBaseSign.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Строка удалена", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            else
            {
                MessageBox.Show("Выберите строку для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //}
            dataBaseSign.closeConnection();
        }
        private void EditSign_Load(object sender, EventArgs e)
        {
            display_datagrid();
            tbID.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            deleteRow();
            display_datagrid();
        }

        private void dgwSign_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgwSign.Rows[selectedRow];
                tbID.Text = row.Cells[0].Value.ToString();
                tbTitle.Text = row.Cells[1].Value.ToString();
                tbFamily.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
