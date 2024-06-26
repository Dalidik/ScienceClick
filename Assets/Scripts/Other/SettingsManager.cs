using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SettingsManager : MonoBehaviour
{
	private bool isMuted;
	public Toggle toggle;

	private void Start()
	{
		isMuted = PlayerPrefs.GetInt("Mute") == 1;
		
	}

	public void MutePressed()
	{
		isMuted = !isMuted;
		
		PlayerPrefs.SetInt("Muted", isMuted ? 1 : 0);
		ButtonClick();
	}

	private void ButtonClick()
	{
		if (isMuted)
		{
			toggle.isOn = true;
		}
		else
		{
			toggle.isOn = false;
		}
	}
}
