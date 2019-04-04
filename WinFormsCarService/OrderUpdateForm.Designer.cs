namespace WinFormsCarService
{
    partial class OrderUpdateForm
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
            this.buttonUpdateOrder = new System.Windows.Forms.Button();
            this.richTextBoxOrderDescription = new System.Windows.Forms.RichTextBox();
            this.labelOrderDescription = new System.Windows.Forms.Label();
            this.numericUpDownKm = new System.Windows.Forms.NumericUpDown();
            this.labelKm = new System.Windows.Forms.Label();
            this.dateTimePickerOrderFinish = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOrderStart = new System.Windows.Forms.DateTimePicker();
            this.labelOrderFinishDate = new System.Windows.Forms.Label();
            this.labelOrderStartDate = new System.Windows.Forms.Label();
            this.radioButtonOrderAwaiting = new System.Windows.Forms.RadioButton();
            this.radioButtonOrderExecuted = new System.Windows.Forms.RadioButton();
            this.radioButtonOrderRefused = new System.Windows.Forms.RadioButton();
            this.groupBoxAddNewOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKm)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAddNewOrder
            // 
            this.groupBoxAddNewOrder.Controls.Add(this.radioButtonOrderRefused);
            this.groupBoxAddNewOrder.Controls.Add(this.radioButtonOrderExecuted);
            this.groupBoxAddNewOrder.Controls.Add(this.radioButtonOrderAwaiting);
            this.groupBoxAddNewOrder.Controls.Add(this.buttonUpdateOrder);
            this.groupBoxAddNewOrder.Controls.Add(this.richTextBoxOrderDescription);
            this.groupBoxAddNewOrder.Controls.Add(this.labelOrderDescription);
            this.groupBoxAddNewOrder.Controls.Add(this.numericUpDownKm);
            this.groupBoxAddNewOrder.Controls.Add(this.labelKm);
            this.groupBoxAddNewOrder.Controls.Add(this.dateTimePickerOrderFinish);
            this.groupBoxAddNewOrder.Controls.Add(this.dateTimePickerOrderStart);
            this.groupBoxAddNewOrder.Controls.Add(this.labelOrderFinishDate);
            this.groupBoxAddNewOrder.Controls.Add(this.labelOrderStartDate);
            this.groupBoxAddNewOrder.Location = new System.Drawing.Point(215, 12);
            this.groupBoxAddNewOrder.Name = "groupBoxAddNewOrder";
            this.groupBoxAddNewOrder.Size = new System.Drawing.Size(370, 426);
            this.groupBoxAddNewOrder.TabIndex = 1;
            this.groupBoxAddNewOrder.TabStop = false;
            // 
            // buttonUpdateOrder
            // 
            this.buttonUpdateOrder.Location = new System.Drawing.Point(208, 397);
            this.buttonUpdateOrder.Name = "buttonUpdateOrder";
            this.buttonUpdateOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateOrder.TabIndex = 8;
            this.buttonUpdateOrder.Text = "Modifica";
            this.buttonUpdateOrder.UseVisualStyleBackColor = true;
            this.buttonUpdateOrder.Click += new System.EventHandler(this.buttonUpdateOrder_Click);
            // 
            // richTextBoxOrderDescription
            // 
            this.richTextBoxOrderDescription.Location = new System.Drawing.Point(121, 140);
            this.richTextBoxOrderDescription.Name = "richTextBoxOrderDescription";
            this.richTextBoxOrderDescription.Size = new System.Drawing.Size(200, 142);
            this.richTextBoxOrderDescription.TabIndex = 7;
            this.richTextBoxOrderDescription.Text = "";
            this.richTextBoxOrderDescription.TextChanged += new System.EventHandler(this.richTextBoxOrderDescription_TextChanged);
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
            this.numericUpDownKm.ValueChanged += new System.EventHandler(this.numericUpDownKm_ValueChanged);
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
            // dateTimePickerOrderFinish
            // 
            this.dateTimePickerOrderFinish.Location = new System.Drawing.Point(121, 54);
            this.dateTimePickerOrderFinish.Name = "dateTimePickerOrderFinish";
            this.dateTimePickerOrderFinish.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerOrderFinish.TabIndex = 3;
            this.dateTimePickerOrderFinish.ValueChanged += new System.EventHandler(this.dateTimePickerOrderFinish_ValueChanged);
            // 
            // dateTimePickerOrderStart
            // 
            this.dateTimePickerOrderStart.CustomFormat = "";
            this.dateTimePickerOrderStart.Location = new System.Drawing.Point(121, 31);
            this.dateTimePickerOrderStart.Name = "dateTimePickerOrderStart";
            this.dateTimePickerOrderStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerOrderStart.TabIndex = 2;
            this.dateTimePickerOrderStart.ValueChanged += new System.EventHandler(this.dateTimePickerOrderStart_ValueChanged);
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
            // labelOrderStartDate
            // 
            this.labelOrderStartDate.AutoSize = true;
            this.labelOrderStartDate.Location = new System.Drawing.Point(7, 31);
            this.labelOrderStartDate.Name = "labelOrderStartDate";
            this.labelOrderStartDate.Size = new System.Drawing.Size(86, 13);
            this.labelOrderStartDate.TabIndex = 0;
            this.labelOrderStartDate.Text = "Data programare";
            // 
            // radioButtonOrderAwaiting
            // 
            this.radioButtonOrderAwaiting.AutoSize = true;
            this.radioButtonOrderAwaiting.Location = new System.Drawing.Point(16, 325);
            this.radioButtonOrderAwaiting.Name = "radioButtonOrderAwaiting";
            this.radioButtonOrderAwaiting.Size = new System.Drawing.Size(127, 17);
            this.radioButtonOrderAwaiting.TabIndex = 9;
            this.radioButtonOrderAwaiting.TabStop = true;
            this.radioButtonOrderAwaiting.Text = "comanda in asteptare";
            this.radioButtonOrderAwaiting.UseVisualStyleBackColor = true;
            this.radioButtonOrderAwaiting.CheckedChanged += new System.EventHandler(this.radioButtonOrderAwaiting_CheckedChanged);
            // 
            // radioButtonOrderExecuted
            // 
            this.radioButtonOrderExecuted.AutoSize = true;
            this.radioButtonOrderExecuted.Location = new System.Drawing.Point(16, 348);
            this.radioButtonOrderExecuted.Name = "radioButtonOrderExecuted";
            this.radioButtonOrderExecuted.Size = new System.Drawing.Size(119, 17);
            this.radioButtonOrderExecuted.TabIndex = 10;
            this.radioButtonOrderExecuted.TabStop = true;
            this.radioButtonOrderExecuted.Text = "comanda executata";
            this.radioButtonOrderExecuted.UseVisualStyleBackColor = true;
            this.radioButtonOrderExecuted.CheckedChanged += new System.EventHandler(this.radioButtonOrderExecuted_CheckedChanged);
            // 
            // radioButtonOrderRefused
            // 
            this.radioButtonOrderRefused.AutoSize = true;
            this.radioButtonOrderRefused.Location = new System.Drawing.Point(16, 371);
            this.radioButtonOrderRefused.Name = "radioButtonOrderRefused";
            this.radioButtonOrderRefused.Size = new System.Drawing.Size(110, 17);
            this.radioButtonOrderRefused.TabIndex = 11;
            this.radioButtonOrderRefused.TabStop = true;
            this.radioButtonOrderRefused.Text = "comanda refuzata";
            this.radioButtonOrderRefused.UseVisualStyleBackColor = true;
            this.radioButtonOrderRefused.CheckedChanged += new System.EventHandler(this.radioButtonOrderRefused_CheckedChanged);
            // 
            // OrderUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxAddNewOrder);
            this.Name = "OrderUpdateForm";
            this.Text = "OrderUpdateForm";
            this.groupBoxAddNewOrder.ResumeLayout(false);
            this.groupBoxAddNewOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddNewOrder;
        private System.Windows.Forms.Button buttonUpdateOrder;
        private System.Windows.Forms.RichTextBox richTextBoxOrderDescription;
        private System.Windows.Forms.Label labelOrderDescription;
        private System.Windows.Forms.NumericUpDown numericUpDownKm;
        private System.Windows.Forms.Label labelKm;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderFinish;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderStart;
        private System.Windows.Forms.Label labelOrderFinishDate;
        private System.Windows.Forms.Label labelOrderStartDate;
        private System.Windows.Forms.RadioButton radioButtonOrderRefused;
        private System.Windows.Forms.RadioButton radioButtonOrderExecuted;
        private System.Windows.Forms.RadioButton radioButtonOrderAwaiting;
    }
}