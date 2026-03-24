namespace SmartVisionInspection
{
	partial class RunForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunForm));
			this.btnGrab = new System.Windows.Forms.Button();
			this.btnLive = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.runImageList = new System.Windows.Forms.ImageList(this.components);
			this.btnStop = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnGrab
			// 
			this.btnGrab.ImageIndex = 0;
			this.btnGrab.ImageList = this.runImageList;
			this.btnGrab.Location = new System.Drawing.Point(17, 18);
			this.btnGrab.Margin = new System.Windows.Forms.Padding(4);
			this.btnGrab.Name = "btnGrab";
			this.btnGrab.Size = new System.Drawing.Size(171, 129);
			this.btnGrab.TabIndex = 0;
			this.btnGrab.Text = "촬상";
			this.btnGrab.UseVisualStyleBackColor = true;
			this.btnGrab.Click += new System.EventHandler(this.btnGrab_Click);
			// 
			// btnLive
			// 
			this.btnLive.ImageIndex = 1;
			this.btnLive.ImageList = this.runImageList;
			this.btnLive.Location = new System.Drawing.Point(208, 18);
			this.btnLive.Margin = new System.Windows.Forms.Padding(4);
			this.btnLive.Name = "btnLive";
			this.btnLive.Size = new System.Drawing.Size(171, 129);
			this.btnLive.TabIndex = 1;
			this.btnLive.Text = "LIVE";
			this.btnLive.UseVisualStyleBackColor = true;
			this.btnLive.Click += new System.EventHandler(this.btnLive_Click);
			// 
			// btnStart
			// 
			this.btnStart.ImageIndex = 2;
			this.btnStart.ImageList = this.runImageList;
			this.btnStart.Location = new System.Drawing.Point(410, 18);
			this.btnStart.Margin = new System.Windows.Forms.Padding(4);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(171, 129);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "검사";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// runImageList
			// 
			this.runImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("runImageList.ImageStream")));
			this.runImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.runImageList.Images.SetKeyName(0, "camera_color.png");
			this.runImageList.Images.SetKeyName(1, "live-64.png");
			this.runImageList.Images.SetKeyName(2, "start-64.png");
			this.runImageList.Images.SetKeyName(3, "stop-64.png");
			// 
			// btnStop
			// 
			this.btnStop.ImageIndex = 3;
			this.btnStop.ImageList = this.runImageList;
			this.btnStop.Location = new System.Drawing.Point(612, 17);
			this.btnStop.Margin = new System.Windows.Forms.Padding(4);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(173, 129);
			this.btnStop.TabIndex = 4;
			this.btnStop.Text = "검사";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// RunForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(831, 185);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnLive);
			this.Controls.Add(this.btnGrab);
			this.Name = "RunForm";
			this.Text = "RunForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnGrab;
		private System.Windows.Forms.Button btnLive;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.ImageList runImageList;
		private System.Windows.Forms.Button btnStop;
	}
}