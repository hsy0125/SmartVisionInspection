namespace SmartVisionInspection.Setting
{
	partial class CameraSetting
	{
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 구성 요소 디자이너에서 생성한 코드

		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbCameraType = new System.Windows.Forms.TextBox();
			this.cbCameraType = new System.Windows.Forms.ComboBox();
			this.btnApply = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbCameraType
			// 
			this.lbCameraType.Location = new System.Drawing.Point(15, 27);
			this.lbCameraType.Name = "lbCameraType";
			this.lbCameraType.Size = new System.Drawing.Size(120, 28);
			this.lbCameraType.TabIndex = 0;
			this.lbCameraType.Text = "카메라 종류";
			// 
			// cbCameraType
			// 
			this.cbCameraType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCameraType.FormattingEnabled = true;
			this.cbCameraType.Items.AddRange(new object[] {
            "None",
            "WebCam",
            "HikRobotCam"});
			this.cbCameraType.Location = new System.Drawing.Point(141, 28);
			this.cbCameraType.Name = "cbCameraType";
			this.cbCameraType.Size = new System.Drawing.Size(206, 26);
			this.cbCameraType.TabIndex = 1;
			// 
			// btnApply
			// 
			this.btnApply.Location = new System.Drawing.Point(243, 81);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(117, 37);
			this.btnApply.TabIndex = 2;
			this.btnApply.Text = "적용";
			this.btnApply.UseVisualStyleBackColor = true;
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// CameraSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnApply);
			this.Controls.Add(this.cbCameraType);
			this.Controls.Add(this.lbCameraType);
			this.Name = "CameraSetting";
			this.Size = new System.Drawing.Size(406, 197);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox lbCameraType;
		private System.Windows.Forms.ComboBox cbCameraType;
		private System.Windows.Forms.Button btnApply;
	}
}
