
namespace GIPv1._2.UserControls
{
    partial class UC_Documents
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label наименованиеОбъектаСтроительстваLabel;
            System.Windows.Forms.Label фамилияСотрудникаLabel;
            System.Windows.Forms.Label названиеОтделаLabel;
            System.Windows.Forms.Label iDОбъектаСтроительстваLabel;
            System.Windows.Forms.Label iDСотрудникаLabel;
            System.Windows.Forms.Label условиеЗадачиLabel;
            System.Windows.Forms.Label датаПостановкиЗадачиLabel;
            System.Windows.Forms.Label срокИсполненияLabel;
            System.Windows.Forms.Label датаИсполненияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Documents));
            this.отделTableAdapter1 = new GIPv1._2._GIPv1_17DataSetTableAdapters.ОтделTableAdapter();
            this.tableAdapterManager1 = new GIPv1._2._GIPv1_17DataSetTableAdapters.TableAdapterManager();
            this.задачиTableAdapter1 = new GIPv1._2._GIPv1_17DataSetTableAdapters.ЗадачиTableAdapter();
            this.объектСтроительстваTableAdapter1 = new GIPv1._2._GIPv1_17DataSetTableAdapters.ОбъектСтроительстваTableAdapter();
            this.сотрудникиTableAdapter1 = new GIPv1._2._GIPv1_17DataSetTableAdapters.СотрудникиTableAdapter();
            this.задачиTableAdapter = new GIPv1._2._GIPv1_17DataSet2TableAdapters.ЗадачиTableAdapter();
            this.нормативноПравоваяДокументацияTableAdapter = new GIPv1._2._GIPv1_5DataSetTableAdapters.НормативноПравоваяДокументацияTableAdapter();
            this._GIPv1_5DataSet = new GIPv1._2._GIPv1_5DataSet();
            this.разделПроектаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new GIPv1._2._GIPv1_5DataSetTableAdapters.СотрудникиTableAdapter();
            this.объектСтроительстваTableAdapter = new GIPv1._2._GIPv1_5DataSetTableAdapters.ОбъектСтроительстваTableAdapter();
            this.tableAdapterManager = new GIPv1._2._GIPv1_5DataSetTableAdapters.TableAdapterManager();
            this.отделTableAdapter = new GIPv1._2._GIPv1_5DataSetTableAdapters.ОтделTableAdapter();
            this.разделПроектаTableAdapter = new GIPv1._2._GIPv1_5DataSetTableAdapters.РазделПроектаTableAdapter();
            this._GIPv1_17DataSet2 = new GIPv1._2._GIPv1_17DataSet2();
            this.задачиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.объектСтроительстваBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._GIPv1_17DataSet3 = new GIPv1._2._GIPv1_17DataSet3();
            this.задачиTableAdapter2 = new GIPv1._2.GIPvRTM2DataSetTableAdapters.ЗадачиTableAdapter();
            this.r137BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCount = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelJob = new System.Windows.Forms.Button();
            this.btnNewDoc = new System.Windows.Forms.Button();
            this.dgwDoc = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditSign = new System.Windows.Forms.Button();
            this.отделBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSotrudnikDoc = new System.Windows.Forms.TextBox();
            this.btnSelectObj = new System.Windows.Forms.Button();
            this.btnSelectSign = new System.Windows.Forms.Button();
            this.cbTitlelDoc = new System.Windows.Forms.ComboBox();
            this.отделBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._GIPv1_17DataSet = new GIPv1._2._GIPv1_17DataSet();
            this.cbProjectDoc = new System.Windows.Forms.ComboBox();
            this.объектСтроительстваBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.объектСтроительстваBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.отделBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDocDateControl = new System.Windows.Forms.Label();
            this.tbValidity = new System.Windows.Forms.TextBox();
            this.tbIDDoc = new System.Windows.Forms.TextBox();
            this.tbiDОбъектаСтроительства = new System.Windows.Forms.TextBox();
            this.задачиBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gIPvRTM2DataSet = new GIPv1._2.GIPvRTM2DataSet();
            this.tbIDSignatory = new System.Windows.Forms.TextBox();
            this.задачиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbDocContent = new System.Windows.Forms.TextBox();
            this.dtDateOfIssue = new System.Windows.Forms.DateTimePicker();
            this.dtValidDate = new System.Windows.Forms.DateTimePicker();
            this.btnClearChange = new System.Windows.Forms.Button();
            this.btnChangeObj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableAdapterManager2 = new GIPv1._2.GIPvRTM2DataSetTableAdapters.TableAdapterManager();
            this.объектСтроительстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.объектСтроительстваTableAdapter2 = new GIPv1._2._GIPv1_17DataSet3TableAdapters.ОбъектСтроительстваTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            label1 = new System.Windows.Forms.Label();
            наименованиеОбъектаСтроительстваLabel = new System.Windows.Forms.Label();
            фамилияСотрудникаLabel = new System.Windows.Forms.Label();
            названиеОтделаLabel = new System.Windows.Forms.Label();
            iDОбъектаСтроительстваLabel = new System.Windows.Forms.Label();
            iDСотрудникаLabel = new System.Windows.Forms.Label();
            условиеЗадачиLabel = new System.Windows.Forms.Label();
            датаПостановкиЗадачиLabel = new System.Windows.Forms.Label();
            срокИсполненияLabel = new System.Windows.Forms.Label();
            датаИсполненияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.разделПроектаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_17DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_17DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r137BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDoc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_17DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIPvRTM2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(5, 234);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 19);
            label1.TabIndex = 52;
            label1.Text = "№ документа:";
            // 
            // наименованиеОбъектаСтроительстваLabel
            // 
            наименованиеОбъектаСтроительстваLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            наименованиеОбъектаСтроительстваLabel.AutoSize = true;
            наименованиеОбъектаСтроительстваLabel.Location = new System.Drawing.Point(2, 29);
            наименованиеОбъектаСтроительстваLabel.Name = "наименованиеОбъектаСтроительстваLabel";
            наименованиеОбъектаСтроительстваLabel.Size = new System.Drawing.Size(62, 19);
            наименованиеОбъектаСтроительстваLabel.TabIndex = 49;
            наименованиеОбъектаСтроительстваLabel.Text = "Проект:";
            // 
            // фамилияСотрудникаLabel
            // 
            фамилияСотрудникаLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            фамилияСотрудникаLabel.AutoSize = true;
            фамилияСотрудникаLabel.Location = new System.Drawing.Point(2, 98);
            фамилияСотрудникаLabel.Name = "фамилияСотрудникаLabel";
            фамилияСотрудникаLabel.Size = new System.Drawing.Size(100, 19);
            фамилияСотрудникаLabel.TabIndex = 47;
            фамилияСотрудникаLabel.Text = "Исполнитель:";
            // 
            // названиеОтделаLabel
            // 
            названиеОтделаLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            названиеОтделаLabel.AutoSize = true;
            названиеОтделаLabel.Location = new System.Drawing.Point(2, 62);
            названиеОтделаLabel.Name = "названиеОтделаLabel";
            названиеОтделаLabel.Size = new System.Drawing.Size(89, 19);
            названиеОтделаLabel.TabIndex = 48;
            названиеОтделаLabel.Text = "Должность:";
            // 
            // iDОбъектаСтроительстваLabel
            // 
            iDОбъектаСтроительстваLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iDОбъектаСтроительстваLabel.AutoSize = true;
            iDОбъектаСтроительстваLabel.Location = new System.Drawing.Point(5, 267);
            iDОбъектаСтроительстваLabel.Name = "iDОбъектаСтроительстваLabel";
            iDОбъектаСтроительстваLabel.Size = new System.Drawing.Size(86, 19);
            iDОбъектаСтроительстваLabel.TabIndex = 52;
            iDОбъектаСтроительстваLabel.Text = "№ проекта:";
            // 
            // iDСотрудникаLabel
            // 
            iDСотрудникаLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iDСотрудникаLabel.AutoSize = true;
            iDСотрудникаLabel.Location = new System.Drawing.Point(5, 300);
            iDСотрудникаLabel.Name = "iDСотрудникаLabel";
            iDСотрудникаLabel.Size = new System.Drawing.Size(109, 19);
            iDСотрудникаLabel.TabIndex = 51;
            iDСотрудникаLabel.Text = "№ подписанта:";
            // 
            // условиеЗадачиLabel
            // 
            условиеЗадачиLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            условиеЗадачиLabel.AutoSize = true;
            условиеЗадачиLabel.Location = new System.Drawing.Point(5, 328);
            условиеЗадачиLabel.Name = "условиеЗадачиLabel";
            условиеЗадачиLabel.Size = new System.Drawing.Size(113, 19);
            условиеЗадачиLabel.TabIndex = 37;
            условиеЗадачиLabel.Text = "Наименование:";
            // 
            // датаПостановкиЗадачиLabel
            // 
            датаПостановкиЗадачиLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            датаПостановкиЗадачиLabel.AutoSize = true;
            датаПостановкиЗадачиLabel.Location = new System.Drawing.Point(5, 442);
            датаПостановкиЗадачиLabel.Name = "датаПостановкиЗадачиLabel";
            датаПостановкиЗадачиLabel.Size = new System.Drawing.Size(104, 19);
            датаПостановкиЗадачиLabel.TabIndex = 41;
            датаПостановкиЗадачиLabel.Text = "Дата Выдачи:";
            // 
            // срокИсполненияLabel
            // 
            срокИсполненияLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            срокИсполненияLabel.AutoSize = true;
            срокИсполненияLabel.Location = new System.Drawing.Point(5, 508);
            срокИсполненияLabel.Name = "срокИсполненияLabel";
            срокИсполненияLabel.Size = new System.Drawing.Size(131, 19);
            срокИсполненияLabel.TabIndex = 45;
            срокИсполненияLabel.Text = "Действителен До:";
            // 
            // датаИсполненияLabel
            // 
            датаИсполненияLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            датаИсполненияLabel.AutoSize = true;
            датаИсполненияLabel.Location = new System.Drawing.Point(5, 475);
            датаИсполненияLabel.Name = "датаИсполненияLabel";
            датаИсполненияLabel.Size = new System.Drawing.Size(151, 19);
            датаИсполненияLabel.TabIndex = 43;
            датаИсполненияLabel.Text = "Срок Действия, мес.:";
            // 
            // отделTableAdapter1
            // 
            this.отделTableAdapter1.ClearBeforeFill = true;
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
            // задачиTableAdapter1
            // 
            this.задачиTableAdapter1.ClearBeforeFill = true;
            // 
            // объектСтроительстваTableAdapter1
            // 
            this.объектСтроительстваTableAdapter1.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter1
            // 
            this.сотрудникиTableAdapter1.ClearBeforeFill = true;
            // 
            // задачиTableAdapter
            // 
            this.задачиTableAdapter.ClearBeforeFill = true;
            // 
            // нормативноПравоваяДокументацияTableAdapter
            // 
            this.нормативноПравоваяДокументацияTableAdapter.ClearBeforeFill = true;
            // 
            // _GIPv1_5DataSet
            // 
            this._GIPv1_5DataSet.DataSetName = "_GIPv1_5DataSet";
            this._GIPv1_5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // разделПроектаBindingSource
            // 
            this.разделПроектаBindingSource.DataMember = "РазделПроекта";
            this.разделПроектаBindingSource.DataSource = this._GIPv1_5DataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ОтделTableAdapter = this.отделTableAdapter;
            this.tableAdapterManager.ПодписантTableAdapter = null;
            this.tableAdapterManager.Проектно_изыскательские_работы__КомплектTableAdapter = null;
            this.tableAdapterManager.РазделПроектаTableAdapter = this.разделПроектаTableAdapter;
            this.tableAdapterManager.РазрешительныйДокументTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            // 
            // отделTableAdapter
            // 
            this.отделTableAdapter.ClearBeforeFill = true;
            // 
            // разделПроектаTableAdapter
            // 
            this.разделПроектаTableAdapter.ClearBeforeFill = true;
            // 
            // _GIPv1_17DataSet2
            // 
            this._GIPv1_17DataSet2.DataSetName = "_GIPv1_17DataSet2";
            this._GIPv1_17DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // задачиBindingSource
            // 
            this.задачиBindingSource.DataMember = "Задачи";
            this.задачиBindingSource.DataSource = this._GIPv1_17DataSet2;
            // 
            // объектСтроительстваBindingSource2
            // 
            this.объектСтроительстваBindingSource2.DataMember = "ОбъектСтроительства";
            this.объектСтроительстваBindingSource2.DataSource = this._GIPv1_17DataSet3;
            // 
            // _GIPv1_17DataSet3
            // 
            this._GIPv1_17DataSet3.DataSetName = "_GIPv1_17DataSet3";
            this._GIPv1_17DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // задачиTableAdapter2
            // 
            this.задачиTableAdapter2.ClearBeforeFill = true;
            // 
            // r137BindingSource
            // 
            this.r137BindingSource.DataMember = "R_137";
            this.r137BindingSource.DataSource = this.разделПроектаBindingSource;
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
            this.btnRefresh.Location = new System.Drawing.Point(807, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 34);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.btnDelJob.Text = "Удалить документ";
            this.btnDelJob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelJob.UseVisualStyleBackColor = true;
            this.btnDelJob.Click += new System.EventHandler(this.btnDelJob_Click);
            // 
            // btnNewDoc
            // 
            this.btnNewDoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewDoc.FlatAppearance.BorderSize = 0;
            this.btnNewDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDoc.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewDoc.ForeColor = System.Drawing.Color.White;
            this.btnNewDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnNewDoc.Image")));
            this.btnNewDoc.Location = new System.Drawing.Point(0, 0);
            this.btnNewDoc.Name = "btnNewDoc";
            this.btnNewDoc.Size = new System.Drawing.Size(175, 60);
            this.btnNewDoc.TabIndex = 9;
            this.btnNewDoc.Text = "  Добавить документ\r\n";
            this.btnNewDoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewDoc.UseVisualStyleBackColor = true;
            this.btnNewDoc.Click += new System.EventHandler(this.btnNewDoc_Click);
            // 
            // dgwDoc
            // 
            this.dgwDoc.AllowUserToAddRows = false;
            this.dgwDoc.AllowUserToDeleteRows = false;
            this.dgwDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDoc.Location = new System.Drawing.Point(0, 66);
            this.dgwDoc.MultiSelect = false;
            this.dgwDoc.Name = "dgwDoc";
            this.dgwDoc.ReadOnly = true;
            this.dgwDoc.Size = new System.Drawing.Size(838, 742);
            this.dgwDoc.TabIndex = 0;
            this.dgwDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDoc_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btnEditSign);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnDelJob);
            this.panel1.Controls.Add(this.btnNewDoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 60);
            this.panel1.TabIndex = 10;
            // 
            // btnEditSign
            // 
            this.btnEditSign.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEditSign.FlatAppearance.BorderSize = 0;
            this.btnEditSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSign.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditSign.ForeColor = System.Drawing.Color.White;
            this.btnEditSign.Image = ((System.Drawing.Image)(resources.GetObject("btnEditSign.Image")));
            this.btnEditSign.Location = new System.Drawing.Point(296, 0);
            this.btnEditSign.Name = "btnEditSign";
            this.btnEditSign.Size = new System.Drawing.Size(175, 60);
            this.btnEditSign.TabIndex = 12;
            this.btnEditSign.Text = "Редактор подписантов";
            this.btnEditSign.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditSign.UseVisualStyleBackColor = true;
            this.btnEditSign.Click += new System.EventHandler(this.btnEditSign_Click);
            // 
            // отделBindingSource1
            // 
            this.отделBindingSource1.DataMember = "Отдел";
            this.отделBindingSource1.DataSource = this._GIPv1_5DataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbSotrudnikDoc);
            this.groupBox1.Controls.Add(this.btnSelectObj);
            this.groupBox1.Controls.Add(this.btnSelectSign);
            this.groupBox1.Controls.Add(наименованиеОбъектаСтроительстваLabel);
            this.groupBox1.Controls.Add(фамилияСотрудникаLabel);
            this.groupBox1.Controls.Add(this.cbTitlelDoc);
            this.groupBox1.Controls.Add(названиеОтделаLabel);
            this.groupBox1.Controls.Add(this.cbProjectDoc);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 185);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбрать данные из таблицы";
            // 
            // tbSotrudnikDoc
            // 
            this.tbSotrudnikDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSotrudnikDoc.Enabled = false;
            this.tbSotrudnikDoc.Location = new System.Drawing.Point(192, 92);
            this.tbSotrudnikDoc.Name = "tbSotrudnikDoc";
            this.tbSotrudnikDoc.Size = new System.Drawing.Size(200, 27);
            this.tbSotrudnikDoc.TabIndex = 53;
            // 
            // btnSelectObj
            // 
            this.btnSelectObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectObj.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSelectObj.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectObj.ForeColor = System.Drawing.Color.White;
            this.btnSelectObj.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectObj.Image")));
            this.btnSelectObj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectObj.Location = new System.Drawing.Point(6, 128);
            this.btnSelectObj.Name = "btnSelectObj";
            this.btnSelectObj.Size = new System.Drawing.Size(180, 51);
            this.btnSelectObj.TabIndex = 52;
            this.btnSelectObj.Text = "Выбрать данные по объекту";
            this.btnSelectObj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectObj.UseVisualStyleBackColor = false;
            this.btnSelectObj.Click += new System.EventHandler(this.btnSelectObj_Click);
            // 
            // btnSelectSign
            // 
            this.btnSelectSign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectSign.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSelectSign.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectSign.ForeColor = System.Drawing.Color.White;
            this.btnSelectSign.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectSign.Image")));
            this.btnSelectSign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectSign.Location = new System.Drawing.Point(212, 128);
            this.btnSelectSign.Name = "btnSelectSign";
            this.btnSelectSign.Size = new System.Drawing.Size(180, 51);
            this.btnSelectSign.TabIndex = 52;
            this.btnSelectSign.Text = "       Выбрать данные по           подписанту /объекту";
            this.btnSelectSign.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectSign.UseVisualStyleBackColor = false;
            this.btnSelectSign.Click += new System.EventHandler(this.btnSelectSign_Click);
            // 
            // cbTitlelDoc
            // 
            this.cbTitlelDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTitlelDoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделBindingSource2, "НазваниеОтдела", true));
            this.cbTitlelDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTitlelDoc.FormattingEnabled = true;
            this.cbTitlelDoc.Location = new System.Drawing.Point(192, 59);
            this.cbTitlelDoc.Name = "cbTitlelDoc";
            this.cbTitlelDoc.Size = new System.Drawing.Size(200, 27);
            this.cbTitlelDoc.TabIndex = 49;
            // 
            // отделBindingSource2
            // 
            this.отделBindingSource2.DataMember = "Отдел";
            this.отделBindingSource2.DataSource = this._GIPv1_17DataSet;
            // 
            // _GIPv1_17DataSet
            // 
            this._GIPv1_17DataSet.DataSetName = "_GIPv1_17DataSet";
            this._GIPv1_17DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbProjectDoc
            // 
            this.cbProjectDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProjectDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cbProjectDoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.объектСтроительстваBindingSource1, "НаименованиеОбъектаСтроительства", true));
            this.cbProjectDoc.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.объектСтроительстваBindingSource3, "IDОбъектаСтроительства", true));
            this.cbProjectDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjectDoc.FormattingEnabled = true;
            this.cbProjectDoc.Location = new System.Drawing.Point(192, 26);
            this.cbProjectDoc.Name = "cbProjectDoc";
            this.cbProjectDoc.Size = new System.Drawing.Size(200, 27);
            this.cbProjectDoc.TabIndex = 50;
            this.cbProjectDoc.SelectedIndexChanged += new System.EventHandler(this.cbProjectDoc_SelectedIndexChanged);
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
            // сотрудникиBindingSource1
            // 
            this.сотрудникиBindingSource1.DataMember = "Сотрудники";
            this.сотрудникиBindingSource1.DataSource = this._GIPv1_17DataSet;
            // 
            // отделBindingSource
            // 
            this.отделBindingSource.DataMember = "Отдел";
            this.отделBindingSource.DataSource = this._GIPv1_5DataSet;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this._GIPv1_5DataSet;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dgwDoc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1253, 814);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.lblDocDateControl);
            this.panel4.Controls.Add(this.tbValidity);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(label1);
            this.panel4.Controls.Add(iDОбъектаСтроительстваLabel);
            this.panel4.Controls.Add(this.tbIDDoc);
            this.panel4.Controls.Add(this.tbiDОбъектаСтроительства);
            this.panel4.Controls.Add(iDСотрудникаLabel);
            this.panel4.Controls.Add(this.tbIDSignatory);
            this.panel4.Controls.Add(условиеЗадачиLabel);
            this.panel4.Controls.Add(this.tbDocContent);
            this.panel4.Controls.Add(датаПостановкиЗадачиLabel);
            this.panel4.Controls.Add(this.dtDateOfIssue);
            this.panel4.Controls.Add(датаИсполненияLabel);
            this.panel4.Controls.Add(срокИсполненияLabel);
            this.panel4.Controls.Add(this.dtValidDate);
            this.panel4.Controls.Add(this.btnClearChange);
            this.panel4.Controls.Add(this.btnChangeObj);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(844, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(522, 742);
            this.panel4.TabIndex = 17;
            // 
            // lblDocDateControl
            // 
            this.lblDocDateControl.AutoSize = true;
            this.lblDocDateControl.ForeColor = System.Drawing.Color.Red;
            this.lblDocDateControl.Location = new System.Drawing.Point(211, 532);
            this.lblDocDateControl.Name = "lblDocDateControl";
            this.lblDocDateControl.Size = new System.Drawing.Size(155, 19);
            this.lblDocDateControl.TabIndex = 56;
            this.lblDocDateControl.Text = "Документ просрочен!";
            // 
            // tbValidity
            // 
            this.tbValidity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValidity.Location = new System.Drawing.Point(195, 470);
            this.tbValidity.Name = "tbValidity";
            this.tbValidity.Size = new System.Drawing.Size(200, 27);
            this.tbValidity.TabIndex = 55;
            // 
            // tbIDDoc
            // 
            this.tbIDDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIDDoc.Enabled = false;
            this.tbIDDoc.Location = new System.Drawing.Point(195, 226);
            this.tbIDDoc.Name = "tbIDDoc";
            this.tbIDDoc.Size = new System.Drawing.Size(200, 27);
            this.tbIDDoc.TabIndex = 53;
            // 
            // tbiDОбъектаСтроительства
            // 
            this.tbiDОбъектаСтроительства.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbiDОбъектаСтроительства.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.задачиBindingSource2, "IDОбъектаСтроительства", true));
            this.tbiDОбъектаСтроительства.Enabled = false;
            this.tbiDОбъектаСтроительства.Location = new System.Drawing.Point(195, 259);
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
            // tbIDSignatory
            // 
            this.tbIDSignatory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIDSignatory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.задачиBindingSource1, "IDСотрудника", true));
            this.tbIDSignatory.Enabled = false;
            this.tbIDSignatory.Location = new System.Drawing.Point(195, 292);
            this.tbIDSignatory.Name = "tbIDSignatory";
            this.tbIDSignatory.Size = new System.Drawing.Size(200, 27);
            this.tbIDSignatory.TabIndex = 52;
            // 
            // задачиBindingSource1
            // 
            this.задачиBindingSource1.DataMember = "Задачи";
            this.задачиBindingSource1.DataSource = this._GIPv1_17DataSet;
            // 
            // tbDocContent
            // 
            this.tbDocContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDocContent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.задачиBindingSource1, "УсловиеЗадачи", true));
            this.tbDocContent.Enabled = false;
            this.tbDocContent.Location = new System.Drawing.Point(195, 325);
            this.tbDocContent.Multiline = true;
            this.tbDocContent.Name = "tbDocContent";
            this.tbDocContent.Size = new System.Drawing.Size(200, 105);
            this.tbDocContent.TabIndex = 38;
            // 
            // dtDateOfIssue
            // 
            this.dtDateOfIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDateOfIssue.CustomFormat = "dd-mmmmm-yyyy";
            this.dtDateOfIssue.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.задачиBindingSource1, "ДатаПостановкиЗадачи", true));
            this.dtDateOfIssue.Location = new System.Drawing.Point(195, 436);
            this.dtDateOfIssue.Name = "dtDateOfIssue";
            this.dtDateOfIssue.Size = new System.Drawing.Size(200, 27);
            this.dtDateOfIssue.TabIndex = 42;
            // 
            // dtValidDate
            // 
            this.dtValidDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtValidDate.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.dtValidDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.задачиBindingSource1, "СрокИсполнения", true));
            this.dtValidDate.Location = new System.Drawing.Point(195, 502);
            this.dtValidDate.Name = "dtValidDate";
            this.dtValidDate.Size = new System.Drawing.Size(200, 27);
            this.dtValidDate.TabIndex = 46;
            // 
            // btnClearChange
            // 
            this.btnClearChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearChange.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnClearChange.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearChange.ForeColor = System.Drawing.Color.White;
            this.btnClearChange.Image = ((System.Drawing.Image)(resources.GetObject("btnClearChange.Image")));
            this.btnClearChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearChange.Location = new System.Drawing.Point(195, 629);
            this.btnClearChange.Name = "btnClearChange";
            this.btnClearChange.Size = new System.Drawing.Size(200, 51);
            this.btnClearChange.TabIndex = 31;
            this.btnClearChange.Text = "       Очистить строки";
            this.btnClearChange.UseVisualStyleBackColor = false;
            this.btnClearChange.Click += new System.EventHandler(this.btnClearChange_Click);
            // 
            // btnChangeObj
            // 
            this.btnChangeObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeObj.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChangeObj.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeObj.ForeColor = System.Drawing.Color.White;
            this.btnChangeObj.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeObj.Image")));
            this.btnChangeObj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeObj.Location = new System.Drawing.Point(195, 572);
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
            this.label2.Location = new System.Drawing.Point(5, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Внести изменения (выделите строку в таблице):";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.lblCount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 819);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1253, 30);
            this.panel2.TabIndex = 11;
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
            // объектСтроительстваBindingSource
            // 
            this.объектСтроительстваBindingSource.DataMember = "ОбъектСтроительства";
            this.объектСтроительстваBindingSource.DataSource = this._GIPv1_5DataSet;
            // 
            // объектСтроительстваTableAdapter2
            // 
            this.объектСтроительстваTableAdapter2.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // UC_Documents
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "UC_Documents";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1263, 854);
            this.Load += new System.EventHandler(this.UC_Documents_Load);
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.разделПроектаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_17DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_17DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r137BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDoc)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_17DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIPvRTM2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _GIPv1_17DataSetTableAdapters.ОтделTableAdapter отделTableAdapter1;
        private _GIPv1_17DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private _GIPv1_17DataSetTableAdapters.ЗадачиTableAdapter задачиTableAdapter1;
        private _GIPv1_17DataSetTableAdapters.ОбъектСтроительстваTableAdapter объектСтроительстваTableAdapter1;
        private _GIPv1_17DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter1;
        private _GIPv1_17DataSet2TableAdapters.ЗадачиTableAdapter задачиTableAdapter;
        private _GIPv1_5DataSetTableAdapters.НормативноПравоваяДокументацияTableAdapter нормативноПравоваяДокументацияTableAdapter;
        private _GIPv1_5DataSet _GIPv1_5DataSet;
        private System.Windows.Forms.BindingSource разделПроектаBindingSource;
        private _GIPv1_5DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private _GIPv1_5DataSetTableAdapters.ОбъектСтроительстваTableAdapter объектСтроительстваTableAdapter;
        private _GIPv1_5DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _GIPv1_5DataSetTableAdapters.ОтделTableAdapter отделTableAdapter;
        private _GIPv1_5DataSetTableAdapters.РазделПроектаTableAdapter разделПроектаTableAdapter;
        private _GIPv1_17DataSet2 _GIPv1_17DataSet2;
        private System.Windows.Forms.BindingSource задачиBindingSource;
        private System.Windows.Forms.BindingSource объектСтроительстваBindingSource2;
        private _GIPv1_17DataSet3 _GIPv1_17DataSet3;
        private GIPvRTM2DataSetTableAdapters.ЗадачиTableAdapter задачиTableAdapter2;
        private System.Windows.Forms.BindingSource r137BindingSource;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelJob;
        private System.Windows.Forms.Button btnNewDoc;
        private System.Windows.Forms.DataGridView dgwDoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource отделBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource1;
        private _GIPv1_17DataSet _GIPv1_17DataSet;
        private System.Windows.Forms.ComboBox cbTitlelDoc;
        private System.Windows.Forms.BindingSource отделBindingSource2;
        private System.Windows.Forms.ComboBox cbProjectDoc;
        private System.Windows.Forms.BindingSource объектСтроительстваBindingSource1;
        private System.Windows.Forms.BindingSource объектСтроительстваBindingSource3;
        private System.Windows.Forms.BindingSource отделBindingSource;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbIDDoc;
        private System.Windows.Forms.TextBox tbiDОбъектаСтроительства;
        private System.Windows.Forms.BindingSource задачиBindingSource2;
        private GIPvRTM2DataSet gIPvRTM2DataSet;
        private System.Windows.Forms.TextBox tbIDSignatory;
        private System.Windows.Forms.BindingSource задачиBindingSource1;
        private System.Windows.Forms.TextBox tbDocContent;
        private System.Windows.Forms.DateTimePicker dtDateOfIssue;
        private System.Windows.Forms.DateTimePicker dtValidDate;
        private System.Windows.Forms.Button btnClearChange;
        private System.Windows.Forms.Button btnChangeObj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private GIPvRTM2DataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.BindingSource объектСтроительстваBindingSource;
        private _GIPv1_17DataSet3TableAdapters.ОбъектСтроительстваTableAdapter объектСтроительстваTableAdapter2;
        private System.Windows.Forms.TextBox tbSotrudnikDoc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox tbValidity;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.Button btnSelectObj;
        private System.Windows.Forms.Button btnSelectSign;
        private System.Windows.Forms.Label lblDocDateControl;
        private System.Windows.Forms.Button btnEditSign;
    }
}
