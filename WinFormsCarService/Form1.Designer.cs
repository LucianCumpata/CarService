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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewClients = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxSearchClient = new System.Windows.Forms.TextBox();
            this.buttonSearchClient = new System.Windows.Forms.Button();
            this.newMecanicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewCars = new System.Windows.Forms.ListView();
            this.columnHeaderCarId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCarNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.buttonAutoDelete = new System.Windows.Forms.Button();
            this.buttonAutoUpdate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllClientsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newClientToolStripMenuItem,
            this.newMecanicToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // newClientToolStripMenuItem
            // 
            this.newClientToolStripMenuItem.Name = "newClientToolStripMenuItem";
            this.newClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newClientToolStripMenuItem.Text = "New client";
            this.newClientToolStripMenuItem.Click += new System.EventHandler(this.newClientToolStripMenuItem_Click);
            // 
            // showAllClientsToolStripMenuItem
            // 
            this.showAllClientsToolStripMenuItem.Name = "showAllClientsToolStripMenuItem";
            this.showAllClientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showAllClientsToolStripMenuItem.Text = "Show all clients";
            this.showAllClientsToolStripMenuItem.Click += new System.EventHandler(this.showAllClientsToolStripMenuItem_Click);
            // 
            // listViewClients
            // 
            this.listViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderFName,
            this.columnHeaderLName,
            this.columnHeaderPhone});
            this.listViewClients.FullRowSelect = true;
            this.listViewClients.Location = new System.Drawing.Point(26, 44);
            this.listViewClients.Name = "listViewClients";
            this.listViewClients.Size = new System.Drawing.Size(332, 183);
            this.listViewClients.TabIndex = 9;
            this.listViewClients.UseCompatibleStateImageBehavior = false;
            this.listViewClients.View = System.Windows.Forms.View.Details;
            this.listViewClients.SelectedIndexChanged += new System.EventHandler(this.listViewClients_SelectedIndexChanged);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            // 
            // columnHeaderFName
            // 
            this.columnHeaderFName.Text = "Nume";
            // 
            // columnHeaderLName
            // 
            this.columnHeaderLName.Text = "Prenume";
            // 
            // columnHeaderPhone
            // 
            this.columnHeaderPhone.Text = "Telefon";
            // 
            // textBoxSearchClient
            // 
            this.textBoxSearchClient.Location = new System.Drawing.Point(26, 239);
            this.textBoxSearchClient.Name = "textBoxSearchClient";
            this.textBoxSearchClient.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchClient.TabIndex = 10;
            // 
            // buttonSearchClient
            // 
            this.buttonSearchClient.Location = new System.Drawing.Point(162, 238);
            this.buttonSearchClient.Name = "buttonSearchClient";
            this.buttonSearchClient.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchClient.TabIndex = 11;
            this.buttonSearchClient.Text = "Cauta";
            this.buttonSearchClient.UseVisualStyleBackColor = true;
            this.buttonSearchClient.Click += new System.EventHandler(this.buttonSearchClient_Click);
            // 
            // newMecanicToolStripMenuItem
            // 
            this.newMecanicToolStripMenuItem.Name = "newMecanicToolStripMenuItem";
            this.newMecanicToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newMecanicToolStripMenuItem.Text = "New mecanic";
            this.newMecanicToolStripMenuItem.Click += new System.EventHandler(this.newMecanicToolStripMenuItem_Click);
            // 
            // listViewCars
            // 
            this.listViewCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCarId,
            this.columnHeaderCarNr});
            this.listViewCars.Location = new System.Drawing.Point(394, 44);
            this.listViewCars.Name = "listViewCars";
            this.listViewCars.Size = new System.Drawing.Size(235, 183);
            this.listViewCars.TabIndex = 12;
            this.listViewCars.UseCompatibleStateImageBehavior = false;
            this.listViewCars.View = System.Windows.Forms.View.Details;
            this.listViewCars.SelectedIndexChanged += new System.EventHandler(this.listViewCars_SelectedIndexChanged);
            // 
            // columnHeaderCarId
            // 
            this.columnHeaderCarId.Text = "Id";
            this.columnHeaderCarId.Width = 39;
            // 
            // columnHeaderCarNr
            // 
            this.columnHeaderCarNr.Text = "Numar Auto";
            this.columnHeaderCarNr.Width = 73;
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Location = new System.Drawing.Point(394, 233);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(73, 23);
            this.buttonAddCar.TabIndex = 13;
            this.buttonAddCar.Text = "Adauga";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // buttonAutoDelete
            // 
            this.buttonAutoDelete.Location = new System.Drawing.Point(554, 233);
            this.buttonAutoDelete.Name = "buttonAutoDelete";
            this.buttonAutoDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoDelete.TabIndex = 14;
            this.buttonAutoDelete.Text = "Sterge";
            this.buttonAutoDelete.UseVisualStyleBackColor = true;
            // 
            // buttonAutoUpdate
            // 
            this.buttonAutoUpdate.Location = new System.Drawing.Point(473, 233);
            this.buttonAutoUpdate.Name = "buttonAutoUpdate";
            this.buttonAutoUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoUpdate.TabIndex = 15;
            this.buttonAutoUpdate.Text = "Modifica";
            this.buttonAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // CarServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonAutoUpdate);
            this.Controls.Add(this.buttonAutoDelete);
            this.Controls.Add(this.buttonAddCar);
            this.Controls.Add(this.listViewCars);
            this.Controls.Add(this.buttonSearchClient);
            this.Controls.Add(this.textBoxSearchClient);
            this.Controls.Add(this.listViewClients);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CarServiceForm";
            this.Text = "Car service";
            this.Load += new System.EventHandler(this.CarServiceForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllClientsToolStripMenuItem;
        private System.Windows.Forms.ListView listViewClients;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderFName;
        private System.Windows.Forms.ColumnHeader columnHeaderLName;
        private System.Windows.Forms.ColumnHeader columnHeaderPhone;
        private System.Windows.Forms.TextBox textBoxSearchClient;
        private System.Windows.Forms.Button buttonSearchClient;
        private System.Windows.Forms.ToolStripMenuItem newMecanicToolStripMenuItem;
        private System.Windows.Forms.ListView listViewCars;
        private System.Windows.Forms.ColumnHeader columnHeaderCarId;
        private System.Windows.Forms.ColumnHeader columnHeaderCarNr;
        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.Button buttonAutoDelete;
        private System.Windows.Forms.Button buttonAutoUpdate;
    }
}

