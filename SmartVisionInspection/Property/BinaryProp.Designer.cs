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
			this.dataGridViewFilter = new System.Windows.Forms.DataGridView();
			this.chkRotatedRect = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbBinMethod = new System.Windows.Forms.ComboBox();
			this.grpBinary.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilter)).BeginInit();
			this.SuspendLayout();
			// 
			// grpBinary
			// 
			this.grpBinary.Controls.Add(this.cbHighlight);
			this.grpBinary.Controls.Add(this.lbHighlight);
			this.grpBinary.Controls.Add(this.binRangeTrackbar);
			this.grpBinary.Location = new System.Drawing.Point(16, 54);
			this.grpBinary.Margin = new System.Windows.Forms.Padding(4);
			this.grpBinary.Name = "grpBinary";
			this.grpBinary.Padding = new System.Windows.Forms.Padding(4);
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
			this.cbHighlight.Margin = new System.Windows.Forms.Padding(4);
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
			this.binRangeTrackbar.Margin = new System.Windows.Forms.Padding(4);
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
			this.chkUse.Margin = new System.Windows.Forms.Padding(4);
			this.chkUse.Name = "chkUse";
			this.chkUse.Size = new System.Drawing.Size(70, 22);
			this.chkUse.TabIndex = 4;
			this.chkUse.Text = "검사";
			this.chkUse.UseVisualStyleBackColor = true;
			this.chkUse.CheckedChanged += new System.EventHandler(this.chkUse_CheckedChanged);
			// 
			// dataGridViewFilter
			// 
			this.dataGridViewFilter.ColumnHeadersHeight = 34;
			this.dataGridViewFilter.Location = new System.Drawing.Point(28, 248);
			this.dataGridViewFilter.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewFilter.Name = "dataGridViewFilter";
			this.dataGridViewFilter.RowHeadersWidth = 62;
			this.dataGridViewFilter.Size = new System.Drawing.Size(324, 202);
			this.dataGridViewFilter.TabIndex = 0;
			this.dataGridViewFilter.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFilter_CellValueChanged);
			// 
			// chkRotatedRect
			// 
			this.chkRotatedRect.AutoSize = true;
			this.chkRotatedRect.Checked = true;
			this.chkRotatedRect.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkRotatedRect.Location = new System.Drawing.Point(28, 480);
			this.chkRotatedRect.Name = "chkRotatedRect";
			this.chkRotatedRect.Size = new System.Drawing.Size(124, 22);
			this.chkRotatedRect.TabIndex = 5;
			this.chkRotatedRect.Text = "회전사각형";
			this.chkRotatedRect.UseVisualStyleBackColor = true;
			this.chkRotatedRect.CheckedChanged += new System.EventHandler(this.chkRotatedRect_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 203);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 18);
			this.label2.TabIndex = 6;
			this.label2.Text = "검사 타입";
			// 
			// cbBinMethod
			// 
			this.cbBinMethod.FormattingEnabled = true;
			this.cbBinMethod.Items.AddRange(new object[] {
            "Feature",
            "FixelCount"});
			this.cbBinMethod.Location = new System.Drawing.Point(126, 200);
			this.cbBinMethod.Name = "cbBinMethod";
			this.cbBinMethod.Size = new System.Drawing.Size(165, 26);
			this.cbBinMethod.TabIndex = 7;
			this.cbBinMethod.SelectedIndexChanged += new System.EventHandler(this.cbBinMethod_SelectedIndexChanged);
			// 
			// BinaryProp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cbBinMethod);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.chkRotatedRect);
			this.Controls.Add(this.dataGridViewFilter);
			this.Controls.Add(this.chkUse);
			this.Controls.Add(this.grpBinary);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "BinaryProp";
			this.Size = new System.Drawing.Size(389, 522);
			this.grpBinary.ResumeLayout(false);
			this.grpBinary.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilter)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grpBinary;
		private UIControl.RangeTrackbar binRangeTrackbar;
		private System.Windows.Forms.ComboBox cbHighlight;
		private System.Windows.Forms.Label lbHighlight;
		private System.Windows.Forms.CheckBox chkUse;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridViewFilter;
		private System.Windows.Forms.CheckBox chkRotatedRect;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbBinMethod;
	}
}
