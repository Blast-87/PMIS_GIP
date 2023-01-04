
namespace GIPv1._2.UserControls
{
    partial class UC_Projects
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDОбъектаСтроительстваLabel;
            System.Windows.Forms.Label наименованиеОбъектаСтроительстваLabel;
            System.Windows.Forms.Label источникСредствLabel;
            System.Windows.Forms.Label датаРегистрацииЗаявленияLabel;
            System.Windows.Forms.Label наименованиеЗаказчикаLabel;
            System.Windows.Forms.Label датаИнспирацииLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Projects));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelObj = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnNewObj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._GIPv1_5DataSet = new GIPv1._2._GIPv1_5DataSet();
            this.объектСтроительстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.объектСтроительстваTableAdapter = new GIPv1._2._GIPv1_5DataSetTableAdapters.ОбъектСтроительстваTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgwProjects = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClearChange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangeObj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.iDОбъектаСтроительстваTextBox = new System.Windows.Forms.TextBox();
            this.источникСредствComboBox = new System.Windows.Forms.ComboBox();
            this.наименованиеОбъектаСтроительстваTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеЗаказчикаTextBox = new System.Windows.Forms.TextBox();
            this.датаРегистрацииЗаявленияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.датаИнспирацииDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableAdapterManager = new GIPv1._2._GIPv1_5DataSetTableAdapters.TableAdapterManager();
            this.объектСтроительстваBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            iDОбъектаСтроительстваLabel = new System.Windows.Forms.Label();
            наименованиеОбъектаСтроительстваLabel = new System.Windows.Forms.Label();
            источникСредствLabel = new System.Windows.Forms.Label();
            датаРегистрацииЗаявленияLabel = new System.Windows.Forms.Label();
            наименованиеЗаказчикаLabel = new System.Windows.Forms.Label();
            датаИнспирацииLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProjects)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDОбъектаСтроительстваLabel
            // 
            iDОбъектаСтроительстваLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iDОбъектаСтроительстваLabel.AutoSize = true;
            iDОбъектаСтроительстваLabel.Location = new System.Drawing.Point(4, 72);
            iDОбъектаСтроительстваLabel.Name = "iDОбъектаСтроительстваLabel";
            iDОбъектаСтроительстваLabel.Size = new System.Drawing.Size(49, 19);
            iDОбъектаСтроительстваLabel.TabIndex = 16;
            iDОбъектаСтроительстваLabel.Text = "N п/п:";
            // 
            // наименованиеОбъектаСтроительстваLabel
            // 
            наименованиеОбъектаСтроительстваLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            наименованиеОбъектаСтроительстваLabel.AutoSize = true;
            наименованиеОбъектаСтроительстваLabel.Location = new System.Drawing.Point(4, 105);
            наименованиеОбъектаСтроительстваLabel.Name = "наименованиеОбъектаСтроительстваLabel";
            наименованиеОбъектаСтроительстваLabel.Size = new System.Drawing.Size(175, 19);
            наименованиеОбъектаСтроительстваLabel.TabIndex = 18;
            наименованиеОбъектаСтроительстваLabel.Text = "Наименование Объекта:";
            // 
            // источникСредствLabel
            // 
            источникСредствLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            источникСредствLabel.AutoSize = true;
            источникСредствLabel.Location = new System.Drawing.Point(4, 296);
            источникСредствLabel.Name = "источникСредствLabel";
            источникСредствLabel.Size = new System.Drawing.Size(137, 19);
            источникСредствLabel.TabIndex = 26;
            источникСредствLabel.Text = "Источник Средств:";
            // 
            // датаРегистрацииЗаявленияLabel
            // 
            датаРегистрацииЗаявленияLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            датаРегистрацииЗаявленияLabel.AutoSize = true;
            датаРегистрацииЗаявленияLabel.Location = new System.Drawing.Point(4, 198);
            датаРегистрацииЗаявленияLabel.Name = "датаРегистрацииЗаявленияLabel";
            датаРегистрацииЗаявленияLabel.Size = new System.Drawing.Size(136, 19);
            датаРегистрацииЗаявленияLabel.TabIndex = 20;
            датаРегистрацииЗаявленияLabel.Text = "Дата Регистрации:";
            // 
            // наименованиеЗаказчикаLabel
            // 
            наименованиеЗаказчикаLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            наименованиеЗаказчикаLabel.AutoSize = true;
            наименованиеЗаказчикаLabel.Location = new System.Drawing.Point(4, 263);
            наименованиеЗаказчикаLabel.Name = "наименованиеЗаказчикаLabel";
            наименованиеЗаказчикаLabel.Size = new System.Drawing.Size(188, 19);
            наименованиеЗаказчикаLabel.TabIndex = 24;
            наименованиеЗаказчикаLabel.Text = "Наименование Заказчика:";
            // 
            // датаИнспирацииLabel
            // 
            датаИнспирацииLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            датаИнспирацииLabel.AutoSize = true;
            датаИнспирацииLabel.Location = new System.Drawing.Point(4, 231);
            датаИнспирацииLabel.Name = "датаИнспирацииLabel";
            датаИнспирацииLabel.Size = new System.Drawing.Size(132, 19);
            датаИнспирацииLabel.TabIndex = 22;
            датаИнспирацииLabel.Text = "Дата Инспирации:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAssign);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnDelObj);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.cbSearch);
            this.panel1.Controls.Add(this.btnNewObj);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 60);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(855, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "источнику:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(677, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Поиск по";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(677, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "названию:";
            // 
            // btnAssign
            // 
            this.btnAssign.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAssign.FlatAppearance.BorderSize = 0;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Image = ((System.Drawing.Image)(resources.GetObject("btnAssign.Image")));
            this.btnAssign.Location = new System.Drawing.Point(292, 0);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(166, 60);
            this.btnAssign.TabIndex = 8;
            this.btnAssign.Text = "Разрешительные документы";
            this.btnAssign.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAssign.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(605, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 34);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelObj
            // 
            this.btnDelObj.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelObj.FlatAppearance.BorderSize = 0;
            this.btnDelObj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelObj.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelObj.ForeColor = System.Drawing.Color.White;
            this.btnDelObj.Image = ((System.Drawing.Image)(resources.GetObject("btnDelObj.Image")));
            this.btnDelObj.Location = new System.Drawing.Point(175, 0);
            this.btnDelObj.Name = "btnDelObj";
            this.btnDelObj.Size = new System.Drawing.Size(117, 60);
            this.btnDelObj.TabIndex = 5;
            this.btnDelObj.Text = " Удалить";
            this.btnDelObj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelObj.UseVisualStyleBackColor = true;
            this.btnDelObj.Click += new System.EventHandler(this.btnDelObj_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbSearch.Location = new System.Drawing.Point(746, 18);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 27);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // cbSearch
            // 
            this.cbSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Бюджет",
            "ИсточникСредств",
            "Средства заказчика",
            "Резервный фонд президента"});
            this.cbSearch.Location = new System.Drawing.Point(929, 18);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(116, 27);
            this.cbSearch.TabIndex = 3;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // btnNewObj
            // 
            this.btnNewObj.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewObj.FlatAppearance.BorderSize = 0;
            this.btnNewObj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewObj.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewObj.ForeColor = System.Drawing.Color.White;
            this.btnNewObj.Image = ((System.Drawing.Image)(resources.GetObject("btnNewObj.Image")));
            this.btnNewObj.Location = new System.Drawing.Point(0, 0);
            this.btnNewObj.Name = "btnNewObj";
            this.btnNewObj.Size = new System.Drawing.Size(175, 60);
            this.btnNewObj.TabIndex = 1;
            this.btnNewObj.Text = "  Добавить объект";
            this.btnNewObj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewObj.UseVisualStyleBackColor = true;
            this.btnNewObj.Click += new System.EventHandler(this.btnNewObj_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(855, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск по:";
            // 
            // _GIPv1_5DataSet
            // 
            this._GIPv1_5DataSet.DataSetName = "_GIPv1_5DataSet";
            this._GIPv1_5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // объектСтроительстваBindingSource
            // 
            this.объектСтроительстваBindingSource.DataMember = "ОбъектСтроительства";
            this.объектСтроительстваBindingSource.DataSource = this._GIPv1_5DataSet;
            // 
            // объектСтроительстваTableAdapter
            // 
            this.объектСтроительстваTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1049, 531);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.dgwProjects);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(643, 531);
            this.panel5.TabIndex = 17;
            // 
            // dgwProjects
            // 
            this.dgwProjects.AllowUserToAddRows = false;
            this.dgwProjects.AllowUserToDeleteRows = false;
            this.dgwProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwProjects.Location = new System.Drawing.Point(0, 0);
            this.dgwProjects.Name = "dgwProjects";
            this.dgwProjects.ReadOnly = true;
            this.dgwProjects.Size = new System.Drawing.Size(643, 531);
            this.dgwProjects.TabIndex = 0;
            this.dgwProjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnClearChange);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnChangeObj);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(iDОбъектаСтроительстваLabel);
            this.panel4.Controls.Add(this.iDОбъектаСтроительстваTextBox);
            this.panel4.Controls.Add(наименованиеОбъектаСтроительстваLabel);
            this.panel4.Controls.Add(this.источникСредствComboBox);
            this.panel4.Controls.Add(this.наименованиеОбъектаСтроительстваTextBox);
            this.panel4.Controls.Add(источникСредствLabel);
            this.panel4.Controls.Add(датаРегистрацииЗаявленияLabel);
            this.panel4.Controls.Add(this.наименованиеЗаказчикаTextBox);
            this.panel4.Controls.Add(this.датаРегистрацииЗаявленияDateTimePicker);
            this.panel4.Controls.Add(наименованиеЗаказчикаLabel);
            this.panel4.Controls.Add(датаИнспирацииLabel);
            this.panel4.Controls.Add(this.датаИнспирацииDateTimePicker);
            this.panel4.Location = new System.Drawing.Point(649, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 531);
            this.panel4.TabIndex = 16;
            // 
            // btnClearChange
            // 
            this.btnClearChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearChange.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnClearChange.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearChange.ForeColor = System.Drawing.Color.White;
            this.btnClearChange.Image = ((System.Drawing.Image)(resources.GetObject("btnClearChange.Image")));
            this.btnClearChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearChange.Location = new System.Drawing.Point(196, 409);
            this.btnClearChange.Name = "btnClearChange";
            this.btnClearChange.Size = new System.Drawing.Size(195, 51);
            this.btnClearChange.TabIndex = 31;
            this.btnClearChange.Text = "       Очистить строки";
            this.btnClearChange.UseVisualStyleBackColor = false;
            this.btnClearChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(196, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 58);
            this.label3.TabIndex = 30;
            this.label3.Text = "Сохраняйте данные после внесения изменений в систему!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChangeObj
            // 
            this.btnChangeObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeObj.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChangeObj.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeObj.ForeColor = System.Drawing.Color.White;
            this.btnChangeObj.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeObj.Image")));
            this.btnChangeObj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeObj.Location = new System.Drawing.Point(196, 352);
            this.btnChangeObj.Name = "btnChangeObj";
            this.btnChangeObj.Size = new System.Drawing.Size(195, 51);
            this.btnChangeObj.TabIndex = 29;
            this.btnChangeObj.Text = "       Внести изменения";
            this.btnChangeObj.UseVisualStyleBackColor = false;
            this.btnChangeObj.Click += new System.EventHandler(this.btnChangeObj_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(133, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Внести изменения:";
            // 
            // iDОбъектаСтроительстваTextBox
            // 
            this.iDОбъектаСтроительстваTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iDОбъектаСтроительстваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.объектСтроительстваBindingSource, "IDОбъектаСтроительства", true));
            this.iDОбъектаСтроительстваTextBox.Location = new System.Drawing.Point(196, 69);
            this.iDОбъектаСтроительстваTextBox.Name = "iDОбъектаСтроительстваTextBox";
            this.iDОбъектаСтроительстваTextBox.ReadOnly = true;
            this.iDОбъектаСтроительстваTextBox.Size = new System.Drawing.Size(200, 27);
            this.iDОбъектаСтроительстваTextBox.TabIndex = 17;
            // 
            // источникСредствComboBox
            // 
            this.источникСредствComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.источникСредствComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.объектСтроительстваBindingSource, "ИсточникСредств", true));
            this.источникСредствComboBox.FormattingEnabled = true;
            this.источникСредствComboBox.Items.AddRange(new object[] {
            "Бюджет",
            "Средства заказчика",
            "Резервный фонд президента"});
            this.источникСредствComboBox.Location = new System.Drawing.Point(196, 293);
            this.источникСредствComboBox.Name = "источникСредствComboBox";
            this.источникСредствComboBox.Size = new System.Drawing.Size(200, 27);
            this.источникСредствComboBox.TabIndex = 27;
            // 
            // наименованиеОбъектаСтроительстваTextBox
            // 
            this.наименованиеОбъектаСтроительстваTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.наименованиеОбъектаСтроительстваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.объектСтроительстваBindingSource, "НаименованиеОбъектаСтроительства", true));
            this.наименованиеОбъектаСтроительстваTextBox.Location = new System.Drawing.Point(196, 102);
            this.наименованиеОбъектаСтроительстваTextBox.Multiline = true;
            this.наименованиеОбъектаСтроительстваTextBox.Name = "наименованиеОбъектаСтроительстваTextBox";
            this.наименованиеОбъектаСтроительстваTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.наименованиеОбъектаСтроительстваTextBox.Size = new System.Drawing.Size(200, 86);
            this.наименованиеОбъектаСтроительстваTextBox.TabIndex = 19;
            // 
            // наименованиеЗаказчикаTextBox
            // 
            this.наименованиеЗаказчикаTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.наименованиеЗаказчикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.объектСтроительстваBindingSource, "НаименованиеЗаказчика", true));
            this.наименованиеЗаказчикаTextBox.Location = new System.Drawing.Point(196, 260);
            this.наименованиеЗаказчикаTextBox.Name = "наименованиеЗаказчикаTextBox";
            this.наименованиеЗаказчикаTextBox.Size = new System.Drawing.Size(200, 27);
            this.наименованиеЗаказчикаTextBox.TabIndex = 25;
            // 
            // датаРегистрацииЗаявленияDateTimePicker
            // 
            this.датаРегистрацииЗаявленияDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.датаРегистрацииЗаявленияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.объектСтроительстваBindingSource, "ДатаРегистрацииЗаявления", true));
            this.датаРегистрацииЗаявленияDateTimePicker.Location = new System.Drawing.Point(196, 194);
            this.датаРегистрацииЗаявленияDateTimePicker.Name = "датаРегистрацииЗаявленияDateTimePicker";
            this.датаРегистрацииЗаявленияDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.датаРегистрацииЗаявленияDateTimePicker.TabIndex = 21;
            // 
            // датаИнспирацииDateTimePicker
            // 
            this.датаИнспирацииDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.датаИнспирацииDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.объектСтроительстваBindingSource, "ДатаИнспирации", true));
            this.датаИнспирацииDateTimePicker.Location = new System.Drawing.Point(196, 227);
            this.датаИнспирацииDateTimePicker.Name = "датаИнспирацииDateTimePicker";
            this.датаИнспирацииDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.датаИнспирацииDateTimePicker.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 596);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 30);
            this.panel2.TabIndex = 1;
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
            // объектСтроительстваBindingSource1
            // 
            this.объектСтроительстваBindingSource1.DataMember = "ОбъектСтроительства";
            this.объектСтроительстваBindingSource1.DataSource = this._GIPv1_5DataSet;
            // 
            // UC_Projects
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "UC_Projects";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1059, 631);
            this.Load += new System.EventHandler(this.UC_Jobs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProjects)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewObj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Button btnDelObj;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.BindingSource объектСтроительстваBindingSource;
        private _GIPv1_5DataSet _GIPv1_5DataSet;
        private _GIPv1_5DataSetTableAdapters.ОбъектСтроительстваTableAdapter объектСтроительстваTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private _GIPv1_5DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnChangeObj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox источникСредствComboBox;
        private System.Windows.Forms.TextBox наименованиеОбъектаСтроительстваTextBox;
        private System.Windows.Forms.TextBox наименованиеЗаказчикаTextBox;
        private System.Windows.Forms.DateTimePicker датаРегистрацииЗаявленияDateTimePicker;
        private System.Windows.Forms.DateTimePicker датаИнспирацииDateTimePicker;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox iDОбъектаСтроительстваTextBox;
        private System.Windows.Forms.BindingSource объектСтроительстваBindingSource1;
        private System.Windows.Forms.Button btnClearChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgwProjects;
    }
}
