namespace WinFormsCarService
{
    partial class OrderDetailsForm
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
            this.buttonAddOrderOperation = new System.Windows.Forms.Button();
            this.buttonDeleteOrderOperation = new System.Windows.Forms.Button();
            this.listViewOrderDetails = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOpDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMecanic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMaterialDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMaterialPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMaterialQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMaterialDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonOrderDetailsRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddOrderOperation
            // 
            this.buttonAddOrderOperation.Location = new System.Drawing.Point(12, 322);
            this.buttonAddOrderOperation.Name = "buttonAddOrderOperation";
            this.buttonAddOrderOperation.Size = new System.Drawing.Size(119, 23);
            this.buttonAddOrderOperation.TabIndex = 2;
            this.buttonAddOrderOperation.Text = "Adauga operatie";
            this.buttonAddOrderOperation.UseVisualStyleBackColor = true;
            this.buttonAddOrderOperation.Click += new System.EventHandler(this.buttonAddOrderOperation_Click);
            // 
            // buttonDeleteOrderOperation
            // 
            this.buttonDeleteOrderOperation.Location = new System.Drawing.Point(154, 322);
            this.buttonDeleteOrderOperation.Name = "buttonDeleteOrderOperation";
            this.buttonDeleteOrderOperation.Size = new System.Drawing.Size(120, 23);
            this.buttonDeleteOrderOperation.TabIndex = 3;
            this.buttonDeleteOrderOperation.Text = "Sterge operatie";
            this.buttonDeleteOrderOperation.UseVisualStyleBackColor = true;
            // 
            // listViewOrderDetails
            // 
            this.listViewOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderOpDesc,
            this.columnHeaderMecanic,
            this.columnHeaderTime,
            this.columnHeaderMaterialDesc,
            this.columnHeaderMaterialPrice,
            this.columnHeaderMaterialQuantity,
            this.columnHeaderMaterialDate});
            this.listViewOrderDetails.FullRowSelect = true;
            this.listViewOrderDetails.Location = new System.Drawing.Point(12, 26);
            this.listViewOrderDetails.Name = "listViewOrderDetails";
            this.listViewOrderDetails.Size = new System.Drawing.Size(760, 270);
            this.listViewOrderDetails.TabIndex = 4;
            this.listViewOrderDetails.UseCompatibleStateImageBehavior = false;
            this.listViewOrderDetails.View = System.Windows.Forms.View.Details;
            this.listViewOrderDetails.SelectedIndexChanged += new System.EventHandler(this.listViewOrderDetails_SelectedIndexChanged);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            this.columnHeaderId.Width = 25;
            // 
            // columnHeaderOpDesc
            // 
            this.columnHeaderOpDesc.Text = "Operatie";
            this.columnHeaderOpDesc.Width = 150;
            // 
            // columnHeaderMecanic
            // 
            this.columnHeaderMecanic.Text = "Mecanic";
            this.columnHeaderMecanic.Width = 100;
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Timp executie";
            this.columnHeaderTime.Width = 105;
            // 
            // columnHeaderMaterialDesc
            // 
            this.columnHeaderMaterialDesc.Text = "Material";
            this.columnHeaderMaterialDesc.Width = 100;
            // 
            // columnHeaderMaterialPrice
            // 
            this.columnHeaderMaterialPrice.Text = "Pret material";
            this.columnHeaderMaterialPrice.Width = 70;
            // 
            // columnHeaderMaterialQuantity
            // 
            this.columnHeaderMaterialQuantity.Text = "Cantitate";
            // 
            // columnHeaderMaterialDate
            // 
            this.columnHeaderMaterialDate.Text = "Data aprovizionare";
            this.columnHeaderMaterialDate.Width = 115;
            // 
            // buttonOrderDetailsRefresh
            // 
            this.buttonOrderDetailsRefresh.Location = new System.Drawing.Point(697, 322);
            this.buttonOrderDetailsRefresh.Name = "buttonOrderDetailsRefresh";
            this.buttonOrderDetailsRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonOrderDetailsRefresh.TabIndex = 5;
            this.buttonOrderDetailsRefresh.Text = "Refresh";
            this.buttonOrderDetailsRefresh.UseVisualStyleBackColor = true;
            this.buttonOrderDetailsRefresh.Click += new System.EventHandler(this.buttonOrderDetailsRefresh_Click);
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 382);
            this.Controls.Add(this.buttonOrderDetailsRefresh);
            this.Controls.Add(this.listViewOrderDetails);
            this.Controls.Add(this.buttonDeleteOrderOperation);
            this.Controls.Add(this.buttonAddOrderOperation);
            this.Name = "OrderDetailsForm";
            this.Text = "Detalii comanda";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddOrderOperation;
        private System.Windows.Forms.Button buttonDeleteOrderOperation;
        private System.Windows.Forms.ListView listViewOrderDetails;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderMecanic;
        private System.Windows.Forms.ColumnHeader columnHeaderOpDesc;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.ColumnHeader columnHeaderMaterialDesc;
        private System.Windows.Forms.ColumnHeader columnHeaderMaterialPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderMaterialQuantity;
        private System.Windows.Forms.ColumnHeader columnHeaderMaterialDate;
        private System.Windows.Forms.Button buttonOrderDetailsRefresh;
    }
}