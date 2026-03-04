namespace SmartVisionInspection.Property
{
	partial class AIModuleProp
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
			this.cbAIModelType = new System.Windows.Forms.ComboBox();
			this.txtAIModelPath = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnLoadModel = new System.Windows.Forms.Button();
			this.btnInspAI = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbAIModelType
			// 
			this.cbAIModelType.FormattingEnabled = true;
			this.cbAIModelType.Location = new System.Drawing.Point(25, 32);
			this.cbAIModelType.Name = "cbAIModelType";
			this.cbAIModelType.Size = new System.Drawing.Size(223, 26);
			this.cbAIModelType.TabIndex = 0;
			this.cbAIModelType.SelectedIndexChanged += new System.EventHandler(this.cbAIModelType_SelectedIndexChanged);
			// 
			// txtAIModelPath
			// 
			this.txtAIModelPath.Location = new System.Drawing.Point(25, 88);
			this.txtAIModelPath.Name = "txtAIModelPath";
			this.txtAIModelPath.Size = new System.Drawing.Size(341, 28);
			this.txtAIModelPath.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(25, 151);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(156, 45);
			this.button1.TabIndex = 1;
			this.button1.Text = "AI모델 선택";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnLoadModel
			// 
			this.btnLoadModel.Location = new System.Drawing.Point(25, 214);
			this.btnLoadModel.Margin = new System.Windows.Forms.Padding(4);
			this.btnLoadModel.Name = "btnLoadModel";
			this.btnLoadModel.Size = new System.Drawing.Size(156, 45);
			this.btnLoadModel.TabIndex = 2;
			this.btnLoadModel.Text = "모델 로딩";
			this.btnLoadModel.UseVisualStyleBackColor = true;
			this.btnLoadModel.Click += new System.EventHandler(this.btnLoadModel_Click);
			// 
			// btnInspAI
			// 
			this.btnInspAI.Location = new System.Drawing.Point(25, 277);
			this.btnInspAI.Margin = new System.Windows.Forms.Padding(4);
			this.btnInspAI.Name = "btnInspAI";
			this.btnInspAI.Size = new System.Drawing.Size(156, 45);
			this.btnInspAI.TabIndex = 3;
			this.btnInspAI.Text = "AI 검사";
			this.btnInspAI.UseVisualStyleBackColor = true;
			this.btnInspAI.Click += new System.EventHandler(this.btnInspAI_Click);
			// 
			// AIModuleProp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnInspAI);
			this.Controls.Add(this.btnLoadModel);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtAIModelPath);
			this.Controls.Add(this.cbAIModelType);
			this.Name = "AIModuleProp";
			this.Size = new System.Drawing.Size(419, 578);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbAIModelType;
		private System.Windows.Forms.TextBox txtAIModelPath;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnLoadModel;
		private System.Windows.Forms.Button btnInspAI;
	}
}
