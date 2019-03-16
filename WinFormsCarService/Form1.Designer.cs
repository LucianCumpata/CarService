namespace WinFormsCarService
{
    partial class CarServiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTestData = new System.Windows.Forms.Button();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.labelLocalitate = new System.Windows.Forms.Label();
            this.labelJudet = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.textBoxLocalitate = new System.Windows.Forms.TextBox();
            this.textBoxJudet = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.groupBoxClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTestData
            // 
            this.buttonTestData.Location = new System.Drawing.Point(630, 349);
            this.buttonTestData.Name = "buttonTestData";
            this.buttonTestData.Size = new System.Drawing.Size(107, 23);
            this.buttonTestData.TabIndex = 0;
            this.buttonTestData.Text = "Add test data";
            this.buttonTestData.UseVisualStyleBackColor = true;
            this.buttonTestData.Click += new System.EventHandler(this.buttonTestData_Click);
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(225, 239);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(75, 23);
            this.buttonAddClient.TabIndex = 1;
            this.buttonAddClient.Text = "Add client";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.textBoxEmail);
            this.groupBoxClient.Controls.Add(this.textBoxTelefon);
            this.groupBoxClient.Controls.Add(this.textBoxJudet);
            this.groupBoxClient.Controls.Add(this.textBoxLocalitate);
            this.groupBoxClient.Controls.Add(this.textBoxAdresa);
            this.groupBoxClient.Controls.Add(this.textBoxPrenume);
            this.groupBoxClient.Controls.Add(this.textBoxNume);
            this.groupBoxClient.Controls.Add(this.labelEmail);
            this.groupBoxClient.Controls.Add(this.labelTelefon);
            this.groupBoxClient.Controls.Add(this.labelJudet);
            this.groupBoxClient.Controls.Add(this.labelLocalitate);
            this.groupBoxClient.Controls.Add(this.labelAdresa);
            this.groupBoxClient.Controls.Add(this.labelPrenume);
            this.groupBoxClient.Controls.Add(this.labelNume);
            this.groupBoxClient.Controls.Add(this.buttonAddClient);
            this.groupBoxClient.Location = new System.Drawing.Point(26, 26);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(306, 268);
            this.groupBoxClient.TabIndex = 3;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Client";
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(7, 34);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(35, 13);
            this.labelNume.TabIndex = 3;
            this.labelNume.Text = "Nume";
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(10, 69);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(49, 13);
            this.labelPrenume.TabIndex = 4;
            this.labelPrenume.Text = "Prenume";
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Location = new System.Drawing.Point(13, 104);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(40, 13);
            this.labelAdresa.TabIndex = 5;
            this.labelAdresa.Text = "Adresa";
            // 
            // labelLocalitate
            // 
            this.labelLocalitate.AutoSize = true;
            this.labelLocalitate.Location = new System.Drawing.Point(16, 138);
            this.labelLocalitate.Name = "labelLocalitate";
            this.labelLocalitate.Size = new System.Drawing.Size(53, 13);
            this.labelLocalitate.TabIndex = 6;
            this.labelLocalitate.Text = "Localitate";
            // 
            // labelJudet
            // 
            this.labelJudet.AutoSize = true;
            this.labelJudet.Location = new System.Drawing.Point(16, 174);
            this.labelJudet.Name = "labelJudet";
            this.labelJudet.Size = new System.Drawing.Size(33, 13);
            this.labelJudet.TabIndex = 7;
            this.labelJudet.Text = "Judet";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(16, 205);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(43, 13);
            this.labelTelefon.TabIndex = 8;
            this.labelTelefon.Text = "Telefon";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(13, 239);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Email";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(96, 26);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(100, 20);
            this.textBoxNume.TabIndex = 10;
            this.textBoxNume.TextChanged += new System.EventHandler(this.textBoxNume_TextChanged);
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Location = new System.Drawing.Point(96, 69);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenume.TabIndex = 11;
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(96, 101);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdresa.TabIndex = 12;
            // 
            // textBoxLocalitate
            // 
            this.textBoxLocalitate.Location = new System.Drawing.Point(96, 131);
            this.textBoxLocalitate.Name = "textBoxLocalitate";
            this.textBoxLocalitate.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocalitate.TabIndex = 13;
            // 
            // textBoxJudet
            // 
            this.textBoxJudet.Location = new System.Drawing.Point(96, 167);
            this.textBoxJudet.Name = "textBoxJudet";
            this.textBoxJudet.Size = new System.Drawing.Size(100, 20);
            this.textBoxJudet.TabIndex = 14;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(96, 205);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefon.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(96, 232);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 16;
            // 
            // CarServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxClient);
            this.Controls.Add(this.buttonTestData);
            this.Name = "CarServiceForm";
            this.Text = "Car service";
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTestData;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.Label labelJudet;
        private System.Windows.Forms.Label labelLocalitate;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxJudet;
        private System.Windows.Forms.TextBox textBoxLocalitate;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.TextBox textBoxNume;
    }
}

