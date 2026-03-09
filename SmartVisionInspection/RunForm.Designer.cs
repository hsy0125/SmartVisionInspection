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
			this.btnGrab = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnGrab
			// 
			this.btnGrab.Location = new System.Drawing.Point(17, 18);
			this.btnGrab.Margin = new System.Windows.Forms.Padding(4);
			this.btnGrab.Name = "btnGrab";
			this.btnGrab.Size = new System.Drawing.Size(171, 74);
			this.btnGrab.TabIndex = 0;
			this.btnGrab.Text = "촬상";
			this.btnGrab.UseVisualStyleBackColor = true;
			this.btnGrab.Click += new System.EventHandler(this.btnGrab_Click);
			// 
			// RunForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(365, 148);
			this.Controls.Add(this.btnGrab);
			this.Name = "RunForm";
			this.Text = "RunForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnGrab;
	}
}