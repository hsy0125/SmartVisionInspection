namespace SmartVisionInspection
{
	partial class CameraForm
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
			this.imageViewer = new SmartVisionInspection.UIControl.ImageViewCtrl();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.imageOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageOpenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.imageSaveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// imageViewer
			// 
			this.imageViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imageViewer.Location = new System.Drawing.Point(0, 33);
			this.imageViewer.Name = "imageViewer";
			this.imageViewer.Size = new System.Drawing.Size(1027, 729);
			this.imageViewer.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.imageOpenToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1027, 33);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// imageOpenToolStripMenuItem
			// 
			this.imageOpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.imageOpenToolStripMenuItem1,
			this.imageSaveToolStripMenuItem1});
			this.imageOpenToolStripMenuItem.Name = "imageOpenToolStripMenuItem";
			this.imageOpenToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
			this.imageOpenToolStripMenuItem.Text = "FIle";
			// 
			// imageOpenToolStripMenuItem1
			// 
			this.imageOpenToolStripMenuItem1.Name = "imageOpenToolStripMenuItem1";
			this.imageOpenToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
			this.imageOpenToolStripMenuItem1.Text = "이미지 열기";
			// 
			// imageSaveToolStripMenuItem1
			// 
			this.imageSaveToolStripMenuItem1.Name = "imageSaveToolStripMenuItem1";
			this.imageSaveToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
			this.imageSaveToolStripMenuItem1.Text = "이미지 저장";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1027, 762);
			this.Controls.Add(this.imageViewer);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "CameraForm";
			this.Text = "CameraForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private UIControl.ImageViewCtrl imageViewer;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem imageOpenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageOpenToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem imageSaveToolStripMenuItem1;
	}
}