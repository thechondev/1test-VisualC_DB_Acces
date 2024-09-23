using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_C__DB__CALR_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAgregarPro_Click(object sender, EventArgs e)
        {
            this.productos_y_VentasTableAdapter.Insertar(txtNombrePro.Text, decimal.Parse(txtPrecioPro.Text), decimal.Parse(txtUnidadesVen.Text));
            this.productos_y_VentasTableAdapter.Fill(this.productos_y_VentasDataSet.Productos_y_Ventas);

        }

        private void cmdEliminarpro_Click(object sender, EventArgs e)
        {
            this.productos_y_VentasTableAdapter.Eliminar(txtNombrePro.Text);
            this.productos_y_VentasTableAdapter.Fill(this.productos_y_VentasDataSet.Productos_y_Ventas);
        }

        private void cmdEditarpro_Click(object sender, EventArgs e)
        {
            this.productos_y_VentasTableAdapter.Modificar(txtNombrePro.Text, decimal.Parse(txtPrecioPro.Text), decimal.Parse(txtUnidadesVen.Text),txtNombrePro.Text);
            this.productos_y_VentasTableAdapter.Fill(this.productos_y_VentasDataSet.Productos_y_Ventas);

        }

        private void productos_y_VentasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productos_y_VentasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productos_y_VentasDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productos_y_VentasDataSet.Productos_y_Ventas' Puede moverla o quitarla según sea necesario.
            this.productos_y_VentasTableAdapter.Fill(this.productos_y_VentasDataSet.Productos_y_Ventas);

        }

        private void productos_y_VentasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productos_y_VentasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productos_y_VentasDataSet);

        }

        private void productos_y_VentasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgProVen.CurrentCell.Value != null)
            {
                txtPrecioPro.Text = dtgProVen[2, dtgProVen.CurrentCell.RowIndex].ToString();
                txtUnidadesVen.Text = dtgProVen[3, dtgProVen.CurrentCell.RowIndex].ToString();

            }

            else
            {
                dtgProVen.CurrentCell.Value = " ";
            }
        }

        private void txtPrecioPro_KeyPress(object sender, KeyPressEventArgs a)
        {
            if (char.IsLetter(a.KeyChar) || (char.IsPunctuation(a.KeyChar) && a.KeyChar != ',') || char.IsSymbol(a.KeyChar) || char.IsWhiteSpace(a.KeyChar))
            {
                a.Handled = true;

            }
        }

        private void txtUnidadesVen_KeyPress(object sender, KeyPressEventArgs i)
        {
            if (char.IsLetter(i.KeyChar) || (char.IsPunctuation(i.KeyChar) && i.KeyChar != ',') || char.IsSymbol(i.KeyChar) || char.IsWhiteSpace(i.KeyChar))
            {
                i.Handled = true;

            }
        }

        
    }
}
