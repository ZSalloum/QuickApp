namespace QuikApp.UI.Controls
{
    partial class ModelDefTree
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trvModels = new System.Windows.Forms.TreeView();
            this.menuModelsTree = new System.Windows.Forms.MenuStrip();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModelsTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvModels
            // 
            this.trvModels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvModels.Location = new System.Drawing.Point(0, 24);
            this.trvModels.Name = "trvModels";
            this.trvModels.Size = new System.Drawing.Size(505, 391);
            this.trvModels.TabIndex = 0;
            this.trvModels.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvModels_AfterSelect);
            // 
            // menuModelsTree
            // 
            this.menuModelsTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem});
            this.menuModelsTree.Location = new System.Drawing.Point(0, 0);
            this.menuModelsTree.Name = "menuModelsTree";
            this.menuModelsTree.Size = new System.Drawing.Size(505, 24);
            this.menuModelsTree.TabIndex = 1;
            this.menuModelsTree.Text = "menuStrip1";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.generateToolStripMenuItem.Text = "Generate";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
            // 
            // ModelDefTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trvModels);
            this.Controls.Add(this.menuModelsTree);
            this.Name = "ModelDefTree";
            this.Size = new System.Drawing.Size(505, 415);
            this.menuModelsTree.ResumeLayout(false);
            this.menuModelsTree.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvModels;
        private System.Windows.Forms.MenuStrip menuModelsTree;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
    }
}
