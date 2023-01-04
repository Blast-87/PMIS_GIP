
namespace GIPv1._2.UserControls
{
    partial class UC_Jobs
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
            System.Windows.Forms.Label условиеЗадачиLabel;
            System.Windows.Forms.Label статусЗадачиLabel;
            System.Windows.Forms.Label датаПостановкиЗадачиLabel;
            System.Windows.Forms.Label датаИсполненияLabel;
            System.Windows.Forms.Label срокИсполненияLabel;
            System.Windows.Forms.Label фамилияСотрудникаLabel;
            System.Windows.Forms.Label названиеОтделаLabel;
            System.Windows.Forms.Label наименованиеОбъектаСтроительстваLabel;
            System.Windows.Forms.Label iDСотрудникаLabel;
            System.Windows.Forms.Label iDОбъектаСтроительстваLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Jobs));
            this._GIPv1_5DataSet = new GIPv1._2._GIPv1_5DataSet();
            this.объектСтроительстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.объектСтроительстваTableAdapter = new GIPv1._2._GIPv1_5DataSetTableAdapters.ОбъектСтроительстваTableAdapter();
            this.отделBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отделTableAdapter = new GIPv1._2._GIPv1_5DataSetTableAdapters.ОтделTableAdapter();
            this.отделBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new GIPv1._2._GIPv1_5DataSetTableAdapters.СотрудникиTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAssignJob = new System.Windows.Forms.Button();
            this.tbSearshJobs = new System.Windows.Forms.TextBox();
            this.btnSaveJobs = new System.Windows.Forms.Button();
            this.cbJob = new System.Windows.Forms.ComboBox();
            this.lblSearchJob = new System.Windows.Forms.Label();
            this.btnDelJob = new System.Windows.Forms.Button();
            this.btnNewJob = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbSotrudnikJobs = new System.Windows.Forms.ComboBox();
            this.сотрудникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._GIPv1_17DataSet = new GIPv1._2._GIPv1_17DataSet();
            this.cbOtdelJobs = new System.Windows.Forms.ComboBox();
            this.отделBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cbProjectJobs = new System.Windows.Forms.ComboBox();
            this.объектСтроительстваBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.объектСтроительстваBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this._GIPv1_17DataSet3 = new GIPv1._2._GIPv1_17DataSet3();
            this.tbiDОбъектаСтроительства = new System.Windows.Forms.TextBox();
            this.задачиBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gIPvRTM2DataSet = new GIPv1._2.GIPvRTM2DataSet();
            this.tbIDСотрудника = new System.Windows.Forms.TextBox();
            this.задачиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbZadanieJobs = new System.Windows.Forms.TextBox();
            this.dtpStartJobs = new System.Windows.Forms.DateTimePicker();
            this.dtpFinishJobs = new System.Windows.Forms.DateTimePicker();
            this.dtpDLineJobs = new System.Windows.Forms.DateTimePicker();
            this.btnClearChange = new System.Windows.Forms.Button();
            this.btnChangeObj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwJobs = new System.Windows.Forms.DataGridView();
            this.объектСтроительстваBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.задачиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._GIPv1_17DataSet2 = new GIPv1._2._GIPv1_17DataSet2();
            this.разделПроектаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.разделПроектаTableAdapter = new GIPv1._2._GIPv1_5DataSetTableAdapters.РазделПроектаTableAdapter();
            this.tableAdapterManager = new GIPv1._2._GIPv1_5DataSetTableAdapters.TableAdapterManager();
            this.r137BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.нормативноПравоваяДокументацияTableAdapter = new GIPv1._2._GIPv1_5DataSetTableAdapters.НормативноПравоваяДокументацияTableAdapter();
            this.задачиTableAdapter = new GIPv1._2._GIPv1_17DataSet2TableAdapters.ЗадачиTableAdapter();
            this.задачиTableAdapter1 = new GIPv1._2._GIPv1_17DataSetTableAdapters.ЗадачиTableAdapter();
            this.tableAdapterManager1 = new GIPv1._2._GIPv1_17DataSetTableAdapters.TableAdapterManager();
            this.объектСтроительстваTableAdapter1 = new GIPv1._2._GIPv1_17DataSetTableAdapters.ОбъектСтроительстваTableAdapter();
            this.отделTableAdapter1 = new GIPv1._2._GIPv1_17DataSetTableAdapters.ОтделTableAdapter();
            this.сотрудникиTableAdapter1 = new GIPv1._2._GIPv1_17DataSetTableAdapters.СотрудникиTableAdapter();
            this.объектСтроительстваTableAdapter2 = new GIPv1._2._GIPv1_17DataSet3TableAdapters.ОбъектСтроительстваTableAdapter();
            this.задачиTableAdapter2 = new GIPv1._2.GIPvRTM2DataSetTableAdapters.ЗадачиTableAdapter();
            this.tableAdapterManager2 = new GIPv1._2.GIPvRTM2DataSetTableAdapters.TableAdapterManager();
            условиеЗадачиLabel = new System.Windows.Forms.Label();
            статусЗадачиLabel = new System.Windows.Forms.Label();
            датаПостановкиЗадачиLabel = new System.Windows.Forms.Label();
            датаИсполненияLabel = new System.Windows.Forms.Label();
            срокИсполненияLabel = new System.Windows.Forms.Label();
            фамилияСотрудникаLabel = new System.Windows.Forms.Label();
            названиеОтделаLabel = new System.Windows.Forms.Label();
            наименованиеОбъектаСтроительстваLabel = new System.Windows.Forms.Label();
            iDСотрудникаLabel = new System.Windows.Forms.Label();
            iDОбъектаСтроительстваLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_17DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_17DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIPvRTM2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_17DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.разделПроектаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r137BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // условиеЗадачиLabel
            // 
            условиеЗадачиLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            условиеЗадачиLabel.AutoSize = true;
            условиеЗадачиLabel.Location = new System.Drawing.Point(5, 278);
            условиеЗадачиLabel.Name = "условиеЗадачиLabel";
            условиеЗадачиLabel.Size = new System.Drawing.Size(121, 19);
            условиеЗадачиLabel.TabIndex = 37;
            условиеЗадачиLabel.Text = "Условие Задачи:";
            // 
            // статусЗадачиLabel
            // 
            статусЗадачиLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            статусЗадачиLabel.AutoSize = true;
            статусЗадачиLabel.Location = new System.Drawing.Point(5, 510);
            статусЗадачиLabel.Name = "статусЗадачиLabel";
            статусЗадачиLabel.Size = new System.Drawing.Size(111, 19);
            статусЗадачиLabel.TabIndex = 39;
            статусЗадачиLabel.Text = "Статус Задачи:";
            // 
            // датаПостановкиЗадачиLabel
            // 
            датаПостановкиЗадачиLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            датаПостановкиЗадачиLabel.AutoSize = true;
            датаПостановкиЗадачиLabel.Location = new System.Drawing.Point(5, 407);
            датаПостановкиЗадачиLabel.Name = "датаПостановкиЗадачиLabel";
            датаПостановкиЗадачиLabel.Size = new System.Drawing.Size(184, 19);
            датаПостановкиЗадачиLabel.TabIndex = 41;
            датаПостановкиЗадачиLabel.Text = "Дата Постановки Задачи:";
            // 
            // датаИсполненияLabel
            // 
            датаИсполненияLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            датаИсполненияLabel.AutoSize = true;
            датаИсполненияLabel.Location = new System.Drawing.Point(5, 440);
            датаИсполненияLabel.Name = "датаИсполненияLabel";
            датаИсполненияLabel.Size = new System.Drawing.Size(132, 19);
            датаИсполненияLabel.TabIndex = 43;
            датаИсполненияLabel.Text = "Дата Исполнения:";
            // 
            // срокИсполненияLabel
            // 
            срокИсполненияLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            срокИсполненияLabel.AutoSize = true;
            срокИсполненияLabel.Location = new System.Drawing.Point(5, 473);
            срокИсполненияLabel.Name = "срокИсполненияLabel";
            срокИсполненияLabel.Size = new System.Drawing.Size(131, 19);
            срокИсполненияLabel.TabIndex = 45;
            срокИсполненияLabel.Text = "Срок Исполнения:";
            // 
            // фамилияСотрудникаLabel
            // 
            фамилияСотрудникаLabel.AutoSize = true;
            фамилияСотрудникаLabel.Location = new System.Drawing.Point(5, 91);
            фамилияСотрудникаLabel.Name = "фамилияСотрудникаLabel";
            фамилияСотрудникаLabel.Size = new System.Drawing.Size(100, 19);
            фамилияСотрудникаLabel.TabIndex = 47;
            фамилияСотрудникаLabel.Text = "Исполнитель:";
            // 
            // названиеОтделаLabel
            // 
            названиеОтделаLabel.AutoSize = true;
            названиеОтделаLabel.Location = new System.Drawing.Point(5, 61);
            названиеОтделаLabel.Name = "названиеОтделаLabel";
            названиеОтделаLabel.Size = new System.Drawing.Size(54, 19);
            названиеОтделаLabel.TabIndex = 48;
            названиеОтделаLabel.Text = "Отдел:";
            // 
            // наименованиеОбъектаСтроительстваLabel
            // 
            наименованиеОбъектаСтроительстваLabel.AutoSize = true;
            наименованиеОбъектаСтроительстваLabel.Location = new System.Drawing.Point(5, 26);
            наименованиеОбъектаСтроительстваLabel.Name = "наименованиеОбъектаСтроительстваLabel";
            наименованиеОбъектаСтроительстваLabel.Size = new System.Drawing.Size(62, 19);
            наименованиеОбъектаСтроительстваLabel.TabIndex = 49;
            наименованиеОбъектаСтроительстваLabel.Text = "Проект:";
            // 
            // iDСотрудникаLabel
            // 
            iDСотрудникаLabel.AutoSize = true;
            iDСотрудникаLabel.Location = new System.Drawing.Point(6, 247);
            iDСотрудникаLabel.Name = "iDСотрудникаLabel";
            iDСотрудникаLabel.Size = new System.Drawing.Size(105, 19);
            iDСотрудникаLabel.TabIndex = 51;
            iDСотрудникаLabel.Text = "Табельный №:";
            // 
            // iDОбъектаСтроительстваLabel
            // 
            iDОбъектаСтроительстваLabel.AutoSize = true;
            iDОбъектаСтроительстваLabel.Location = new System.Drawing.Point(5, 215);
            iDОбъектаСтроительстваLabel.Name = "iDОбъектаСтроительстваLabel";
            iDОбъектаСтроительстваLabel.Size = new System.Drawing.Size(86, 19);
            iDОбъектаСтроительстваLabel.TabIndex = 52;
            iDОбъектаСтроительстваLabel.Text = "№ проекта:";
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
            // отделBindingSource
            // 
            this.отделBindingSource.DataMember = "Отдел";
            this.отделBindingSource.DataSource = this._GIPv1_5DataSet;
            // 
            // отделTableAdapter
            // 
            this.отделTableAdapter.ClearBeforeFill = true;
            // 
            // отделBindingSource1
            // 
            this.отделBindingSource1.DataMember = "Отдел";
            this.отделBindingSource1.DataSource = this._GIPv1_5DataSet;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this._GIPv1_5DataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnAssignJob);
            this.panel1.Controls.Add(this.tbSearshJobs);
            this.panel1.Controls.Add(this.btnSaveJobs);
            this.panel1.Controls.Add(this.cbJob);
            this.panel1.Controls.Add(this.lblSearchJob);
            this.panel1.Controls.Add(this.btnDelJob);
            this.panel1.Controls.Add(this.btnNewJob);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 60);
            this.panel1.TabIndex = 4;
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
            this.btnRefresh.Location = new System.Drawing.Point(896, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 34);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAssignJob
            // 
            this.btnAssignJob.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAssignJob.FlatAppearance.BorderSize = 0;
            this.btnAssignJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignJob.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAssignJob.ForeColor = System.Drawing.Color.White;
            this.btnAssignJob.Image = ((System.Drawing.Image)(resources.GetObject("btnAssignJob.Image")));
            this.btnAssignJob.Location = new System.Drawing.Point(415, 0);
            this.btnAssignJob.Name = "btnAssignJob";
            this.btnAssignJob.Size = new System.Drawing.Size(119, 60);
            this.btnAssignJob.TabIndex = 12;
            this.btnAssignJob.Text = "Утвердить";
            this.btnAssignJob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAssignJob.UseVisualStyleBackColor = true;
            // 
            // tbSearshJobs
            // 
            this.tbSearshJobs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbSearshJobs.Location = new System.Drawing.Point(1141, 18);
            this.tbSearshJobs.Name = "tbSearshJobs";
            this.tbSearshJobs.Size = new System.Drawing.Size(100, 27);
            this.tbSearshJobs.TabIndex = 10;
            // 
            // btnSaveJobs
            // 
            this.btnSaveJobs.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSaveJobs.FlatAppearance.BorderSize = 0;
            this.btnSaveJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveJobs.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveJobs.ForeColor = System.Drawing.Color.White;
            this.btnSaveJobs.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveJobs.Image")));
            this.btnSaveJobs.Location = new System.Drawing.Point(296, 0);
            this.btnSaveJobs.Name = "btnSaveJobs";
            this.btnSaveJobs.Size = new System.Drawing.Size(119, 60);
            this.btnSaveJobs.TabIndex = 11;
            this.btnSaveJobs.Text = "Сохранить";
            this.btnSaveJobs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveJobs.UseVisualStyleBackColor = true;
            this.btnSaveJobs.Click += new System.EventHandler(this.btnSaveJobs_Click);
            // 
            // cbJob
            // 
            this.cbJob.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJob.FormattingEnabled = true;
            this.cbJob.Location = new System.Drawing.Point(993, 18);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(142, 27);
            this.cbJob.TabIndex = 9;
            // 
            // lblSearchJob
            // 
            this.lblSearchJob.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSearchJob.AutoSize = true;
            this.lblSearchJob.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchJob.ForeColor = System.Drawing.Color.White;
            this.lblSearchJob.Location = new System.Drawing.Point(933, 21);
            this.lblSearchJob.Name = "lblSearchJob";
            this.lblSearchJob.Size = new System.Drawing.Size(54, 19);
            this.lblSearchJob.TabIndex = 8;
            this.lblSearchJob.Text = "Поиск:";
            // 
            // btnDelJob
            // 
            this.btnDelJob.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelJob.FlatAppearance.BorderSize = 0;
            this.btnDelJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelJob.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelJob.ForeColor = System.Drawing.Color.White;
            this.btnDelJob.Image = ((System.Drawing.Image)(resources.GetObject("btnDelJob.Image")));
            this.btnDelJob.Location = new System.Drawing.Point(175, 0);
            this.btnDelJob.Name = "btnDelJob";
            this.btnDelJob.Size = new System.Drawing.Size(121, 60);
            this.btnDelJob.TabIndex = 10;
            this.btnDelJob.Text = "Удалить";
            this.btnDelJob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelJob.UseVisualStyleBackColor = true;
            this.btnDelJob.Click += new System.EventHandler(this.btnDelJob_Click);
            // 
            // btnNewJob
            // 
            this.btnNewJob.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewJob.FlatAppearance.BorderSize = 0;
            this.btnNewJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewJob.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewJob.ForeColor = System.Drawing.Color.White;
            this.btnNewJob.Image = ((System.Drawing.Image)(resources.GetObject("btnNewJob.Image")));
            this.btnNewJob.Location = new System.Drawing.Point(0, 0);
            this.btnNewJob.Name = "btnNewJob";
            this.btnNewJob.Size = new System.Drawing.Size(175, 60);
            this.btnNewJob.TabIndex = 9;
            this.btnNewJob.Text = "  Добавить задачу";
            this.btnNewJob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewJob.UseVisualStyleBackColor = true;
            this.btnNewJob.Click += new System.EventHandler(this.btnNewJob_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.lblCount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 719);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1253, 30);
            this.panel2.TabIndex = 5;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCount.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCount.Location = new System.Drawing.Point(1207, 8);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 15);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "0000";
            this.lblCount.TextChanged += new System.EventHandler(this.label5_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(984, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Количество активных задач в работе:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dgwJobs);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1253, 654);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(iDОбъектаСтроительстваLabel);
            this.panel4.Controls.Add(this.tbiDОбъектаСтроительства);
            this.panel4.Controls.Add(iDСотрудникаLabel);
            this.panel4.Controls.Add(this.tbIDСотрудника);
            this.panel4.Controls.Add(this.cbStatus);
            this.panel4.Controls.Add(условиеЗадачиLabel);
            this.panel4.Controls.Add(this.tbZadanieJobs);
            this.panel4.Controls.Add(статусЗадачиLabel);
            this.panel4.Controls.Add(датаПостановкиЗадачиLabel);
            this.panel4.Controls.Add(this.dtpStartJobs);
            this.panel4.Controls.Add(датаИсполненияLabel);
            this.panel4.Controls.Add(this.dtpFinishJobs);
            this.panel4.Controls.Add(срокИсполненияLabel);
            this.panel4.Controls.Add(this.dtpDLineJobs);
            this.panel4.Controls.Add(this.btnClearChange);
            this.panel4.Controls.Add(this.btnChangeObj);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(844, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(522, 654);
            this.panel4.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(наименованиеОбъектаСтроительстваLabel);
            this.groupBox1.Controls.Add(this.cbSotrudnikJobs);
            this.groupBox1.Controls.Add(фамилияСотрудникаLabel);
            this.groupBox1.Controls.Add(this.cbOtdelJobs);
            this.groupBox1.Controls.Add(названиеОтделаLabel);
            this.groupBox1.Controls.Add(this.cbProjectJobs);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 177);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбрать данные";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Olive;
            this.button1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(188, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 51);
            this.button1.TabIndex = 51;
            this.button1.Text = "       Выбрать данные";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cbSotrudnikJobs
            // 
            this.cbSotrudnikJobs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource1, "ФамилияСотрудника", true));
            this.cbSotrudnikJobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSotrudnikJobs.FormattingEnabled = true;
            this.cbSotrudnikJobs.Location = new System.Drawing.Point(188, 88);
            this.cbSotrudnikJobs.Name = "cbSotrudnikJobs";
            this.cbSotrudnikJobs.Size = new System.Drawing.Size(200, 27);
            this.cbSotrudnikJobs.TabIndex = 48;
            this.cbSotrudnikJobs.SelectedIndexChanged += new System.EventHandler(this.cbSotrudnikJobs_SelectedIndexChanged);
            // 
            // сотрудникиBindingSource1
            // 
            this.сотрудникиBindingSource1.DataMember = "Сотрудники";
            this.сотрудникиBindingSource1.DataSource = this._GIPv1_17DataSet;
            // 
            // _GIPv1_17DataSet
            // 
            this._GIPv1_17DataSet.DataSetName = "_GIPv1_17DataSet";
            this._GIPv1_17DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbOtdelJobs
            // 
            this.cbOtdelJobs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделBindingSource2, "НазваниеОтдела", true));
            this.cbOtdelJobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOtdelJobs.FormattingEnabled = true;
            this.cbOtdelJobs.Location = new System.Drawing.Point(188, 56);
            this.cbOtdelJobs.Name = "cbOtdelJobs";
            this.cbOtdelJobs.Size = new System.Drawing.Size(200, 27);
            this.cbOtdelJobs.TabIndex = 49;
            this.cbOtdelJobs.SelectedIndexChanged += new System.EventHandler(this.cbOtdelJobs_SelectedIndexChanged);
            // 
            // отделBindingSource2
            // 
            this.отделBindingSource2.DataMember = "Отдел";
            this.отделBindingSource2.DataSource = this._GIPv1_17DataSet;
            // 
            // cbProjectJobs
            // 
            this.cbProjectJobs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cbProjectJobs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.объектСтроительстваBindingSource1, "НаименованиеОбъектаСтроительства", true));
            this.cbProjectJobs.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.объектСтроительстваBindingSource3, "IDОбъектаСтроительства", true));
            this.cbProjectJobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjectJobs.FormattingEnabled = true;
            this.cbProjectJobs.Location = new System.Drawing.Point(188, 23);
            this.cbProjectJobs.Name = "cbProjectJobs";
            this.cbProjectJobs.Size = new System.Drawing.Size(200, 27);
            this.cbProjectJobs.TabIndex = 50;
            this.cbProjectJobs.SelectedIndexChanged += new System.EventHandler(this.cbProjectJobs_SelectedIndexChanged);
            this.cbProjectJobs.SelectionChangeCommitted += new System.EventHandler(this.cbProjectJobs_SelectionChangeCommitted);
            // 
            // объектСтроительстваBindingSource1
            // 
            this.объектСтроительстваBindingSource1.DataMember = "ОбъектСтроительства";
            this.объектСтроительстваBindingSource1.DataSource = this._GIPv1_17DataSet;
            // 
            // объектСтроительстваBindingSource3
            // 
            this.объектСтроительстваBindingSource3.DataMember = "ОбъектСтроительства";
            this.объектСтроительстваBindingSource3.DataSource = this._GIPv1_17DataSet3;
            // 
            // _GIPv1_17DataSet3
            // 
            this._GIPv1_17DataSet3.DataSetName = "_GIPv1_17DataSet3";
            this._GIPv1_17DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbiDОбъектаСтроительства
            // 
            this.tbiDОбъектаСтроительства.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.задачиBindingSource2, "IDОбъектаСтроительства", true));
            this.tbiDОбъектаСтроительства.Location = new System.Drawing.Point(195, 212);
            this.tbiDОбъектаСтроительства.Name = "tbiDОбъектаСтроительства";
            this.tbiDОбъектаСтроительства.Size = new System.Drawing.Size(200, 27);
            this.tbiDОбъектаСтроительства.TabIndex = 53;
            // 
            // задачиBindingSource2
            // 
            this.задачиBindingSource2.DataMember = "Задачи";
            this.задачиBindingSource2.DataSource = this.gIPvRTM2DataSet;
            // 
            // gIPvRTM2DataSet
            // 
            this.gIPvRTM2DataSet.DataSetName = "GIPvRTM2DataSet";
            this.gIPvRTM2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbIDСотрудника
            // 
            this.tbIDСотрудника.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.задачиBindingSource1, "IDСотрудника", true));
            this.tbIDСотрудника.Location = new System.Drawing.Point(195, 245);
            this.tbIDСотрудника.Name = "tbIDСотрудника";
            this.tbIDСотрудника.Size = new System.Drawing.Size(200, 27);
            this.tbIDСотрудника.TabIndex = 52;
            // 
            // задачиBindingSource1
            // 
            this.задачиBindingSource1.DataMember = "Задачи";
            this.задачиBindingSource1.DataSource = this._GIPv1_17DataSet;
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.задачиBindingSource1, "СтатусЗадачи", true));
            this.cbStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.задачиBindingSource1, "СтатусЗадачи", true));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "В работе",
            "Утверждено"});
            this.cbStatus.Location = new System.Drawing.Point(195, 502);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(200, 27);
            this.cbStatus.TabIndex = 47;
            // 
            // tbZadanieJobs
            // 
            this.tbZadanieJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbZadanieJobs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.задачиBindingSource1, "УсловиеЗадачи", true));
            this.tbZadanieJobs.Location = new System.Drawing.Point(195, 278);
            this.tbZadanieJobs.Multiline = true;
            this.tbZadanieJobs.Name = "tbZadanieJobs";
            this.tbZadanieJobs.Size = new System.Drawing.Size(200, 119);
            this.tbZadanieJobs.TabIndex = 38;
            // 
            // dtpStartJobs
            // 
            this.dtpStartJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartJobs.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.задачиBindingSource1, "ДатаПостановкиЗадачи", true));
            this.dtpStartJobs.Location = new System.Drawing.Point(195, 403);
            this.dtpStartJobs.Name = "dtpStartJobs";
            this.dtpStartJobs.Size = new System.Drawing.Size(200, 27);
            this.dtpStartJobs.TabIndex = 42;
            // 
            // dtpFinishJobs
            // 
            this.dtpFinishJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFinishJobs.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.задачиBindingSource1, "ДатаИсполнения", true));
            this.dtpFinishJobs.Location = new System.Drawing.Point(195, 436);
            this.dtpFinishJobs.Name = "dtpFinishJobs";
            this.dtpFinishJobs.Size = new System.Drawing.Size(200, 27);
            this.dtpFinishJobs.TabIndex = 44;
            // 
            // dtpDLineJobs
            // 
            this.dtpDLineJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDLineJobs.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.задачиBindingSource1, "СрокИсполнения", true));
            this.dtpDLineJobs.Location = new System.Drawing.Point(195, 469);
            this.dtpDLineJobs.Name = "dtpDLineJobs";
            this.dtpDLineJobs.Size = new System.Drawing.Size(200, 27);
            this.dtpDLineJobs.TabIndex = 46;
            // 
            // btnClearChange
            // 
            this.btnClearChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearChange.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnClearChange.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearChange.ForeColor = System.Drawing.Color.White;
            this.btnClearChange.Image = ((System.Drawing.Image)(resources.GetObject("btnClearChange.Image")));
            this.btnClearChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearChange.Location = new System.Drawing.Point(195, 590);
            this.btnClearChange.Name = "btnClearChange";
            this.btnClearChange.Size = new System.Drawing.Size(200, 51);
            this.btnClearChange.TabIndex = 31;
            this.btnClearChange.Text = "       Очистить строки";
            this.btnClearChange.UseVisualStyleBackColor = false;
            // 
            // btnChangeObj
            // 
            this.btnChangeObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeObj.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChangeObj.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeObj.ForeColor = System.Drawing.Color.White;
            this.btnChangeObj.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeObj.Image")));
            this.btnChangeObj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeObj.Location = new System.Drawing.Point(195, 533);
            this.btnChangeObj.Name = "btnChangeObj";
            this.btnChangeObj.Size = new System.Drawing.Size(200, 51);
            this.btnChangeObj.TabIndex = 29;
            this.btnChangeObj.Text = "       Внести изменения";
            this.btnChangeObj.UseVisualStyleBackColor = false;
            this.btnChangeObj.Click += new System.EventHandler(this.btnChangeObj_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(131, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Внести изменения:";
            // 
            // dgwJobs
            // 
            this.dgwJobs.AllowUserToAddRows = false;
            this.dgwJobs.AllowUserToDeleteRows = false;
            this.dgwJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwJobs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwJobs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwJobs.Location = new System.Drawing.Point(0, 0);
            this.dgwJobs.MultiSelect = false;
            this.dgwJobs.Name = "dgwJobs";
            this.dgwJobs.ReadOnly = true;
            this.dgwJobs.Size = new System.Drawing.Size(838, 654);
            this.dgwJobs.TabIndex = 0;
            this.dgwJobs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwJobs_CellClick);
            // 
            // объектСтроительстваBindingSource2
            // 
            this.объектСтроительстваBindingSource2.DataMember = "ОбъектСтроительства";
            this.объектСтроительстваBindingSource2.DataSource = this._GIPv1_17DataSet3;
            // 
            // задачиBindingSource
            // 
            this.задачиBindingSource.DataMember = "Задачи";
            this.задачиBindingSource.DataSource = this._GIPv1_17DataSet2;
            // 
            // _GIPv1_17DataSet2
            // 
            this._GIPv1_17DataSet2.DataSetName = "_GIPv1_17DataSet2";
            this._GIPv1_17DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // разделПроектаBindingSource
            // 
            this.разделПроектаBindingSource.DataMember = "РазделПроекта";
            this.разделПроектаBindingSource.DataSource = this._GIPv1_5DataSet;
            // 
            // разделПроектаTableAdapter
            // 
            this.разделПроектаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = GIPv1._2._GIPv1_5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.НормативноПравоваяДокументацияTableAdapter = null;
            this.tableAdapterManager.ОбъектСтроительстваTableAdapter = this.объектСтроительстваTableAdapter;
            this.tableAdapterManager.ОтделTableAdapter = this.отделTableAdapter;
            this.tableAdapterManager.ПодписантTableAdapter = null;
            this.tableAdapterManager.Проектно_изыскательские_работы__КомплектTableAdapter = null;
            this.tableAdapterManager.РазделПроектаTableAdapter = this.разделПроектаTableAdapter;
            this.tableAdapterManager.РазрешительныйДокументTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            // 
            // r137BindingSource
            // 
            this.r137BindingSource.DataMember = "R_137";
            this.r137BindingSource.DataSource = this.разделПроектаBindingSource;
            // 
            // нормативноПравоваяДокументацияTableAdapter
            // 
            this.нормативноПравоваяДокументацияTableAdapter.ClearBeforeFill = true;
            // 
            // задачиTableAdapter
            // 
            this.задачиTableAdapter.ClearBeforeFill = true;
            // 
            // задачиTableAdapter1
            // 
            this.задачиTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = GIPv1._2._GIPv1_17DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ЗадачиTableAdapter = this.задачиTableAdapter1;
            this.tableAdapterManager1.НормативноПравоваяДокументацияTableAdapter = null;
            this.tableAdapterManager1.ОбъектСтроительстваTableAdapter = this.объектСтроительстваTableAdapter1;
            this.tableAdapterManager1.ОтделTableAdapter = this.отделTableAdapter1;
            this.tableAdapterManager1.ПодписантTableAdapter = null;
            this.tableAdapterManager1.Проектно_изыскательские_работы__КомплектTableAdapter = null;
            this.tableAdapterManager1.РазрешительныйДокументTableAdapter = null;
            this.tableAdapterManager1.СотрудникиTableAdapter = this.сотрудникиTableAdapter1;
            // 
            // объектСтроительстваTableAdapter1
            // 
            this.объектСтроительстваTableAdapter1.ClearBeforeFill = true;
            // 
            // отделTableAdapter1
            // 
            this.отделTableAdapter1.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter1
            // 
            this.сотрудникиTableAdapter1.ClearBeforeFill = true;
            // 
            // объектСтроительстваTableAdapter2
            // 
            this.объектСтроительстваTableAdapter2.ClearBeforeFill = true;
            // 
            // задачиTableAdapter2
            // 
            this.задачиTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.UpdateOrder = GIPv1._2.GIPvRTM2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager2.ЗадачиTableAdapter = this.задачиTableAdapter2;
            this.tableAdapterManager2.НормативноПравоваяДокументацияTableAdapter = null;
            this.tableAdapterManager2.ОбъектСтроительстваTableAdapter = null;
            this.tableAdapterManager2.ОтделTableAdapter = null;
            this.tableAdapterManager2.ПодписантTableAdapter = null;
            this.tableAdapterManager2.РазрешительныйДокументTableAdapter = null;
            this.tableAdapterManager2.СотрудникиTableAdapter = null;
            this.tableAdapterManager2.ТЭПTableAdapter = null;
            // 
            // UC_Jobs
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "UC_Jobs";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1263, 754);
            this.Load += new System.EventHandler(this.UC_Jobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_17DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_17DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIPvRTM2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_17DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.разделПроектаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r137BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource отделBindingSource;
        private _GIPv1_5DataSet _GIPv1_5DataSet;
        private System.Windows.Forms.BindingSource объектСтроительстваBindingSource;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private _GIPv1_5DataSetTableAdapters.ОбъектСтроительстваTableAdapter объектСтроительстваTableAdapter;
        private _GIPv1_5DataSetTableAdapters.ОтделTableAdapter отделTableAdapter;
        private System.Windows.Forms.BindingSource отделBindingSource1;
        private _GIPv1_5DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAssignJob;
        private System.Windows.Forms.Button btnSaveJobs;
        private System.Windows.Forms.Button btnDelJob;
        private System.Windows.Forms.Button btnNewJob;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbSearshJobs;
        private System.Windows.Forms.ComboBox cbJob;
        private System.Windows.Forms.Label lblSearchJob;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgwJobs;
        private System.Windows.Forms.BindingSource разделПроектаBindingSource;
        private _GIPv1_5DataSetTableAdapters.РазделПроектаTableAdapter разделПроектаTableAdapter;
        private _GIPv1_5DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource r137BindingSource;
        private _GIPv1_5DataSetTableAdapters.НормативноПравоваяДокументацияTableAdapter нормативноПравоваяДокументацияTableAdapter;
        private System.Windows.Forms.BindingSource задачиBindingSource;
        private _GIPv1_17DataSet2 _GIPv1_17DataSet2;
        private _GIPv1_17DataSet2TableAdapters.ЗадачиTableAdapter задачиTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource задачиBindingSource1;
        private _GIPv1_17DataSet _GIPv1_17DataSet;
        private System.Windows.Forms.TextBox tbZadanieJobs;
        private System.Windows.Forms.DateTimePicker dtpStartJobs;
        private System.Windows.Forms.DateTimePicker dtpFinishJobs;
        private System.Windows.Forms.DateTimePicker dtpDLineJobs;
        private System.Windows.Forms.Button btnClearChange;
        private System.Windows.Forms.Button btnChangeObj;
        private System.Windows.Forms.Label label2;
        private _GIPv1_17DataSetTableAdapters.ЗадачиTableAdapter задачиTableAdapter1;
        private _GIPv1_17DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbOtdelJobs;
        private System.Windows.Forms.BindingSource отделBindingSource2;
        private System.Windows.Forms.ComboBox cbSotrudnikJobs;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource1;
        private _GIPv1_17DataSetTableAdapters.ОтделTableAdapter отделTableAdapter1;
        private _GIPv1_17DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter1;
        private System.Windows.Forms.ComboBox cbProjectJobs;
        private System.Windows.Forms.BindingSource объектСтроительстваBindingSource1;
        private _GIPv1_17DataSetTableAdapters.ОбъектСтроительстваTableAdapter объектСтроительстваTableAdapter1;
        private System.Windows.Forms.BindingSource объектСтроительстваBindingSource3;
        private _GIPv1_17DataSet3 _GIPv1_17DataSet3;
        private System.Windows.Forms.BindingSource объектСтроительстваBindingSource2;
        private _GIPv1_17DataSet3TableAdapters.ОбъектСтроительстваTableAdapter объектСтроительстваTableAdapter2;
        private System.Windows.Forms.TextBox tbIDСотрудника;
        private System.Windows.Forms.TextBox tbiDОбъектаСтроительства;
        private System.Windows.Forms.BindingSource задачиBindingSource2;
        private GIPvRTM2DataSet gIPvRTM2DataSet;
        private GIPvRTM2DataSetTableAdapters.ЗадачиTableAdapter задачиTableAdapter2;
        private GIPvRTM2DataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}
