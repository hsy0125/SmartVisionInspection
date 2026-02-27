namespace SmartVisionInspection
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
			this.imageViewCtrl2 = new SmartVisionInspection.UIControl.ImageViewCtrl();
			this.imageViewCtrl = new SmartVisionInspection.UIControl.ImageViewCtrl();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imegeSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// imageViewCtrl2
			// 
			this.imageViewCtrl2.Location = new System.Drawing.Point(58, 97);
			this.imageViewCtrl2.Name = "imageViewCtrl2";
			this.imageViewCtrl2.Size = new System.Drawing.Size(150, 150);
			this.imageViewCtrl2.TabIndex = 1;
			// 
			// imageViewCtrl
			// 
			this.imageViewCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imageViewCtrl.Location = new System.Drawing.Point(0, 33);
			this.imageViewCtrl.Name = "imageViewCtrl";
			this.imageViewCtrl.Size = new System.Drawing.Size(752, 498);
			this.imageViewCtrl.TabIndex = 2;
			// 
			// menuStrip
			// 
			this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(752, 33);
			this.menuStrip.TabIndex = 4;
			this.menuStrip.Text = "menuStrip2";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageOpenToolStripMenuItem,
            this.imegeSaveToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// imageOpenToolStripMenuItem
			// 
			this.imageOpenToolStripMenuItem.Name = "imageOpenToolStripMenuItem";
			this.imageOpenToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
			this.imageOpenToolStripMenuItem.Text = "이미지 열기";
			this.imageOpenToolStripMenuItem.Click += new System.EventHandler(this.imageOpenToolStripMenuItem_Click);
			// 
			// imegeSaveToolStripMenuItem
			// 
			this.imegeSaveToolStripMenuItem.Name = "imegeSaveToolStripMenuItem";
			this.imegeSaveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
			this.imegeSaveToolStripMenuItem.Text = "이미지 저장";
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(752, 531);
			this.Controls.Add(this.imageViewCtrl);
			this.Controls.Add(this.imageViewCtrl2);
			this.Controls.Add(this.menuStrip);
			this.Name = "MainForm";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private UIControl.ImageViewCtrl imageViewCtrl2;
		private UIControl.ImageViewCtrl imageViewCtrl;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageOpenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imegeSaveToolStripMenuItem;
	}
}