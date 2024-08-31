namespace WindowsFormsApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAirline = new System.Windows.Forms.TextBox();
            this.textBoxFlightNumber = new System.Windows.Forms.TextBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.comboBoxAirplaneType = new System.Windows.Forms.ComboBox();
            this.buttonAddFlight = new System.Windows.Forms.Button();
            this.comboBoxFlightGeneral = new System.Windows.Forms.ComboBox();
            this.buttonUpdateFlight = new System.Windows.Forms.Button();
            this.buttonDeleteFlight = new System.Windows.Forms.Button();
            this.dataGridViewFlight = new System.Windows.Forms.DataGridView();
            this.buttonRefreshFlight = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNameUser = new System.Windows.Forms.TextBox();
            this.textBoxEmailUser = new System.Windows.Forms.TextBox();
            this.textBoxAddressUser = new System.Windows.Forms.TextBox();
            this.textBoxAgeUser = new System.Windows.Forms.TextBox();
            this.comboBoxFlightNumber = new System.Windows.Forms.ComboBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonRefreshUser = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.comboBoxUserGeneral = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonRefreshFlight);
            this.tabPage1.Controls.Add(this.dataGridViewFlight);
            this.tabPage1.Controls.Add(this.buttonDeleteFlight);
            this.tabPage1.Controls.Add(this.buttonUpdateFlight);
            this.tabPage1.Controls.Add(this.comboBoxFlightGeneral);
            this.tabPage1.Controls.Add(this.buttonAddFlight);
            this.tabPage1.Controls.Add(this.comboBoxAirplaneType);
            this.tabPage1.Controls.Add(this.textBoxDestination);
            this.tabPage1.Controls.Add(this.textBoxFlightNumber);
            this.tabPage1.Controls.Add(this.textBoxAirline);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Flight Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxUserGeneral);
            this.tabPage2.Controls.Add(this.buttonUser);
            this.tabPage2.Controls.Add(this.buttonRefreshUser);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.buttonAddUser);
            this.tabPage2.Controls.Add(this.comboBoxFlightNumber);
            this.tabPage2.Controls.Add(this.textBoxAgeUser);
            this.tabPage2.Controls.Add(this.textBoxAddressUser);
            this.tabPage2.Controls.Add(this.textBoxEmailUser);
            this.tabPage2.Controls.Add(this.textBoxNameUser);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.buttonDeleteUser);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Airline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Flight Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Airplane Type";
            // 
            // textBoxAirline
            // 
            this.textBoxAirline.Location = new System.Drawing.Point(180, 30);
            this.textBoxAirline.Name = "textBoxAirline";
            this.textBoxAirline.Size = new System.Drawing.Size(203, 22);
            this.textBoxAirline.TabIndex = 4;
            // 
            // textBoxFlightNumber
            // 
            this.textBoxFlightNumber.Location = new System.Drawing.Point(180, 58);
            this.textBoxFlightNumber.Name = "textBoxFlightNumber";
            this.textBoxFlightNumber.Size = new System.Drawing.Size(203, 22);
            this.textBoxFlightNumber.TabIndex = 5;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(180, 86);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(203, 22);
            this.textBoxDestination.TabIndex = 6;
            // 
            // comboBoxAirplaneType
            // 
            this.comboBoxAirplaneType.FormattingEnabled = true;
            this.comboBoxAirplaneType.Location = new System.Drawing.Point(180, 114);
            this.comboBoxAirplaneType.Name = "comboBoxAirplaneType";
            this.comboBoxAirplaneType.Size = new System.Drawing.Size(203, 24);
            this.comboBoxAirplaneType.TabIndex = 7;
            // 
            // buttonAddFlight
            // 
            this.buttonAddFlight.Location = new System.Drawing.Point(506, 33);
            this.buttonAddFlight.Name = "buttonAddFlight";
            this.buttonAddFlight.Size = new System.Drawing.Size(203, 23);
            this.buttonAddFlight.TabIndex = 8;
            this.buttonAddFlight.Text = "Add";
            this.buttonAddFlight.UseVisualStyleBackColor = true;
            this.buttonAddFlight.Click += new System.EventHandler(this.buttonAddFlight_Click);
            // 
            // comboBoxFlightGeneral
            // 
            this.comboBoxFlightGeneral.FormattingEnabled = true;
            this.comboBoxFlightGeneral.Location = new System.Drawing.Point(506, 72);
            this.comboBoxFlightGeneral.Name = "comboBoxFlightGeneral";
            this.comboBoxFlightGeneral.Size = new System.Drawing.Size(203, 24);
            this.comboBoxFlightGeneral.TabIndex = 9;
            this.comboBoxFlightGeneral.SelectedIndexChanged += new System.EventHandler(this.comboBoxFlightGeneral_SelectedIndexChanged);
            // 
            // buttonUpdateFlight
            // 
            this.buttonUpdateFlight.Location = new System.Drawing.Point(506, 110);
            this.buttonUpdateFlight.Name = "buttonUpdateFlight";
            this.buttonUpdateFlight.Size = new System.Drawing.Size(98, 23);
            this.buttonUpdateFlight.TabIndex = 10;
            this.buttonUpdateFlight.Text = "Update";
            this.buttonUpdateFlight.UseVisualStyleBackColor = true;
            this.buttonUpdateFlight.Click += new System.EventHandler(this.buttonUpdateFlight_Click);
            // 
            // buttonDeleteFlight
            // 
            this.buttonDeleteFlight.Location = new System.Drawing.Point(611, 110);
            this.buttonDeleteFlight.Name = "buttonDeleteFlight";
            this.buttonDeleteFlight.Size = new System.Drawing.Size(98, 23);
            this.buttonDeleteFlight.TabIndex = 11;
            this.buttonDeleteFlight.Text = "Delete";
            this.buttonDeleteFlight.UseVisualStyleBackColor = true;
            this.buttonDeleteFlight.Click += new System.EventHandler(this.buttonDeleteFlight_Click);
            // 
            // dataGridViewFlight
            // 
            this.dataGridViewFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlight.Location = new System.Drawing.Point(39, 144);
            this.dataGridViewFlight.Name = "dataGridViewFlight";
            this.dataGridViewFlight.RowHeadersWidth = 51;
            this.dataGridViewFlight.RowTemplate.Height = 24;
            this.dataGridViewFlight.Size = new System.Drawing.Size(670, 224);
            this.dataGridViewFlight.TabIndex = 12;
            // 
            // buttonRefreshFlight
            // 
            this.buttonRefreshFlight.Location = new System.Drawing.Point(611, 374);
            this.buttonRefreshFlight.Name = "buttonRefreshFlight";
            this.buttonRefreshFlight.Size = new System.Drawing.Size(98, 23);
            this.buttonRefreshFlight.TabIndex = 13;
            this.buttonRefreshFlight.Text = "Refresh";
            this.buttonRefreshFlight.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(601, 119);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteUser.TabIndex = 12;
            this.buttonDeleteUser.Text = "Delete";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Age";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Flight Number";
            // 
            // textBoxNameUser
            // 
            this.textBoxNameUser.Location = new System.Drawing.Point(168, 32);
            this.textBoxNameUser.Name = "textBoxNameUser";
            this.textBoxNameUser.Size = new System.Drawing.Size(203, 22);
            this.textBoxNameUser.TabIndex = 17;
            // 
            // textBoxEmailUser
            // 
            this.textBoxEmailUser.Location = new System.Drawing.Point(168, 60);
            this.textBoxEmailUser.Name = "textBoxEmailUser";
            this.textBoxEmailUser.Size = new System.Drawing.Size(203, 22);
            this.textBoxEmailUser.TabIndex = 18;
            // 
            // textBoxAddressUser
            // 
            this.textBoxAddressUser.Location = new System.Drawing.Point(168, 88);
            this.textBoxAddressUser.Name = "textBoxAddressUser";
            this.textBoxAddressUser.Size = new System.Drawing.Size(203, 22);
            this.textBoxAddressUser.TabIndex = 19;
            // 
            // textBoxAgeUser
            // 
            this.textBoxAgeUser.Location = new System.Drawing.Point(168, 116);
            this.textBoxAgeUser.Name = "textBoxAgeUser";
            this.textBoxAgeUser.Size = new System.Drawing.Size(203, 22);
            this.textBoxAgeUser.TabIndex = 20;
            // 
            // comboBoxFlightNumber
            // 
            this.comboBoxFlightNumber.FormattingEnabled = true;
            this.comboBoxFlightNumber.Location = new System.Drawing.Point(168, 144);
            this.comboBoxFlightNumber.Name = "comboBoxFlightNumber";
            this.comboBoxFlightNumber.Size = new System.Drawing.Size(203, 24);
            this.comboBoxFlightNumber.TabIndex = 21;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(473, 35);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(203, 23);
            this.buttonAddUser.TabIndex = 22;
            this.buttonAddUser.Text = "Add";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(42, 174);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(670, 201);
            this.dataGridView2.TabIndex = 23;
            // 
            // buttonRefreshUser
            // 
            this.buttonRefreshUser.Location = new System.Drawing.Point(614, 381);
            this.buttonRefreshUser.Name = "buttonRefreshUser";
            this.buttonRefreshUser.Size = new System.Drawing.Size(98, 23);
            this.buttonRefreshUser.TabIndex = 24;
            this.buttonRefreshUser.Text = "Refresh";
            this.buttonRefreshUser.UseVisualStyleBackColor = true;
            // 
            // buttonUser
            // 
            this.buttonUser.Location = new System.Drawing.Point(473, 119);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(98, 23);
            this.buttonUser.TabIndex = 25;
            this.buttonUser.Text = "Update";
            this.buttonUser.UseVisualStyleBackColor = true;
            // 
            // comboBoxUserGeneral
            // 
            this.comboBoxUserGeneral.FormattingEnabled = true;
            this.comboBoxUserGeneral.Location = new System.Drawing.Point(473, 74);
            this.comboBoxUserGeneral.Name = "comboBoxUserGeneral";
            this.comboBoxUserGeneral.Size = new System.Drawing.Size(203, 24);
            this.comboBoxUserGeneral.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAirplaneType;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.TextBox textBoxFlightNumber;
        private System.Windows.Forms.TextBox textBoxAirline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRefreshFlight;
        private System.Windows.Forms.DataGridView dataGridViewFlight;
        private System.Windows.Forms.Button buttonDeleteFlight;
        private System.Windows.Forms.Button buttonUpdateFlight;
        private System.Windows.Forms.ComboBox comboBoxFlightGeneral;
        private System.Windows.Forms.Button buttonAddFlight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRefreshUser;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.ComboBox comboBoxFlightNumber;
        private System.Windows.Forms.TextBox textBoxAgeUser;
        private System.Windows.Forms.TextBox textBoxAddressUser;
        private System.Windows.Forms.TextBox textBoxEmailUser;
        private System.Windows.Forms.TextBox textBoxNameUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.ComboBox comboBoxUserGeneral;
    }
}

