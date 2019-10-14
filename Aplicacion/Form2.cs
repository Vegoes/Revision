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
        bool avisoLetra = false;
        bool avisoFormato = false;
        string dataFormato;
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
            avisoFormato = false;
            aviso = false;
            avisoLetra = false;

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
            else
            {
                if (char.IsLetter(Convert.ToChar(txtCantidades.Text)))
                {
                    txtCantidades.BackColor = Color.Pink;
                    MessageBox.Show("Por favor, introduza un número válido en Cantidades", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    avisoLetra = true;
                }
            }

            if (txtCaducidade.Text == "")
            {
                txtCaducidade.BackColor = Color.Pink;
                aviso = true;
            }

            try
            {
                dataFormato = Convert.ToDateTime(txtCaducidade.Text).ToString("dd/MM/yyyy");
            }
            catch
            {
                MessageBox.Show("Formato de data non válido. Por favor, introduza un formato de data válido", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtCaducidade.BackColor = Color.Pink;
                avisoFormato = true;
            }

            if (aviso)
            {
                MessageBox.Show("Hay campos que teñen que ser enchidos", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

            if (!aviso && !avisoLetra && !avisoFormato && numSeleccionado == 1)
            {
                this.Text = "Novo Alimento";
                producto = new ListViewItem(txtNome.Text, form1.listDespensa.Items.Count);
                producto.Checked = true;
                producto.SubItems.Add(txtMarca.Text);
                producto.SubItems.Add(txtCantidades.Text);
                producto.SubItems.Add(txtLugar.Text);
                producto.SubItems.Add(dataFormato);

                form1.listDespensa.Items.AddRange(new ListViewItem[] { producto });
                this.Close();
            }
            //else
            //{
            //    this.Text = "Editar Alimento";
            //    for (int i = form1.listDespensa.SelectedIndices.Count - 1; i >= 0; i--)
            //    {
            //        form1.listDespensa.Items.RemoveAt(form1.listDespensa.SelectedIndices[i]);
            //        producto = new ListViewItem(txtNome.Text, form1.listDespensa.Items.Count);
            //        producto.Checked = true;
            //        producto.SubItems.Add(txtMarca.Text);
            //        producto.SubItems.Add(txtCantidades.Text);
            //        producto.SubItems.Add(txtLugar.Text);
            //        producto.SubItems.Add(txtCaducidade.Text);

            //        form1.listDespensa.Items.AddRange(new ListViewItem[] { producto });
            //        this.Close();
            //    }
            //}
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
