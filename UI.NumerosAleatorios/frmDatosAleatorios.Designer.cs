namespace UI.NumerosAleatorios
{
    partial class frmDatosAleatorios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nombre = new Label();
            DatosDelEmpleado = new Label();
            Número = new Label();
            FechaDeNacimiento = new Label();
            Sueldo = new Label();
            Grupo = new Label();
            txtNombre = new TextBox();
            txtNumero = new TextBox();
            txtSueldo = new TextBox();
            GenerarDatosAleatorios = new Button();
            dateFechaNacimiento = new DateTimePicker();
            radioFemenino = new RadioButton();
            radioMasculino = new RadioButton();
            comboGrupo = new ComboBox();
            checkSeguroM = new CheckBox();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(82, 86);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(78, 25);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre";
            // 
            // DatosDelEmpleado
            // 
            DatosDelEmpleado.AutoSize = true;
            DatosDelEmpleado.Location = new Point(52, 40);
            DatosDelEmpleado.Name = "DatosDelEmpleado";
            DatosDelEmpleado.Size = new Size(173, 25);
            DatosDelEmpleado.TabIndex = 2;
            DatosDelEmpleado.Text = "Datos del empleado";
            // 
            // Número
            // 
            Número.AutoSize = true;
            Número.Location = new Point(82, 130);
            Número.Name = "Número";
            Número.Size = new Size(77, 25);
            Número.TabIndex = 3;
            Número.Text = "Número";
            // 
            // FechaDeNacimiento
            // 
            FechaDeNacimiento.AutoSize = true;
            FechaDeNacimiento.Location = new Point(82, 177);
            FechaDeNacimiento.Name = "FechaDeNacimiento";
            FechaDeNacimiento.Size = new Size(174, 25);
            FechaDeNacimiento.TabIndex = 4;
            FechaDeNacimiento.Text = "Fecha de nacimiento";
            // 
            // Sueldo
            // 
            Sueldo.AutoSize = true;
            Sueldo.Location = new Point(85, 361);
            Sueldo.Name = "Sueldo";
            Sueldo.Size = new Size(67, 25);
            Sueldo.TabIndex = 5;
            Sueldo.Text = "Sueldo";
            // 
            // Grupo
            // 
            Grupo.AutoSize = true;
            Grupo.Location = new Point(85, 311);
            Grupo.Name = "Grupo";
            Grupo.Size = new Size(62, 25);
            Grupo.TabIndex = 6;
            Grupo.Text = "Grupo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(184, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 7;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(184, 127);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(150, 31);
            txtNumero.TabIndex = 8;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(187, 361);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(150, 31);
            txtSueldo.TabIndex = 9;
            // 
            // GenerarDatosAleatorios
            // 
            GenerarDatosAleatorios.Location = new Point(141, 465);
            GenerarDatosAleatorios.Name = "GenerarDatosAleatorios";
            GenerarDatosAleatorios.Size = new Size(318, 36);
            GenerarDatosAleatorios.TabIndex = 10;
            GenerarDatosAleatorios.Text = "Generar Datos Aleatorios";
            GenerarDatosAleatorios.UseVisualStyleBackColor = true;
            GenerarDatosAleatorios.Click += GenerarDatosAleatorios_Click;
            // 
            // dateFechaNacimiento
            // 
            dateFechaNacimiento.Location = new Point(284, 177);
            dateFechaNacimiento.Name = "dateFechaNacimiento";
            dateFechaNacimiento.Size = new Size(325, 31);
            dateFechaNacimiento.TabIndex = 11;
            // 
            // radioFemenino
            // 
            radioFemenino.AutoSize = true;
            radioFemenino.Location = new Point(141, 221);
            radioFemenino.Name = "radioFemenino";
            radioFemenino.Size = new Size(115, 29);
            radioFemenino.TabIndex = 12;
            radioFemenino.TabStop = true;
            radioFemenino.Text = "Femenino";
            radioFemenino.UseVisualStyleBackColor = true;
            // 
            // radioMasculino
            // 
            radioMasculino.AutoSize = true;
            radioMasculino.Location = new Point(141, 268);
            radioMasculino.Name = "radioMasculino";
            radioMasculino.Size = new Size(117, 29);
            radioMasculino.TabIndex = 13;
            radioMasculino.TabStop = true;
            radioMasculino.Text = "Masculino";
            radioMasculino.UseVisualStyleBackColor = true;
            // 
            // comboGrupo
            // 
            comboGrupo.FormattingEnabled = true;
            comboGrupo.Location = new Point(187, 311);
            comboGrupo.Name = "comboGrupo";
            comboGrupo.Size = new Size(182, 33);
            comboGrupo.TabIndex = 15;
            // 
            // checkSeguroM
            // 
            checkSeguroM.AutoSize = true;
            checkSeguroM.Location = new Point(216, 413);
            checkSeguroM.Name = "checkSeguroM";
            checkSeguroM.Size = new Size(159, 29);
            checkSeguroM.TabIndex = 16;
            checkSeguroM.Text = "Seguro medico";
            checkSeguroM.UseVisualStyleBackColor = true;
            // 
            // frmDatosAleatorios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 513);
            Controls.Add(checkSeguroM);
            Controls.Add(comboGrupo);
            Controls.Add(radioMasculino);
            Controls.Add(radioFemenino);
            Controls.Add(dateFechaNacimiento);
            Controls.Add(GenerarDatosAleatorios);
            Controls.Add(txtSueldo);
            Controls.Add(txtNumero);
            Controls.Add(txtNombre);
            Controls.Add(Grupo);
            Controls.Add(Sueldo);
            Controls.Add(FechaDeNacimiento);
            Controls.Add(Número);
            Controls.Add(DatosDelEmpleado);
            Controls.Add(Nombre);
            Name = "frmDatosAleatorios";
            Text = "Empleado con datos aleatorios";
            Load += frmDatosAleatorios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostratMensaje;
        private Label Nombre;
        private Label DatosDelEmpleado;
        private Label Número;
        private Label FechaDeNacimiento;
        private Label Sueldo;
        private Label Grupo;
        private TextBox txtNombre;
        private TextBox txtNumero;
        private TextBox txtSueldo;
        private Button GenerarDatosAleatorios;
        private DateTimePicker dateFechaNacimiento;
        private RadioButton radioFemenino;
        private RadioButton radioMasculino;
        private ComboBox comboGrupo;
        private CheckBox checkSeguroM;
    }
}
