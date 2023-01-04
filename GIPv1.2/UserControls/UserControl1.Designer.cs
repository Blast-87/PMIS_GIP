
namespace GIPv1._2.UserControls
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.объектСтроительстваTableAdapter = new GIPv1._2._GIPv1_5DataSetTableAdapters.ОбъектСтроительстваTableAdapter();
            this.объектСтроительстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._GIPv1_5DataSet = new GIPv1._2._GIPv1_5DataSet();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSaveObj = new System.Windows.Forms.Button();
            this.btnDelObj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnChangeObj = new System.Windows.Forms.Button();
            this.btnNewObj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_5DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 596);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 30);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(1013, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "00";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(830, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество объектов в работе:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(569, 561);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "№ п/п";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Наименование проекта";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Дата регистрации";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата инспирации";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Наименование заказчика";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Источник средств";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1047, 561);
            this.panel3.TabIndex = 5;
            // 
            // объектСтроительстваTableAdapter
            // 
            this.объектСтроительстваTableAdapter.ClearBeforeFill = true;
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
            // btnAssign
            // 
            this.btnAssign.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAssign.FlatAppearance.BorderSize = 0;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Image = ((System.Drawing.Image)(resources.GetObject("btnAssign.Image")));
            this.btnAssign.Location = new System.Drawing.Point(532, 0);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(119, 60);
            this.btnAssign.TabIndex = 8;
            this.btnAssign.Text = "Утвердить";
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
            this.btnRefresh.Location = new System.Drawing.Point(689, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 34);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSaveObj
            // 
            this.btnSaveObj.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSaveObj.FlatAppearance.BorderSize = 0;
            this.btnSaveObj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveObj.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveObj.ForeColor = System.Drawing.Color.White;
            this.btnSaveObj.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveObj.Image")));
            this.btnSaveObj.Location = new System.Drawing.Point(413, 0);
            this.btnSaveObj.Name = "btnSaveObj";
            this.btnSaveObj.Size = new System.Drawing.Size(119, 60);
            this.btnSaveObj.TabIndex = 6;
            this.btnSaveObj.Text = "Сохранить";
            this.btnSaveObj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveObj.UseVisualStyleBackColor = true;
            // 
            // btnDelObj
            // 
            this.btnDelObj.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelObj.FlatAppearance.BorderSize = 0;
            this.btnDelObj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelObj.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelObj.ForeColor = System.Drawing.Color.White;
            this.btnDelObj.Image = ((System.Drawing.Image)(resources.GetObject("btnDelObj.Image")));
            this.btnDelObj.Location = new System.Drawing.Point(296, 0);
            this.btnDelObj.Name = "btnDelObj";
            this.btnDelObj.Size = new System.Drawing.Size(117, 60);
            this.btnDelObj.TabIndex = 5;
            this.btnDelObj.Text = " Удалить";
            this.btnDelObj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelObj.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.Location = new System.Drawing.Point(934, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(786, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // btnChangeObj
            // 
            this.btnChangeObj.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChangeObj.FlatAppearance.BorderSize = 0;
            this.btnChangeObj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeObj.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeObj.ForeColor = System.Drawing.Color.White;
            this.btnChangeObj.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeObj.Image")));
            this.btnChangeObj.Location = new System.Drawing.Point(175, 0);
            this.btnChangeObj.Name = "btnChangeObj";
            this.btnChangeObj.Size = new System.Drawing.Size(121, 60);
            this.btnChangeObj.TabIndex = 2;
            this.btnChangeObj.Text = " Изменить";
            this.btnChangeObj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeObj.UseVisualStyleBackColor = true;
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
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(726, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btnAssign);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnSaveObj);
            this.panel1.Controls.Add(this.btnDelObj);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnChangeObj);
            this.panel1.Controls.Add(this.btnNewObj);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 60);
            this.panel1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.объектСтроительстваBindingSource, "НаименованиеОбъектаСтроительства", true));
            this.comboBox2.DataSource = this.объектСтроительстваBindingSource;
            this.comboBox2.DisplayMember = "НаименованиеОбъектаСтроительства";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(646, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "IDОбъектаСтроительства";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1057, 631);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.объектСтроительстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GIPv1_5DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel3;
        private _GIPv1_5DataSetTableAdapters.ОбъектСтроительстваTableAdapter объектСтроительстваTableAdapter;
        private System.Windows.Forms.BindingSource объектСтроительстваBindingSource;
        private _GIPv1_5DataSet _GIPv1_5DataSet;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSaveObj;
        private System.Windows.Forms.Button btnDelObj;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnChangeObj;
        private System.Windows.Forms.Button btnNewObj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
