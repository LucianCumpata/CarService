namespace WinFormsCarService
{
    partial class NewOrderDetailsForm
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
            this.buttonAddNewOrderDetails = new System.Windows.Forms.Button();
            this.labelOperationName = new System.Windows.Forms.Label();
            this.textBoxOperationName = new System.Windows.Forms.TextBox();
            this.groupBoxOperation = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownExecutionTime = new System.Windows.Forms.NumericUpDown();
            this.groupBoxMaterial = new System.Windows.Forms.GroupBox();
            this.labelMaterialName = new System.Windows.Forms.Label();
            this.labelMaterialQuantity = new System.Windows.Forms.Label();
            this.labelMaterialPrice = new System.Windows.Forms.Label();
            this.labelMaterialDate = new System.Windows.Forms.Label();
            this.dateTimePickerMaterialArrival = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownMaterialQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaterialPrice = new System.Windows.Forms.NumericUpDown();
            this.listViewMecanics = new System.Windows.Forms.ListView();
            this.columnHeaderMecanicId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMecanicFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMecanicLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxMaterialDescription = new System.Windows.Forms.TextBox();
            this.groupBoxOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExecutionTime)).BeginInit();
            this.groupBoxMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaterialQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaterialPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddNewOrderDetails
            // 
            this.buttonAddNewOrderDetails.Location = new System.Drawing.Point(247, 376);
            this.buttonAddNewOrderDetails.Name = "buttonAddNewOrderDetails";
            this.buttonAddNewOrderDetails.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNewOrderDetails.TabIndex = 0;
            this.buttonAddNewOrderDetails.Text = "Salveaza";
            this.buttonAddNewOrderDetails.UseVisualStyleBackColor = true;
            this.buttonAddNewOrderDetails.Click += new System.EventHandler(this.buttonAddNewOrderDetails_Click);
            // 
            // labelOperationName
            // 
            this.labelOperationName.AutoSize = true;
            this.labelOperationName.Location = new System.Drawing.Point(15, 22);
            this.labelOperationName.Name = "labelOperationName";
            this.labelOperationName.Size = new System.Drawing.Size(52, 13);
            this.labelOperationName.TabIndex = 1;
            this.labelOperationName.Text = "Denumire";
            // 
            // textBoxOperationName
            // 
            this.textBoxOperationName.Location = new System.Drawing.Point(94, 19);
            this.textBoxOperationName.Name = "textBoxOperationName";
            this.textBoxOperationName.Size = new System.Drawing.Size(120, 20);
            this.textBoxOperationName.TabIndex = 2;
            this.textBoxOperationName.TextChanged += new System.EventHandler(this.textBoxOperationName_TextChanged);
            // 
            // groupBoxOperation
            // 
            this.groupBoxOperation.Controls.Add(this.numericUpDownExecutionTime);
            this.groupBoxOperation.Controls.Add(this.label2);
            this.groupBoxOperation.Controls.Add(this.textBoxOperationName);
            this.groupBoxOperation.Controls.Add(this.labelOperationName);
            this.groupBoxOperation.Location = new System.Drawing.Point(12, 215);
            this.groupBoxOperation.Name = "groupBoxOperation";
            this.groupBoxOperation.Size = new System.Drawing.Size(275, 110);
            this.groupBoxOperation.TabIndex = 3;
            this.groupBoxOperation.TabStop = false;
            this.groupBoxOperation.Text = "Operatie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Timp executie";
            // 
            // numericUpDownExecutionTime
            // 
            this.numericUpDownExecutionTime.Location = new System.Drawing.Point(94, 55);
            this.numericUpDownExecutionTime.Name = "numericUpDownExecutionTime";
            this.numericUpDownExecutionTime.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownExecutionTime.TabIndex = 4;
            this.numericUpDownExecutionTime.ValueChanged += new System.EventHandler(this.numericUpDownExecutionTime_ValueChanged);
            // 
            // groupBoxMaterial
            // 
            this.groupBoxMaterial.Controls.Add(this.textBoxMaterialDescription);
            this.groupBoxMaterial.Controls.Add(this.numericUpDownMaterialPrice);
            this.groupBoxMaterial.Controls.Add(this.numericUpDownMaterialQuantity);
            this.groupBoxMaterial.Controls.Add(this.dateTimePickerMaterialArrival);
            this.groupBoxMaterial.Controls.Add(this.labelMaterialDate);
            this.groupBoxMaterial.Controls.Add(this.labelMaterialPrice);
            this.groupBoxMaterial.Controls.Add(this.labelMaterialQuantity);
            this.groupBoxMaterial.Controls.Add(this.labelMaterialName);
            this.groupBoxMaterial.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMaterial.Name = "groupBoxMaterial";
            this.groupBoxMaterial.Size = new System.Drawing.Size(275, 174);
            this.groupBoxMaterial.TabIndex = 4;
            this.groupBoxMaterial.TabStop = false;
            this.groupBoxMaterial.Text = "Material";
            // 
            // labelMaterialName
            // 
            this.labelMaterialName.AutoSize = true;
            this.labelMaterialName.Location = new System.Drawing.Point(15, 33);
            this.labelMaterialName.Name = "labelMaterialName";
            this.labelMaterialName.Size = new System.Drawing.Size(52, 13);
            this.labelMaterialName.TabIndex = 5;
            this.labelMaterialName.Text = "Denumire";
            // 
            // labelMaterialQuantity
            // 
            this.labelMaterialQuantity.AutoSize = true;
            this.labelMaterialQuantity.Location = new System.Drawing.Point(15, 65);
            this.labelMaterialQuantity.Name = "labelMaterialQuantity";
            this.labelMaterialQuantity.Size = new System.Drawing.Size(49, 13);
            this.labelMaterialQuantity.TabIndex = 6;
            this.labelMaterialQuantity.Text = "Cantitate";
            // 
            // labelMaterialPrice
            // 
            this.labelMaterialPrice.AutoSize = true;
            this.labelMaterialPrice.Location = new System.Drawing.Point(15, 91);
            this.labelMaterialPrice.Name = "labelMaterialPrice";
            this.labelMaterialPrice.Size = new System.Drawing.Size(26, 13);
            this.labelMaterialPrice.TabIndex = 7;
            this.labelMaterialPrice.Text = "Pret";
            // 
            // labelMaterialDate
            // 
            this.labelMaterialDate.AutoSize = true;
            this.labelMaterialDate.Location = new System.Drawing.Point(15, 127);
            this.labelMaterialDate.Name = "labelMaterialDate";
            this.labelMaterialDate.Size = new System.Drawing.Size(96, 13);
            this.labelMaterialDate.TabIndex = 8;
            this.labelMaterialDate.Text = "Data aprovizionare";
            // 
            // dateTimePickerMaterialArrival
            // 
            this.dateTimePickerMaterialArrival.Location = new System.Drawing.Point(69, 143);
            this.dateTimePickerMaterialArrival.Name = "dateTimePickerMaterialArrival";
            this.dateTimePickerMaterialArrival.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerMaterialArrival.TabIndex = 12;
            this.dateTimePickerMaterialArrival.ValueChanged += new System.EventHandler(this.dateTimePickerMaterialArrival_ValueChanged);
            // 
            // numericUpDownMaterialQuantity
            // 
            this.numericUpDownMaterialQuantity.Location = new System.Drawing.Point(105, 68);
            this.numericUpDownMaterialQuantity.Name = "numericUpDownMaterialQuantity";
            this.numericUpDownMaterialQuantity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaterialQuantity.TabIndex = 13;
            this.numericUpDownMaterialQuantity.ValueChanged += new System.EventHandler(this.numericUpDownMaterialQuantity_ValueChanged);
            // 
            // numericUpDownMaterialPrice
            // 
            this.numericUpDownMaterialPrice.Location = new System.Drawing.Point(105, 95);
            this.numericUpDownMaterialPrice.Name = "numericUpDownMaterialPrice";
            this.numericUpDownMaterialPrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaterialPrice.TabIndex = 14;
            this.numericUpDownMaterialPrice.ValueChanged += new System.EventHandler(this.numericUpDownMaterialPrice_ValueChanged);
            // 
            // listViewMecanics
            // 
            this.listViewMecanics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMecanicId,
            this.columnHeaderMecanicFName,
            this.columnHeaderMecanicLName});
            this.listViewMecanics.FullRowSelect = true;
            this.listViewMecanics.Location = new System.Drawing.Point(310, 12);
            this.listViewMecanics.MultiSelect = false;
            this.listViewMecanics.Name = "listViewMecanics";
            this.listViewMecanics.Size = new System.Drawing.Size(283, 178);
            this.listViewMecanics.TabIndex = 10;
            this.listViewMecanics.UseCompatibleStateImageBehavior = false;
            this.listViewMecanics.View = System.Windows.Forms.View.Details;
            this.listViewMecanics.SelectedIndexChanged += new System.EventHandler(this.listViewMecanics_SelectedIndexChanged);
            // 
            // columnHeaderMecanicId
            // 
            this.columnHeaderMecanicId.Text = "Id";
            // 
            // columnHeaderMecanicFName
            // 
            this.columnHeaderMecanicFName.Text = "Nume";
            // 
            // columnHeaderMecanicLName
            // 
            this.columnHeaderMecanicLName.Text = "Prenume";
            // 
            // textBoxMaterialDescription
            // 
            this.textBoxMaterialDescription.Location = new System.Drawing.Point(102, 33);
            this.textBoxMaterialDescription.Name = "textBoxMaterialDescription";
            this.textBoxMaterialDescription.Size = new System.Drawing.Size(120, 20);
            this.textBoxMaterialDescription.TabIndex = 15;
            this.textBoxMaterialDescription.TextChanged += new System.EventHandler(this.textBoxMaterialDescription_TextChanged);
            // 
            // NewOrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.listViewMecanics);
            this.Controls.Add(this.groupBoxMaterial);
            this.Controls.Add(this.groupBoxOperation);
            this.Controls.Add(this.buttonAddNewOrderDetails);
            this.Name = "NewOrderDetailsForm";
            this.Text = "NewOrderDetailsForm";
            this.groupBoxOperation.ResumeLayout(false);
            this.groupBoxOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExecutionTime)).EndInit();
            this.groupBoxMaterial.ResumeLayout(false);
            this.groupBoxMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaterialQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaterialPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNewOrderDetails;
        private System.Windows.Forms.Label labelOperationName;
        private System.Windows.Forms.TextBox textBoxOperationName;
        private System.Windows.Forms.GroupBox groupBoxOperation;
        private System.Windows.Forms.NumericUpDown numericUpDownExecutionTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxMaterial;
        private System.Windows.Forms.Label labelMaterialDate;
        private System.Windows.Forms.Label labelMaterialPrice;
        private System.Windows.Forms.Label labelMaterialQuantity;
        private System.Windows.Forms.Label labelMaterialName;
        private System.Windows.Forms.DateTimePicker dateTimePickerMaterialArrival;
        private System.Windows.Forms.NumericUpDown numericUpDownMaterialQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownMaterialPrice;
        private System.Windows.Forms.ListView listViewMecanics;
        private System.Windows.Forms.ColumnHeader columnHeaderMecanicId;
        private System.Windows.Forms.ColumnHeader columnHeaderMecanicFName;
        private System.Windows.Forms.ColumnHeader columnHeaderMecanicLName;
        private System.Windows.Forms.TextBox textBoxMaterialDescription;
    }
}