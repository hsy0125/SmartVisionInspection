using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace SmartVisionInspection.Core
{
	internal class PreviewImage
	{
		private Mat _orinalImage = null;
		private Mat _previewImage = null;
		private bool _usePreview = true;

		public void SetImage(Mat image)
		{

			_orinalImage = image;
			_previewImage = new Mat();
		}
	}
}
