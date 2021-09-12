
namespace _3___Practica_Formularios
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dateRegistro = new System.Windows.Forms.DateTimePicker();
            this.comboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.chckbExtranjero = new System.Windows.Forms.CheckBox();
            this.dtgvAlumnos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estranj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCarga = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(218, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(227, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateRegistro
            // 
            this.dateRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRegistro.Location = new System.Drawing.Point(218, 90);
            this.dateRegistro.Name = "dateRegistro";
            this.dateRegistro.Size = new System.Drawing.Size(227, 22);
            this.dateRegistro.TabIndex = 1;
            this.dateRegistro.ValueChanged += new System.EventHandler(this.dateRegistro_ValueChanged);
            // 
            // comboEstadoCivil
            // 
            this.comboEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstadoCivil.FormattingEnabled = true;
            this.comboEstadoCivil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Divorciado/a",
            "Viudo/a",
            "Concubinato"});
            this.comboEstadoCivil.Location = new System.Drawing.Point(218, 116);
            this.comboEstadoCivil.Name = "comboEstadoCivil";
            this.comboEstadoCivil.Size = new System.Drawing.Size(227, 24);
            this.comboEstadoCivil.TabIndex = 2;
            this.comboEstadoCivil.SelectedIndexChanged += new System.EventHandler(this.comboEstadoCivil_SelectedIndexChanged);
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHombre.Location = new System.Drawing.Point(220, 161);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(82, 24);
            this.rbHombre.TabIndex = 3;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            this.rbHombre.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMujer.Location = new System.Drawing.Point(344, 161);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(69, 24);
            this.rbMujer.TabIndex = 4;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            this.rbMujer.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // chckbExtranjero
            // 
            this.chckbExtranjero.AutoSize = true;
            this.chckbExtranjero.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbExtranjero.Location = new System.Drawing.Point(220, 200);
            this.chckbExtranjero.Name = "chckbExtranjero";
            this.chckbExtranjero.Size = new System.Drawing.Size(103, 24);
            this.chckbExtranjero.TabIndex = 5;
            this.chckbExtranjero.Text = "Extranjero";
            this.chckbExtranjero.UseVisualStyleBackColor = true;
            // 
            // dtgvAlumnos
            // 
            this.dtgvAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.FecCreacion,
            this.EstCivil,
            this.Sex,
            this.Estranj});
            this.dtgvAlumnos.Location = new System.Drawing.Point(21, 296);
            this.dtgvAlumnos.Name = "dtgvAlumnos";
            this.dtgvAlumnos.Size = new System.Drawing.Size(538, 150);
            this.dtgvAlumnos.TabIndex = 6;
            this.dtgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // FecCreacion
            // 
            this.FecCreacion.HeaderText = "Fecha Creación";
            this.FecCreacion.Name = "FecCreacion";
            // 
            // EstCivil
            // 
            this.EstCivil.HeaderText = "Estado Civil";
            this.EstCivil.Name = "EstCivil";
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Sexo";
            this.Sex.Name = "Sex";
            // 
            // Estranj
            // 
            this.Estranj.HeaderText = "Extranjero";
            this.Estranj.Name = "Estranj";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(60, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(129, 19);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Ingrese su nombre";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(60, 93);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(124, 19);
            this.lblRegistro.TabIndex = 8;
            this.lblRegistro.Text = "Fecha de registro";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(60, 121);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(85, 19);
            this.lblEstadoCivil.TabIndex = 9;
            this.lblEstadoCivil.Text = "Estado civil";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 64);
            this.button1.TabIndex = 10;
            this.button1.Text = "AGREGAR ALUMN@";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCarga
            // 
            this.lblCarga.AutoSize = true;
            this.lblCarga.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarga.Location = new System.Drawing.Point(421, 227);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(14, 20);
            this.lblCarga.TabIndex = 11;
            this.lblCarga.Text = " ";
            this.lblCarga.Click += new System.EventHandler(this.lblCarga_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(233, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 50);
            this.button2.TabIndex = 12;
            this.button2.Text = "CERRAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.BackColor = System.Drawing.Color.Maroon;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBienvenida.Location = new System.Drawing.Point(21, 9);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(538, 36);
            this.lblBienvenida.TabIndex = 13;
            this.lblBienvenida.Text = "BIENVENIDOS WINDOWS FORMS";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 545);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblCarga);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dtgvAlumnos);
            this.Controls.Add(this.chckbExtranjero);
            this.Controls.Add(this.rbMujer);
            this.Controls.Add(this.rbHombre);
            this.Controls.Add(this.comboEstadoCivil);
            this.Controls.Add(this.dateRegistro);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Carga de alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dateRegistro;
        private System.Windows.Forms.ComboBox comboEstadoCivil;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.CheckBox chckbExtranjero;
        private System.Windows.Forms.DataGridView dtgvAlumnos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estranj;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblBienvenida;
    }
}

