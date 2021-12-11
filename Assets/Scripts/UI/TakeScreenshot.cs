using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TakeScreenshot : MonoBehaviour {


	[SerializeField]
	GameObject blink;
	/*
	private string GetAndroidExternalStoragePath()
	{
		if (Application.platform != RuntimePlatform.Android)
			return Application.persistentDataPath;

		var jc = new AndroidJavaClass("android.os.Environment");
		var path = jc.CallStatic<AndroidJavaObject>("getExternalStoragePublicDirectory",
			jc.GetStatic<string>("DIRECTORY_DCIM"))
			.Call<string>("getAbsolutePath");
		return path;
	} 
	*/

	public void TakeAShot()
	{
		StartCoroutine ("CaptureIt");
		Debug.Log("Capture Success");
	}

	IEnumerator CaptureIt()
	{
		string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
		string fileName = "Screenshot" + timeStamp + ".png";
		string pathToSave = fileName;
		ScreenCapture.CaptureScreenshot(pathToSave);
		yield return new WaitForEndOfFrame();
		Instantiate (blink, new Vector2(0f, 0f), Quaternion.identity);
	}

	/*
	public bool takingScreenshot = false;

	public void CaptureScreenshot()
	{
		StartCoroutine(TakeScreenshotAndSave());
	}

	private IEnumerator TakeScreenshotAndSave()
	{
		takingScreenshot = true;
		yield return new WaitForEndOfFrame();

		Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
		ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
		ss.Apply();

		// Save the screenshot to Gallery/Photos
		string name = string.Format("{0}_Capture{1}_{2}.png", Application.productName, "{0}", System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
		Debug.Log("Permission result: " + NativeGallery.SaveImageToGallery(ss, Application.productName + " Captures", name));
		takingScreenshot = false;
			
	}
	*/
}
