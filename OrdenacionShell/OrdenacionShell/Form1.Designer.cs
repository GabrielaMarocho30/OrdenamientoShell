
namespace OrdenacionShell
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lstOriginal = new System.Windows.Forms.ListBox();
            this.lstOrdenado = new System.Windows.Forms.ListBox();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(172, 34);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(172, 186);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.UseWaitCursor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 318);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lstOriginal
            // 
            this.lstOriginal.FormattingEnabled = true;
            this.lstOriginal.Location = new System.Drawing.Point(12, 75);
            this.lstOriginal.Name = "lstOriginal";
            this.lstOriginal.Size = new System.Drawing.Size(142, 225);
            this.lstOriginal.TabIndex = 3;
            // 
            // lstOrdenado
            // 
            this.lstOrdenado.FormattingEnabled = true;
            this.lstOrdenado.Location = new System.Drawing.Point(282, 75);
            this.lstOrdenado.Name = "lstOrdenado";
            this.lstOrdenado.Size = new System.Drawing.Size(144, 225);
            this.lstOrdenado.TabIndex = 4;
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(12, 34);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(142, 20);
            this.txtNro.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 371);
            this.Controls.Add(this.txtNro);
            this.Controls.Add(this.lstOrdenado);
            this.Controls.Add(this.lstOriginal);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox lstOriginal;
        private System.Windows.Forms.ListBox lstOrdenado;
        private System.Windows.Forms.TextBox txtNro;
    }
}

