namespace WinFormsCarService
{
    partial class MecanicForm
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
            this.groupBoxMecanics = new System.Windows.Forms.GroupBox();
            this.buttonMecanicUpdate = new System.Windows.Forms.Button();
            this.textBoxPrenumeMecanic = new System.Windows.Forms.TextBox();
            this.textBoxNumeMecanic = new System.Windows.Forms.TextBox();
            this.labelMacanicPrenume = new System.Windows.Forms.Label();
            this.labelMecanicNume = new System.Windows.Forms.Label();
            this.buttonAddMecanic = new System.Windows.Forms.Button();
            this.listViewMecanics = new System.Windows.Forms.ListView();
            this.columnHeaderMecanicId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMecanicFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMecanicLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonMecanicDelete = new System.Windows.Forms.Button();
            this.groupBoxMecanics.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMecanics
            // 
            this.groupBoxMecanics.Controls.Add(this.buttonMecanicDelete);
            this.groupBoxMecanics.Controls.Add(this.listViewMecanics);
            this.groupBoxMecanics.Controls.Add(this.buttonMecanicUpdate);
            this.groupBoxMecanics.Controls.Add(this.textBoxPrenumeMecanic);
            this.groupBoxMecanics.Controls.Add(this.textBoxNumeMecanic);
            this.groupBoxMecanics.Controls.Add(this.labelMacanicPrenume);
            this.groupBoxMecanics.Controls.Add(this.labelMecanicNume);
            this.groupBoxMecanics.Controls.Add(this.buttonAddMecanic);
            this.groupBoxMecanics.Location = new System.Drawing.Point(141, 34);
            this.groupBoxMecanics.Name = "groupBoxMecanics";
            this.groupBoxMecanics.Size = new System.Drawing.Size(306, 358);
            this.groupBoxMecanics.TabIndex = 8;
            this.groupBoxMecanics.TabStop = false;
            this.groupBoxMecanics.Text = "Mecanic";
            // 
            // buttonMecanicUpdate
            // 
            this.buttonMecanicUpdate.Location = new System.Drawing.Point(127, 203);
            this.buttonMecanicUpdate.Name = "buttonMecanicUpdate";
            this.buttonMecanicUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonMecanicUpdate.TabIndex = 7;
            this.buttonMecanicUpdate.Text = "Modifica";
            this.buttonMecanicUpdate.UseVisualStyleBackColor = true;
            // 
            // textBoxPrenumeMecanic
            // 
            this.textBoxPrenumeMecanic.Location = new System.Drawing.Point(73, 295);
            this.textBoxPrenumeMecanic.MaxLength = 15;
            this.textBoxPrenumeMecanic.Name = "textBoxPrenumeMecanic";
            this.textBoxPrenumeMecanic.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenumeMecanic.TabIndex = 4;
            this.textBoxPrenumeMecanic.TextChanged += new System.EventHandler(this.textBoxPrenumeMecanic_TextChanged);
            // 
            // textBoxNumeMecanic
            // 
            this.textBoxNumeMecanic.Location = new System.Drawing.Point(73, 259);
            this.textBoxNumeMecanic.MaxLength = 15;
            this.textBoxNumeMecanic.Name = "textBoxNumeMecanic";
            this.textBoxNumeMecanic.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeMecanic.TabIndex = 3;
            this.textBoxNumeMecanic.TextChanged += new System.EventHandler(this.textBoxNumeMecanic_TextChanged_1);
            // 
            // labelMacanicPrenume
            // 
            this.labelMacanicPrenume.AutoSize = true;
            this.labelMacanicPrenume.Location = new System.Drawing.Point(14, 295);
            this.labelMacanicPrenume.Name = "labelMacanicPrenume";
            this.labelMacanicPrenume.Size = new System.Drawing.Size(49, 13);
            this.labelMacanicPrenume.TabIndex = 2;
            this.labelMacanicPrenume.Text = "Prenume";
            // 
            // labelMecanicNume
            // 
            this.labelMecanicNume.AutoSize = true;
            this.labelMecanicNume.Location = new System.Drawing.Point(14, 259);
            this.labelMecanicNume.Name = "labelMecanicNume";
            this.labelMecanicNume.Size = new System.Drawing.Size(35, 13);
            this.labelMecanicNume.TabIndex = 1;
            this.labelMecanicNume.Text = "Nume";
            // 
            // buttonAddMecanic
            // 
            this.buttonAddMecanic.Location = new System.Drawing.Point(17, 203);
            this.buttonAddMecanic.Name = "buttonAddMecanic";
            this.buttonAddMecanic.Size = new System.Drawing.Size(104, 23);
            this.buttonAddMecanic.TabIndex = 0;
            this.buttonAddMecanic.Text = "Adauga mecanic";
            this.buttonAddMecanic.UseVisualStyleBackColor = true;
            this.buttonAddMecanic.Click += new System.EventHandler(this.buttonAddMecanic_Click_1);
            // 
            // listViewMecanics
            // 
            this.listViewMecanics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMecanicId,
            this.columnHeaderMecanicFName,
            this.columnHeaderMecanicLName});
            this.listViewMecanics.FullRowSelect = true;
            this.listViewMecanics.Location = new System.Drawing.Point(17, 19);
            this.listViewMecanics.MultiSelect = false;
            this.listViewMecanics.Name = "listViewMecanics";
            this.listViewMecanics.Size = new System.Drawing.Size(283, 178);
            this.listViewMecanics.TabIndex = 9;
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
            // buttonMecanicDelete
            // 
            this.buttonMecanicDelete.Location = new System.Drawing.Point(208, 203);
            this.buttonMecanicDelete.Name = "buttonMecanicDelete";
            this.buttonMecanicDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonMecanicDelete.TabIndex = 10;
            this.buttonMecanicDelete.Text = "Sterge";
            this.buttonMecanicDelete.UseVisualStyleBackColor = true;
            this.buttonMecanicDelete.Click += new System.EventHandler(this.buttonMecanicDelete_Click);
            // 
            // MecanicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.groupBoxMecanics);
            this.Name = "MecanicForm";
            this.Text = "MecanicForm";
            this.Load += new System.EventHandler(this.MecanicForm_Load);
            this.groupBoxMecanics.ResumeLayout(false);
            this.groupBoxMecanics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMecanics;
        private System.Windows.Forms.Button buttonMecanicUpdate;
        private System.Windows.Forms.TextBox textBoxPrenumeMecanic;
        private System.Windows.Forms.TextBox textBoxNumeMecanic;
        private System.Windows.Forms.Label labelMacanicPrenume;
        private System.Windows.Forms.Label labelMecanicNume;
        private System.Windows.Forms.Button buttonAddMecanic;
        private System.Windows.Forms.ListView listViewMecanics;
        private System.Windows.Forms.ColumnHeader columnHeaderMecanicId;
        private System.Windows.Forms.ColumnHeader columnHeaderMecanicFName;
        private System.Windows.Forms.ColumnHeader columnHeaderMecanicLName;
        private System.Windows.Forms.Button buttonMecanicDelete;
    }
}