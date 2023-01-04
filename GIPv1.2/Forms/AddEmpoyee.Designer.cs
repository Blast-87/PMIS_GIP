
namespace GIPv1._2.Forms
{
    partial class AddEmpoyee
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
            System.Windows.Forms.Label iDСотрудникаLabel;
            System.Windows.Forms.Label фамилияСотрудникаLabel;
            System.Windows.Forms.Label имяСотрудникаLabel;
            System.Windows.Forms.Label отчествоСотрудникаLabel;
            System.Windows.Forms.Label должностьLabel;
            System.Windows.Forms.Label датаРожденияLabel;
            System.Windows.Forms.Label тарифнаяСтавкаLabel;
            System.Windows.Forms.Label iDОтделаLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label is_adminLabel;
            System.Windows.Forms.Label lblNameForm;
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveAddEmpl = new System.Windows.Forms.Button();
            this.btnCloseAddEmpl = new System.Windows.Forms.Button();
            this._GIPv1_7DataSet = new GIPv1._2._GIPv1_7DataSet();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new GIPv1._2._GIPv1_7DataSetTableAdapters.СотрудникиTableAdapter();
            this.tableAdapterManager = new GIPv1._2._GIPv1_7DataSetTableAdapters.TableAdapterManager();
            this.iDСотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.tbFamily = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.tbFunction = new System.Windows.Forms.TextBox();
            this.tbBirthDay = new System.Windows.Forms.DateTimePicker();
            this.tbTariffRate = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.is_adminCheckBox = new System.Windows.Forms.CheckBox();
            this.cbChoiseDepartment = new System.Windows.Forms.ComboBox();
            this.отделBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отделTableAdapter = new GIPv1._2._GIPv1_7DataSetTableAdapters.ОтделTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.отделBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            iDСотрудникаLabel = new System.Windows.Forms.Label();
            фамилияСотрудникаLabel = new System.Windows.Forms.Label();
            имяСотрудникаLabel = new System.Windows.Forms.Label();
            отчествоСотрудникаLabel = new System.Windows.Forms.Label();
            должностьLabel = new System.Windows.Forms.Label();
            датаРожденияLabel = new System.Windows.Forms.Label();
            тарифнаяСтавкаLabel = new System.Windows.Forms.Label();
            iDОтделаLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            is_adminLabel = new System.Windows.Forms.Label();
            lblNameForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDСотрудникаLabel
            // 
            iDСотрудникаLabel.AutoSize = true;
            iDСотрудникаLabel.Location = new System.Drawing.Point(76, 98);
            iDСотрудникаLabel.Name = "iDСотрудникаLabel";
            iDСотрудникаLabel.Size = new System.Drawing.Size(53, 19);
            iDСотрудникаLabel.TabIndex = 33;
            iDСотрудникаLabel.Text = "№ п/п:";
            // 
            // фамилияСотрудникаLabel
            // 
            фамилияСотрудникаLabel.AutoSize = true;
            фамилияСотрудникаLabel.Location = new System.Drawing.Point(76, 131);
            фамилияСотрудникаLabel.Name = "фамилияСотрудникаLabel";
            фамилияСотрудникаLabel.Size = new System.Drawing.Size(158, 19);
            фамилияСотрудникаLabel.TabIndex = 35;
            фамилияСотрудникаLabel.Text = "Фамилия Сотрудника:";
            // 
            // имяСотрудникаLabel
            // 
            имяСотрудникаLabel.AutoSize = true;
            имяСотрудникаLabel.Location = new System.Drawing.Point(76, 164);
            имяСотрудникаLabel.Name = "имяСотрудникаLabel";
            имяСотрудникаLabel.Size = new System.Drawing.Size(125, 19);
            имяСотрудникаLabel.TabIndex = 37;
            имяСотрудникаLabel.Text = "Имя Сотрудника:";
            // 
            // отчествоСотрудникаLabel
            // 
            отчествоСотрудникаLabel.AutoSize = true;
            отчествоСотрудникаLabel.Location = new System.Drawing.Point(76, 197);
            отчествоСотрудникаLabel.Name = "отчествоСотрудникаLabel";
            отчествоСотрудникаLabel.Size = new System.Drawing.Size(160, 19);
            отчествоСотрудникаLabel.TabIndex = 39;
            отчествоСотрудникаLabel.Text = "Отчество Сотрудника:";
            // 
            // должностьLabel
            // 
            должностьLabel.AutoSize = true;
            должностьLabel.Location = new System.Drawing.Point(76, 230);
            должностьLabel.Name = "должностьLabel";
            должностьLabel.Size = new System.Drawing.Size(89, 19);
            должностьLabel.TabIndex = 41;
            должностьLabel.Text = "Должность:";
            // 
            // датаРожденияLabel
            // 
            датаРожденияLabel.AutoSize = true;
            датаРожденияLabel.Location = new System.Drawing.Point(76, 264);
            датаРожденияLabel.Name = "датаРожденияLabel";
            датаРожденияLabel.Size = new System.Drawing.Size(120, 19);
            датаРожденияLabel.TabIndex = 43;
            датаРожденияLabel.Text = "Дата Рождения:";
            // 
            // тарифнаяСтавкаLabel
            // 
            тарифнаяСтавкаLabel.AutoSize = true;
            тарифнаяСтавкаLabel.Location = new System.Drawing.Point(76, 296);
            тарифнаяСтавкаLabel.Name = "тарифнаяСтавкаLabel";
            тарифнаяСтавкаLabel.Size = new System.Drawing.Size(130, 19);
            тарифнаяСтавкаLabel.TabIndex = 45;
            тарифнаяСтавкаLabel.Text = "Тарифная Ставка:";
            // 
            // iDОтделаLabel
            // 
            iDОтделаLabel.AutoSize = true;
            iDОтделаLabel.Location = new System.Drawing.Point(76, 329);
            iDОтделаLabel.Name = "iDОтделаLabel";
            iDОтделаLabel.Size = new System.Drawing.Size(54, 19);
            iDОтделаLabel.TabIndex = 47;
            iDОтделаLabel.Text = "Отдел:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(76, 362);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(49, 19);
            loginLabel.TabIndex = 49;
            loginLabel.Text = "Login:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(76, 395);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(75, 19);
            passwordLabel.TabIndex = 51;
            passwordLabel.Text = "Password:";
            // 
            // is_adminLabel
            // 
            is_adminLabel.AutoSize = true;
            is_adminLabel.Location = new System.Drawing.Point(76, 430);
            is_adminLabel.Name = "is_adminLabel";
            is_adminLabel.Size = new System.Drawing.Size(117, 19);
            is_adminLabel.TabIndex = 53;
            is_adminLabel.Text = "Администартор:";
            // 
            // lblNameForm
            // 
            lblNameForm.AutoSize = true;
            lblNameForm.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblNameForm.Location = new System.Drawing.Point(129, 51);
            lblNameForm.Name = "lblNameForm";
            lblNameForm.Size = new System.Drawing.Size(266, 25);
            lblNameForm.TabIndex = 55;
            lblNameForm.Text = "Добавить нового сотрудника";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 542);
            this.panel2.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Location = new System.Drawing.Point(547, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 542);
            this.panel4.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(0, 552);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(557, 10);
            this.panel3.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 10);
            this.panel1.TabIndex = 27;
            // 
            // btnSaveAddEmpl
            // 
            this.btnSaveAddEmpl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveAddEmpl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSaveAddEmpl.FlatAppearance.BorderSize = 0;
            this.btnSaveAddEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAddEmpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveAddEmpl.Location = new System.Drawing.Point(80, 487);
            this.btnSaveAddEmpl.Name = "btnSaveAddEmpl";
            this.btnSaveAddEmpl.Size = new System.Drawing.Size(140, 39);
            this.btnSaveAddEmpl.TabIndex = 32;
            this.btnSaveAddEmpl.Text = "Сохранить";
            this.btnSaveAddEmpl.UseVisualStyleBackColor = false;
            this.btnSaveAddEmpl.Click += new System.EventHandler(this.btnSaveAddEmpl_Click);
            // 
            // btnCloseAddEmpl
            // 
            this.btnCloseAddEmpl.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCloseAddEmpl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseAddEmpl.FlatAppearance.BorderSize = 0;
            this.btnCloseAddEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAddEmpl.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseAddEmpl.Location = new System.Drawing.Point(324, 487);
            this.btnCloseAddEmpl.Name = "btnCloseAddEmpl";
            this.btnCloseAddEmpl.Size = new System.Drawing.Size(140, 39);
            this.btnCloseAddEmpl.TabIndex = 31;
            this.btnCloseAddEmpl.Text = "Отменить";
            this.btnCloseAddEmpl.UseVisualStyleBackColor = false;
            this.btnCloseAddEmpl.Click += new System.EventHandler(this.btnCloseAddEmpl_Click);
            // 
            // _GIPv1_7DataSet
            // 
            this._GIPv1_7DataSet.DataSetName = "_GIPv1_7DataSet";
            this._GIPv1_7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this._GIPv1_7DataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = GIPv1._2._GIPv1_7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.НормативноПравоваяДокументацияTableAdapter = null;
            this.tableAdapterManager.ОбъектСтроительстваTableAdapter = null;
            this.tableAdapterManager.ОтделTableAdapter = null;
            this.tableAdapterManager.ПодписантTableAdapter = null;
            this.tableAdapterManager.Проектно_изыскательские_работы__КомплектTableAdapter = null;
            this.tableAdapterManager.РазделПроектаTableAdapter = null;
            this.tableAdapterManager.РазрешительныйДокументTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            // 
            // iDСотрудникаTextBox
            // 
            this.iDСотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "IDСотрудника", true));
            this.iDСотрудникаTextBox.Location = new System.Drawing.Point(264, 95);
            this.iDСотрудникаTextBox.Name = "iDСотрудникаTextBox";
            this.iDСотрудникаTextBox.ReadOnly = true;
            this.iDСотрудникаTextBox.Size = new System.Drawing.Size(200, 27);
            this.iDСотрудникаTextBox.TabIndex = 34;
            // 
            // tbFamily
            // 
            this.tbFamily.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "ФамилияСотрудника", true));
            this.tbFamily.Location = new System.Drawing.Point(264, 128);
            this.tbFamily.Name = "tbFamily";
            this.tbFamily.Size = new System.Drawing.Size(200, 27);
            this.tbFamily.TabIndex = 36;
            // 
            // tbName
            // 
            this.tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "ИмяСотрудника", true));
            this.tbName.Location = new System.Drawing.Point(264, 161);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 27);
            this.tbName.TabIndex = 38;
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "ОтчествоСотрудника", true));
            this.tbPatronymic.Location = new System.Drawing.Point(264, 194);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(200, 27);
            this.tbPatronymic.TabIndex = 40;
            // 
            // tbFunction
            // 
            this.tbFunction.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Должность", true));
            this.tbFunction.Location = new System.Drawing.Point(264, 227);
            this.tbFunction.Name = "tbFunction";
            this.tbFunction.Size = new System.Drawing.Size(200, 27);
            this.tbFunction.TabIndex = 42;
            // 
            // tbBirthDay
            // 
            this.tbBirthDay.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.сотрудникиBindingSource, "ДатаРождения", true));
            this.tbBirthDay.Location = new System.Drawing.Point(264, 260);
            this.tbBirthDay.Name = "tbBirthDay";
            this.tbBirthDay.Size = new System.Drawing.Size(200, 27);
            this.tbBirthDay.TabIndex = 44;
            // 
            // tbTariffRate
            // 
            this.tbTariffRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "ТарифнаяСтавка", true));
            this.tbTariffRate.Location = new System.Drawing.Point(264, 293);
            this.tbTariffRate.Name = "tbTariffRate";
            this.tbTariffRate.Size = new System.Drawing.Size(200, 27);
            this.tbTariffRate.TabIndex = 46;
            // 
            // tbLogin
            // 
            this.tbLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Login", true));
            this.tbLogin.Location = new System.Drawing.Point(264, 359);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(200, 27);
            this.tbLogin.TabIndex = 50;
            // 
            // tbPassword
            // 
            this.tbPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Password", true));
            this.tbPassword.Location = new System.Drawing.Point(264, 392);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(200, 27);
            this.tbPassword.TabIndex = 52;
            // 
            // is_adminCheckBox
            // 
            this.is_adminCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.сотрудникиBindingSource, "is_admin", true));
            this.is_adminCheckBox.Location = new System.Drawing.Point(264, 425);
            this.is_adminCheckBox.Name = "is_adminCheckBox";
            this.is_adminCheckBox.Size = new System.Drawing.Size(200, 24);
            this.is_adminCheckBox.TabIndex = 54;
            this.is_adminCheckBox.Text = "Да/Нет";
            this.is_adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // cbChoiseDepartment
            // 
            this.cbChoiseDepartment.DataSource = this.отделBindingSource;
            this.cbChoiseDepartment.DisplayMember = "НазваниеОтдела";
            this.cbChoiseDepartment.FormattingEnabled = true;
            this.cbChoiseDepartment.Location = new System.Drawing.Point(264, 326);
            this.cbChoiseDepartment.Name = "cbChoiseDepartment";
            this.cbChoiseDepartment.Size = new System.Drawing.Size(200, 27);
            this.cbChoiseDepartment.TabIndex = 58;
            this.cbChoiseDepartment.ValueMember = "IDОтдела";
            // 
            // отделBindingSource
            // 
            this.отделBindingSource.DataMember = "Отдел";
            this.отделBindingSource.DataSource = this._GIPv1_7DataSet;
            // 
            // отделTableAdapter
            // 
            this.отделTableAdapter.ClearBeforeFill = true;
            // 
            // отделBindingSource1
            // 
            this.отделBindingSource1.DataMember = "Отдел";
            this.отделBindingSource1.DataSource = this._GIPv1_7DataSet;
            // 
            // AddEmpoyee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(557, 562);
            this.Controls.Add(this.cbChoiseDepartment);
            this.Controls.Add(lblNameForm);
            this.Controls.Add(iDСотрудникаLabel);
            this.Controls.Add(this.iDСотрудникаTextBox);
            this.Controls.Add(фамилияСотрудникаLabel);
            this.Controls.Add(this.tbFamily);
            this.Controls.Add(имяСотрудникаLabel);
            this.Controls.Add(this.tbName);
            this.Controls.Add(отчествоСотрудникаLabel);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(должностьLabel);
            this.Controls.Add(this.tbFunction);
            this.Controls.Add(датаРожденияLabel);
            this.Controls.Add(this.tbBirthDay);
            this.Controls.Add(тарифнаяСтавкаLabel);
            this.Controls.Add(this.tbTariffRate);
            this.Controls.Add(iDОтделаLabel);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(is_adminLabel);
            this.Controls.Add(this.is_adminCheckBox);
            this.Controls.Add(this.btnSaveAddEmpl);
            this.Controls.Add(this.btnCloseAddEmpl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEmpoyee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmpoyee";
            this.Load += new System.EventHandler(this.AddEmpoyee_Load);
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveAddEmpl;
        private System.Windows.Forms.Button btnCloseAddEmpl;
        private _GIPv1_7DataSet _GIPv1_7DataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private _GIPv1_7DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private _GIPv1_7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDСотрудникаTextBox;
        private System.Windows.Forms.TextBox tbFamily;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.TextBox tbFunction;
        private System.Windows.Forms.DateTimePicker tbBirthDay;
        private System.Windows.Forms.TextBox tbTariffRate;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox is_adminCheckBox;
        private System.Windows.Forms.ComboBox cbChoiseDepartment;
        private System.Windows.Forms.BindingSource отделBindingSource;
        private _GIPv1_7DataSetTableAdapters.ОтделTableAdapter отделTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource отделBindingSource1;
    }
}