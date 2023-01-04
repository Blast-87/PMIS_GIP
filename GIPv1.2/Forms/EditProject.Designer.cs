
namespace GIPv1._2.Forms
{
    partial class EditProject
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
            System.Windows.Forms.Label lblNameForm;
            System.Windows.Forms.Label источникСредствLabel;
            System.Windows.Forms.Label наименованиеОбъектаСтроительстваLabel;
            System.Windows.Forms.Label датаРегистрацииЗаявленияLabel;
            System.Windows.Forms.Label датаИнспирацииLabel;
            System.Windows.Forms.Label наименованиеЗаказчикаLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableAdapterManager = new GIPv1._2._GIPv1_5DataSetTableAdapters.TableAdapterManager();
            this.объектСтроительстваTableAdapter = new GIPv1._2._GIPv1_5DataSetTableAdapters.ОбъектСтроительстваTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.объектСтроительстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._GIPv1_5DataSet = new GIPv1._2._GIPv1_5DataSet();
            this.btnSaveEditF = new System.Windows.Forms.Button();
            this.btnCloseEditF = new System.Windows.Forms.Button();
            this.источникСредствComboBox = new System.Windows.Forms.ComboBox();
            this.наименованиеОбъектаСтроительстваTextBox = new System.Windows.Forms.TextBox();
            this.датаРегистрацииЗаявленияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.датаИнспирацииDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.наименованиеЗаказчикаTextBox = new System.Windows.Forms.TextBox();
            this.отделBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отделTableAdapter = new GIPv1._2._GIPv1_5DataSetTableAdapters.ОтделTableAdapter();
            lblNameForm = new System.Windows.Forms.Label();
            источникСредствLabel = new System.Windows.Forms.Label();
            наименованиеОбъектаСтроительстваLabel = new System.Windows.Forms.Label();
            датаРегистрацииЗаявленияLabel = new System.Windows.Forms.Label();
            датаИнспирацииLabel = new System.Windows.Forms.Label();
            наименованиеЗаказчикаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameForm
            // 
            lblNameForm.AutoSize = true;
            lblNameForm.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblNameForm.Location = new System.Drawing.Point(280, 40);
            lblNameForm.Name = "lblNameForm";
            lblNameForm.Size = new System.Drawing.Size(213, 25);
            lblNameForm.TabIndex = 23;
            lblNameForm.Text = "Редактировать проект";
            // 
            // источникСредствLabel
            // 
            источникСредствLabel.AutoSize = true;
            источникСредствLabel.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            источникСредствLabel.Location = new System.Drawing.Point(65, 300);
            источникСредствLabel.Name = "источникСредствLabel";
            источникСредствLabel.Size = new System.Drawing.Size(137, 19);
            источникСредствLabel.TabIndex = 44;
            источникСредствLabel.Text = "Источник Средств:";
            // 
            // наименованиеОбъектаСтроительстваLabel
            // 
            наименованиеОбъектаСтроительстваLabel.AutoSize = true;
            наименованиеОбъектаСтроительстваLabel.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            наименованиеОбъектаСтроительстваLabel.Location = new System.Drawing.Point(65, 100);
            наименованиеОбъектаСтроительстваLabel.Name = "наименованиеОбъектаСтроительстваLabel";
            наименованиеОбъектаСтроительстваLabel.Size = new System.Drawing.Size(279, 19);
            наименованиеОбъектаСтроительстваLabel.TabIndex = 40;
            наименованиеОбъектаСтроительстваLabel.Text = "Наименование Объекта Строительства:";
            // 
            // датаРегистрацииЗаявленияLabel
            // 
            датаРегистрацииЗаявленияLabel.AutoSize = true;
            датаРегистрацииЗаявленияLabel.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаРегистрацииЗаявленияLabel.Location = new System.Drawing.Point(65, 180);
            датаРегистрацииЗаявленияLabel.Name = "датаРегистрацииЗаявленияLabel";
            датаРегистрацииЗаявленияLabel.Size = new System.Drawing.Size(212, 19);
            датаРегистрацииЗаявленияLabel.TabIndex = 41;
            датаРегистрацииЗаявленияLabel.Text = "Дата Регистрации Заявления:";
            // 
            // датаИнспирацииLabel
            // 
            датаИнспирацииLabel.AutoSize = true;
            датаИнспирацииLabel.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаИнспирацииLabel.Location = new System.Drawing.Point(65, 220);
            датаИнспирацииLabel.Name = "датаИнспирацииLabel";
            датаИнспирацииLabel.Size = new System.Drawing.Size(132, 19);
            датаИнспирацииLabel.TabIndex = 42;
            датаИнспирацииLabel.Text = "Дата Инспирации:";
            // 
            // наименованиеЗаказчикаLabel
            // 
            наименованиеЗаказчикаLabel.AutoSize = true;
            наименованиеЗаказчикаLabel.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            наименованиеЗаказчикаLabel.Location = new System.Drawing.Point(65, 260);
            наименованиеЗаказчикаLabel.Name = "наименованиеЗаказчикаLabel";
            наименованиеЗаказчикаLabel.Size = new System.Drawing.Size(188, 19);
            наименованиеЗаказчикаLabel.TabIndex = 43;
            наименованиеЗаказчикаLabel.Text = "Наименование Заказчика:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 430);
            this.panel2.TabIndex = 37;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Location = new System.Drawing.Point(790, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 430);
            this.panel4.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 10);
            this.panel1.TabIndex = 36;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = GIPv1._2._GIPv1_5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.НормативноПравоваяДокументацияTableAdapter = null;
            this.tableAdapterManager.ОбъектСтроительстваTableAdapter = this.объектСтроительстваTableAdapter;
            this.tableAdapterManager.ОтделTableAdapter = null;
            this.tableAdapterManager.ПодписантTableAdapter = null;
            this.tableAdapterManager.Проектно_изыскательские_работы__КомплектTableAdapter = null;
            this.tableAdapterManager.РазделПроектаTableAdapter = null;
            this.tableAdapterManager.РазрешительныйДокументTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // объектСтроительстваTableAdapter
            // 
            this.объектСтроительстваTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 440);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 10);
            this.panel3.TabIndex = 39;
            // 
            // объектСтроительстваBindingSource
            // 
            this.объектСтроительстваBindingSource.DataMember = "ОбъектСтроительства";
            this.объектСтроительстваBindingSource.DataSource = this._GIPv1_5DataSet;
            // 
            // _GIPv1_5DataSet
            // 
            this._GIPv1_5DataSet.DataSetName = "_GIPv1_5DataSet";
            this._GIPv1_5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSaveEditF
            // 
            this.btnSaveEditF.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveEditF.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSaveEditF.FlatAppearance.BorderSize = 0;
            this.btnSaveEditF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEditF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveEditF.Location = new System.Drawing.Point(400, 360);
            this.btnSaveEditF.Name = "btnSaveEditF";
            this.btnSaveEditF.Size = new System.Drawing.Size(140, 39);
            this.btnSaveEditF.TabIndex = 33;
            this.btnSaveEditF.Text = "Сохранить";
            this.btnSaveEditF.UseVisualStyleBackColor = false;
            this.btnSaveEditF.Click += new System.EventHandler(this.btnSaveEditF_Click);
            // 
            // btnCloseEditF
            // 
            this.btnCloseEditF.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCloseEditF.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseEditF.FlatAppearance.BorderSize = 0;
            this.btnCloseEditF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseEditF.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseEditF.Location = new System.Drawing.Point(600, 360);
            this.btnCloseEditF.Name = "btnCloseEditF";
            this.btnCloseEditF.Size = new System.Drawing.Size(140, 39);
            this.btnCloseEditF.TabIndex = 32;
            this.btnCloseEditF.Text = "Отменить";
            this.btnCloseEditF.UseVisualStyleBackColor = false;
            // 
            // источникСредствComboBox
            // 
            this.источникСредствComboBox.DataSource = this.отделBindingSource;
            this.источникСредствComboBox.FormattingEnabled = true;
            this.источникСредствComboBox.Location = new System.Drawing.Point(400, 300);
            this.источникСредствComboBox.Name = "источникСредствComboBox";
            this.источникСредствComboBox.Size = new System.Drawing.Size(340, 27);
            this.источникСредствComboBox.TabIndex = 49;
            // 
            // наименованиеОбъектаСтроительстваTextBox
            // 
            this.наименованиеОбъектаСтроительстваTextBox.Location = new System.Drawing.Point(400, 100);
            this.наименованиеОбъектаСтроительстваTextBox.Multiline = true;
            this.наименованиеОбъектаСтроительстваTextBox.Name = "наименованиеОбъектаСтроительстваTextBox";
            this.наименованиеОбъектаСтроительстваTextBox.Size = new System.Drawing.Size(340, 60);
            this.наименованиеОбъектаСтроительстваTextBox.TabIndex = 45;
            // 
            // датаРегистрацииЗаявленияDateTimePicker
            // 
            this.датаРегистрацииЗаявленияDateTimePicker.Location = new System.Drawing.Point(400, 180);
            this.датаРегистрацииЗаявленияDateTimePicker.Name = "датаРегистрацииЗаявленияDateTimePicker";
            this.датаРегистрацииЗаявленияDateTimePicker.Size = new System.Drawing.Size(340, 27);
            this.датаРегистрацииЗаявленияDateTimePicker.TabIndex = 46;
            // 
            // датаИнспирацииDateTimePicker
            // 
            this.датаИнспирацииDateTimePicker.Location = new System.Drawing.Point(400, 220);
            this.датаИнспирацииDateTimePicker.Name = "датаИнспирацииDateTimePicker";
            this.датаИнспирацииDateTimePicker.Size = new System.Drawing.Size(340, 27);
            this.датаИнспирацииDateTimePicker.TabIndex = 47;
            // 
            // наименованиеЗаказчикаTextBox
            // 
            this.наименованиеЗаказчикаTextBox.Location = new System.Drawing.Point(400, 260);
            this.наименованиеЗаказчикаTextBox.Name = "наименованиеЗаказчикаTextBox";
            this.наименованиеЗаказчикаTextBox.Size = new System.Drawing.Size(340, 27);
            this.наименованиеЗаказчикаTextBox.TabIndex = 48;
            // 
            // отделBindingSource
            // 
            this.отделBindingSource.DataMember = "Отдел";
            this.отделBindingSource.DataSource = this._GIPv1_5DataSet;
            // 
            // отделTableAdapter
            // 
            this.отделTableAdapter.ClearBeforeFill = true;
            // 
            // EditProject
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.источникСредствComboBox);
            this.Controls.Add(this.наименованиеОбъектаСтроительстваTextBox);
            this.Controls.Add(this.датаРегистрацииЗаявленияDateTimePicker);
            this.Controls.Add(this.датаИнспирацииDateTimePicker);
            this.Controls.Add(this.наименованиеЗаказчикаTextBox);
            this.Controls.Add(источникСредствLabel);
            this.Controls.Add(наименованиеОбъектаСтроительстваLabel);
            this.Controls.Add(датаРегистрацииЗаявленияLabel);
            this.Controls.Add(датаИнспирацииLabel);
            this.Controls.Add(наименованиеЗаказчикаLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(lblNameForm);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSaveEditF);
            this.Controls.Add(this.btnCloseEditF);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProject";
            this.Load += new System.EventHandler(this.EditProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private _GIPv1_5DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _GIPv1_5DataSetTableAdapters.ОбъектСтроительстваTableAdapter объектСтроительстваTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource объектСтроительстваBindingSource;
        private _GIPv1_5DataSet _GIPv1_5DataSet;
        private System.Windows.Forms.Button btnSaveEditF;
        private System.Windows.Forms.Button btnCloseEditF;
        private System.Windows.Forms.ComboBox источникСредствComboBox;
        private System.Windows.Forms.TextBox наименованиеОбъектаСтроительстваTextBox;
        private System.Windows.Forms.DateTimePicker датаРегистрацииЗаявленияDateTimePicker;
        private System.Windows.Forms.DateTimePicker датаИнспирацииDateTimePicker;
        private System.Windows.Forms.TextBox наименованиеЗаказчикаTextBox;
        private System.Windows.Forms.BindingSource отделBindingSource;
        private _GIPv1_5DataSetTableAdapters.ОтделTableAdapter отделTableAdapter;
    }
}