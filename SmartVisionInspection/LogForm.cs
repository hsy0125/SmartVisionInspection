using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartVisionInspection.Util;
using WeifenLuo.WinFormsUI.Docking;

namespace SmartVisionInspection
{
	public partial class LogForm : DockContent
	{
		public LogForm()
		{
			InitializeComponent();

			//폼이 닫힐 때 이벤트 제거를 위해 이벤트 추가
			this.FormClosed += LogForm_FormClosed;
			//로그가 추가될 때 이벤트 추가
			SLogger.LogUpdated += OnLogUpdated;
		}
		//로그 이벤트 발생시, 리스트박스에 로그 추가 함수 호출
		private void OnLogUpdated(string logMessage)
		{
			//UI 스레드가 아닐 경우, Invoke()를 호출하여 UI 스레드에서 실행되도록 강제함 (비동기 멀티스레드 환경에서 안전하게 UI 업데이트)
			if (listBoxLogs.InvokeRequired)
			{
				listBoxLogs.Invoke(new Action(() => AddLog(logMessage)));
			}
			else
			{
				AddLog(logMessage);
			}
		}

		//리스트박스에 로그 추가
		private void AddLog(string logMessage)
		{
			//로그가 1000개 이상이면, 가장 오래된 로그를 삭제
			if (listBoxLogs.Items.Count > 1000)
			{
				listBoxLogs.Items.RemoveAt(0);
			}
			listBoxLogs.Items.Add(logMessage);

			//자동 스크롤 (항상 스크롤 제일 아래로)
			listBoxLogs.TopIndex = listBoxLogs.Items.Count - 1;
		}

		//폼이 닫힐 때 이벤트 제거
		private void LogForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			SLogger.LogUpdated -= OnLogUpdated;
			this.FormClosed -= LogForm_FormClosed;
		}
	}
}

