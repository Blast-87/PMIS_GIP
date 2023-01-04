using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIPv1._2.Forms
{
    public partial class AddProject1 : Form
    {
        public AddProject1()
        {
            InitializeComponent();
        }

        private void объектСтроительстваBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.объектСтроительстваBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._GIPv1_5DataSet);

        }

        private void объектСтроительстваBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.объектСтроительстваBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._GIPv1_5DataSet);

        }

        private void объектСтроительстваBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.объектСтроительстваBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._GIPv1_5DataSet);

        }

        //private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.сотрудникиBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this._GIPv1_5DataSet);

        //}

        private void объектСтроительстваBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.объектСтроительстваBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._GIPv1_5DataSet);

        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_GIPv1_5DataSet.ОбъектСтроительства". При необходимости она может быть перемещена или удалена.
            this.объектСтроительстваTableAdapter.Fill(this._GIPv1_5DataSet.ОбъектСтроительства);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            объектСтроительстваBindingSource.EndEdit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            объектСтроительстваBindingSource.EndEdit();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
