using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MvCameraControl;

namespace SmartVisionInspection.Grab
{
	public enum CameraType
	{
		[Description("사용안함")]
		None = 0,
		[Description("웹캠")]
		WebCam,
		[Description("HikRobot 카메라")]
		HikRobotCam
	}
	struct GrabUserBuffer
	{
		//실제 이미지 데이터를 보관하는 배열(메모리 내 이미지 처리, 파일 읽기)
		private byte[] _imageBuffer;
		//네이티브 코드에 넘기기 위한 포인터(PInvoke, OpenCVSharp, Native SDK)
		private IntPtr _imageBufferPtr;
		//배열을 고정시켜 포인터 안정성 확보(배열 → 포인터 변환 시 메모리 고정)
		private GCHandle _imageHandle;

		public byte[] ImageBuffer
		{
			get
			{
				return _imageBuffer;
			}
			set
			{
				_imageBuffer = value;
			}
		}
		public IntPtr ImageBufferPtr
		{
			get
			{
				return _imageBufferPtr;
			}
			set
			{
				_imageBufferPtr = value;
			}
		}
		public GCHandle ImageHandle
		{
			get
			{
				return _imageHandle;
			}
			set
			{
				_imageHandle = value;
			}
		}
	}

	internal abstract class GrabModel
	{
		public delegate void GrabEventHandler<T>(object sender, T obj = null) where T : class;

		public event GrabEventHandler<object> GrabCompleted;
		public event GrabEventHandler<object> TransferCompleted;

		protected GrabUserBuffer[] _userImageBuffer = null;
		public int BufferIndex { get; set; } = 0;

		protected string _strIpAddr = "";
		internal bool HardwareTrigger { get; set; } = false;
		internal bool IncreaseBufferIndex { get; set; } = false;

		private IDevice _device = null;
		//private MvCameraControl.Net.IDevice _device = null;
		// 이미지 취득 콜백함수

		internal abstract bool Create(string strIpAddr = null);

		internal abstract bool Grab(int bufferIndex, bool waitDone = true);

		internal abstract bool Close();

		internal abstract bool Open();

		internal virtual bool Reconnect() { return true; }

		internal abstract bool GetPixelBpp(out int pixelBpp);

		internal abstract bool SetExposureTime(long exposure);

		internal abstract bool GetExposureTime(out long exposure);

		internal abstract bool SetGain(float gain);

		internal abstract bool GetGain(out float gain);

		internal abstract bool GetResolution(out int width, out int height, out int stride);

		internal virtual bool SetTriggerMode(bool hardwareTrigger) { return true; }

		internal virtual bool SetWhiteBalance(bool auto, float redGain = 1.0f, float blueGain = 1.0f) { return true; }

		internal bool InitGrab()
		{
			if (!Create())
				return false;

			if (!Open())
			{
				if (!Reconnect())
					return false;
			}

			return true;
		}

		internal bool InitBuffer(int bufferCount = 1)
		{
			if (bufferCount < 1)
				return false;

			_userImageBuffer = new GrabUserBuffer[bufferCount];
			return true;
		}

		internal bool SetBuffer(byte[] buffer, IntPtr bufferPtr, GCHandle bufferHandle, int bufferIndex = 0)
		{
			_userImageBuffer[bufferIndex].ImageBuffer = buffer;
			_userImageBuffer[bufferIndex].ImageBufferPtr = bufferPtr;
			_userImageBuffer[bufferIndex].ImageHandle = bufferHandle;

			return true;
		}
		protected virtual void OnGrabCompleted(object obj = null)
		{
			GrabCompleted?.Invoke(this, obj);
		}
		protected virtual void OnTransferCompleted(object obj = null)
		{
			TransferCompleted?.Invoke(this, obj);
		}

		internal abstract void Dispose();

	}
	
	}
