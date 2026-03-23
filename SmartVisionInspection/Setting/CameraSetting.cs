using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartVisionInspection.Grab;
using SmartVisionInspection.Util;

namespace SmartVisionInspection.Setting
{
	public partial class CameraSetting : UserControl
	{
		public CameraSetting()
		{
			InitializeComponent();

			LoadSetting();
		}
		private void LoadSetting()
		{
			//카메라 타입을 콤보박스에 추가

			//방법1
			//List<CameraType> cameras = new List<CameraType>();
			//cameras.Add(CameraType.None);
			//cameras.Add(CameraType.WebCam);
			//cameras.Add(CameraType.HikRobotCam);

			//cbCameraType.DataSource = cameras;

			//방법2
			//Enum.GetValues(typeof(CameraType)) → CameraType의 모든 값을 배열로 가져옴
			//.Cast<CameraType>() → 배열을 IEnumerable<CameraType>으로 변환
			//.ToList() → List<CameraType> 으로 변환
			//REFCODE eIOInput
			cbCameraType.DataSource = Enum.GetValues(typeof(CameraType)).Cast<CameraType>().ToList();

			//환경설정에서 현재 카메라 타입 얻기
			cbCameraType.SelectedIndex = (int)SettingXml.Inst.CamType;
		}

		private void SaveSetting()
		{
			//환경설정에 카메라 타입 설정
			SettingXml.Inst.CamType = (CameraType)cbCameraType.SelectedIndex;
			//환경설정 저장
			SettingXml.Save(); 
			
			SLogger.Write($"카메라 설정 저장");

		}

		private void btnApply_Click(object sender, EventArgs e)
		{
			SaveSetting();
		}
	}
}
