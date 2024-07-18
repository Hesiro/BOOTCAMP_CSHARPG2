namespace WinFormsAppEntradas
{
    partial class FormEntornoGrafico
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
            label1 = new Label();
            buttonPantallaDos = new Button();
            buttonPantallaTres = new Button();
            label2 = new Label();
            textBoxNombre = new TextBox();
            label3 = new Label();
            textBoxApellido = new TextBox();
            label4 = new Label();
            textBoxEdad = new TextBox();
            label5 = new Label();
            textBoxDireccion = new TextBox();
            label6 = new Label();
            comboBoxGenero = new ComboBox();
            buttonInsertar = new Button();
            buttonLimpiar = new Button();
            buttonSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 20);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 0;
            label1.Text = "CAPTURA DE DATOS";
            // 
            // buttonPantallaDos
            // 
            buttonPantallaDos.Location = new Point(339, 68);
            buttonPantallaDos.Name = "buttonPantallaDos";
            buttonPantallaDos.Size = new Size(75, 44);
            buttonPantallaDos.TabIndex = 1;
            buttonPantallaDos.Text = "Pantalla Dos";
            buttonPantallaDos.UseVisualStyleBackColor = true;
            buttonPantallaDos.Click += buttonPantallaDos_Click;
            // 
            // buttonPantallaTres
            // 
            buttonPantallaTres.Location = new Point(339, 126);
            buttonPantallaTres.Name = "buttonPantallaTres";
            buttonPantallaTres.Size = new Size(75, 44);
            buttonPantallaTres.TabIndex = 2;
            buttonPantallaTres.Text = "Pantalla Tres";
            buttonPantallaTres.UseVisualStyleBackColor = true;
            buttonPantallaTres.Click += buttonPantallaTres_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(101, 65);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(169, 23);
            textBoxNombre.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Apellido";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(101, 94);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(169, 23);
            textBoxApellido.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 126);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 7;
            label4.Text = "Edad";
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(101, 123);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(169, 23);
            textBoxEdad.TabIndex = 8;
            textBoxEdad.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 155);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 9;
            label5.Text = "Dirección";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(101, 152);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(169, 23);
            textBoxDireccion.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 184);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 11;
            label6.Text = "Genero";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            comboBoxGenero.Location = new Point(101, 181);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(169, 23);
            comboBoxGenero.TabIndex = 12;
            // 
            // buttonInsertar
            // 
            buttonInsertar.Location = new Point(33, 246);
            buttonInsertar.Name = "buttonInsertar";
            buttonInsertar.Size = new Size(75, 23);
            buttonInsertar.TabIndex = 13;
            buttonInsertar.Text = "Insertar";
            buttonInsertar.UseVisualStyleBackColor = true;
            buttonInsertar.Click += buttonInsertar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(114, 246);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(75, 23);
            buttonLimpiar.TabIndex = 14;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(195, 246);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(75, 23);
            buttonSalir.TabIndex = 15;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            // 
            // FormEntornoGrafico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 292);
            Controls.Add(buttonSalir);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonInsertar);
            Controls.Add(comboBoxGenero);
            Controls.Add(label6);
            Controls.Add(textBoxDireccion);
            Controls.Add(label5);
            Controls.Add(textBoxEdad);
            Controls.Add(label4);
            Controls.Add(textBoxApellido);
            Controls.Add(label3);
            Controls.Add(textBoxNombre);
            Controls.Add(label2);
            Controls.Add(buttonPantallaTres);
            Controls.Add(buttonPantallaDos);
            Controls.Add(label1);
            Name = "FormEntornoGrafico";
            Text = "Entorno Grafico";
            Load += FormEntornoGrafico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonPantallaDos;
        private Button buttonPantallaTres;
        private Label label2;
        private TextBox textBoxNombre;
        private Label label3;
        private TextBox textBoxApellido;
        private Label label4;
        private TextBox textBoxEdad;
        private Label label5;
        private TextBox textBoxDireccion;
        private Label label6;
        private ComboBox comboBoxGenero;
        private Button buttonInsertar;
        private Button buttonLimpiar;
        private Button buttonSalir;
    }
}
