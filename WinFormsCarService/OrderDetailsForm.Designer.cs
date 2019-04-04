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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Mecanici");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Material");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Imagine");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Operatie", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Detalii Comanda", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeViewOrderDetails = new System.Windows.Forms.TreeView();
            this.buttonAddOrderOperation = new System.Windows.Forms.Button();
            this.buttonDeleteOrderOperation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeViewOrderDetails
            // 
            this.treeViewOrderDetails.Location = new System.Drawing.Point(32, 12);
            this.treeViewOrderDetails.Name = "treeViewOrderDetails";
            treeNode1.Name = "NodeMecanics";
            treeNode1.Text = "Mecanici";
            treeNode2.Name = "NodeMaterial";
            treeNode2.Text = "Material";
            treeNode3.Name = "NodeImage";
            treeNode3.Text = "Imagine";
            treeNode4.Name = "NodeOperation";
            treeNode4.Text = "Operatie";
            treeNode5.Name = "NodeRoot";
            treeNode5.Text = "Detalii Comanda";
            this.treeViewOrderDetails.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeViewOrderDetails.Size = new System.Drawing.Size(135, 310);
            this.treeViewOrderDetails.TabIndex = 1;
            // 
            // buttonAddOrderOperation
            // 
            this.buttonAddOrderOperation.Location = new System.Drawing.Point(32, 345);
            this.buttonAddOrderOperation.Name = "buttonAddOrderOperation";
            this.buttonAddOrderOperation.Size = new System.Drawing.Size(119, 23);
            this.buttonAddOrderOperation.TabIndex = 2;
            this.buttonAddOrderOperation.Text = "Adauga operatie";
            this.buttonAddOrderOperation.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteOrderOperation
            // 
            this.buttonDeleteOrderOperation.Location = new System.Drawing.Point(157, 345);
            this.buttonDeleteOrderOperation.Name = "buttonDeleteOrderOperation";
            this.buttonDeleteOrderOperation.Size = new System.Drawing.Size(120, 23);
            this.buttonDeleteOrderOperation.TabIndex = 3;
            this.buttonDeleteOrderOperation.Text = "Sterge operatie";
            this.buttonDeleteOrderOperation.UseVisualStyleBackColor = true;
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.buttonDeleteOrderOperation);
            this.Controls.Add(this.buttonAddOrderOperation);
            this.Controls.Add(this.treeViewOrderDetails);
            this.Name = "OrderDetailsForm";
            this.Text = "Detalii comanda";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeViewOrderDetails;
        private System.Windows.Forms.Button buttonAddOrderOperation;
        private System.Windows.Forms.Button buttonDeleteOrderOperation;
    }
}