using UnityEngine;

public class AndroidCamera
{

	AndroidJavaObject camera = null;

	public AndroidCamera()
	{
		WebCamDevice[] devices = WebCamTexture.devices;
		Debug.Log("Camera Name:" + devices[0].name);

		open();
	}

	public void open()
	{
		if (camera == null)
		{
#if (UNITY_ANDROID && !UNITY_EDITOR)
			AndroidJavaClass cameraClass = new AndroidJavaClass("android.hardware.Camera");
			camera = cameraClass.CallStatic<AndroidJavaObject>("open");
#endif
		}
	}

	public void release()
	{
		if (camera != null)
		{
			LEDOff();

			camera.Call("release");
			camera = null;
		}
	}

	public void startPreview()
	{
		if (camera != null)
		{
			Debug.Log("AndroidCamera::startPreview()");
			camera.Call("startPreview");
		}
	}

	public void stopPreview()
	{
		if (camera != null)
		{
			Debug.Log("AndroidCamera::stopPreview()");
			LEDOff();
			camera.Call("stopPreview");
		}
	}

	// Flash
	public void setFlashMode(string mode)
	{
		if (camera != null)
		{
			AndroidJavaObject cameraParameters = camera.Call<AndroidJavaObject>("getParameters");
			cameraParameters.Call("setFlashMode", mode);
			camera.Call("setParameters", cameraParameters);
		}
	}

	// LED
	public void LEDOn()
	{
		setFlashMode("torch");
	}

	// LED
	public void LEDOff()
	{
		setFlashMode("off");
	}
}