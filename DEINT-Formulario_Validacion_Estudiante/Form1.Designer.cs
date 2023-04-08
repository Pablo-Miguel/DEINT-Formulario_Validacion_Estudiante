namespace DEINT_Formulario_Validacion_Estudiante
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbHead = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNif = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbNif = new System.Windows.Forms.TextBox();
            this.pbEstudiante = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.epNif = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.epApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstudiante)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbHead);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(198, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de estudiantes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbHead
            // 
            this.pbHead.Image = global::DEINT_Formulario_Validacion_Estudiante.Properties.Resources.descarga;
            this.pbHead.Location = new System.Drawing.Point(11, 3);
            this.pbHead.Name = "pbHead";
            this.pbHead.Size = new System.Drawing.Size(58, 58);
            this.pbHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHead.TabIndex = 0;
            this.pbHead.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 69);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(509, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 29);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(396, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 55);
            this.label3.TabIndex = 3;
            this.label3.Text = "Buscar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(35, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estudiantes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnLimpiar);
            this.panel3.Controls.Add(this.btnAnyadir);
            this.panel3.Controls.Add(this.lblEmail);
            this.panel3.Controls.Add(this.lblApellido);
            this.panel3.Controls.Add(this.lblNombre);
            this.panel3.Controls.Add(this.lblNif);
            this.panel3.Controls.Add(this.tbEmail);
            this.panel3.Controls.Add(this.tbApellido);
            this.panel3.Controls.Add(this.tbNombre);
            this.panel3.Controls.Add(this.tbNif);
            this.panel3.Controls.Add(this.pbEstudiante);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(1, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 307);
            this.panel3.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(239, 262);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 39);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(138, 262);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 39);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAnyadir
            // 
            this.btnAnyadir.Location = new System.Drawing.Point(34, 262);
            this.btnAnyadir.Name = "btnAnyadir";
            this.btnAnyadir.Size = new System.Drawing.Size(98, 39);
            this.btnAnyadir.TabIndex = 15;
            this.btnAnyadir.Text = "Añadir";
            this.btnAnyadir.UseVisualStyleBackColor = true;
            this.btnAnyadir.Click += new System.EventHandler(this.btnAnyadir_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEmail.Location = new System.Drawing.Point(199, 209);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(147, 19);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApellido
            // 
            this.lblApellido.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblApellido.Location = new System.Drawing.Point(7, 209);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(144, 19);
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNombre.Location = new System.Drawing.Point(199, 159);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(147, 19);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNif
            // 
            this.lblNif.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNif.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNif.Location = new System.Drawing.Point(7, 159);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(144, 19);
            this.lblNif.TabIndex = 11;
            this.lblNif.Text = "Nif";
            this.lblNif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(202, 231);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(144, 25);
            this.tbEmail.TabIndex = 10;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // tbApellido
            // 
            this.tbApellido.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellido.Location = new System.Drawing.Point(7, 231);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(144, 25);
            this.tbApellido.TabIndex = 9;
            this.tbApellido.TextChanged += new System.EventHandler(this.tbApellido_TextChanged);
            this.tbApellido.Validating += new System.ComponentModel.CancelEventHandler(this.tbApellido_Validating);
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(202, 181);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(144, 25);
            this.tbNombre.TabIndex = 8;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            this.tbNombre.Validating += new System.ComponentModel.CancelEventHandler(this.tbNombre_Validating);
            // 
            // tbNif
            // 
            this.tbNif.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNif.Location = new System.Drawing.Point(7, 181);
            this.tbNif.Name = "tbNif";
            this.tbNif.Size = new System.Drawing.Size(144, 25);
            this.tbNif.TabIndex = 7;
            this.tbNif.TextChanged += new System.EventHandler(this.tbNif_TextChanged);
            this.tbNif.Validating += new System.ComponentModel.CancelEventHandler(this.tbNif_Validating);
            // 
            // pbEstudiante
            // 
            this.pbEstudiante.Image = global::DEINT_Formulario_Validacion_Estudiante.Properties.Resources.descarga;
            this.pbEstudiante.Location = new System.Drawing.Point(93, 23);
            this.pbEstudiante.Name = "pbEstudiante";
            this.pbEstudiante.Size = new System.Drawing.Size(134, 133);
            this.pbEstudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEstudiante.TabIndex = 6;
            this.pbEstudiante.TabStop = false;
            this.pbEstudiante.Click += new System.EventHandler(this.pbEstudiante_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(3, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Información del estudiante";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(480, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lista de estudiantes";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(386, 145);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(486, 307);
            this.panel4.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(477, 277);
            this.listBox1.TabIndex = 7;
            // 
            // epNif
            // 
            this.epNif.ContainerControl = this;
            // 
            // epNombre
            // 
            this.epNombre.ContainerControl = this;
            // 
            // epApellido
            // 
            this.epApellido.ContainerControl = this;
            // 
            // epEmail
            // 
            this.epEmail.ContainerControl = this;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 457);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstudiante)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epNif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbHead;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAnyadir;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbNif;
        private System.Windows.Forms.PictureBox pbEstudiante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ErrorProvider epNif;
        private System.Windows.Forms.ErrorProvider epNombre;
        private System.Windows.Forms.ErrorProvider epApellido;
        private System.Windows.Forms.ErrorProvider epEmail;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

