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
using SmartVisionInspection.Teach;
using WeifenLuo.WinFormsUI.Docking;

namespace SmartVisionInspection
{
	public partial class ModelTreeForm : DockContent
	{

		//개별 트리 노트에서 팝업 메뉴 보이기를 위한 메뉴
		private ContextMenuStrip _contextMenu;

		public ModelTreeForm()
		{
			InitializeComponent();

			//초기 트리 노트의 기본값은 "Root"
			tvModelTree.Nodes.Add("Root");

			// 컨텍스트 메뉴 초기화
			_contextMenu = new ContextMenuStrip();

			List<InspWindowType> windowTypeList;
			windowTypeList = new List<InspWindowType> { InspWindowType.Base, InspWindowType.Body, InspWindowType.Sub };

			foreach (InspWindowType windowType in windowTypeList)
				_contextMenu.Items.Add(new ToolStripMenuItem(windowType.ToString(), null, AddNode_Click) { Tag = windowType });

		}

		private void tvModelTree_MouseDown(object sender, MouseEventArgs e)
		{
			//Root 노드에서 마우스 오른쪽 버튼 클릭 시에, 팝업 메뉴 생성
			if (e.Button == MouseButtons.Right)
			{
				TreeNode clickedNode = tvModelTree.GetNodeAt(e.X, e.Y);
				if (clickedNode != null && clickedNode.Text == "Root")
				{
					tvModelTree.SelectedNode = clickedNode;
					_contextMenu.Show(tvModelTree, e.Location);
				}
			}
		}

		private void AddNode_Click(object sender, EventArgs e)
		{
			if (tvModelTree.SelectedNode != null & sender is ToolStripMenuItem)
			{
				ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
				InspWindowType windowType = (InspWindowType)menuItem.Tag;
				AddNewROI(windowType);
			}
		}

		//imageViewer에 ROI 추가 기능 실행
		private void AddNewROI(InspWindowType inspWindowType)
		{
			CameraForm cameraForm = MainForm.GetDockForm<CameraForm>();
			if (cameraForm != null)
			{
				cameraForm.AddRoi(inspWindowType);
			}
		}
		//현재 모델 전체의 ROI를 트리 모델에 업데이트
		public void UpdateDiagramEntity()
		{
			tvModelTree.Nodes.Clear();
			TreeNode rootNode = tvModelTree.Nodes.Add("Root");

			Model model = Global.Inst.InspStage.CurModel;
			List<InspWindow> windowList = model.InspWindowList;
			if (windowList.Count <= 0)
				return;

			foreach (InspWindow window in model.InspWindowList)
			{
				if (window is null)
					continue;

				string uid = window.UID;

				TreeNode node = new TreeNode(uid);
				rootNode.Nodes.Add(node);
			}

			tvModelTree.ExpandAll();
		}

	}
}
