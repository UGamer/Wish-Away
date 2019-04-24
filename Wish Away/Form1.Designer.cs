namespace Wish_Away
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TopToolStrip = new System.Windows.Forms.ToolStrip();
            this.ItemsButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TopToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(270, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 250);
            this.panel1.TabIndex = 1;
            // 
            // TopToolStrip
            // 
            this.TopToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemsButton});
            this.TopToolStrip.Location = new System.Drawing.Point(0, 0);
            this.TopToolStrip.Name = "TopToolStrip";
            this.TopToolStrip.Size = new System.Drawing.Size(1000, 32);
            this.TopToolStrip.TabIndex = 2;
            this.TopToolStrip.Text = "TopToolStrip";
            // 
            // ItemsButton
            // 
            this.ItemsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ItemsButton.Image = ((System.Drawing.Image)(resources.GetObject("ItemsButton.Image")));
            this.ItemsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItemsButton.Name = "ItemsButton";
            this.ItemsButton.Size = new System.Drawing.Size(60, 29);
            this.ItemsButton.Text = "Items";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 574);
            this.Controls.Add(this.TopToolStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Wish Away";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TopToolStrip.ResumeLayout(false);
            this.TopToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip TopToolStrip;
        private System.Windows.Forms.ToolStripButton ItemsButton;
    }
}

