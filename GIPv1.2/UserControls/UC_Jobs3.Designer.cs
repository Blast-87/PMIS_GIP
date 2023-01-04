
namespace GIPv1._2.UserControls
{
    partial class UC_Jobs3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Jobs3));
            System.Windows.Forms.Label iDЗадачиLabel;
            System.Windows.Forms.Label iDОбъектаСтроительстваLabel;
            System.Windows.Forms.Label iDСотрудникаLabel;
            System.Windows.Forms.Label условиеЗадачиLabel;
            System.Windows.Forms.Label датаПостановкиЗадачиLabel;
            System.Windows.Forms.Label датаИсполненияLabel;
            System.Windows.Forms.Label срокИсполненияLabel;
            System.Windows.Forms.Label статусЗадачиLabel;
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._GIPv1_17DataSet = new GIPv1._2._GIPv1_17DataSet();
            this.задачиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.задачиTableAdapter = new GIPv1._2._GIPv1_17DataSetTableAdapters.ЗадачиTableAdapter();
            this.tableAdapterManager = new GIPv1._2._GIPv1_17DataSetTableAdapters.TableAdapterManager();
            this.задачиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.задачиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gIPvRTM2DataSet = new GIPv1._2.GIPvRTM2DataSet();
            this.задачиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.задачиTableAdapter1 = new GIPv1._2.GIPvRTM2DataSetTableAdapters.ЗадачиTableAdapter();
            this.tableAdapterManager1 = new GIPv1._2.GIPvRTM2DataSetTableAdapters.TableAdapterManager();
            this.iDЗадачиTextBox = new System.Windows.Forms.TextBox();
            this.iDОбъектаСтроительстваTextBox = new System.Windows.Forms.TextBox();
            this.iDСотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.условиеЗадачиTextBox = new System.Windows.Forms.TextBox();
            this.датаПостановкиЗадачиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.датаИсполненияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.срокИсполненияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.статусЗадачиTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            iDЗадачиLabel = new System.Windows.Forms.Label();
            iDОбъектаСтроительстваLabel = new System.Windows.Forms.Label();
            iDСотрудникаLabel = new System.Windows.Forms.Label();
            условиеЗадачиLabel = new System.Windows.Forms.Label();
            датаПостановкиЗадачиLabel = new System.Windows.Forms.Label();
            датаИсполненияLabel = new System.Windows.Forms.Label();
            срокИсполненияLabel = new System.Windows.Forms.Label();
            статусЗадачиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_17DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingNavigator)).BeginInit();
            this.задачиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIPvRTM2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Object";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(83, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Otdel";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(83, 94);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 0;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ispolnitel";
            // 
            // _GIPv1_17DataSet
            // 
            this._GIPv1_17DataSet.DataSetName = "_GIPv1_17DataSet";
            this._GIPv1_17DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // задачиBindingSource
            // 
            this.задачиBindingSource.DataMember = "Задачи";
            this.задачиBindingSource.DataSource = this._GIPv1_17DataSet;
            // 
            // задачиTableAdapter
            // 
            this.задачиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = GIPv1._2._GIPv1_17DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗадачиTableAdapter = this.задачиTableAdapter;
            this.tableAdapterManager.НормативноПравоваяДокументацияTableAdapter = null;
            this.tableAdapterManager.ОбъектСтроительстваTableAdapter = null;
            this.tableAdapterManager.ОтделTableAdapter = null;
            this.tableAdapterManager.ПодписантTableAdapter = null;
            this.tableAdapterManager.Проектно_изыскательские_работы__КомплектTableAdapter = null;
            this.tableAdapterManager.РазрешительныйДокументTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // задачиBindingNavigator
            // 
            this.задачиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.задачиBindingNavigator.BindingSource = this.задачиBindingSource;
            this.задачиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.задачиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.задачиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.задачиBindingNavigatorSaveItem});
            this.задачиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.задачиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.задачиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.задачиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.задачиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.задачиBindingNavigator.Name = "задачиBindingNavigator";
            this.задачиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.задачиBindingNavigator.Size = new System.Drawing.Size(1036, 25);
            this.задачиBindingNavigator.TabIndex = 3;
            this.задачиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // задачиBindingNavigatorSaveItem
            // 
            this.задачиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.задачиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("задачиBindingNavigatorSaveItem.Image")));
            this.задачиBindingNavigatorSaveItem.Name = "задачиBindingNavigatorSaveItem";
            this.задачиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.задачиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.задачиBindingNavigatorSaveItem.Click += new System.EventHandler(this.задачиBindingNavigatorSaveItem_Click);
            // 
            // gIPvRTM2DataSet
            // 
            this.gIPvRTM2DataSet.DataSetName = "GIPvRTM2DataSet";
            this.gIPvRTM2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // задачиBindingSource1
            // 
            this.задачиBindingSource1.DataMember = "Задачи";
            this.задачиBindingSource1.DataSource = this.gIPvRTM2DataSet;
            // 
            // задачиTableAdapter1
            // 
            this.задачиTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = GIPv1._2.GIPvRTM2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ЗадачиTableAdapter = this.задачиTableAdapter1;
            this.tableAdapterManager1.НормативноПравоваяДокументацияTableAdapter = null;
            this.tableAdapterManager1.ОбъектСтроительстваTableAdapter = null;
            this.tableAdapterManager1.ОтделTableAdapter = null;
            this.tableAdapterManager1.ПодписантTableAdapter = null;
            this.tableAdapterManager1.РазрешительныйДокументTableAdapter = null;
            this.tableAdapterManager1.СотрудникиTableAdapter = null;
            this.tableAdapterManager1.ТЭПTableAdapter = null;
            // 
            // iDЗадачиLabel
            // 
            iDЗадачиLabel.AutoSize = true;
            iDЗадачиLabel.Location = new System.Drawing.Point(337, 50);
            iDЗадачиLabel.Name = "iDЗадачиLabel";
            iDЗадачиLabel.Size = new System.Drawing.Size(57, 13);
            iDЗадачиLabel.TabIndex = 8;
            iDЗадачиLabel.Text = "IDЗадачи:";
            // 
            // iDЗадачиTextBox
            // 
            this.iDЗадачиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.задачиBindingSource1, "IDЗадачи", true));
            this.iDЗадачиTextBox.Location = new System.Drawing.Point(487, 47);
            this.iDЗадачиTextBox.Name = "iDЗадачиTextBox";
            this.iDЗадачиTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDЗадачиTextBox.TabIndex = 9;
            // 
            // iDОбъектаСтроительстваLabel
            // 
            iDОбъектаСтроительстваLabel.AutoSize = true;
            iDОбъектаСтроительстваLabel.Location = new System.Drawing.Point(337, 76);
            iDОбъектаСтроительстваLabel.Name = "iDОбъектаСтроительстваLabel";
            iDОбъектаСтроительстваLabel.Size = new System.Drawing.Size(144, 13);
            iDОбъектаСтроительстваLabel.TabIndex = 10;
            iDОбъектаСтроительстваLabel.Text = "IDОбъекта Строительства:";
            // 
            // iDОбъектаСтроительстваTextBox
            // 
            this.iDОбъектаСтроительстваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.задачиBindingSource1, "IDОбъектаСтроительства", true));
            this.iDОбъектаСтроительстваTextBox.Location = new System.Drawing.Point(487, 73);
            this.iDОбъектаСтроительстваTextBox.Name = "iDОбъектаСтроительстваTextBox";
            this.iDОбъектаСтроительстваTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDОбъектаСтроительстваTextBox.TabIndex = 11;
            // 
            // iDСотрудникаLabel
            // 
            iDСотрудникаLabel.AutoSize = true;
            iDСотрудникаLabel.Location = new System.Drawing.Point(337, 102);
            iDСотрудникаLabel.Name = "iDСотрудникаLabel";
            iDСотрудникаLabel.Size = new System.Drawing.Size(80, 13);
            iDСотрудникаLabel.TabIndex = 12;
            iDСотрудникаLabel.Text = "IDСотрудника:";
            // 
            // iDСотрудникаTextBox
            // 
            this.iDСотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.задачиBindingSource1, "IDСотрудника", true));
            this.iDСотрудникаTextBox.Location = new System.Drawing.Point(487, 99);
            this.iDСотрудникаTextBox.Name = "iDСотрудникаTextBox";
            this.iDСотрудникаTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDСотрудникаTextBox.TabIndex = 13;
            // 
            // условиеЗадачиLabel
            // 
            условиеЗадачиLabel.AutoSize = true;
            условиеЗадачиLabel.Location = new System.Drawing.Point(337, 128);
            условиеЗадачиLabel.Name = "условиеЗадачиLabel";
            условиеЗадачиLabel.Size = new System.Drawing.Size(93, 13);
            условиеЗадачиLabel.TabIndex = 14;
            условиеЗадачиLabel.Text = "Условие Задачи:";
            // 
            // условиеЗадачиTextBox
            // 
            this.условиеЗадачиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.задачиBindingSource1, "УсловиеЗадачи", true));
            this.условиеЗадачиTextBox.Location = new System.Drawing.Point(487, 125);
            this.условиеЗадачиTextBox.Name = "условиеЗадачиTextBox";
            this.условиеЗадачиTextBox.Size = new System.Drawing.Size(200, 20);
            this.условиеЗадачиTextBox.TabIndex = 15;
            // 
            // датаПостановкиЗадачиLabel
            // 
            датаПостановкиЗадачиLabel.AutoSize = true;
            датаПостановкиЗадачиLabel.Location = new System.Drawing.Point(337, 155);
            датаПостановкиЗадачиLabel.Name = "датаПостановкиЗадачиLabel";
            датаПостановкиЗадачиLabel.Size = new System.Drawing.Size(139, 13);
            датаПостановкиЗадачиLabel.TabIndex = 16;
            датаПостановкиЗадачиLabel.Text = "Дата Постановки Задачи:";
            // 
            // датаПостановкиЗадачиDateTimePicker
            // 
            this.датаПостановкиЗадачиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.задачиBindingSource1, "ДатаПостановкиЗадачи", true));
            this.датаПостановкиЗадачиDateTimePicker.Location = new System.Drawing.Point(487, 151);
            this.датаПостановкиЗадачиDateTimePicker.Name = "датаПостановкиЗадачиDateTimePicker";
            this.датаПостановкиЗадачиDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаПостановкиЗадачиDateTimePicker.TabIndex = 17;
            // 
            // датаИсполненияLabel
            // 
            датаИсполненияLabel.AutoSize = true;
            датаИсполненияLabel.Location = new System.Drawing.Point(337, 181);
            датаИсполненияLabel.Name = "датаИсполненияLabel";
            датаИсполненияLabel.Size = new System.Drawing.Size(101, 13);
            датаИсполненияLabel.TabIndex = 18;
            датаИсполненияLabel.Text = "Дата Исполнения:";
            // 
            // датаИсполненияDateTimePicker
            // 
            this.датаИсполненияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.задачиBindingSource1, "ДатаИсполнения", true));
            this.датаИсполненияDateTimePicker.Location = new System.Drawing.Point(487, 177);
            this.датаИсполненияDateTimePicker.Name = "датаИсполненияDateTimePicker";
            this.датаИсполненияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаИсполненияDateTimePicker.TabIndex = 19;
            // 
            // срокИсполненияLabel
            // 
            срокИсполненияLabel.AutoSize = true;
            срокИсполненияLabel.Location = new System.Drawing.Point(337, 207);
            срокИсполненияLabel.Name = "срокИсполненияLabel";
            срокИсполненияLabel.Size = new System.Drawing.Size(100, 13);
            срокИсполненияLabel.TabIndex = 20;
            срокИсполненияLabel.Text = "Срок Исполнения:";
            // 
            // срокИсполненияDateTimePicker
            // 
            this.срокИсполненияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.задачиBindingSource1, "СрокИсполнения", true));
            this.срокИсполненияDateTimePicker.Location = new System.Drawing.Point(487, 203);
            this.срокИсполненияDateTimePicker.Name = "срокИсполненияDateTimePicker";
            this.срокИсполненияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.срокИсполненияDateTimePicker.TabIndex = 21;
            // 
            // статусЗадачиLabel
            // 
            статусЗадачиLabel.AutoSize = true;
            статусЗадачиLabel.Location = new System.Drawing.Point(337, 232);
            статусЗадачиLabel.Name = "статусЗадачиLabel";
            статусЗадачиLabel.Size = new System.Drawing.Size(83, 13);
            статусЗадачиLabel.TabIndex = 22;
            статусЗадачиLabel.Text = "Статус Задачи:";
            // 
            // статусЗадачиTextBox
            // 
            this.статусЗадачиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.задачиBindingSource1, "СтатусЗадачи", true));
            this.статусЗадачиTextBox.Location = new System.Drawing.Point(487, 229);
            this.статусЗадачиTextBox.Name = "статусЗадачиTextBox";
            this.статусЗадачиTextBox.Size = new System.Drawing.Size(200, 20);
            this.статусЗадачиTextBox.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(811, 302);
            this.dataGridView1.TabIndex = 24;
            // 
            // UC_Jobs3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(iDЗадачиLabel);
            this.Controls.Add(this.iDЗадачиTextBox);
            this.Controls.Add(iDОбъектаСтроительстваLabel);
            this.Controls.Add(this.iDОбъектаСтроительстваTextBox);
            this.Controls.Add(iDСотрудникаLabel);
            this.Controls.Add(this.iDСотрудникаTextBox);
            this.Controls.Add(условиеЗадачиLabel);
            this.Controls.Add(this.условиеЗадачиTextBox);
            this.Controls.Add(датаПостановкиЗадачиLabel);
            this.Controls.Add(this.датаПостановкиЗадачиDateTimePicker);
            this.Controls.Add(датаИсполненияLabel);
            this.Controls.Add(this.датаИсполненияDateTimePicker);
            this.Controls.Add(срокИсполненияLabel);
            this.Controls.Add(this.срокИсполненияDateTimePicker);
            this.Controls.Add(статусЗадачиLabel);
            this.Controls.Add(this.статусЗадачиTextBox);
            this.Controls.Add(this.задачиBindingNavigator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "UC_Jobs3";
            this.Size = new System.Drawing.Size(1036, 654);
            this.Load += new System.EventHandler(this.UC_Jobs3_Load);
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_17DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingNavigator)).EndInit();
            this.задачиBindingNavigator.ResumeLayout(false);
            this.задачиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIPvRTM2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.задачиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private _GIPv1_17DataSet _GIPv1_17DataSet;
        private System.Windows.Forms.BindingSource задачиBindingSource;
        private _GIPv1_17DataSetTableAdapters.ЗадачиTableAdapter задачиTableAdapter;
        private _GIPv1_17DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator задачиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton задачиBindingNavigatorSaveItem;
        private GIPvRTM2DataSet gIPvRTM2DataSet;
        private System.Windows.Forms.BindingSource задачиBindingSource1;
        private GIPvRTM2DataSetTableAdapters.ЗадачиTableAdapter задачиTableAdapter1;
        private GIPvRTM2DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox iDЗадачиTextBox;
        private System.Windows.Forms.TextBox iDОбъектаСтроительстваTextBox;
        private System.Windows.Forms.TextBox iDСотрудникаTextBox;
        private System.Windows.Forms.TextBox условиеЗадачиTextBox;
        private System.Windows.Forms.DateTimePicker датаПостановкиЗадачиDateTimePicker;
        private System.Windows.Forms.DateTimePicker датаИсполненияDateTimePicker;
        private System.Windows.Forms.DateTimePicker срокИсполненияDateTimePicker;
        private System.Windows.Forms.TextBox статусЗадачиTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
