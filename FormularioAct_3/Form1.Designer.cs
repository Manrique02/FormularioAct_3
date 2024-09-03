namespace FormularioAct_3
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbEstatura = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxNombre = new System.Windows.Forms.TextBox();
            this.TbxApellido = new System.Windows.Forms.TextBox();
            this.TbxTelefono = new System.Windows.Forms.TextBox();
            this.TbxEstatura = new System.Windows.Forms.TextBox();
            this.TbxEdad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.GbxGenero = new System.Windows.Forms.GroupBox();
            this.RBtnMujer = new System.Windows.Forms.RadioButton();
            this.RBtnHombre = new System.Windows.Forms.RadioButton();
            this.GbxGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(49, 49);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(66, 16);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(44, 85);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(77, 16);
            this.lbApellido.TabIndex = 1;
            this.lbApellido.Text = "Apellidos:";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.Location = new System.Drawing.Point(44, 121);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(73, 16);
            this.lbTelefono.TabIndex = 2;
            this.lbTelefono.Text = "Teléfono:";
            // 
            // lbEstatura
            // 
            this.lbEstatura.AutoSize = true;
            this.lbEstatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstatura.Location = new System.Drawing.Point(49, 154);
            this.lbEstatura.Name = "lbEstatura";
            this.lbEstatura.Size = new System.Drawing.Size(68, 16);
            this.lbEstatura.TabIndex = 3;
            this.lbEstatura.Text = "Estatura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad:";
            // 
            // TbxNombre
            // 
            this.TbxNombre.Location = new System.Drawing.Point(123, 49);
            this.TbxNombre.Name = "TbxNombre";
            this.TbxNombre.Size = new System.Drawing.Size(148, 22);
            this.TbxNombre.TabIndex = 5;
            // 
            // TbxApellido
            // 
            this.TbxApellido.Location = new System.Drawing.Point(123, 85);
            this.TbxApellido.Name = "TbxApellido";
            this.TbxApellido.Size = new System.Drawing.Size(148, 22);
            this.TbxApellido.TabIndex = 6;
            // 
            // TbxTelefono
            // 
            this.TbxTelefono.Location = new System.Drawing.Point(123, 121);
            this.TbxTelefono.Name = "TbxTelefono";
            this.TbxTelefono.Size = new System.Drawing.Size(148, 22);
            this.TbxTelefono.TabIndex = 7;
            // 
            // TbxEstatura
            // 
            this.TbxEstatura.Location = new System.Drawing.Point(123, 154);
            this.TbxEstatura.Name = "TbxEstatura";
            this.TbxEstatura.Size = new System.Drawing.Size(148, 22);
            this.TbxEstatura.TabIndex = 8;
            // 
            // TbxEdad
            // 
            this.TbxEdad.Location = new System.Drawing.Point(123, 189);
            this.TbxEdad.Name = "TbxEdad";
            this.TbxEdad.Size = new System.Drawing.Size(148, 22);
            this.TbxEdad.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGuardar.Location = new System.Drawing.Point(360, 170);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 35);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(485, 170);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 35);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // GbxGenero
            // 
            this.GbxGenero.Controls.Add(this.RBtnMujer);
            this.GbxGenero.Controls.Add(this.RBtnHombre);
            this.GbxGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxGenero.Location = new System.Drawing.Point(373, 49);
            this.GbxGenero.Name = "GbxGenero";
            this.GbxGenero.Size = new System.Drawing.Size(183, 67);
            this.GbxGenero.TabIndex = 12;
            this.GbxGenero.TabStop = false;
            this.GbxGenero.Text = "Genero";
            // 
            // RBtnMujer
            // 
            this.RBtnMujer.AutoSize = true;
            this.RBtnMujer.Location = new System.Drawing.Point(112, 35);
            this.RBtnMujer.Name = "RBtnMujer";
            this.RBtnMujer.Size = new System.Drawing.Size(66, 20);
            this.RBtnMujer.TabIndex = 1;
            this.RBtnMujer.TabStop = true;
            this.RBtnMujer.Text = "Mujer";
            this.RBtnMujer.UseVisualStyleBackColor = true;
            // 
            // RBtnHombre
            // 
            this.RBtnHombre.AutoSize = true;
            this.RBtnHombre.Location = new System.Drawing.Point(17, 36);
            this.RBtnHombre.Name = "RBtnHombre";
            this.RBtnHombre.Size = new System.Drawing.Size(83, 20);
            this.RBtnHombre.TabIndex = 0;
            this.RBtnHombre.TabStop = true;
            this.RBtnHombre.Text = "Hombre";
            this.RBtnHombre.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = global::FormularioAct_3.Properties.Resources.pngtree_a_colorful_image_of_autumn_leaves_on_the_ground_image_13081840;
            this.ClientSize = new System.Drawing.Size(607, 235);
            this.Controls.Add(this.GbxGenero);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.TbxEdad);
            this.Controls.Add(this.TbxEstatura);
            this.Controls.Add(this.TbxTelefono);
            this.Controls.Add(this.TbxApellido);
            this.Controls.Add(this.TbxNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbEstatura);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GbxGenero.ResumeLayout(false);
            this.GbxGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbEstatura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbxNombre;
        private System.Windows.Forms.TextBox TbxApellido;
        private System.Windows.Forms.TextBox TbxTelefono;
        private System.Windows.Forms.TextBox TbxEstatura;
        private System.Windows.Forms.TextBox TbxEdad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox GbxGenero;
        private System.Windows.Forms.RadioButton RBtnMujer;
        private System.Windows.Forms.RadioButton RBtnHombre;
    }
}

