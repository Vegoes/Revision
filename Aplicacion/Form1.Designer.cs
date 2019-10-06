namespace Aplicacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnOpcions = new System.Windows.Forms.Button();
            this.btnGardar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCantidades = new System.Windows.Forms.Label();
            this.lblCompra = new System.Windows.Forms.Label();
            this.lblCaducidade = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(1224, 38);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(152, 40);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo Alimento";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(1224, 179);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(152, 40);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar Alimento";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1224, 320);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(152, 40);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar Alimento";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnOpcions
            // 
            this.btnOpcions.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOpcions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcions.Location = new System.Drawing.Point(1224, 602);
            this.btnOpcions.Name = "btnOpcions";
            this.btnOpcions.Size = new System.Drawing.Size(152, 38);
            this.btnOpcions.TabIndex = 10;
            this.btnOpcions.Text = "Opcións";
            this.btnOpcions.UseVisualStyleBackColor = true;
            // 
            // btnGardar
            // 
            this.btnGardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGardar.Location = new System.Drawing.Point(1224, 461);
            this.btnGardar.Name = "btnGardar";
            this.btnGardar.Size = new System.Drawing.Size(152, 40);
            this.btnGardar.TabIndex = 11;
            this.btnGardar.Text = "Gardar Cambios";
            this.btnGardar.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(9, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(121, 16);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome do Producto";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(334, 9);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(122, 16);
            this.lblMarca.TabIndex = 13;
            this.lblMarca.Text = "Marca do Producto";
            // 
            // lblCantidades
            // 
            this.lblCantidades.AutoSize = true;
            this.lblCantidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidades.Location = new System.Drawing.Point(612, 9);
            this.lblCantidades.Name = "lblCantidades";
            this.lblCantidades.Size = new System.Drawing.Size(77, 16);
            this.lblCantidades.TabIndex = 14;
            this.lblCantidades.Text = "Cantidades";
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompra.Location = new System.Drawing.Point(842, 9);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(112, 16);
            this.lblCompra.TabIndex = 15;
            this.lblCompra.Text = "Lugar de Compra";
            // 
            // lblCaducidade
            // 
            this.lblCaducidade.AutoSize = true;
            this.lblCaducidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaducidade.Location = new System.Drawing.Point(1095, 9);
            this.lblCaducidade.Name = "lblCaducidade";
            this.lblCaducidade.Size = new System.Drawing.Size(82, 16);
            this.lblCaducidade.TabIndex = 16;
            this.lblCaducidade.Text = "Caducidade";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1206, 602);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 666);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblCaducidade);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.lblCantidades);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnGardar);
            this.Controls.Add(this.btnOpcions);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnNovo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Despensa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnOpcions;
        private System.Windows.Forms.Button btnGardar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCantidades;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Label lblCaducidade;
        private System.Windows.Forms.ListView listView1;
    }
}

