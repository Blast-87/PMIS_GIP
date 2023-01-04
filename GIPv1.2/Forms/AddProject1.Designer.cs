
namespace GIPv1._2.Forms
{
    partial class AddProject1
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
            System.Windows.Forms.Label наименованиеОбъектаСтроительстваLabel;
            System.Windows.Forms.Label датаРегистрацииЗаявленияLabel;
            System.Windows.Forms.Label датаИнспирацииLabel;
            System.Windows.Forms.Label наименованиеЗаказчикаLabel;
            System.Windows.Forms.Label lblNameForm;
            System.Windows.Forms.Label источникСредствLabel;
            this.объектСтроительстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._GIPv1_5DataSet = new GIPv1._2._GIPv1_5DataSet();
            this.наименованиеОбъектаСтроительстваTextBox = new System.Windows.Forms.TextBox();
            this.датаРегистрацииЗаявленияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.датаИнспирацииDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.наименованиеЗаказчикаTextBox = new System.Windows.Forms.TextBox();
            this.btnCloseAddPr = new System.Windows.Forms.Button();
            this.btnSaveAddPr = new System.Windows.Forms.Button();
            this.источникСредствComboBox = new System.Windows.Forms.ComboBox();
            this.объектСтроительстваTableAdapter = new GIPv1._2._GIPv1_5DataSetTableAdapters.ОбъектСтроительстваTableAdapter();
            this.tableAdapterManager = new GIPv1._2._GIPv1_5DataSetTableAdapters.TableAdapterManager();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            наименованиеОбъектаСтроительстваLabel = new System.Windows.Forms.Label();
            датаРегистрацииЗаявленияLabel = new System.Windows.Forms.Label();
            датаИнспирацииLabel = new System.Windows.Forms.Label();
            наименованиеЗаказчикаLabel = new System.Windows.Forms.Label();
            lblNameForm = new System.Windows.Forms.Label();
            источникСредствLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_5DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // наименованиеОбъектаСтроительстваLabel
            // 
            наименованиеОбъектаСтроительстваLabel.AutoSize = true;
            наименованиеОбъектаСтроительстваLabel.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            наименованиеОбъектаСтроительстваLabel.Location = new System.Drawing.Point(51, 89);
            наименованиеОбъектаСтроительстваLabel.Name = "наименованиеОбъектаСтроительстваLabel";
            наименованиеОбъектаСтроительстваLabel.Size = new System.Drawing.Size(279, 19);
            наименованиеОбъектаСтроительстваLabel.TabIndex = 3;
            наименованиеОбъектаСтроительстваLabel.Text = "Наименование Объекта Строительства:";
            // 
            // датаРегистрацииЗаявленияLabel
            // 
            датаРегистрацииЗаявленияLabel.AutoSize = true;
            датаРегистрацииЗаявленияLabel.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаРегистрацииЗаявленияLabel.Location = new System.Drawing.Point(51, 160);
            датаРегистрацииЗаявленияLabel.Name = "датаРегистрацииЗаявленияLabel";
            датаРегистрацииЗаявленияLabel.Size = new System.Drawing.Size(212, 19);
            датаРегистрацииЗаявленияLabel.TabIndex = 5;
            датаРегистрацииЗаявленияLabel.Text = "Дата Регистрации Заявления:";
            // 
            // датаИнспирацииLabel
            // 
            датаИнспирацииLabel.AutoSize = true;
            датаИнспирацииLabel.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаИнспирацииLabel.Location = new System.Drawing.Point(51, 199);
            датаИнспирацииLabel.Name = "датаИнспирацииLabel";
            датаИнспирацииLabel.Size = new System.Drawing.Size(132, 19);
            датаИнспирацииLabel.TabIndex = 7;
            датаИнспирацииLabel.Text = "Дата Инспирации:";
            // 
            // наименованиеЗаказчикаLabel
            // 
            наименованиеЗаказчикаLabel.AutoSize = true;
            наименованиеЗаказчикаLabel.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            наименованиеЗаказчикаLabel.Location = new System.Drawing.Point(51, 238);
            наименованиеЗаказчикаLabel.Name = "наименованиеЗаказчикаLabel";
            наименованиеЗаказчикаLabel.Size = new System.Drawing.Size(188, 19);
            наименованиеЗаказчикаLabel.TabIndex = 9;
            наименованиеЗаказчикаLabel.Text = "Наименование Заказчика:";
            // 
            // lblNameForm
            // 
            lblNameForm.AutoSize = true;
            lblNameForm.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblNameForm.Location = new System.Drawing.Point(202, 32);
            lblNameForm.Name = "lblNameForm";
            lblNameForm.Size = new System.Drawing.Size(223, 25);
            lblNameForm.TabIndex = 3;
            lblNameForm.Text = "Добавить новый проект";
            // 
            // источникСредствLabel
            // 
            источникСредствLabel.AutoSize = true;
            источникСредствLabel.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            источникСредствLabel.Location = new System.Drawing.Point(51, 277);
            источникСредствLabel.Name = "источникСредствLabel";
            источникСредствLabel.Size = new System.Drawing.Size(137, 19);
            источникСредствLabel.TabIndex = 15;
            источникСредствLabel.Text = "Источник Средств:";
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
            // наименованиеОбъектаСтроительстваTextBox
            // 
            this.наименованиеОбъектаСтроительстваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.объектСтроительстваBindingSource, "НаименованиеОбъектаСтроительства", true));
            this.наименованиеОбъектаСтроительстваTextBox.Location = new System.Drawing.Point(401, 88);
            this.наименованиеОбъектаСтроительстваTextBox.Multiline = true;
            this.наименованиеОбъектаСтроительстваTextBox.Name = "наименованиеОбъектаСтроительстваTextBox";
            this.наименованиеОбъектаСтроительстваTextBox.Size = new System.Drawing.Size(200, 56);
            this.наименованиеОбъектаСтроительстваTextBox.TabIndex = 4;
            // 
            // датаРегистрацииЗаявленияDateTimePicker
            // 
            this.датаРегистрацииЗаявленияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.объектСтроительстваBindingSource, "ДатаРегистрацииЗаявления", true));
            this.датаРегистрацииЗаявленияDateTimePicker.Location = new System.Drawing.Point(401, 158);
            this.датаРегистрацииЗаявленияDateTimePicker.Name = "датаРегистрацииЗаявленияDateTimePicker";
            this.датаРегистрацииЗаявленияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаРегистрацииЗаявленияDateTimePicker.TabIndex = 6;
            // 
            // датаИнспирацииDateTimePicker
            // 
            this.датаИнспирацииDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.объектСтроительстваBindingSource, "ДатаИнспирации", true));
            this.датаИнспирацииDateTimePicker.Location = new System.Drawing.Point(401, 197);
            this.датаИнспирацииDateTimePicker.Name = "датаИнспирацииDateTimePicker";
            this.датаИнспирацииDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаИнспирацииDateTimePicker.TabIndex = 8;
            // 
            // наименованиеЗаказчикаTextBox
            // 
            this.наименованиеЗаказчикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.объектСтроительстваBindingSource, "НаименованиеЗаказчика", true));
            this.наименованиеЗаказчикаTextBox.Location = new System.Drawing.Point(401, 237);
            this.наименованиеЗаказчикаTextBox.Name = "наименованиеЗаказчикаTextBox";
            this.наименованиеЗаказчикаTextBox.Size = new System.Drawing.Size(200, 20);
            this.наименованиеЗаказчикаTextBox.TabIndex = 10;
            // 
            // btnCloseAddPr
            // 
            this.btnCloseAddPr.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCloseAddPr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseAddPr.FlatAppearance.BorderSize = 0;
            this.btnCloseAddPr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAddPr.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseAddPr.Location = new System.Drawing.Point(401, 322);
            this.btnCloseAddPr.Name = "btnCloseAddPr";
            this.btnCloseAddPr.Size = new System.Drawing.Size(140, 39);
            this.btnCloseAddPr.TabIndex = 13;
            this.btnCloseAddPr.Text = "Отменить";
            this.btnCloseAddPr.UseVisualStyleBackColor = false;
            this.btnCloseAddPr.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaveAddPr
            // 
            this.btnSaveAddPr.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveAddPr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSaveAddPr.FlatAppearance.BorderSize = 0;
            this.btnSaveAddPr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAddPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveAddPr.Location = new System.Drawing.Point(123, 322);
            this.btnSaveAddPr.Name = "btnSaveAddPr";
            this.btnSaveAddPr.Size = new System.Drawing.Size(140, 39);
            this.btnSaveAddPr.TabIndex = 13;
            this.btnSaveAddPr.Text = "Сохранить";
            this.btnSaveAddPr.UseVisualStyleBackColor = false;
            this.btnSaveAddPr.Click += new System.EventHandler(this.button2_Click);
            // 
            // источникСредствComboBox
            // 
            this.источникСредствComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.объектСтроительстваBindingSource, "ИсточникСредств", true));
            this.источникСредствComboBox.FormattingEnabled = true;
            this.источникСредствComboBox.Items.AddRange(new object[] {
            "Бюджет",
            "Средства заказчика",
            "Резервный фонд президента"});
            this.источникСредствComboBox.Location = new System.Drawing.Point(401, 275);
            this.источникСредствComboBox.Name = "источникСредствComboBox";
            this.источникСредствComboBox.Size = new System.Drawing.Size(200, 21);
            this.источникСредствComboBox.TabIndex = 16;
            // 
            // объектСтроительстваTableAdapter
            // 
            this.объектСтроительстваTableAdapter.ClearBeforeFill = true;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 382);
            this.panel2.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Location = new System.Drawing.Point(634, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 382);
            this.panel4.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 392);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(644, 10);
            this.panel3.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 10);
            this.panel1.TabIndex = 19;
            // 
            // AddProject1
            // 
            this.AcceptButton = this.btnCloseAddPr;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnSaveAddPr;
            this.ClientSize = new System.Drawing.Size(644, 402);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(источникСредствLabel);
            this.Controls.Add(this.источникСредствComboBox);
            this.Controls.Add(this.btnSaveAddPr);
            this.Controls.Add(this.btnCloseAddPr);
            this.Controls.Add(lblNameForm);
            this.Controls.Add(наименованиеОбъектаСтроительстваLabel);
            this.Controls.Add(this.наименованиеОбъектаСтроительстваTextBox);
            this.Controls.Add(датаРегистрацииЗаявленияLabel);
            this.Controls.Add(this.датаРегистрацииЗаявленияDateTimePicker);
            this.Controls.Add(датаИнспирацииLabel);
            this.Controls.Add(this.датаИнспирацииDateTimePicker);
            this.Controls.Add(наименованиеЗаказчикаLabel);
            this.Controls.Add(this.наименованиеЗаказчикаTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProject1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление нового проекта";
            this.Load += new System.EventHandler(this.AddProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_5DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _GIPv1_5DataSet _GIPv1_5DataSet;
        private System.Windows.Forms.BindingSource объектСтроительстваBindingSource;
        private _GIPv1_5DataSetTableAdapters.ОбъектСтроительстваTableAdapter объектСтроительстваTableAdapter;
        private _GIPv1_5DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox наименованиеОбъектаСтроительстваTextBox;
        private System.Windows.Forms.DateTimePicker датаРегистрацииЗаявленияDateTimePicker;
        private System.Windows.Forms.DateTimePicker датаИнспирацииDateTimePicker;
        private System.Windows.Forms.TextBox наименованиеЗаказчикаTextBox;
        private System.Windows.Forms.Button btnCloseAddPr;
        private System.Windows.Forms.Button btnSaveAddPr;
        private System.Windows.Forms.ComboBox источникСредствComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}