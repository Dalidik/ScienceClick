using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Button = UnityEngine.UIElements.Button;

public class AudioManager : MonoBehaviour
{
	[Header("Audio Source")]

	[SerializeField]
	AudioSource soundSource;

	[Header("Audio Clip")]
	public AudioClip sound;



	private void Start()
	{
		soundSource.clip = sound;
	}

	public void ButtonPressSound()
	{
		soundSource.PlayOneShot(sound);
	}
	
}
    

