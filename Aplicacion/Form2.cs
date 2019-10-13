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
    public partial class Form2 : Form
    {
        bool aviso = false;
        Form1 form1;
        int numSeleccionado;

        public Form2(Form1 form, int numSelec)
        {
            InitializeComponent();
            form1 = form;
            numSeleccionado = numSelec;
        }

        private void BtnGardar_Click(object sender, EventArgs e)
        {
            ListViewItem producto;

            if (txtNome.Text == "")
            {
                txtNome.BackColor = Color.Pink;
                aviso = true;
            }

            if (txtCantidades.Text == "")
            {
                txtCantidades.BackColor = Color.Pink;
                aviso = true;
            }

            if (txtCaducidade.Text == "")
            {
                txtCaducidade.BackColor = Color.Pink;
                aviso = true;
            }

            if (aviso)
            {
                aviso = false;
                MessageBox.Show("Hay campos que teñen que ser enchidos", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

            if (txtNome.Text != "" && txtCantidades.Text != "" && txtCaducidade.Text != "" && numSeleccionado == 1)
            {
                producto = new ListViewItem(txtNome.Text, form1.listDespensa.Items.Count);
                producto.Checked = true;
                producto.SubItems.Add(txtMarca.Text);
                producto.SubItems.Add(txtCantidades.Text);
                producto.SubItems.Add(txtLugar.Text);
                producto.SubItems.Add(txtCaducidade.Text);

                form1.listDespensa.Items.AddRange(new ListViewItem[] { producto });
                this.Close();
            }
            else
            {
                for (int i = form1.listDespensa.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    form1.listDespensa.Items.RemoveAt(form1.listDespensa.SelectedIndices[i]);
                    producto = new ListViewItem(txtNome.Text, form1.listDespensa.Items.Count);
                    producto.Checked = true;
                    producto.SubItems.Add(txtMarca.Text);
                    producto.SubItems.Add(txtCantidades.Text);
                    producto.SubItems.Add(txtLugar.Text);
                    producto.SubItems.Add(txtCaducidade.Text);

                    form1.listDespensa.Items.AddRange(new ListViewItem[] { producto });
                    this.Close();
                }
            }
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.BackColor = Color.White;
        }

        private void TxtCantidades_TextChanged(object sender, EventArgs e)
        {
            txtCantidades.BackColor = Color.White;
        }

        private void TxtCaducidade_TextChanged(object sender, EventArgs e)
        {
            txtCaducidade.BackColor = Color.White;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
