namespace WinFormsCarService
{
    partial class AddCarForm
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
            this.groupBoxAutomobile = new System.Windows.Forms.GroupBox();
            this.buttonAutoDelete = new System.Windows.Forms.Button();
            this.buttonAutoUpdate = new System.Windows.Forms.Button();
            this.textBoxAutoId = new System.Windows.Forms.TextBox();
            this.labelAutoId = new System.Windows.Forms.Label();
            this.buttonAddAuto = new System.Windows.Forms.Button();
            this.textBoxIdClient = new System.Windows.Forms.TextBox();
            this.textBoxDenumireSasiu = new System.Windows.Forms.TextBox();
            this.textBoxCodSasiu = new System.Windows.Forms.TextBox();
            this.textBoxSerieSasiu = new System.Windows.Forms.TextBox();
            this.labelAutoClientId = new System.Windows.Forms.Label();
            this.textBoxNumarAuto = new System.Windows.Forms.TextBox();
            this.labelSasiuDenumire = new System.Windows.Forms.Label();
            this.labelSasiuCod = new System.Windows.Forms.Label();
            this.labelAutoSerieSasiu = new System.Windows.Forms.Label();
            this.labelAutoNumar = new System.Windows.Forms.Label();
            this.groupBoxAutomobile.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBoxAutomobile.Location = new System.Drawing.Point(257, 113);
            this.groupBoxAutomobile.Name = "groupBoxAutomobile";
            this.groupBoxAutomobile.Size = new System.Drawing.Size(286, 225);
            this.groupBoxAutomobile.TabIndex = 8;
            this.groupBoxAutomobile.TabStop = false;
            this.groupBoxAutomobile.Text = "Auto";
            // 
            // buttonAutoDelete
            // 
            this.buttonAutoDelete.Location = new System.Drawing.Point(207, 195);
            this.buttonAutoDelete.Name = "buttonAutoDelete";
            this.buttonAutoDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoDelete.TabIndex = 14;
            this.buttonAutoDelete.Text = "Delete";
            this.buttonAutoDelete.UseVisualStyleBackColor = true;
            // 
            // buttonAutoUpdate
            // 
            this.buttonAutoUpdate.Location = new System.Drawing.Point(125, 195);
            this.buttonAutoUpdate.Name = "buttonAutoUpdate";
            this.buttonAutoUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoUpdate.TabIndex = 13;
            this.buttonAutoUpdate.Text = "Update";
            this.buttonAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // textBoxAutoId
            // 
            this.textBoxAutoId.Location = new System.Drawing.Point(100, 167);
            this.textBoxAutoId.Name = "textBoxAutoId";
            this.textBoxAutoId.Size = new System.Drawing.Size(100, 20);
            this.textBoxAutoId.TabIndex = 12;
            this.textBoxAutoId.TextChanged += new System.EventHandler(this.textBoxAutoId_TextChanged);
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
            // textBoxIdClient
            // 
            this.textBoxIdClient.Location = new System.Drawing.Point(100, 141);
            this.textBoxIdClient.Name = "textBoxIdClient";
            this.textBoxIdClient.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdClient.TabIndex = 9;
            this.textBoxIdClient.TextChanged += new System.EventHandler(this.textBoxIdClient_TextChanged);
            // 
            // textBoxDenumireSasiu
            // 
            this.textBoxDenumireSasiu.Location = new System.Drawing.Point(100, 114);
            this.textBoxDenumireSasiu.Name = "textBoxDenumireSasiu";
            this.textBoxDenumireSasiu.Size = new System.Drawing.Size(100, 20);
            this.textBoxDenumireSasiu.TabIndex = 8;
            this.textBoxDenumireSasiu.TextChanged += new System.EventHandler(this.textBoxDenumireSasiu_TextChanged);
            // 
            // textBoxCodSasiu
            // 
            this.textBoxCodSasiu.Location = new System.Drawing.Point(100, 80);
            this.textBoxCodSasiu.Name = "textBoxCodSasiu";
            this.textBoxCodSasiu.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodSasiu.TabIndex = 7;
            this.textBoxCodSasiu.TextChanged += new System.EventHandler(this.textBoxCodSasiu_TextChanged);
            // 
            // textBoxSerieSasiu
            // 
            this.textBoxSerieSasiu.Location = new System.Drawing.Point(100, 49);
            this.textBoxSerieSasiu.Name = "textBoxSerieSasiu";
            this.textBoxSerieSasiu.Size = new System.Drawing.Size(100, 20);
            this.textBoxSerieSasiu.TabIndex = 6;
            this.textBoxSerieSasiu.TextChanged += new System.EventHandler(this.textBoxSerieSasiu_TextChanged);
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
            // textBoxNumarAuto
            // 
            this.textBoxNumarAuto.Location = new System.Drawing.Point(100, 20);
            this.textBoxNumarAuto.Name = "textBoxNumarAuto";
            this.textBoxNumarAuto.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumarAuto.TabIndex = 4;
            this.textBoxNumarAuto.TextChanged += new System.EventHandler(this.textBoxNumarAuto_TextChanged);
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
            // labelSasiuCod
            // 
            this.labelSasiuCod.AutoSize = true;
            this.labelSasiuCod.Location = new System.Drawing.Point(10, 84);
            this.labelSasiuCod.Name = "labelSasiuCod";
            this.labelSasiuCod.Size = new System.Drawing.Size(55, 13);
            this.labelSasiuCod.TabIndex = 2;
            this.labelSasiuCod.Text = "Cod Sasiu";
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
            // labelAutoNumar
            // 
            this.labelAutoNumar.AutoSize = true;
            this.labelAutoNumar.Location = new System.Drawing.Point(7, 20);
            this.labelAutoNumar.Name = "labelAutoNumar";
            this.labelAutoNumar.Size = new System.Drawing.Size(63, 13);
            this.labelAutoNumar.TabIndex = 0;
            this.labelAutoNumar.Text = "Numar Auto";
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxAutomobile);
            this.Name = "AddCarForm";
            this.Text = "AddCarForm";
            this.groupBoxAutomobile.ResumeLayout(false);
            this.groupBoxAutomobile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAutomobile;
        private System.Windows.Forms.Button buttonAutoDelete;
        private System.Windows.Forms.Button buttonAutoUpdate;
        private System.Windows.Forms.TextBox textBoxAutoId;
        private System.Windows.Forms.Label labelAutoId;
        private System.Windows.Forms.Button buttonAddAuto;
        private System.Windows.Forms.TextBox textBoxIdClient;
        private System.Windows.Forms.TextBox textBoxDenumireSasiu;
        private System.Windows.Forms.TextBox textBoxCodSasiu;
        private System.Windows.Forms.TextBox textBoxSerieSasiu;
        private System.Windows.Forms.Label labelAutoClientId;
        private System.Windows.Forms.TextBox textBoxNumarAuto;
        private System.Windows.Forms.Label labelSasiuDenumire;
        private System.Windows.Forms.Label labelSasiuCod;
        private System.Windows.Forms.Label labelAutoSerieSasiu;
        private System.Windows.Forms.Label labelAutoNumar;
    }
}