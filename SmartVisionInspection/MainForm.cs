using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SmartVisionInspection
{

	public partial class MainForm : Form
	{
		private static DockPanel _dockPanel;
		public MainForm()
		{
			InitializeComponent();

			_dockPanel = new DockPanel
			{
				Dock = DockStyle.Fill
			};
			Controls.Add(_dockPanel);

			// Visual Studio 2015 테마 적용
			_dockPanel.Theme = new VS2015BlueTheme();

			//#2_DOCKPANEL#6 도킹 윈도우 로드 메서드 호출
			LoadDockingWindows();
		}
		private void LoadDockingWindows()
		{
			//도킹해제 금지 설정
			_dockPanel.AllowEndUserDocking = false;

			//메인폼 설정
			var cameraWindow = new CameraForm();
			cameraWindow.Show(_dockPanel, DockState.Document);

			//속성창 추가
			var propWindow = new PropertiesForm();
			propWindow.Show(_dockPanel, DockState.DockRight);
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
					cameraForm.LoadImage(filePath);
				}
			}
		}
	}
}
