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
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxJudet = new System.Windows.Forms.TextBox();
            this.textBoxLocalitate = new System.Windows.Forms.TextBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelJudet = new System.Windows.Forms.Label();
            this.labelLocalitate = new System.Windows.Forms.Label();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.buttonShowAllClients = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxMecanics = new System.Windows.Forms.GroupBox();
            this.buttonAddMecanic = new System.Windows.Forms.Button();
            this.labelMecanicNume = new System.Windows.Forms.Label();
            this.labelMacanicPrenume = new System.Windows.Forms.Label();
            this.textBoxNumeMecanic = new System.Windows.Forms.TextBox();
            this.textBoxPrenumeMecanic = new System.Windows.Forms.TextBox();
            this.labelMecanicId = new System.Windows.Forms.Label();
            this.textBoxMecanicId = new System.Windows.Forms.TextBox();
            this.buttonMecanicUpdate = new System.Windows.Forms.Button();
            this.groupBoxAutomobile = new System.Windows.Forms.GroupBox();
            this.labelAutoNumar = new System.Windows.Forms.Label();
            this.labelAutoSerieSasiu = new System.Windows.Forms.Label();
            this.labelSasiuCod = new System.Windows.Forms.Label();
            this.labelSasiuDenumire = new System.Windows.Forms.Label();
            this.textBoxNumarAuto = new System.Windows.Forms.TextBox();
            this.labelAutoClientId = new System.Windows.Forms.Label();
            this.textBoxSerieSasiu = new System.Windows.Forms.TextBox();
            this.textBoxCodSasiu = new System.Windows.Forms.TextBox();
            this.textBoxDenumireSasiu = new System.Windows.Forms.TextBox();
            this.textBoxIdClient = new System.Windows.Forms.TextBox();
            this.buttonAddAuto = new System.Windows.Forms.Button();
            this.labelAutoId = new System.Windows.Forms.Label();
            this.textBoxAutoId = new System.Windows.Forms.TextBox();
            this.buttonAutoUpdate = new System.Windows.Forms.Button();
            this.buttonAutoDelete = new System.Windows.Forms.Button();
            this.groupBoxClient.SuspendLayout();
            this.groupBoxMecanics.SuspendLayout();
            this.groupBoxAutomobile.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTestData
            // 
            this.buttonTestData.Location = new System.Drawing.Point(681, 390);
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
            this.groupBoxClient.Location = new System.Drawing.Point(12, 12);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(306, 268);
            this.groupBoxClient.TabIndex = 3;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Client";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(96, 232);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 16;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(96, 205);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefon.TabIndex = 15;
            // 
            // textBoxJudet
            // 
            this.textBoxJudet.Location = new System.Drawing.Point(96, 167);
            this.textBoxJudet.Name = "textBoxJudet";
            this.textBoxJudet.Size = new System.Drawing.Size(100, 20);
            this.textBoxJudet.TabIndex = 14;
            // 
            // textBoxLocalitate
            // 
            this.textBoxLocalitate.Location = new System.Drawing.Point(96, 131);
            this.textBoxLocalitate.Name = "textBoxLocalitate";
            this.textBoxLocalitate.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocalitate.TabIndex = 13;
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(96, 101);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdresa.TabIndex = 12;
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Location = new System.Drawing.Point(96, 69);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenume.TabIndex = 11;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(96, 26);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(100, 20);
            this.textBoxNume.TabIndex = 10;
            this.textBoxNume.TextChanged += new System.EventHandler(this.textBoxNume_TextChanged);
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
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(16, 205);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(43, 13);
            this.labelTelefon.TabIndex = 8;
            this.labelTelefon.Text = "Telefon";
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
            // labelLocalitate
            // 
            this.labelLocalitate.AutoSize = true;
            this.labelLocalitate.Location = new System.Drawing.Point(16, 138);
            this.labelLocalitate.Name = "labelLocalitate";
            this.labelLocalitate.Size = new System.Drawing.Size(53, 13);
            this.labelLocalitate.TabIndex = 6;
            this.labelLocalitate.Text = "Localitate";
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
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(10, 69);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(49, 13);
            this.labelPrenume.TabIndex = 4;
            this.labelPrenume.Text = "Prenume";
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
            // buttonShowAllClients
            // 
            this.buttonShowAllClients.Location = new System.Drawing.Point(685, 419);
            this.buttonShowAllClients.Name = "buttonShowAllClients";
            this.buttonShowAllClients.Size = new System.Drawing.Size(103, 23);
            this.buttonShowAllClients.TabIndex = 4;
            this.buttonShowAllClients.Text = "Show all clients";
            this.buttonShowAllClients.UseVisualStyleBackColor = true;
            this.buttonShowAllClients.Click += new System.EventHandler(this.buttonShowAllClients_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(713, 361);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete Client";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxMecanics
            // 
            this.groupBoxMecanics.Controls.Add(this.buttonMecanicUpdate);
            this.groupBoxMecanics.Controls.Add(this.textBoxMecanicId);
            this.groupBoxMecanics.Controls.Add(this.labelMecanicId);
            this.groupBoxMecanics.Controls.Add(this.textBoxPrenumeMecanic);
            this.groupBoxMecanics.Controls.Add(this.textBoxNumeMecanic);
            this.groupBoxMecanics.Controls.Add(this.labelMacanicPrenume);
            this.groupBoxMecanics.Controls.Add(this.labelMecanicNume);
            this.groupBoxMecanics.Controls.Add(this.buttonAddMecanic);
            this.groupBoxMecanics.Location = new System.Drawing.Point(26, 316);
            this.groupBoxMecanics.Name = "groupBoxMecanics";
            this.groupBoxMecanics.Size = new System.Drawing.Size(306, 122);
            this.groupBoxMecanics.TabIndex = 6;
            this.groupBoxMecanics.TabStop = false;
            this.groupBoxMecanics.Text = "Mecanic";
            // 
            // buttonAddMecanic
            // 
            this.buttonAddMecanic.Location = new System.Drawing.Point(196, 33);
            this.buttonAddMecanic.Name = "buttonAddMecanic";
            this.buttonAddMecanic.Size = new System.Drawing.Size(82, 23);
            this.buttonAddMecanic.TabIndex = 0;
            this.buttonAddMecanic.Text = "Add mecanic";
            this.buttonAddMecanic.UseVisualStyleBackColor = true;
            this.buttonAddMecanic.Click += new System.EventHandler(this.buttonAddMecanic_Click);
            // 
            // labelMecanicNume
            // 
            this.labelMecanicNume.AutoSize = true;
            this.labelMecanicNume.Location = new System.Drawing.Point(13, 33);
            this.labelMecanicNume.Name = "labelMecanicNume";
            this.labelMecanicNume.Size = new System.Drawing.Size(35, 13);
            this.labelMecanicNume.TabIndex = 1;
            this.labelMecanicNume.Text = "Nume";
            // 
            // labelMacanicPrenume
            // 
            this.labelMacanicPrenume.AutoSize = true;
            this.labelMacanicPrenume.Location = new System.Drawing.Point(13, 71);
            this.labelMacanicPrenume.Name = "labelMacanicPrenume";
            this.labelMacanicPrenume.Size = new System.Drawing.Size(49, 13);
            this.labelMacanicPrenume.TabIndex = 2;
            this.labelMacanicPrenume.Text = "Prenume";
            // 
            // textBoxNumeMecanic
            // 
            this.textBoxNumeMecanic.Location = new System.Drawing.Point(72, 33);
            this.textBoxNumeMecanic.Name = "textBoxNumeMecanic";
            this.textBoxNumeMecanic.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeMecanic.TabIndex = 3;
            this.textBoxNumeMecanic.TextChanged += new System.EventHandler(this.textBoxNumeMecanic_TextChanged);
            // 
            // textBoxPrenumeMecanic
            // 
            this.textBoxPrenumeMecanic.Location = new System.Drawing.Point(72, 71);
            this.textBoxPrenumeMecanic.Name = "textBoxPrenumeMecanic";
            this.textBoxPrenumeMecanic.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenumeMecanic.TabIndex = 4;
            // 
            // labelMecanicId
            // 
            this.labelMecanicId.AutoSize = true;
            this.labelMecanicId.Location = new System.Drawing.Point(16, 103);
            this.labelMecanicId.Name = "labelMecanicId";
            this.labelMecanicId.Size = new System.Drawing.Size(16, 13);
            this.labelMecanicId.TabIndex = 5;
            this.labelMecanicId.Text = "Id";
            // 
            // textBoxMecanicId
            // 
            this.textBoxMecanicId.Location = new System.Drawing.Point(72, 96);
            this.textBoxMecanicId.Name = "textBoxMecanicId";
            this.textBoxMecanicId.Size = new System.Drawing.Size(100, 20);
            this.textBoxMecanicId.TabIndex = 6;
            // 
            // buttonMecanicUpdate
            // 
            this.buttonMecanicUpdate.Location = new System.Drawing.Point(196, 67);
            this.buttonMecanicUpdate.Name = "buttonMecanicUpdate";
            this.buttonMecanicUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonMecanicUpdate.TabIndex = 7;
            this.buttonMecanicUpdate.Text = "Update";
            this.buttonMecanicUpdate.UseVisualStyleBackColor = true;
            this.buttonMecanicUpdate.Click += new System.EventHandler(this.buttonMecanicUpdate_Click);
            // 
            // groupBoxAutomobile
            // 
            this.groupBoxAutomobile.Controls.Add(this.buttonAutoDelete);
            this.groupBoxAutomobile.Controls.Add(this.buttonAutoUpdate);
            this.groupBoxAutomobile.Controls.Add(this.textBoxAutoId);
            this.groupBoxAutomobile.Controls.Add(this.labelAutoId);
            this.groupBoxAutomobile.Controls.Add(this.buttonAddAuto);
            this.groupBoxAutomobile.Controls.Add(this.textBoxIdClient);
            this.groupBoxAutomobile.Controls.Add(this.textBoxDenumireSasiu);
            this.groupBoxAutomobile.Controls.Add(this.textBoxCodSasiu);
            this.groupBoxAutomobile.Controls.Add(this.textBoxSerieSasiu);
            this.groupBoxAutomobile.Controls.Add(this.labelAutoClientId);
            this.groupBoxAutomobile.Controls.Add(this.textBoxNumarAuto);
            this.groupBoxAutomobile.Controls.Add(this.labelSasiuDenumire);
            this.groupBoxAutomobile.Controls.Add(this.labelSasiuCod);
            this.groupBoxAutomobile.Controls.Add(this.labelAutoSerieSasiu);
            this.groupBoxAutomobile.Controls.Add(this.labelAutoNumar);
            this.groupBoxAutomobile.Location = new System.Drawing.Point(324, 12);
            this.groupBoxAutomobile.Name = "groupBoxAutomobile";
            this.groupBoxAutomobile.Size = new System.Drawing.Size(286, 225);
            this.groupBoxAutomobile.TabIndex = 7;
            this.groupBoxAutomobile.TabStop = false;
            this.groupBoxAutomobile.Text = "Auto";
            // 
            // labelAutoNumar
            // 
            this.labelAutoNumar.AutoSize = true;
            this.labelAutoNumar.Location = new System.Drawing.Point(7, 20);
            this.labelAutoNumar.Name = "labelAutoNumar";
            this.labelAutoNumar.Size = new System.Drawing.Size(63, 13);
            this.labelAutoNumar.TabIndex = 0;
            this.labelAutoNumar.Text = "Numar Auto";
            // 
            // labelAutoSerieSasiu
            // 
            this.labelAutoSerieSasiu.AutoSize = true;
            this.labelAutoSerieSasiu.Location = new System.Drawing.Point(10, 49);
            this.labelAutoSerieSasiu.Name = "labelAutoSerieSasiu";
            this.labelAutoSerieSasiu.Size = new System.Drawing.Size(60, 13);
            this.labelAutoSerieSasiu.TabIndex = 1;
            this.labelAutoSerieSasiu.Text = "Serie Sasiu";
            // 
            // labelSasiuCod
            // 
            this.labelSasiuCod.AutoSize = true;
            this.labelSasiuCod.Location = new System.Drawing.Point(10, 84);
            this.labelSasiuCod.Name = "labelSasiuCod";
            this.labelSasiuCod.Size = new System.Drawing.Size(55, 13);
            this.labelSasiuCod.TabIndex = 2;
            this.labelSasiuCod.Text = "Cod Sasiu";
            // 
            // labelSasiuDenumire
            // 
            this.labelSasiuDenumire.AutoSize = true;
            this.labelSasiuDenumire.Location = new System.Drawing.Point(6, 114);
            this.labelSasiuDenumire.Name = "labelSasiuDenumire";
            this.labelSasiuDenumire.Size = new System.Drawing.Size(81, 13);
            this.labelSasiuDenumire.TabIndex = 3;
            this.labelSasiuDenumire.Text = "Denumire Sasiu";
            // 
            // textBoxNumarAuto
            // 
            this.textBoxNumarAuto.Location = new System.Drawing.Point(100, 20);
            this.textBoxNumarAuto.Name = "textBoxNumarAuto";
            this.textBoxNumarAuto.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumarAuto.TabIndex = 4;
            // 
            // labelAutoClientId
            // 
            this.labelAutoClientId.AutoSize = true;
            this.labelAutoClientId.Location = new System.Drawing.Point(10, 141);
            this.labelAutoClientId.Name = "labelAutoClientId";
            this.labelAutoClientId.Size = new System.Drawing.Size(45, 13);
            this.labelAutoClientId.TabIndex = 5;
            this.labelAutoClientId.Text = "Id Client";
            // 
            // textBoxSerieSasiu
            // 
            this.textBoxSerieSasiu.Location = new System.Drawing.Point(100, 49);
            this.textBoxSerieSasiu.Name = "textBoxSerieSasiu";
            this.textBoxSerieSasiu.Size = new System.Drawing.Size(100, 20);
            this.textBoxSerieSasiu.TabIndex = 6;
            // 
            // textBoxCodSasiu
            // 
            this.textBoxCodSasiu.Location = new System.Drawing.Point(100, 80);
            this.textBoxCodSasiu.Name = "textBoxCodSasiu";
            this.textBoxCodSasiu.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodSasiu.TabIndex = 7;
            // 
            // textBoxDenumireSasiu
            // 
            this.textBoxDenumireSasiu.Location = new System.Drawing.Point(100, 114);
            this.textBoxDenumireSasiu.Name = "textBoxDenumireSasiu";
            this.textBoxDenumireSasiu.Size = new System.Drawing.Size(100, 20);
            this.textBoxDenumireSasiu.TabIndex = 8;
            // 
            // textBoxIdClient
            // 
            this.textBoxIdClient.Location = new System.Drawing.Point(100, 141);
            this.textBoxIdClient.Name = "textBoxIdClient";
            this.textBoxIdClient.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdClient.TabIndex = 9;
            // 
            // buttonAddAuto
            // 
            this.buttonAddAuto.Location = new System.Drawing.Point(23, 196);
            this.buttonAddAuto.Name = "buttonAddAuto";
            this.buttonAddAuto.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAuto.TabIndex = 10;
            this.buttonAddAuto.Text = "Add auto";
            this.buttonAddAuto.UseVisualStyleBackColor = true;
            this.buttonAddAuto.Click += new System.EventHandler(this.buttonAddAuto_Click);
            // 
            // labelAutoId
            // 
            this.labelAutoId.AutoSize = true;
            this.labelAutoId.Location = new System.Drawing.Point(15, 165);
            this.labelAutoId.Name = "labelAutoId";
            this.labelAutoId.Size = new System.Drawing.Size(16, 13);
            this.labelAutoId.TabIndex = 11;
            this.labelAutoId.Text = "Id";
            // 
            // textBoxAutoId
            // 
            this.textBoxAutoId.Location = new System.Drawing.Point(100, 167);
            this.textBoxAutoId.Name = "textBoxAutoId";
            this.textBoxAutoId.Size = new System.Drawing.Size(100, 20);
            this.textBoxAutoId.TabIndex = 12;
            // 
            // buttonAutoUpdate
            // 
            this.buttonAutoUpdate.Location = new System.Drawing.Point(125, 195);
            this.buttonAutoUpdate.Name = "buttonAutoUpdate";
            this.buttonAutoUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoUpdate.TabIndex = 13;
            this.buttonAutoUpdate.Text = "Update";
            this.buttonAutoUpdate.UseVisualStyleBackColor = true;
            this.buttonAutoUpdate.Click += new System.EventHandler(this.buttonAutoUpdate_Click);
            // 
            // buttonAutoDelete
            // 
            this.buttonAutoDelete.Location = new System.Drawing.Point(207, 195);
            this.buttonAutoDelete.Name = "buttonAutoDelete";
            this.buttonAutoDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoDelete.TabIndex = 14;
            this.buttonAutoDelete.Text = "Delete";
            this.buttonAutoDelete.UseVisualStyleBackColor = true;
            this.buttonAutoDelete.Click += new System.EventHandler(this.buttonAutoDelete_Click);
            // 
            // CarServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxAutomobile);
            this.Controls.Add(this.groupBoxMecanics);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonShowAllClients);
            this.Controls.Add(this.groupBoxClient);
            this.Controls.Add(this.buttonTestData);
            this.Name = "CarServiceForm";
            this.Text = "Car service";
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.groupBoxMecanics.ResumeLayout(false);
            this.groupBoxMecanics.PerformLayout();
            this.groupBoxAutomobile.ResumeLayout(false);
            this.groupBoxAutomobile.PerformLayout();
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
        private System.Windows.Forms.Button buttonShowAllClients;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxMecanics;
        private System.Windows.Forms.TextBox textBoxPrenumeMecanic;
        private System.Windows.Forms.TextBox textBoxNumeMecanic;
        private System.Windows.Forms.Label labelMacanicPrenume;
        private System.Windows.Forms.Label labelMecanicNume;
        private System.Windows.Forms.Button buttonAddMecanic;
        private System.Windows.Forms.Button buttonMecanicUpdate;
        private System.Windows.Forms.TextBox textBoxMecanicId;
        private System.Windows.Forms.Label labelMecanicId;
        private System.Windows.Forms.GroupBox groupBoxAutomobile;
        private System.Windows.Forms.Label labelAutoSerieSasiu;
        private System.Windows.Forms.Label labelAutoNumar;
        private System.Windows.Forms.Label labelSasiuCod;
        private System.Windows.Forms.Button buttonAddAuto;
        private System.Windows.Forms.TextBox textBoxIdClient;
        private System.Windows.Forms.TextBox textBoxDenumireSasiu;
        private System.Windows.Forms.TextBox textBoxCodSasiu;
        private System.Windows.Forms.TextBox textBoxSerieSasiu;
        private System.Windows.Forms.Label labelAutoClientId;
        private System.Windows.Forms.TextBox textBoxNumarAuto;
        private System.Windows.Forms.Label labelSasiuDenumire;
        private System.Windows.Forms.Button buttonAutoUpdate;
        private System.Windows.Forms.TextBox textBoxAutoId;
        private System.Windows.Forms.Label labelAutoId;
        private System.Windows.Forms.Button buttonAutoDelete;
    }
}

