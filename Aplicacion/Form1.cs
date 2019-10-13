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
        public Form1()
        {
            InitializeComponent();
            listDespensa.View = View.Details;
            listDespensa.FullRowSelect = true;
            listDespensa.GridLines = true;
            listDespensa.Sorting = SortOrder.Ascending;

            listDespensa.Columns.Add("Nome do Producto", 300, HorizontalAlignment.Center);
            listDespensa.Columns.Add("Marca do Producto", 300, HorizontalAlignment.Center);
            listDespensa.Columns.Add("Cantidades", 150, HorizontalAlignment.Center);
            listDespensa.Columns.Add("Lugar de Compra", 250, HorizontalAlignment.Center);
            listDespensa.Columns.Add("Caducidade", -2, HorizontalAlignment.Center);
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
                for (int i = listDespensa.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    listDespensa.Items.RemoveAt(listDespensa.SelectedIndices[i]);
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this, 2);
            form2.ShowDialog();
        }
    }
}
