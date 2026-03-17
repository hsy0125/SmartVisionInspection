using SmartVisionInspection.Algorithm;
using SmartVisionInspection.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVisionInspection.Teach
{
    public class InspWindowFactory
    {
        #region Singleton Instance
        private static readonly Lazy<InspWindowFactory> _instance = new Lazy<InspWindowFactory>(() => new InspWindowFactory());

        public static InspWindowFactory Inst
        {
            get
            {
                return _instance.Value;
            }
        }
        #endregion

        //같은 타입의 일련번호 관리를 위한 딕셔너리
        private Dictionary<string, int> _windowTypeNo = new Dictionary<string, int>();

        public InspWindowFactory() { }

        //InspWindow를 생성하기 위해, 타입을 입력받아, 생성된 InspWindow 반환
        public InspWindow Create(InspWindowType windowType, bool addAlgorithm = true)
        {
            string name, prefix;
            if (!GetWindowName(windowType, out name, out prefix))
                return null;

            InspWindow inspWindow = new InspWindow(windowType, name);
            if (inspWindow is null)
                return null;

            if (!_windowTypeNo.ContainsKey(name))
                _windowTypeNo[name] = 0;

            int curID = _windowTypeNo[name];
            curID++;

            inspWindow.UID = string.Format("{0}_{1:D6}", prefix, curID);

            _windowTypeNo[name] = curID;

            if (addAlgorithm)
                AddInspAlgorithm(inspWindow);

            return inspWindow;
        }
		//InspWindow가 생성된 후, InspWindowType에 따라 알고리즘을 추가하는 함수.
        //현재는 모든 타입에 InspBinary 알고리즘을 추가하도록 구현되어 있지만, 향후 다른 알고리즘이 추가될 수 있도록 switch문으로 구현되어 있음.
		private bool AddInspAlgorithm(InspWindow inspWindow)
        {
            switch (inspWindow.InspWindowType)
            {
                case InspWindowType.Base:
                    inspWindow.AddInspAlgorithm(InspectType.InspBinary);
                    break;
                case InspWindowType.Body:
                    inspWindow.AddInspAlgorithm(InspectType.InspBinary);
                    break;
                case InspWindowType.Sub:
                    inspWindow.AddInspAlgorithm(InspectType.InspBinary);
                    break;
            }

            return true;
        }

        //타입을 입력하면, 해당 타입의 이름과 UID 이름 반환
        private bool GetWindowName(InspWindowType windowType, out string name, out string prefix)
        {
            name = string.Empty;
            prefix = string.Empty;
            switch (windowType)
            {
                case InspWindowType.Base:
                    name = "Base";
                    prefix = "BAS";
                    break;
                case InspWindowType.Body:
                    name = "Body";
                    prefix = "BDY";
                    break;
                case InspWindowType.Sub:
                    name = "Sub";
                    prefix = "SUB";
                    break;
                default:
                    return false;
            }
            return true;
        }

    }
}
