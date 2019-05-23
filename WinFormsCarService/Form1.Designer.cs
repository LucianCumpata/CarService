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
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMecanicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllMecanicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewClients = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClientAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClientLocalitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClientJudet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClientEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxSearchClient = new System.Windows.Forms.TextBox();
            this.buttonSearchClient = new System.Windows.Forms.Button();
            this.listViewCars = new System.Windows.Forms.ListView();
            this.columnHeaderCarId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCarNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSerieSasiu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCodSasiu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDenumireAuto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.buttonAutoDelete = new System.Windows.Forms.Button();
            this.buttonAutoUpdate = new System.Windows.Forms.Button();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.columnHeaderOrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateSystem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateFinish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonNewOrder = new System.Windows.Forms.Button();
            this.buttonOrderDetails = new System.Windows.Forms.Button();
            this.groupBoxCars = new System.Windows.Forms.GroupBox();
            this.groupBoxClients = new System.Windows.Forms.GroupBox();
            this.buttonClientDelete = new System.Windows.Forms.Button();
            this.groupBoxOrders = new System.Windows.Forms.GroupBox();
            this.buttonOrderUpdate = new System.Windows.Forms.Button();
            this.richTextBoxOrderDescription = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBoxCars.SuspendLayout();
            this.groupBoxClients.SuspendLayout();
            this.groupBoxOrders.SuspendLayout();
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
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newClientToolStripMenuItem,
            this.newMecanicToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // newClientToolStripMenuItem
            // 
            this.newClientToolStripMenuItem.Name = "newClientToolStripMenuItem";
            this.newClientToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newClientToolStripMenuItem.Text = "New client";
            this.newClientToolStripMenuItem.Click += new System.EventHandler(this.newClientToolStripMenuItem_Click);
            // 
            // newMecanicToolStripMenuItem
            // 
            this.newMecanicToolStripMenuItem.Name = "newMecanicToolStripMenuItem";
            this.newMecanicToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newMecanicToolStripMenuItem.Text = "New mecanic";
            this.newMecanicToolStripMenuItem.Click += new System.EventHandler(this.newMecanicToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.showAllClientsToolStripMenuItem,
            this.showAllMecanicsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showAllClientsToolStripMenuItem
            // 
            this.showAllClientsToolStripMenuItem.Name = "showAllClientsToolStripMenuItem";
            this.showAllClientsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.showAllClientsToolStripMenuItem.Text = "Show all clients";
            this.showAllClientsToolStripMenuItem.Click += new System.EventHandler(this.showAllClientsToolStripMenuItem_Click);
            // 
            // showAllMecanicsToolStripMenuItem
            // 
            this.showAllMecanicsToolStripMenuItem.Name = "showAllMecanicsToolStripMenuItem";
            this.showAllMecanicsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.showAllMecanicsToolStripMenuItem.Text = "Show all mecanics";
            this.showAllMecanicsToolStripMenuItem.Click += new System.EventHandler(this.showAllMecanicsToolStripMenuItem_Click);
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
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // listViewClients
            // 
            this.listViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderFName,
            this.columnHeaderLName,
            this.columnHeaderClientAdress,
            this.columnHeaderClientLocalitate,
            this.columnHeaderClientJudet,
            this.columnHeaderPhone,
            this.columnHeaderClientEmail});
            this.listViewClients.FullRowSelect = true;
            this.listViewClients.Location = new System.Drawing.Point(8, 22);
            this.listViewClients.MultiSelect = false;
            this.listViewClients.Name = "listViewClients";
            this.listViewClients.Size = new System.Drawing.Size(358, 183);
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
            // columnHeaderClientAdress
            // 
            this.columnHeaderClientAdress.DisplayIndex = 4;
            this.columnHeaderClientAdress.Text = "Adresa";
            this.columnHeaderClientAdress.Width = 100;
            // 
            // columnHeaderClientLocalitate
            // 
            this.columnHeaderClientLocalitate.DisplayIndex = 5;
            this.columnHeaderClientLocalitate.Text = "Localitate";
            // 
            // columnHeaderClientJudet
            // 
            this.columnHeaderClientJudet.DisplayIndex = 6;
            this.columnHeaderClientJudet.Text = "Judet";
            // 
            // columnHeaderPhone
            // 
            this.columnHeaderPhone.DisplayIndex = 3;
            this.columnHeaderPhone.Text = "Telefon";
            // 
            // columnHeaderClientEmail
            // 
            this.columnHeaderClientEmail.Text = "Email";
            // 
            // textBoxSearchClient
            // 
            this.textBoxSearchClient.Location = new System.Drawing.Point(6, 220);
            this.textBoxSearchClient.Name = "textBoxSearchClient";
            this.textBoxSearchClient.Size = new System.Drawing.Size(115, 20);
            this.textBoxSearchClient.TabIndex = 10;
            this.textBoxSearchClient.TextChanged += new System.EventHandler(this.textBoxSearchClient_TextChanged);
            // 
            // buttonSearchClient
            // 
            this.buttonSearchClient.Location = new System.Drawing.Point(166, 222);
            this.buttonSearchClient.Name = "buttonSearchClient";
            this.buttonSearchClient.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchClient.TabIndex = 11;
            this.buttonSearchClient.Text = "Cauta";
            this.buttonSearchClient.UseVisualStyleBackColor = true;
            this.buttonSearchClient.Click += new System.EventHandler(this.buttonSearchClient_Click);
            // 
            // listViewCars
            // 
            this.listViewCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCarId,
            this.columnHeaderCarNr,
            this.columnHeaderSerieSasiu,
            this.columnHeaderCodSasiu,
            this.columnHeaderDenumireAuto});
            this.listViewCars.FullRowSelect = true;
            this.listViewCars.Location = new System.Drawing.Point(6, 19);
            this.listViewCars.MultiSelect = false;
            this.listViewCars.Name = "listViewCars";
            this.listViewCars.Size = new System.Drawing.Size(364, 183);
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
            // columnHeaderSerieSasiu
            // 
            this.columnHeaderSerieSasiu.Text = "SerieSasiu";
            this.columnHeaderSerieSasiu.Width = 75;
            // 
            // columnHeaderCodSasiu
            // 
            this.columnHeaderCodSasiu.Text = "Cod sasiu";
            // 
            // columnHeaderDenumireAuto
            // 
            this.columnHeaderDenumireAuto.Text = "Denumire";
            this.columnHeaderDenumireAuto.Width = 100;
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Location = new System.Drawing.Point(6, 220);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(73, 23);
            this.buttonAddCar.TabIndex = 13;
            this.buttonAddCar.Text = "Adauga";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // buttonAutoDelete
            // 
            this.buttonAutoDelete.Location = new System.Drawing.Point(166, 220);
            this.buttonAutoDelete.Name = "buttonAutoDelete";
            this.buttonAutoDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoDelete.TabIndex = 14;
            this.buttonAutoDelete.Text = "Sterge";
            this.buttonAutoDelete.UseVisualStyleBackColor = true;
            this.buttonAutoDelete.Click += new System.EventHandler(this.buttonAutoDelete_Click);
            // 
            // buttonAutoUpdate
            // 
            this.buttonAutoUpdate.Location = new System.Drawing.Point(85, 220);
            this.buttonAutoUpdate.Name = "buttonAutoUpdate";
            this.buttonAutoUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoUpdate.TabIndex = 15;
            this.buttonAutoUpdate.Text = "Modifica";
            this.buttonAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderOrderID,
            this.columnHeaderStatus,
            this.columnHeaderDateSystem,
            this.columnHeaderDateStart,
            this.columnHeaderDateFinish,
            this.columnHeaderKm});
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.GridLines = true;
            this.listViewOrders.Location = new System.Drawing.Point(8, 19);
            this.listViewOrders.MultiSelect = false;
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(414, 155);
            this.listViewOrders.TabIndex = 16;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            this.listViewOrders.SelectedIndexChanged += new System.EventHandler(this.listViewOrders_SelectedIndexChanged);
            // 
            // columnHeaderOrderID
            // 
            this.columnHeaderOrderID.Text = "Id";
            this.columnHeaderOrderID.Width = 30;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Stare comanda";
            this.columnHeaderStatus.Width = 85;
            // 
            // columnHeaderDateSystem
            // 
            this.columnHeaderDateSystem.Text = "Data sistem";
            this.columnHeaderDateSystem.Width = 75;
            // 
            // columnHeaderDateStart
            // 
            this.columnHeaderDateStart.Text = "Data incepere";
            this.columnHeaderDateStart.Width = 75;
            // 
            // columnHeaderDateFinish
            // 
            this.columnHeaderDateFinish.Text = "Data terminare";
            this.columnHeaderDateFinish.Width = 75;
            // 
            // columnHeaderKm
            // 
            this.columnHeaderKm.Text = "Km bord";
            // 
            // buttonNewOrder
            // 
            this.buttonNewOrder.Location = new System.Drawing.Point(248, 220);
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.Size = new System.Drawing.Size(90, 23);
            this.buttonNewOrder.TabIndex = 17;
            this.buttonNewOrder.Text = "Comanda noua";
            this.buttonNewOrder.UseVisualStyleBackColor = true;
            this.buttonNewOrder.Click += new System.EventHandler(this.buttonNewOrder_Click);
            // 
            // buttonOrderDetails
            // 
            this.buttonOrderDetails.Location = new System.Drawing.Point(8, 180);
            this.buttonOrderDetails.Name = "buttonOrderDetails";
            this.buttonOrderDetails.Size = new System.Drawing.Size(113, 23);
            this.buttonOrderDetails.TabIndex = 18;
            this.buttonOrderDetails.Text = "Detalii comanda";
            this.buttonOrderDetails.UseVisualStyleBackColor = true;
            this.buttonOrderDetails.Click += new System.EventHandler(this.buttonOrderDetails_Click);
            // 
            // groupBoxCars
            // 
            this.groupBoxCars.Controls.Add(this.listViewCars);
            this.groupBoxCars.Controls.Add(this.buttonAddCar);
            this.groupBoxCars.Controls.Add(this.buttonNewOrder);
            this.groupBoxCars.Controls.Add(this.buttonAutoDelete);
            this.groupBoxCars.Controls.Add(this.buttonAutoUpdate);
            this.groupBoxCars.Location = new System.Drawing.Point(396, 27);
            this.groupBoxCars.Name = "groupBoxCars";
            this.groupBoxCars.Size = new System.Drawing.Size(376, 284);
            this.groupBoxCars.TabIndex = 19;
            this.groupBoxCars.TabStop = false;
            this.groupBoxCars.Text = "Masini";
            // 
            // groupBoxClients
            // 
            this.groupBoxClients.Controls.Add(this.buttonClientDelete);
            this.groupBoxClients.Controls.Add(this.listViewClients);
            this.groupBoxClients.Controls.Add(this.textBoxSearchClient);
            this.groupBoxClients.Controls.Add(this.buttonSearchClient);
            this.groupBoxClients.Location = new System.Drawing.Point(12, 27);
            this.groupBoxClients.Name = "groupBoxClients";
            this.groupBoxClients.Size = new System.Drawing.Size(372, 284);
            this.groupBoxClients.TabIndex = 20;
            this.groupBoxClients.TabStop = false;
            this.groupBoxClients.Text = "Clienti";
            // 
            // buttonClientDelete
            // 
            this.buttonClientDelete.Location = new System.Drawing.Point(265, 222);
            this.buttonClientDelete.Name = "buttonClientDelete";
            this.buttonClientDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonClientDelete.TabIndex = 12;
            this.buttonClientDelete.Text = "Sterge";
            this.buttonClientDelete.UseVisualStyleBackColor = true;
            this.buttonClientDelete.Click += new System.EventHandler(this.buttonClientDelete_Click);
            // 
            // groupBoxOrders
            // 
            this.groupBoxOrders.Controls.Add(this.buttonOrderUpdate);
            this.groupBoxOrders.Controls.Add(this.richTextBoxOrderDescription);
            this.groupBoxOrders.Controls.Add(this.listViewOrders);
            this.groupBoxOrders.Controls.Add(this.buttonOrderDetails);
            this.groupBoxOrders.Location = new System.Drawing.Point(12, 336);
            this.groupBoxOrders.Name = "groupBoxOrders";
            this.groupBoxOrders.Size = new System.Drawing.Size(760, 213);
            this.groupBoxOrders.TabIndex = 21;
            this.groupBoxOrders.TabStop = false;
            this.groupBoxOrders.Text = "Comenzi";
            // 
            // buttonOrderUpdate
            // 
            this.buttonOrderUpdate.Location = new System.Drawing.Point(128, 179);
            this.buttonOrderUpdate.Name = "buttonOrderUpdate";
            this.buttonOrderUpdate.Size = new System.Drawing.Size(113, 23);
            this.buttonOrderUpdate.TabIndex = 20;
            this.buttonOrderUpdate.Text = "Modifica comanda";
            this.buttonOrderUpdate.UseVisualStyleBackColor = true;
            this.buttonOrderUpdate.Click += new System.EventHandler(this.buttonOrderUpdate_Click);
            // 
            // richTextBoxOrderDescription
            // 
            this.richTextBoxOrderDescription.Location = new System.Drawing.Point(444, 19);
            this.richTextBoxOrderDescription.MaxLength = 1024;
            this.richTextBoxOrderDescription.Name = "richTextBoxOrderDescription";
            this.richTextBoxOrderDescription.ReadOnly = true;
            this.richTextBoxOrderDescription.Size = new System.Drawing.Size(278, 155);
            this.richTextBoxOrderDescription.TabIndex = 19;
            this.richTextBoxOrderDescription.Text = "";
            this.richTextBoxOrderDescription.TextChanged += new System.EventHandler(this.richTextBoxOrderDescription_TextChanged);
            // 
            // CarServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBoxOrders);
            this.Controls.Add(this.groupBoxClients);
            this.Controls.Add(this.groupBoxCars);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CarServiceForm";
            this.Text = "Car service";
            this.Load += new System.EventHandler(this.CarServiceForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxCars.ResumeLayout(false);
            this.groupBoxClients.ResumeLayout(false);
            this.groupBoxClients.PerformLayout();
            this.groupBoxOrders.ResumeLayout(false);
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
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderID;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.ColumnHeader columnHeaderDateSystem;
        private System.Windows.Forms.ColumnHeader columnHeaderDateStart;
        private System.Windows.Forms.ColumnHeader columnHeaderDateFinish;
        private System.Windows.Forms.ColumnHeader columnHeaderKm;
        private System.Windows.Forms.Button buttonNewOrder;
        private System.Windows.Forms.Button buttonOrderDetails;
        private System.Windows.Forms.GroupBox groupBoxCars;
        private System.Windows.Forms.GroupBox groupBoxClients;
        private System.Windows.Forms.GroupBox groupBoxOrders;
        private System.Windows.Forms.RichTextBox richTextBoxOrderDescription;
        private System.Windows.Forms.ToolStripMenuItem showAllMecanicsToolStripMenuItem;
        private System.Windows.Forms.Button buttonClientDelete;
        private System.Windows.Forms.Button buttonOrderUpdate;
        private System.Windows.Forms.ColumnHeader columnHeaderSerieSasiu;
        private System.Windows.Forms.ColumnHeader columnHeaderCodSasiu;
        private System.Windows.Forms.ColumnHeader columnHeaderDenumireAuto;
        private System.Windows.Forms.ColumnHeader columnHeaderClientAdress;
        private System.Windows.Forms.ColumnHeader columnHeaderClientLocalitate;
        private System.Windows.Forms.ColumnHeader columnHeaderClientJudet;
        private System.Windows.Forms.ColumnHeader columnHeaderClientEmail;
    }
}

