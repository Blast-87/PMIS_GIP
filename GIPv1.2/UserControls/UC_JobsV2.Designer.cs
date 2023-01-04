
namespace GIPv1._2.UserControls
{
    partial class UC_JobsV2
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
            System.Windows.Forms.Label iDСотрудникаLabel;
            System.Windows.Forms.Label условиеЗадачиLabel;
            System.Windows.Forms.Label статусЗадачиLabel;
            System.Windows.Forms.Label датаПостановкиЗадачиLabel;
            System.Windows.Forms.Label датаИсполненияLabel;
            System.Windows.Forms.Label срокИсполненияLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.lblSotrudJobs2 = new System.Windows.Forms.Label();
            this.lblOtdelJobs2 = new System.Windows.Forms.Label();
            this.lblObjJobs2 = new System.Windows.Forms.Label();
            this.cbSotrudJobs2 = new System.Windows.Forms.ComboBox();
            this.cbOtdelJobs2 = new System.Windows.Forms.ComboBox();
            this.cbObjektlJobs2 = new System.Windows.Forms.ComboBox();
            this.panelDGV = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.объектСтроительстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._GIPv1_17DataSet3 = new GIPv1._2._GIPv1_17DataSet3();
            this.panel3 = new System.Windows.Forms.Panel();
            this.объектСтроительстваTableAdapter = new GIPv1._2._GIPv1_17DataSet3TableAdapters.ОбъектСтроительстваTableAdapter();
            this.tableAdapterManager = new GIPv1._2._GIPv1_17DataSet3TableAdapters.TableAdapterManager();
            this.tbiDОбъектаСтроительства = new System.Windows.Forms.TextBox();
            this.tbIDСотрудника = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbZadanieJobs = new System.Windows.Forms.TextBox();
            this.dtpStartJobs = new System.Windows.Forms.DateTimePicker();
            this.dtpFinishJobs = new System.Windows.Forms.DateTimePicker();
            this.dtpDLineJobs = new System.Windows.Forms.DateTimePicker();
            iDОбъектаСтроительстваLabel = new System.Windows.Forms.Label();
            iDСотрудникаLabel = new System.Windows.Forms.Label();
            условиеЗадачиLabel = new System.Windows.Forms.Label();
            статусЗадачиLabel = new System.Windows.Forms.Label();
            датаПостановкиЗадачиLabel = new System.Windows.Forms.Label();
            датаИсполненияLabel = new System.Windows.Forms.Label();
            срокИсполненияLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_17DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 60);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelMiddle);
            this.panel2.Controls.Add(this.panelData);
            this.panel2.Controls.Add(this.panelDGV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 674);
            this.panel2.TabIndex = 1;
            // 
            // panelMiddle
            // 
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(600, 0);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(6, 674);
            this.panelMiddle.TabIndex = 2;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(iDОбъектаСтроительстваLabel);
            this.panelData.Controls.Add(this.tbiDОбъектаСтроительства);
            this.panelData.Controls.Add(iDСотрудникаLabel);
            this.panelData.Controls.Add(this.tbIDСотрудника);
            this.panelData.Controls.Add(this.cbStatus);
            this.panelData.Controls.Add(условиеЗадачиLabel);
            this.panelData.Controls.Add(this.tbZadanieJobs);
            this.panelData.Controls.Add(статусЗадачиLabel);
            this.panelData.Controls.Add(датаПостановкиЗадачиLabel);
            this.panelData.Controls.Add(this.dtpStartJobs);
            this.panelData.Controls.Add(датаИсполненияLabel);
            this.panelData.Controls.Add(this.dtpFinishJobs);
            this.panelData.Controls.Add(срокИсполненияLabel);
            this.panelData.Controls.Add(this.dtpDLineJobs);
            this.panelData.Controls.Add(this.lblSotrudJobs2);
            this.panelData.Controls.Add(this.lblOtdelJobs2);
            this.panelData.Controls.Add(this.lblObjJobs2);
            this.panelData.Controls.Add(this.cbSotrudJobs2);
            this.panelData.Controls.Add(this.cbOtdelJobs2);
            this.panelData.Controls.Add(this.cbObjektlJobs2);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelData.Location = new System.Drawing.Point(606, 0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(398, 674);
            this.panelData.TabIndex = 1;
            // 
            // lblSotrudJobs2
            // 
            this.lblSotrudJobs2.AutoSize = true;
            this.lblSotrudJobs2.Location = new System.Drawing.Point(56, 102);
            this.lblSotrudJobs2.Name = "lblSotrudJobs2";
            this.lblSotrudJobs2.Size = new System.Drawing.Size(81, 19);
            this.lblSotrudJobs2.TabIndex = 1;
            this.lblSotrudJobs2.Text = "Сотрудник";
            // 
            // lblOtdelJobs2
            // 
            this.lblOtdelJobs2.AutoSize = true;
            this.lblOtdelJobs2.Location = new System.Drawing.Point(56, 69);
            this.lblOtdelJobs2.Name = "lblOtdelJobs2";
            this.lblOtdelJobs2.Size = new System.Drawing.Size(50, 19);
            this.lblOtdelJobs2.TabIndex = 1;
            this.lblOtdelJobs2.Text = "Отдел";
            // 
            // lblObjJobs2
            // 
            this.lblObjJobs2.AutoSize = true;
            this.lblObjJobs2.Location = new System.Drawing.Point(56, 36);
            this.lblObjJobs2.Name = "lblObjJobs2";
            this.lblObjJobs2.Size = new System.Drawing.Size(59, 19);
            this.lblObjJobs2.TabIndex = 1;
            this.lblObjJobs2.Text = "Объект";
            // 
            // cbSotrudJobs2
            // 
            this.cbSotrudJobs2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSotrudJobs2.FormattingEnabled = true;
            this.cbSotrudJobs2.Location = new System.Drawing.Point(167, 99);
            this.cbSotrudJobs2.Name = "cbSotrudJobs2";
            this.cbSotrudJobs2.Size = new System.Drawing.Size(217, 27);
            this.cbSotrudJobs2.TabIndex = 0;
            // 
            // cbOtdelJobs2
            // 
            this.cbOtdelJobs2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOtdelJobs2.FormattingEnabled = true;
            this.cbOtdelJobs2.Location = new System.Drawing.Point(167, 66);
            this.cbOtdelJobs2.Name = "cbOtdelJobs2";
            this.cbOtdelJobs2.Size = new System.Drawing.Size(217, 27);
            this.cbOtdelJobs2.TabIndex = 0;
            // 
            // cbObjektlJobs2
            // 
            this.cbObjektlJobs2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObjektlJobs2.FormattingEnabled = true;
            this.cbObjektlJobs2.Location = new System.Drawing.Point(167, 33);
            this.cbObjektlJobs2.Name = "cbObjektlJobs2";
            this.cbObjektlJobs2.Size = new System.Drawing.Size(217, 27);
            this.cbObjektlJobs2.TabIndex = 0;
            // 
            // panelDGV
            // 
            this.panelDGV.Controls.Add(this.dataGridView1);
            this.panelDGV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDGV.Location = new System.Drawing.Point(0, 0);
            this.panelDGV.Name = "panelDGV";
            this.panelDGV.Size = new System.Drawing.Size(600, 674);
            this.panelDGV.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 674);
            this.dataGridView1.TabIndex = 0;
            // 
            // объектСтроительстваBindingSource
            // 
            this.объектСтроительстваBindingSource.DataMember = "ОбъектСтроительства";
            this.объектСтроительстваBindingSource.DataSource = this._GIPv1_17DataSet3;
            // 
            // _GIPv1_17DataSet3
            // 
            this._GIPv1_17DataSet3.DataSetName = "_GIPv1_17DataSet3";
            this._GIPv1_17DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 709);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1004, 30);
            this.panel3.TabIndex = 2;
            // 
            // объектСтроительстваTableAdapter
            // 
            this.объектСтроительстваTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = GIPv1._2._GIPv1_17DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗадачиTableAdapter = null;
            this.tableAdapterManager.НормативноПравоваяДокументацияTableAdapter = null;
            this.tableAdapterManager.ОбъектСтроительстваTableAdapter = this.объектСтроительстваTableAdapter;
            this.tableAdapterManager.ОтделTableAdapter = null;
            this.tableAdapterManager.ПодписантTableAdapter = null;
            this.tableAdapterManager.Проектно_изыскательские_работы__КомплектTableAdapter = null;
            this.tableAdapterManager.РазрешительныйДокументTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // iDОбъектаСтроительстваLabel
            // 
            iDОбъектаСтроительстваLabel.AutoSize = true;
            iDОбъектаСтроительстваLabel.Location = new System.Drawing.Point(4, 143);
            iDОбъектаСтроительстваLabel.Name = "iDОбъектаСтроительстваLabel";
            iDОбъектаСтроительстваLabel.Size = new System.Drawing.Size(86, 19);
            iDОбъектаСтроительстваLabel.TabIndex = 65;
            iDОбъектаСтроительстваLabel.Text = "№ проекта:";
            // 
            // tbiDОбъектаСтроительства
            // 
            this.tbiDОбъектаСтроительства.Location = new System.Drawing.Point(194, 140);
            this.tbiDОбъектаСтроительства.Name = "tbiDОбъектаСтроительства";
            this.tbiDОбъектаСтроительства.Size = new System.Drawing.Size(200, 27);
            this.tbiDОбъектаСтроительства.TabIndex = 67;
            // 
            // iDСотрудникаLabel
            // 
            iDСотрудникаLabel.AutoSize = true;
            iDСотрудникаLabel.Location = new System.Drawing.Point(5, 237);
            iDСотрудникаLabel.Name = "iDСотрудникаLabel";
            iDСотрудникаLabel.Size = new System.Drawing.Size(105, 19);
            iDСотрудникаLabel.TabIndex = 64;
            iDСотрудникаLabel.Text = "Табельный №:";
            // 
            // tbIDСотрудника
            // 
            this.tbIDСотрудника.Location = new System.Drawing.Point(194, 235);
            this.tbIDСотрудника.Name = "tbIDСотрудника";
            this.tbIDСотрудника.Size = new System.Drawing.Size(200, 27);
            this.tbIDСотрудника.TabIndex = 66;
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "В работе",
            "Утверждено"});
            this.cbStatus.Location = new System.Drawing.Point(194, 507);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(200, 27);
            this.cbStatus.TabIndex = 63;
            // 
            // условиеЗадачиLabel
            // 
            условиеЗадачиLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            условиеЗадачиLabel.AutoSize = true;
            условиеЗадачиLabel.Location = new System.Drawing.Point(4, 270);
            условиеЗадачиLabel.Name = "условиеЗадачиLabel";
            условиеЗадачиLabel.Size = new System.Drawing.Size(121, 19);
            условиеЗадачиLabel.TabIndex = 54;
            условиеЗадачиLabel.Text = "Условие Задачи:";
            // 
            // tbZadanieJobs
            // 
            this.tbZadanieJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbZadanieJobs.Location = new System.Drawing.Point(194, 267);
            this.tbZadanieJobs.Multiline = true;
            this.tbZadanieJobs.Name = "tbZadanieJobs";
            this.tbZadanieJobs.Size = new System.Drawing.Size(200, 135);
            this.tbZadanieJobs.TabIndex = 55;
            // 
            // статусЗадачиLabel
            // 
            статусЗадачиLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            статусЗадачиLabel.AutoSize = true;
            статусЗадачиLabel.Location = new System.Drawing.Point(4, 515);
            статусЗадачиLabel.Name = "статусЗадачиLabel";
            статусЗадачиLabel.Size = new System.Drawing.Size(111, 19);
            статусЗадачиLabel.TabIndex = 56;
            статусЗадачиLabel.Text = "Статус Задачи:";
            // 
            // датаПостановкиЗадачиLabel
            // 
            датаПостановкиЗадачиLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            датаПостановкиЗадачиLabel.AutoSize = true;
            датаПостановкиЗадачиLabel.Location = new System.Drawing.Point(4, 412);
            датаПостановкиЗадачиLabel.Name = "датаПостановкиЗадачиLabel";
            датаПостановкиЗадачиLabel.Size = new System.Drawing.Size(184, 19);
            датаПостановкиЗадачиLabel.TabIndex = 57;
            датаПостановкиЗадачиLabel.Text = "Дата Постановки Задачи:";
            // 
            // dtpStartJobs
            // 
            this.dtpStartJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartJobs.Location = new System.Drawing.Point(194, 408);
            this.dtpStartJobs.Name = "dtpStartJobs";
            this.dtpStartJobs.Size = new System.Drawing.Size(200, 27);
            this.dtpStartJobs.TabIndex = 58;
            // 
            // датаИсполненияLabel
            // 
            датаИсполненияLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            датаИсполненияLabel.AutoSize = true;
            датаИсполненияLabel.Location = new System.Drawing.Point(4, 445);
            датаИсполненияLabel.Name = "датаИсполненияLabel";
            датаИсполненияLabel.Size = new System.Drawing.Size(132, 19);
            датаИсполненияLabel.TabIndex = 59;
            датаИсполненияLabel.Text = "Дата Исполнения:";
            // 
            // dtpFinishJobs
            // 
            this.dtpFinishJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFinishJobs.Location = new System.Drawing.Point(194, 441);
            this.dtpFinishJobs.Name = "dtpFinishJobs";
            this.dtpFinishJobs.Size = new System.Drawing.Size(200, 27);
            this.dtpFinishJobs.TabIndex = 60;
            // 
            // срокИсполненияLabel
            // 
            срокИсполненияLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            срокИсполненияLabel.AutoSize = true;
            срокИсполненияLabel.Location = new System.Drawing.Point(4, 478);
            срокИсполненияLabel.Name = "срокИсполненияLabel";
            срокИсполненияLabel.Size = new System.Drawing.Size(131, 19);
            срокИсполненияLabel.TabIndex = 61;
            срокИсполненияLabel.Text = "Срок Исполнения:";
            // 
            // dtpDLineJobs
            // 
            this.dtpDLineJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDLineJobs.Location = new System.Drawing.Point(194, 474);
            this.dtpDLineJobs.Name = "dtpDLineJobs";
            this.dtpDLineJobs.Size = new System.Drawing.Size(200, 27);
            this.dtpDLineJobs.TabIndex = 62;
            // 
            // UC_JobsV2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "UC_JobsV2";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1014, 744);
            this.Load += new System.EventHandler(this.UC_JobsV2_Load);
            this.panel2.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.panelDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_17DataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Panel panelDGV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _GIPv1_17DataSet3 _GIPv1_17DataSet3;
        private System.Windows.Forms.BindingSource объектСтроительстваBindingSource;
        private _GIPv1_17DataSet3TableAdapters.ОбъектСтроительстваTableAdapter объектСтроительстваTableAdapter;
        private _GIPv1_17DataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label lblSotrudJobs2;
        private System.Windows.Forms.Label lblOtdelJobs2;
        private System.Windows.Forms.Label lblObjJobs2;
        private System.Windows.Forms.ComboBox cbSotrudJobs2;
        private System.Windows.Forms.ComboBox cbOtdelJobs2;
        private System.Windows.Forms.ComboBox cbObjektlJobs2;
        private System.Windows.Forms.TextBox tbiDОбъектаСтроительства;
        private System.Windows.Forms.TextBox tbIDСотрудника;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox tbZadanieJobs;
        private System.Windows.Forms.DateTimePicker dtpStartJobs;
        private System.Windows.Forms.DateTimePicker dtpFinishJobs;
        private System.Windows.Forms.DateTimePicker dtpDLineJobs;
    }
}
