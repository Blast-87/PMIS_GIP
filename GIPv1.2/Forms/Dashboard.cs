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
using GIPv1._2.UserControls;

namespace GIPv1._2
{
    public partial class Form2 : Form
    {
        private readonly CheckUser _user;
        DataBase dataBase = new DataBase(); //от CyberDanger



        int PanelWidth;
        bool isCollapsed;
        public Form2(CheckUser user)
        {
            _user = user;
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            UC_Projects uch = new UC_Projects();
            AddControlsPanel(uch);
        }

        private void IsAdmin()
        {
            btnObjects.Visible = _user.IsAdmin;
            btnDocs.Visible = _user.IsAdmin;

        }

        //private void Form_Dashboard_Load(object sender, EventArgs e)
        //{
        //    lblUserName.Text = Helper.UserData[1];
        //    string RoleName = ds.getSingleValueSingleColum("select Description from tblRoles where id = '" + Helper.UserData[2] + "'", out RoleName, 0);
        //    lblRole.Text = RoleName;
        //}
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 15;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 15;
                if (panelLeft.Width <= 65)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }     

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void moveSidepanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            toolStripStatusLabel1.Text = "Выход";
        }

        private void AddControlsPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        private void btnObjects_Click(object sender, EventArgs e)
        {
            moveSidepanel(btnObjects);
            //btnObjects.BackColor = Color.White;
            //btnObjects.ForeColor = Color.Black;
            UC_Projects uch = new UC_Projects();
            AddControlsPanel(uch);
            toolStripStatusLabel1.Text = "Меню Проекты";
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            moveSidepanel(btnJobs);
            //UC_Jobs uch = new UC_Jobs();
            jobsV4 uch = new jobsV4();
            //UC_Jobs3 uch = new UC_Jobs3();
            AddControlsPanel(uch);
            toolStripStatusLabel1.Text = "Меню Задачи";
        }

        private void btnDocs_Click(object sender, EventArgs e)
        {
            moveSidepanel(btnDocs);
            UC_Documents uch = new UC_Documents();
            AddControlsPanel(uch);
            toolStripStatusLabel1.Text = "Меню Документы";
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            UC_Payment uch = new UC_Payment();
            AddControlsPanel(uch);
            moveSidepanel(btnAnalytics);
            toolStripStatusLabel1.Text = "Меню Аналитика";
        }

        private void btnEmloyees_Click(object sender, EventArgs e)
        {
            moveSidepanel(btnEmployees);
            UC_Employees uch = new UC_Employees();
            AddControlsPanel(uch);
            toolStripStatusLabel1.Text = "Меню Работники";
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            UC_Reports uch = new UC_Reports  ();
            moveSidepanel(btnReports);
            AddControlsPanel(uch);
            toolStripStatusLabel1.Text = "Меню Отчеты";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblUserName.Text = $"{_user.Login}";
            lblRole.Text = $"{_user.Status}";
            IsAdmin();
            btnMaximizedForm.Visible = true;
            btnNormalForm.Visible = false;


            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
                //Button btn = sender as Button;

                //btn.Text = "MouseEnter " + btn.Name;
            
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMaximizedForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizedForm.Visible = false;
            btnNormalForm.Visible = true;
        }

        private void btnMinimizedForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNormalForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnNormalForm.Visible = false;
            btnMaximizedForm.Visible = true;
        }
    }
}
