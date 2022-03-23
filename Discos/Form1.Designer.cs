namespace Discos
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
            this.DgvDiscos = new System.Windows.Forms.DataGridView();
            this.ImagenDisco = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDiscos
            // 
            this.DgvDiscos.BackgroundColor = System.Drawing.Color.IndianRed;
            this.DgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDiscos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvDiscos.Location = new System.Drawing.Point(12, 149);
            this.DgvDiscos.MultiSelect = false;
            this.DgvDiscos.Name = "DgvDiscos";
            this.DgvDiscos.RowHeadersWidth = 62;
            this.DgvDiscos.RowTemplate.Height = 28;
            this.DgvDiscos.Size = new System.Drawing.Size(842, 185);
            this.DgvDiscos.TabIndex = 0;
            this.DgvDiscos.SelectionChanged += new System.EventHandler(this.DgvDiscos_SelectionChanged);
            // 
            // ImagenDisco
            // 
            this.ImagenDisco.Location = new System.Drawing.Point(886, 105);
            this.ImagenDisco.Name = "ImagenDisco";
            this.ImagenDisco.Size = new System.Drawing.Size(266, 261);
            this.ImagenDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenDisco.TabIndex = 1;
            this.ImagenDisco.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 382);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 37);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(164, 382);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 37);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1213, 602);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.ImagenDisco);
            this.Controls.Add(this.DgvDiscos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenDisco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDiscos;
        private System.Windows.Forms.PictureBox ImagenDisco;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
    }
}

