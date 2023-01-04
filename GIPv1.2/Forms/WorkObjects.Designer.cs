
namespace GIPv1._2.Forms
{
    partial class WorkObjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkObjects));
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveObj = new System.Windows.Forms.Button();
            this.btnChangeObj = new System.Windows.Forms.Button();
            this.btnDelObj = new System.Windows.Forms.Button();
            this.btnNewObj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDateCreate = new System.Windows.Forms.TextBox();
            this.tbNameObj = new System.Windows.Forms.TextBox();
            this.tbIDObj = new System.Windows.Forms.TextBox();
            this.lblDateCreate = new System.Windows.Forms.Label();
            this.lblNameObj = new System.Windows.Forms.Label();
            this.lblIDObj = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 505);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 168);
            this.panel2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.btnSaveObj);
            this.groupBox2.Controls.Add(this.btnChangeObj);
            this.groupBox2.Controls.Add(this.btnDelObj);
            this.groupBox2.Controls.Add(this.btnNewObj);
            this.groupBox2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(680, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление объектами";
            // 
            // btnSaveObj
            // 
            this.btnSaveObj.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveObj.Location = new System.Drawing.Point(7, 107);
            this.btnSaveObj.Name = "btnSaveObj";
            this.btnSaveObj.Size = new System.Drawing.Size(187, 23);
            this.btnSaveObj.TabIndex = 0;
            this.btnSaveObj.Text = "Сохранить";
            this.btnSaveObj.UseVisualStyleBackColor = true;
            // 
            // btnChangeObj
            // 
            this.btnChangeObj.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeObj.Location = new System.Drawing.Point(7, 78);
            this.btnChangeObj.Name = "btnChangeObj";
            this.btnChangeObj.Size = new System.Drawing.Size(187, 23);
            this.btnChangeObj.TabIndex = 0;
            this.btnChangeObj.Text = "Изменить";
            this.btnChangeObj.UseVisualStyleBackColor = true;
            // 
            // btnDelObj
            // 
            this.btnDelObj.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelObj.Location = new System.Drawing.Point(6, 49);
            this.btnDelObj.Name = "btnDelObj";
            this.btnDelObj.Size = new System.Drawing.Size(187, 23);
            this.btnDelObj.TabIndex = 0;
            this.btnDelObj.Text = "Удалить";
            this.btnDelObj.UseVisualStyleBackColor = true;
            // 
            // btnNewObj
            // 
            this.btnNewObj.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewObj.Location = new System.Drawing.Point(7, 20);
            this.btnNewObj.Name = "btnNewObj";
            this.btnNewObj.Size = new System.Drawing.Size(187, 23);
            this.btnNewObj.TabIndex = 0;
            this.btnNewObj.Text = "Новый объект";
            this.btnNewObj.UseVisualStyleBackColor = true;
            this.btnNewObj.Click += new System.EventHandler(this.btnNewObj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.tbDateCreate);
            this.groupBox1.Controls.Add(this.tbNameObj);
            this.groupBox1.Controls.Add(this.tbIDObj);
            this.groupBox1.Controls.Add(this.lblDateCreate);
            this.groupBox1.Controls.Add(this.lblNameObj);
            this.groupBox1.Controls.Add(this.lblIDObj);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Запись";
            // 
            // tbDateCreate
            // 
            this.tbDateCreate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbDateCreate.Location = new System.Drawing.Point(137, 95);
            this.tbDateCreate.Name = "tbDateCreate";
            this.tbDateCreate.Size = new System.Drawing.Size(432, 20);
            this.tbDateCreate.TabIndex = 4;
            // 
            // tbNameObj
            // 
            this.tbNameObj.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbNameObj.Location = new System.Drawing.Point(137, 60);
            this.tbNameObj.Name = "tbNameObj";
            this.tbNameObj.Size = new System.Drawing.Size(432, 20);
            this.tbNameObj.TabIndex = 4;
            // 
            // tbIDObj
            // 
            this.tbIDObj.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbIDObj.Location = new System.Drawing.Point(137, 25);
            this.tbIDObj.Name = "tbIDObj";
            this.tbIDObj.Size = new System.Drawing.Size(432, 20);
            this.tbIDObj.TabIndex = 4;
            // 
            // lblDateCreate
            // 
            this.lblDateCreate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDateCreate.AutoSize = true;
            this.lblDateCreate.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateCreate.ForeColor = System.Drawing.Color.Black;
            this.lblDateCreate.Location = new System.Drawing.Point(6, 95);
            this.lblDateCreate.Name = "lblDateCreate";
            this.lblDateCreate.Size = new System.Drawing.Size(110, 19);
            this.lblDateCreate.TabIndex = 0;
            this.lblDateCreate.Text = "Дата создания";
            // 
            // lblNameObj
            // 
            this.lblNameObj.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNameObj.AutoSize = true;
            this.lblNameObj.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameObj.ForeColor = System.Drawing.Color.Black;
            this.lblNameObj.Location = new System.Drawing.Point(6, 59);
            this.lblNameObj.Name = "lblNameObj";
            this.lblNameObj.Size = new System.Drawing.Size(110, 19);
            this.lblNameObj.TabIndex = 0;
            this.lblNameObj.Text = "Наименование";
            // 
            // lblIDObj
            // 
            this.lblIDObj.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIDObj.AutoSize = true;
            this.lblIDObj.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIDObj.ForeColor = System.Drawing.Color.Black;
            this.lblIDObj.Location = new System.Drawing.Point(6, 24);
            this.lblIDObj.Name = "lblIDObj";
            this.lblIDObj.Size = new System.Drawing.Size(22, 19);
            this.lblIDObj.TabIndex = 0;
            this.lblIDObj.Text = "ID";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(1024, 144);
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
            this.label2.Location = new System.Drawing.Point(885, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество объектов:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 615);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 58);
            this.panel1.TabIndex = 3;
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
            this.btnRefresh.Location = new System.Drawing.Point(692, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 34);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.Location = new System.Drawing.Point(937, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Наименование объекта",
            "Заказчик",
            "Источник финансирования"});
            this.comboBox1.Location = new System.Drawing.Point(789, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(181, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "Задачи и исполнители\r\n";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Разрешительные документы\r\n";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(729, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск:";
            // 
            // WorkObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "WorkObjects";
            this.Text = "WorkObjects";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveObj;
        private System.Windows.Forms.Button btnChangeObj;
        private System.Windows.Forms.Button btnDelObj;
        private System.Windows.Forms.Button btnNewObj;
        private System.Windows.Forms.TextBox tbDateCreate;
        private System.Windows.Forms.TextBox tbNameObj;
        private System.Windows.Forms.TextBox tbIDObj;
        private System.Windows.Forms.Label lblDateCreate;
        private System.Windows.Forms.Label lblNameObj;
        private System.Windows.Forms.Label lblIDObj;
        private System.Windows.Forms.Button btnRefresh;
    }
}