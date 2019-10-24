using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion
{
    public partial class Form1 : Form
    {
        List<ProductoNovo> productos = new List<ProductoNovo>();
        ListViewItem producto;

        public Form1()
        {
            InitializeComponent();
            CargarProductos();

            listDespensa.View = View.Details;
            listDespensa.FullRowSelect = true;
            listDespensa.GridLines = true;
            listDespensa.Sorting = SortOrder.Ascending;

            listDespensa.Columns.Add("Nome do Producto", 300, HorizontalAlignment.Center);
            listDespensa.Columns.Add("Marca do Producto", 300, HorizontalAlignment.Center);
            listDespensa.Columns.Add("Cantidades", 150, HorizontalAlignment.Center);
            listDespensa.Columns.Add("Lugar de Compra", 250, HorizontalAlignment.Center);
            listDespensa.Columns.Add("Caducidade", -2, HorizontalAlignment.Center);

            for (int i = 0; i < productos.Count; i++)
            {
                producto = new ListViewItem(productos[i].Nome, listDespensa.Items.Count);
                producto.Checked = true;
                producto.SubItems.Add(productos[i].Marca);
                producto.SubItems.Add(Convert.ToString(productos[i].Cantidades));
                producto.SubItems.Add(productos[i].Lugar);
                producto.SubItems.Add(productos[i].Caducidade);
                listDespensa.Items.AddRange(new ListViewItem[] { producto });
            }
        }

        private void CargarProductos()
        {
            productos = BD.CargarProducto();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this, 1);
            form2.ShowDialog();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (listDespensa.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("¿Está seguro de querer borrar o producto/s seleccionado/s?", "Dúbida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    for (int i = listDespensa.SelectedIndices.Count - 1; i >= 0; i--)
                    {
                        listDespensa.Items.RemoveAt(listDespensa.SelectedIndices[i]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona o producto que queiras borrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (listDespensa.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona o producto que queiras editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (listDespensa.SelectedItems.Count > 1)
            {
                MessageBox.Show("Por favor, seleccione so un producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (listDespensa.Items.Count != 0 && listDespensa.SelectedItems.Count == 1)
            {
                Form2 form2 = new Form2(this, 2);
                form2.txtNome.Text = listDespensa.SelectedItems[0].SubItems[0].Text;
                form2.txtMarca.Text = listDespensa.SelectedItems[0].SubItems[1].Text;
                form2.txtCantidades.Text = listDespensa.SelectedItems[0].SubItems[2].Text;
                form2.txtLugar.Text = listDespensa.SelectedItems[0].SubItems[3].Text;
                form2.txtCaducidade.Text = listDespensa.SelectedItems[0].SubItems[4].Text;
                form2.ShowDialog();
            }
        }
    }
}
