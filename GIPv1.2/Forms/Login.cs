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
using System.Diagnostics;
//using md5_sql_hash.Connect;

namespace GIPv1._2
{
    public partial class Form1 : Form
    {
        DataBase database = new DataBase();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowPass.Visible = true;
            pnlLinksHide.Visible = true;
            lnkLabelToLinks.Visible = true;
            //txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 20;
            txtUserName.MaxLength = 20;
            this.WindowState = FormWindowState.Normal;
        }
  
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginUser = txtUserName.Text;
            var passUser = txtPassword.Text;
            //var passUser = md5.hashPassword(txtPassword.Text);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select IDСотрудника, Login, Password, is_admin from Сотрудники where Login='{loginUser}' and Password='{passUser}'";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                var user = new CheckUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[3]));
                MessageBox.Show("Добро пожаловать!", "Вход выполнен!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 frm2 = new Form2(user);
                this.Hide();
                frm2.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Уточните данные у администратора.", "Аккаунт не идентифицирован в БД.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
       
        }

        private void HidePass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            ShowPass.Visible = true;
            HidePass.Visible = false;
        }
        private void ShowPass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            ShowPass.Visible = false;
            HidePass.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void lLabelURLUKS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://uks.mogilev.biz");
        }


        private void lnkLabelToLinks_Click(object sender, EventArgs e)
        {
            lnkLabelHideLinks.Visible = true;
            lnkLabelToLinks.Visible = false;
            pnlLinksShow.Visible = true;
            pnlLinksHide.Visible = false;
        }

        private void lnkLabelHideLinks_Click(object sender, EventArgs e)
        {
            lnkLabelHideLinks.Visible = false;
            lnkLabelToLinks.Visible = true;
            pnlLinksShow.Visible = false;
            pnlLinksHide.Visible = true;
        }

        private void btnViber_Click(object sender, EventArgs e)
        {
            Process.Start("viber://chat?number=%2B375295485974");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discordapp.com/users/PavelShestakov#3948/");
        }

        private void btnTelegramLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/Pavel_Shestakou");
        }

        private void btnGitHubKink_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Blast-87");
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //

        //private void HidePass_Click(object sender, EventArgs e)
        //{
        //    txtPassword.UseSystemPasswordChar = true;
        //    ShowPass.Visible = true;
        //    HidePass.Visible = false;
        //}



        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    if (isFormValid())
        //    {
        //        if (checkLogin())
        //        { 

        //        }
        //    }
        //}

        //private bool checkLogin()
        //{


        //    string username = dataBase.getSingleValue ("select UserName from dbo.Сотрудники where UserName='" + txtUserName.Text + " and Password='" + txtPassword.Text + "''", out username, 0);
        //if (username==null)
        //    {
        //        MessageBox.Show("Неверное имя пользователя или пароль", "Неправильные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //else
        //    {
        //        return true;
        //    }
        //}

        //private bool isFormValid()
        //{
        //    if (txtUserName.Text.ToString().Trim() == string.Empty || txtPassword.Text.ToString().Trim() == string.Empty)
        //    {
        //        MessageBox.Show("Поля ввода не могут быть пустыми", "Пожалуйста, заполните поля ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //    else 
        //    {
        //        return true;
        //    }
        //}
    }
}
