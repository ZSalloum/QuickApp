namespace QuickApp
{
    partial class MainForm
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
            this.splitMainContainer = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modelDefTree = new QuikApp.UI.Controls.ModelDefTree();
            this.detailsManagerControl1 = new QuikApp.UI.Controls.DetailsManagerControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitMainContainer)).BeginInit();
            this.splitMainContainer.Panel1.SuspendLayout();
            this.splitMainContainer.Panel2.SuspendLayout();
            this.splitMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMainContainer
            // 
            this.splitMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMainContainer.Location = new System.Drawing.Point(0, 24);
            this.splitMainContainer.Name = "splitMainContainer";
            // 
            // splitMainContainer.Panel1
            // 
            this.splitMainContainer.Panel1.Controls.Add(this.modelDefTree);
            // 
            // splitMainContainer.Panel2
            // 
            this.splitMainContainer.Panel2.Controls.Add(this.detailsManagerControl1);
            this.splitMainContainer.Size = new System.Drawing.Size(1039, 416);
            this.splitMainContainer.SplitterDistance = 346;
            this.splitMainContainer.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1039, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modelDefTree
            // 
            this.modelDefTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelDefTree.Location = new System.Drawing.Point(0, 0);
            this.modelDefTree.Name = "modelDefTree";
            this.modelDefTree.Size = new System.Drawing.Size(346, 416);
            this.modelDefTree.TabIndex = 0;
            // 
            // detailsManagerControl1
            // 
            this.detailsManagerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsManagerControl1.Location = new System.Drawing.Point(0, 0);
            this.detailsManagerControl1.Name = "detailsManagerControl1";
            this.detailsManagerControl1.Size = new System.Drawing.Size(689, 416);
            this.detailsManagerControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 440);
            this.Controls.Add(this.splitMainContainer);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.splitMainContainer.Panel1.ResumeLayout(false);
            this.splitMainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMainContainer)).EndInit();
            this.splitMainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMainContainer;
        private QuikApp.UI.Controls.ModelDefTree modelDefTree;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private QuikApp.UI.Controls.DetailsManagerControl detailsManagerControl1;
    }
}

