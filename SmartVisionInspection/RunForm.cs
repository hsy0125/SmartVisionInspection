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
using WeifenLuo.WinFormsUI.Docking;


namespace SmartVisionInspection
{
	public partial class RunForm : DockContent
	{
		public RunForm()
		{
			InitializeComponent();
		}

		private void btnGrab_Click(object sender, EventArgs e)
		{
			Global.Inst.InspStage.Grab(0);
		}
	}
}
