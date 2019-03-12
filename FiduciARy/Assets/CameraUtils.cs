using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CameraUtils : MonoBehaviour {

	private bool flashON = false;

	public void ToggleFlash()
	{
		if (flashON)
		{
			CameraDevice.Instance.SetFlashTorchMode(false);
			flashON = false;
			Debug.Log("Flash light is OFF!");
		} else
		{
			CameraDevice.Instance.SetFlashTorchMode(true);
			flashON = true;
			Debug.Log("Flash light is ON!");
		}
	}

	void Start () {
		var vuforia = VuforiaARController.Instance;
		vuforia.RegisterVuforiaStartedCallback(OnVuforiaStarted);
		vuforia.RegisterOnPauseCallback(OnPaused);
	}

	private void OnVuforiaStarted()
	{
		CameraDevice.Instance.SetFocusMode(
			CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
	}

	private void OnPaused(bool paused)
	{
		if (!paused) // resumed
		{
			// Set again autofocus mode when app is resumed
			CameraDevice.Instance.SetFocusMode(
				CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
		}
	}
}
