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
            this.textBoxMecanicId = new System.Windows.Forms.TextBox();
            this.labelMecanicId = new System.Windows.Forms.Label();
            this.textBoxPrenumeMecanic = new System.Windows.Forms.TextBox();
            this.textBoxNumeMecanic = new System.Windows.Forms.TextBox();
            this.labelMacanicPrenume = new System.Windows.Forms.Label();
            this.labelMecanicNume = new System.Windows.Forms.Label();
            this.buttonAddMecanic = new System.Windows.Forms.Button();
            this.groupBoxMecanics.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBoxMecanics.Location = new System.Drawing.Point(149, 164);
            this.groupBoxMecanics.Name = "groupBoxMecanics";
            this.groupBoxMecanics.Size = new System.Drawing.Size(306, 122);
            this.groupBoxMecanics.TabIndex = 8;
            this.groupBoxMecanics.TabStop = false;
            this.groupBoxMecanics.Text = "Mecanic";
            // 
            // buttonMecanicUpdate
            // 
            this.buttonMecanicUpdate.Location = new System.Drawing.Point(196, 67);
            this.buttonMecanicUpdate.Name = "buttonMecanicUpdate";
            this.buttonMecanicUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonMecanicUpdate.TabIndex = 7;
            this.buttonMecanicUpdate.Text = "Update";
            this.buttonMecanicUpdate.UseVisualStyleBackColor = true;
            // 
            // textBoxMecanicId
            // 
            this.textBoxMecanicId.Location = new System.Drawing.Point(72, 96);
            this.textBoxMecanicId.Name = "textBoxMecanicId";
            this.textBoxMecanicId.Size = new System.Drawing.Size(100, 20);
            this.textBoxMecanicId.TabIndex = 6;
            this.textBoxMecanicId.TextChanged += new System.EventHandler(this.textBoxMecanicId_TextChanged);
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
            // textBoxPrenumeMecanic
            // 
            this.textBoxPrenumeMecanic.Location = new System.Drawing.Point(72, 71);
            this.textBoxPrenumeMecanic.Name = "textBoxPrenumeMecanic";
            this.textBoxPrenumeMecanic.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenumeMecanic.TabIndex = 4;
            this.textBoxPrenumeMecanic.TextChanged += new System.EventHandler(this.textBoxPrenumeMecanic_TextChanged);
            // 
            // textBoxNumeMecanic
            // 
            this.textBoxNumeMecanic.Location = new System.Drawing.Point(72, 33);
            this.textBoxNumeMecanic.Name = "textBoxNumeMecanic";
            this.textBoxNumeMecanic.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeMecanic.TabIndex = 3;
            this.textBoxNumeMecanic.TextChanged += new System.EventHandler(this.textBoxNumeMecanic_TextChanged_1);
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
            // labelMecanicNume
            // 
            this.labelMecanicNume.AutoSize = true;
            this.labelMecanicNume.Location = new System.Drawing.Point(13, 33);
            this.labelMecanicNume.Name = "labelMecanicNume";
            this.labelMecanicNume.Size = new System.Drawing.Size(35, 13);
            this.labelMecanicNume.TabIndex = 1;
            this.labelMecanicNume.Text = "Nume";
            // 
            // buttonAddMecanic
            // 
            this.buttonAddMecanic.Location = new System.Drawing.Point(196, 33);
            this.buttonAddMecanic.Name = "buttonAddMecanic";
            this.buttonAddMecanic.Size = new System.Drawing.Size(82, 23);
            this.buttonAddMecanic.TabIndex = 0;
            this.buttonAddMecanic.Text = "Add mecanic";
            this.buttonAddMecanic.UseVisualStyleBackColor = true;
            this.buttonAddMecanic.Click += new System.EventHandler(this.buttonAddMecanic_Click_1);
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
        private System.Windows.Forms.TextBox textBoxMecanicId;
        private System.Windows.Forms.Label labelMecanicId;
        private System.Windows.Forms.TextBox textBoxPrenumeMecanic;
        private System.Windows.Forms.TextBox textBoxNumeMecanic;
        private System.Windows.Forms.Label labelMacanicPrenume;
        private System.Windows.Forms.Label labelMecanicNume;
        private System.Windows.Forms.Button buttonAddMecanic;
    }
}