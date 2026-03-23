using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartVisionInspection.Core;
using SmartVisionInspection.Setting;
using SmartVisionInspection.Teach;
using SmartVisionInspection.Util;
using WeifenLuo.WinFormsUI.Docking;

namespace SmartVisionInspection
{

	public partial class MainForm : Form
	{
		private static DockPanel _dockPanel;
		public MainForm()
		{
			InitializeComponent();

			_dockPanel = new DockPanel()
			{
				Dock = DockStyle.Fill
			}
			;
			Controls.Add(_dockPanel);

			// Visual Studio 2015 테마 적용
			_dockPanel.Theme = new VS2015BlueTheme();

			//#2_DOCKPANEL#6 도킹 윈도우 로드 메서드 호출
			LoadDockingWindows();

			//#6_INSP_STAGE#1 전역 인스턴스 초기화
			Global.Inst.Initialize();
		}
		private void LoadDockingWindows()
		{
			//도킹해제 금지 설정
			_dockPanel.AllowEndUserDocking = false;

			//메인폼 설정
			var cameraWindow = new CameraForm();
			cameraWindow.Show(_dockPanel, DockState.Document);

			//#13_INSP_RESULT#7 검사 결과창 30% 비율로 추가
			var resultWindow = new ResultForm();
			resultWindow.Show(cameraWindow.Pane, DockAlignment.Bottom, 0.3);

			//# MODEL TREE#3 검사 결과창 우측에 40% 비율로 모델트리 추가
			var modelTreeWindow = new ModelTreeForm();
			modelTreeWindow.Show(resultWindow.Pane, DockAlignment.Right, 0.4);

			//실행창 추가
			var runWindow = new RunForm();
			runWindow.Show(modelTreeWindow.Pane, null);

			//속성창 추가
			var propWindow = new PropertiesForm();
			propWindow.Show(_dockPanel, DockState.DockRight);

			//#14_LOGFORM#2 로그창 추가
			var logWindow = new LogForm();
			logWindow.Show(propWindow.Pane, DockAlignment.Bottom, 0.3);
		}
		public static T GetDockForm<T>() where T : DockContent
		{
			var findForm = _dockPanel.Contents.OfType<T>().FirstOrDefault();
			return findForm;
		}
		private void imageOpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CameraForm cameraForm = GetDockForm<CameraForm>();
			if (cameraForm is null)
				return;

			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Title = "이미지 파일 선택";
				openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
				openFileDialog.Multiselect = false;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					string filePath = openFileDialog.FileName;


					//#11_MATCHING#12 이미지 로딩함수 변경
					Global.Inst.InspStage.SetImageBuffer(filePath);
					Global.Inst.InspStage.CurModel.InspectImagePath = filePath;
				}
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Global.Inst.Dispose();
		}

		private void setupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SLogger.Write($"환경설정창 열기");
			SetupForm setupForm = new SetupForm();
			setupForm.ShowDialog();
		}
		//#12_MODEL SAVE#3 모델 파일 열기,저장, 다른 이름으로 저장 기능 구현
		private string GetMdoelTitle(Model curModel)
		{
			if (curModel is null)
				return "";

			string modelName = curModel.ModelName;
			return $"{Define.PROGRAM_NAME} - MODEL : {modelName}";
		}

		private void modelNEwToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//신규 모델 추가를 위한 모델 정보를 받기 위한 창 띄우기
			NewModel newModel = new NewModel();
			newModel.ShowDialog();

			Model curModel = Global.Inst.InspStage.CurModel;
			if (curModel != null)
			{
				this.Text = GetMdoelTitle(curModel);
			}
		}

		private void modelOpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//모델 파일 열기
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Title = "모델 파일 선택";
				openFileDialog.Filter = "Model Files|*.xml;";
				openFileDialog.Multiselect = false;
				openFileDialog.InitialDirectory = SettingXml.Inst.ModelDir;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					string filePath = openFileDialog.FileName;
					if (Global.Inst.InspStage.LoadModel(filePath))
					{
						Model curModel = Global.Inst.InspStage.CurModel;
						if (curModel != null)
						{
							this.Text = GetMdoelTitle(curModel);
						}
					}
				}
			}
		}

		private void modelSaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//모델 파일 저장
			Global.Inst.InspStage.SaveModel("");
		}

		private void modelSaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//다른이름으로 모델 파일 저장
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.InitialDirectory = SettingXml.Inst.ModelDir;
				saveFileDialog.Title = "모델 파일 선택";
				saveFileDialog.Filter = "Model Files|*.xml;";
				saveFileDialog.DefaultExt = "xml";

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					string filePath = saveFileDialog.FileName;
					Global.Inst.InspStage.SaveModel(filePath);
				}
			}
		}
	}
	
}
