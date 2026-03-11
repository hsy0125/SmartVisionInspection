using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartVisionInspection.Setting
{
	public partial class PathSetting : UserControl
	{
		public PathSetting()
		{
			InitializeComponent();
			LoadSetting();
		}
		private void LoadSetting()
		{
			//환경설정에서 모델 저장 경로 얻기
			txtModelDir.Text = SettingXml.Inst.ModelDir;
			txtImageDir.Text = SettingXml.Inst.ImageDir;

		}
		private void SaveSetting()
		{
			//환경설정에 모델 저장 경로 설정
			SettingXml.Inst.ModelDir = txtModelDir.Text;
			SettingXml.Inst.ImageDir = txtImageDir.Text;

			//환경설정 저장
			SettingXml.Save();
		}

		private void btnSelModelDir_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
			{
				folderDialog.Description = "폴더를 선택하세요.";
				folderDialog.ShowNewFolderButton = true;    //새 폴더 생성 버튼 활성화

				if (folderDialog.ShowDialog() == DialogResult.OK)
				{
					txtModelDir.Text = folderDialog.SelectedPath;
				}
			}

		}

		private void btnSelImageDir_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
			{
				folderDialog.Description = "폴더를 선택하세요.";
				folderDialog.ShowNewFolderButton = true;    //새 폴더 생성 버튼 활성화

				if (folderDialog.ShowDialog() == DialogResult.OK)
				{
					txtImageDir.Text = folderDialog.SelectedPath;
				}
			}
		}

		private void btnApply_Click(object sender, EventArgs e)
		{
			SaveSetting();
		}
	}
}
