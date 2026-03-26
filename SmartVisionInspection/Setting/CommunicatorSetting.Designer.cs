namespace SmartVisionInspection.Setting
{
	partial class CommunicatorSetting
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
			this.lbMachine = new System.Windows.Forms.Label();
			this.lbCommType = new System.Windows.Forms.Label();
			this.laIpAddr = new System.Windows.Forms.Label();
			this.btnApply = new System.Windows.Forms.Button();
			this.cbCommType = new System.Windows.Forms.ComboBox();
			this.txtMachine = new System.Windows.Forms.TextBox();
			this.txtIpAddr = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lbMachine
			// 
			this.lbMachine.AutoSize = true;
			this.lbMachine.Location = new System.Drawing.Point(30, 31);
			this.lbMachine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbMachine.Name = "lbMachine";
			this.lbMachine.Size = new System.Drawing.Size(62, 18);
			this.lbMachine.TabIndex = 13;
			this.lbMachine.Text = "설비명";
			// 
			// lbCommType
			// 
			this.lbCommType.AutoSize = true;
			this.lbCommType.Location = new System.Drawing.Point(30, 64);
			this.lbCommType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbCommType.Name = "lbCommType";
			this.lbCommType.Size = new System.Drawing.Size(80, 18);
			this.lbCommType.TabIndex = 14;
			this.lbCommType.Text = "통신타입";
			// 
			// laIpAddr
			// 
			this.laIpAddr.AutoSize = true;
			this.laIpAddr.Location = new System.Drawing.Point(30, 100);
			this.laIpAddr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.laIpAddr.Name = "laIpAddr";
			this.laIpAddr.Size = new System.Drawing.Size(64, 18);
			this.laIpAddr.TabIndex = 15;
			this.laIpAddr.Text = "IP 주소";
			// 
			// btnApply
			// 
			this.btnApply.Location = new System.Drawing.Point(235, 144);
			this.btnApply.Margin = new System.Windows.Forms.Padding(4);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(107, 34);
			this.btnApply.TabIndex = 16;
			this.btnApply.Text = "적용";
			this.btnApply.UseVisualStyleBackColor = true;
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// cbCommType
			// 
			this.cbCommType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCommType.FormattingEnabled = true;
			this.cbCommType.Location = new System.Drawing.Point(141, 64);
			this.cbCommType.Margin = new System.Windows.Forms.Padding(4);
			this.cbCommType.Name = "cbCommType";
			this.cbCommType.Size = new System.Drawing.Size(197, 26);
			this.cbCommType.TabIndex = 17;
			// 
			// txtMachine
			// 
			this.txtMachine.Location = new System.Drawing.Point(141, 21);
			this.txtMachine.Name = "txtMachine";
			this.txtMachine.Size = new System.Drawing.Size(197, 28);
			this.txtMachine.TabIndex = 18;
			// 
			// txtIpAddr
			// 
			this.txtIpAddr.Location = new System.Drawing.Point(141, 109);
			this.txtIpAddr.Name = "txtIpAddr";
			this.txtIpAddr.Size = new System.Drawing.Size(195, 28);
			this.txtIpAddr.TabIndex = 19;
			// 
			// CommunicatorSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtIpAddr);
			this.Controls.Add(this.txtMachine);
			this.Controls.Add(this.cbCommType);
			this.Controls.Add(this.btnApply);
			this.Controls.Add(this.laIpAddr);
			this.Controls.Add(this.lbCommType);
			this.Controls.Add(this.lbMachine);
			this.Name = "CommunicatorSetting";
			this.Size = new System.Drawing.Size(381, 211);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbMachine;
		private System.Windows.Forms.Label lbCommType;
		private System.Windows.Forms.Label laIpAddr;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.ComboBox cbCommType;
		private System.Windows.Forms.TextBox txtMachine;
		private System.Windows.Forms.TextBox txtIpAddr;
	}
}
