
namespace GIPv1._2.Forms
{
    partial class AddJob
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.отделBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._GIPv1_7DataSet = new GIPv1._2._GIPv1_7DataSet();
            this.объектСтроительстваTableAdapter = new GIPv1._2._GIPv1_5DataSetTableAdapters.ОбъектСтроительстваTableAdapter();
            this.отделTableAdapter = new GIPv1._2._GIPv1_5DataSetTableAdapters.ОтделTableAdapter();
            this.сотрудникиTableAdapter = new GIPv1._2._GIPv1_5DataSetTableAdapters.СотрудникиTableAdapter();
            this.объектСтроительстваTableAdapter1 = new GIPv1._2._GIPv1_7DataSetTableAdapters.ОбъектСтроительстваTableAdapter();
            this.отделBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._GIPv1_5DataSet = new GIPv1._2._GIPv1_5DataSet();
            this.btnCloseAddJ = new System.Windows.Forms.Button();
            this.btnSaveAddJ = new System.Windows.Forms.Button();
            this.dtpDLineJobs = new System.Windows.Forms.DateTimePicker();
            this.cbSotrudnikJobs = new System.Windows.Forms.ComboBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отделTableAdapter1 = new GIPv1._2._GIPv1_7DataSetTableAdapters.ОтделTableAdapter();
            this.сотрудникиTableAdapter1 = new GIPv1._2._GIPv1_7DataSetTableAdapters.СотрудникиTableAdapter();
            this.dtpStartJobs = new System.Windows.Forms.DateTimePicker();
            this.tbZadanieJobs = new System.Windows.Forms.TextBox();
            this.cbProjectJobs = new System.Windows.Forms.ComboBox();
            this.объектСтроительстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.объектСтроительстваBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gIPv17DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbOtdelJobs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.сотрудникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIPv17DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // отделBindingSource1
            // 
            this.отделBindingSource1.DataMember = "Отдел";
            this.отделBindingSource1.DataSource = this._GIPv1_7DataSet;
            // 
            // _GIPv1_7DataSet
            // 
            this._GIPv1_7DataSet.DataSetName = "_GIPv1_7DataSet";
            this._GIPv1_7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // объектСтроительстваTableAdapter
            // 
            this.объектСтроительстваTableAdapter.ClearBeforeFill = true;
            // 
            // отделTableAdapter
            // 
            this.отделTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // объектСтроительстваTableAdapter1
            // 
            this.объектСтроительстваTableAdapter1.ClearBeforeFill = true;
            // 
            // отделBindingSource
            // 
            this.отделBindingSource.DataMember = "Отдел";
            this.отделBindingSource.DataSource = this._GIPv1_5DataSet;
            // 
            // _GIPv1_5DataSet
            // 
            this._GIPv1_5DataSet.DataSetName = "_GIPv1_5DataSet";
            this._GIPv1_5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCloseAddJ
            // 
            this.btnCloseAddJ.BackColor = System.Drawing.Color.IndianRed;
            this.btnCloseAddJ.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseAddJ.FlatAppearance.BorderSize = 0;
            this.btnCloseAddJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAddJ.Location = new System.Drawing.Point(900, 358);
            this.btnCloseAddJ.Name = "btnCloseAddJ";
            this.btnCloseAddJ.Size = new System.Drawing.Size(115, 41);
            this.btnCloseAddJ.TabIndex = 66;
            this.btnCloseAddJ.Text = "Закрыть";
            this.btnCloseAddJ.UseVisualStyleBackColor = false;
            // 
            // btnSaveAddJ
            // 
            this.btnSaveAddJ.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveAddJ.FlatAppearance.BorderSize = 0;
            this.btnSaveAddJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAddJ.Location = new System.Drawing.Point(607, 358);
            this.btnSaveAddJ.Name = "btnSaveAddJ";
            this.btnSaveAddJ.Size = new System.Drawing.Size(115, 41);
            this.btnSaveAddJ.TabIndex = 67;
            this.btnSaveAddJ.Text = "Сохранить";
            this.btnSaveAddJ.UseVisualStyleBackColor = false;
            this.btnSaveAddJ.Click += new System.EventHandler(this.btnSaveAddJ_Click);
            // 
            // dtpDLineJobs
            // 
            this.dtpDLineJobs.Location = new System.Drawing.Point(234, 292);
            this.dtpDLineJobs.Name = "dtpDLineJobs";
            this.dtpDLineJobs.Size = new System.Drawing.Size(200, 27);
            this.dtpDLineJobs.TabIndex = 65;
            // 
            // cbSotrudnikJobs
            // 
            this.cbSotrudnikJobs.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.сотрудникиBindingSource, "ФамилияСотрудника", true));
            this.cbSotrudnikJobs.FormattingEnabled = true;
            this.cbSotrudnikJobs.Location = new System.Drawing.Point(152, 160);
            this.cbSotrudnikJobs.Name = "cbSotrudnikJobs";
            this.cbSotrudnikJobs.Size = new System.Drawing.Size(282, 27);
            this.cbSotrudnikJobs.TabIndex = 61;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this._GIPv1_5DataSet;
            // 
            // отделTableAdapter1
            // 
            this.отделTableAdapter1.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter1
            // 
            this.сотрудникиTableAdapter1.ClearBeforeFill = true;
            // 
            // dtpStartJobs
            // 
            this.dtpStartJobs.Location = new System.Drawing.Point(234, 228);
            this.dtpStartJobs.Name = "dtpStartJobs";
            this.dtpStartJobs.Size = new System.Drawing.Size(200, 27);
            this.dtpStartJobs.TabIndex = 64;
            // 
            // tbZadanieJobs
            // 
            this.tbZadanieJobs.Location = new System.Drawing.Point(607, 72);
            this.tbZadanieJobs.Multiline = true;
            this.tbZadanieJobs.Name = "tbZadanieJobs";
            this.tbZadanieJobs.Size = new System.Drawing.Size(408, 247);
            this.tbZadanieJobs.TabIndex = 63;
            // 
            // cbProjectJobs
            // 
            this.cbProjectJobs.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.объектСтроительстваBindingSource, "НаименованиеОбъектаСтроительства", true));
            this.cbProjectJobs.DataSource = this.объектСтроительстваBindingSource1;
            this.cbProjectJobs.DisplayMember = "НаименованиеОбъектаСтроительства";
            this.cbProjectJobs.FormattingEnabled = true;
            this.cbProjectJobs.Location = new System.Drawing.Point(152, 76);
            this.cbProjectJobs.Name = "cbProjectJobs";
            this.cbProjectJobs.Size = new System.Drawing.Size(282, 27);
            this.cbProjectJobs.TabIndex = 62;
            this.cbProjectJobs.ValueMember = "IDОбъектаСтроительства";
            this.cbProjectJobs.SelectedIndexChanged += new System.EventHandler(this.cbProjectJobs_SelectedIndexChanged);
            // 
            // объектСтроительстваBindingSource
            // 
            this.объектСтроительстваBindingSource.DataMember = "ОбъектСтроительства";
            this.объектСтроительстваBindingSource.DataSource = this._GIPv1_5DataSet;
            // 
            // объектСтроительстваBindingSource1
            // 
            this.объектСтроительстваBindingSource1.DataMember = "ОбъектСтроительства";
            this.объектСтроительстваBindingSource1.DataSource = this.gIPv17DataSetBindingSource;
            // 
            // gIPv17DataSetBindingSource
            // 
            this.gIPv17DataSetBindingSource.DataSource = this._GIPv1_7DataSet;
            this.gIPv17DataSetBindingSource.Position = 0;
            // 
            // cbOtdelJobs
            // 
            this.cbOtdelJobs.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.отделBindingSource, "НазваниеОтдела", true));
            this.cbOtdelJobs.FormattingEnabled = true;
            this.cbOtdelJobs.Location = new System.Drawing.Point(152, 118);
            this.cbOtdelJobs.Name = "cbOtdelJobs";
            this.cbOtdelJobs.Size = new System.Drawing.Size(282, 27);
            this.cbOtdelJobs.TabIndex = 60;
            this.cbOtdelJobs.SelectedIndexChanged += new System.EventHandler(this.cbOtdelJobs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 59;
            this.label1.Text = "Отдел";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 19);
            this.label6.TabIndex = 58;
            this.label6.Text = "Срок исполнения, до:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 57;
            this.label9.Text = "задачи:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 56;
            this.label5.Text = "Дата постановки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 55;
            this.label4.Text = "Исполнитель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(402, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 25);
            this.label7.TabIndex = 54;
            this.label7.Text = "Постановка задачи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Условие задачи - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Проект";
            // 
            // сотрудникиBindingSource1
            // 
            this.сотрудникиBindingSource1.DataMember = "Сотрудники";
            this.сотрудникиBindingSource1.DataSource = this._GIPv1_7DataSet;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 430);
            this.panel2.TabIndex = 49;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Location = new System.Drawing.Point(1041, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 430);
            this.panel4.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 440);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1051, 10);
            this.panel3.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 10);
            this.panel1.TabIndex = 48;
            // 
            // AddJob
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.btnCloseAddJ);
            this.Controls.Add(this.btnSaveAddJ);
            this.Controls.Add(this.dtpDLineJobs);
            this.Controls.Add(this.cbSotrudnikJobs);
            this.Controls.Add(this.dtpStartJobs);
            this.Controls.Add(this.tbZadanieJobs);
            this.Controls.Add(this.cbProjectJobs);
            this.Controls.Add(this.cbOtdelJobs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddJob";
            this.Load += new System.EventHandler(this.AddJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIPv17DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource отделBindingSource1;
        private _GIPv1_7DataSet _GIPv1_7DataSet;
        private _GIPv1_5DataSetTableAdapters.ОбъектСтроительстваTableAdapter объектСтроительстваTableAdapter;
        private _GIPv1_5DataSetTableAdapters.ОтделTableAdapter отделTableAdapter;
        private _GIPv1_5DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private _GIPv1_7DataSetTableAdapters.ОбъектСтроительстваTableAdapter объектСтроительстваTableAdapter1;
        private System.Windows.Forms.BindingSource отделBindingSource;
        private _GIPv1_5DataSet _GIPv1_5DataSet;
        private System.Windows.Forms.Button btnCloseAddJ;
        private System.Windows.Forms.Button btnSaveAddJ;
        private System.Windows.Forms.DateTimePicker dtpDLineJobs;
        private System.Windows.Forms.ComboBox cbSotrudnikJobs;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private _GIPv1_7DataSetTableAdapters.ОтделTableAdapter отделTableAdapter1;
        private _GIPv1_7DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter1;
        private System.Windows.Forms.DateTimePicker dtpStartJobs;
        private System.Windows.Forms.TextBox tbZadanieJobs;
        private System.Windows.Forms.ComboBox cbProjectJobs;
        private System.Windows.Forms.BindingSource объектСтроительстваBindingSource;
        private System.Windows.Forms.BindingSource объектСтроительстваBindingSource1;
        private System.Windows.Forms.BindingSource gIPv17DataSetBindingSource;
        private System.Windows.Forms.ComboBox cbOtdelJobs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}