namespace WinFormsCarService
{
    partial class NewOrderForm
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
            this.groupBoxAddNewOrder = new System.Windows.Forms.GroupBox();
            this.labelOrderStartDate = new System.Windows.Forms.Label();
            this.labelOrderFinishDate = new System.Windows.Forms.Label();
            this.dateTimePickerOrderStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOrderFinish = new System.Windows.Forms.DateTimePicker();
            this.labelKm = new System.Windows.Forms.Label();
            this.numericUpDownKm = new System.Windows.Forms.NumericUpDown();
            this.labelOrderDescription = new System.Windows.Forms.Label();
            this.richTextBoxOrderDescription = new System.Windows.Forms.RichTextBox();
            this.buttonAddNewOrder = new System.Windows.Forms.Button();
            this.groupBoxAddNewOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKm)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAddNewOrder
            // 
            this.groupBoxAddNewOrder.Controls.Add(this.buttonAddNewOrder);
            this.groupBoxAddNewOrder.Controls.Add(this.richTextBoxOrderDescription);
            this.groupBoxAddNewOrder.Controls.Add(this.labelOrderDescription);
            this.groupBoxAddNewOrder.Controls.Add(this.numericUpDownKm);
            this.groupBoxAddNewOrder.Controls.Add(this.labelKm);
            this.groupBoxAddNewOrder.Controls.Add(this.dateTimePickerOrderFinish);
            this.groupBoxAddNewOrder.Controls.Add(this.dateTimePickerOrderStart);
            this.groupBoxAddNewOrder.Controls.Add(this.labelOrderFinishDate);
            this.groupBoxAddNewOrder.Controls.Add(this.labelOrderStartDate);
            this.groupBoxAddNewOrder.Location = new System.Drawing.Point(131, 46);
            this.groupBoxAddNewOrder.Name = "groupBoxAddNewOrder";
            this.groupBoxAddNewOrder.Size = new System.Drawing.Size(370, 326);
            this.groupBoxAddNewOrder.TabIndex = 0;
            this.groupBoxAddNewOrder.TabStop = false;
            // 
            // labelOrderStartDate
            // 
            this.labelOrderStartDate.AutoSize = true;
            this.labelOrderStartDate.Location = new System.Drawing.Point(7, 31);
            this.labelOrderStartDate.Name = "labelOrderStartDate";
            this.labelOrderStartDate.Size = new System.Drawing.Size(86, 13);
            this.labelOrderStartDate.TabIndex = 0;
            this.labelOrderStartDate.Text = "Data programare";
            // 
            // labelOrderFinishDate
            // 
            this.labelOrderFinishDate.AutoSize = true;
            this.labelOrderFinishDate.Location = new System.Drawing.Point(10, 62);
            this.labelOrderFinishDate.Name = "labelOrderFinishDate";
            this.labelOrderFinishDate.Size = new System.Drawing.Size(74, 13);
            this.labelOrderFinishDate.TabIndex = 1;
            this.labelOrderFinishDate.Text = "Data finalizare";
            // 
            // dateTimePickerOrderStart
            // 
            this.dateTimePickerOrderStart.CustomFormat = "";
            this.dateTimePickerOrderStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOrderStart.Location = new System.Drawing.Point(121, 31);
            this.dateTimePickerOrderStart.Name = "dateTimePickerOrderStart";
            this.dateTimePickerOrderStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerOrderStart.TabIndex = 2;
            // 
            // dateTimePickerOrderFinish
            // 
            this.dateTimePickerOrderFinish.Location = new System.Drawing.Point(121, 54);
            this.dateTimePickerOrderFinish.Name = "dateTimePickerOrderFinish";
            this.dateTimePickerOrderFinish.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerOrderFinish.TabIndex = 3;
            // 
            // labelKm
            // 
            this.labelKm.AutoSize = true;
            this.labelKm.Location = new System.Drawing.Point(13, 99);
            this.labelKm.Name = "labelKm";
            this.labelKm.Size = new System.Drawing.Size(46, 13);
            this.labelKm.TabIndex = 4;
            this.labelKm.Text = "Km bord";
            // 
            // numericUpDownKm
            // 
            this.numericUpDownKm.Location = new System.Drawing.Point(121, 99);
            this.numericUpDownKm.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownKm.Name = "numericUpDownKm";
            this.numericUpDownKm.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownKm.TabIndex = 5;
            // 
            // labelOrderDescription
            // 
            this.labelOrderDescription.AutoSize = true;
            this.labelOrderDescription.Location = new System.Drawing.Point(13, 183);
            this.labelOrderDescription.Name = "labelOrderDescription";
            this.labelOrderDescription.Size = new System.Drawing.Size(52, 13);
            this.labelOrderDescription.TabIndex = 6;
            this.labelOrderDescription.Text = "Descriere";
            // 
            // richTextBoxOrderDescription
            // 
            this.richTextBoxOrderDescription.Location = new System.Drawing.Point(121, 140);
            this.richTextBoxOrderDescription.Name = "richTextBoxOrderDescription";
            this.richTextBoxOrderDescription.Size = new System.Drawing.Size(200, 142);
            this.richTextBoxOrderDescription.TabIndex = 7;
            this.richTextBoxOrderDescription.Text = "";
            // 
            // buttonAddNewOrder
            // 
            this.buttonAddNewOrder.Location = new System.Drawing.Point(210, 297);
            this.buttonAddNewOrder.Name = "buttonAddNewOrder";
            this.buttonAddNewOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNewOrder.TabIndex = 8;
            this.buttonAddNewOrder.Text = "Adauga";
            this.buttonAddNewOrder.UseVisualStyleBackColor = true;
            this.buttonAddNewOrder.Click += new System.EventHandler(this.buttonAddNewOrder_Click);
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.groupBoxAddNewOrder);
            this.Name = "NewOrderForm";
            this.Text = "Comanda noua";
            this.groupBoxAddNewOrder.ResumeLayout(false);
            this.groupBoxAddNewOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddNewOrder;
        private System.Windows.Forms.Label labelOrderStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderFinish;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderStart;
        private System.Windows.Forms.Label labelOrderFinishDate;
        private System.Windows.Forms.NumericUpDown numericUpDownKm;
        private System.Windows.Forms.Label labelKm;
        private System.Windows.Forms.Button buttonAddNewOrder;
        private System.Windows.Forms.RichTextBox richTextBoxOrderDescription;
        private System.Windows.Forms.Label labelOrderDescription;
    }
}