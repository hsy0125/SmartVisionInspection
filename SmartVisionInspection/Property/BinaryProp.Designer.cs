namespace SmartVisionInspection.Property
{
	partial class BinaryProp
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
				if (binRangeTrackbar != null)
					binRangeTrackbar.RangeChanged -= Range_RangeChanged;

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
			this.grpBinary = new System.Windows.Forms.GroupBox();
			this.cbHighlight = new System.Windows.Forms.ComboBox();
			this.lbHighlight = new System.Windows.Forms.Label();
			this.binRangeTrackbar = new SmartVisionInspection.UIControl.RangeTrackbar();
			this.chkUse = new System.Windows.Forms.CheckBox();
			this.grpBinary.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpBinary
			// 
			this.grpBinary.Controls.Add(this.cbHighlight);
			this.grpBinary.Controls.Add(this.lbHighlight);
			this.grpBinary.Controls.Add(this.binRangeTrackbar);
			this.grpBinary.Location = new System.Drawing.Point(16, 54);
			this.grpBinary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.grpBinary.Name = "grpBinary";
			this.grpBinary.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.grpBinary.Size = new System.Drawing.Size(357, 135);
			this.grpBinary.TabIndex = 0;
			this.grpBinary.TabStop = false;
			this.grpBinary.Text = "이진화";
			// 
			// cbHighlight
			// 
			this.cbHighlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHighlight.FormattingEnabled = true;
			this.cbHighlight.Location = new System.Drawing.Point(110, 88);
			this.cbHighlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbHighlight.Name = "cbHighlight";
			this.cbHighlight.Size = new System.Drawing.Size(165, 26);
			this.cbHighlight.TabIndex = 2;
			this.cbHighlight.SelectedIndexChanged += new System.EventHandler(this.cbHighlight_SelectedIndexChanged);
			// 
			// lbHighlight
			// 
			this.lbHighlight.AutoSize = true;
			this.lbHighlight.Location = new System.Drawing.Point(9, 98);
			this.lbHighlight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbHighlight.Name = "lbHighlight";
			this.lbHighlight.Size = new System.Drawing.Size(98, 18);
			this.lbHighlight.TabIndex = 7;
			this.lbHighlight.Text = "하이라이트";
			// 
			// binRangeTrackbar
			// 
			this.binRangeTrackbar.Location = new System.Drawing.Point(10, 18);
			this.binRangeTrackbar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.binRangeTrackbar.Name = "binRangeTrackbar";
			this.binRangeTrackbar.Size = new System.Drawing.Size(339, 66);
			this.binRangeTrackbar.TabIndex = 6;
			this.binRangeTrackbar.ValueLeft = 0;
			this.binRangeTrackbar.ValueRight = 128;
			// 
			// chkUse
			// 
			this.chkUse.AutoSize = true;
			this.chkUse.Checked = true;
			this.chkUse.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkUse.Location = new System.Drawing.Point(16, 21);
			this.chkUse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chkUse.Name = "chkUse";
			this.chkUse.Size = new System.Drawing.Size(70, 22);
			this.chkUse.TabIndex = 4;
			this.chkUse.Text = "검사";
			this.chkUse.UseVisualStyleBackColor = true;
			this.chkUse.CheckedChanged += new System.EventHandler(this.chkUse_CheckedChanged);
			// 
			// BinaryProp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.chkUse);
			this.Controls.Add(this.grpBinary);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "BinaryProp";
			this.Size = new System.Drawing.Size(389, 522);
			this.grpBinary.ResumeLayout(false);
			this.grpBinary.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grpBinary;
		private UIControl.RangeTrackbar binRangeTrackbar;
		private System.Windows.Forms.ComboBox cbHighlight;
		private System.Windows.Forms.Label lbHighlight;
		private System.Windows.Forms.CheckBox chkUse;
	}
}
