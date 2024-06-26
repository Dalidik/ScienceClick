using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
	
		private bool muteSound = true;

		[SerializeField]
		private Sprite[] buttonSprites;

		[SerializeField]
		private Image targetButton;



		private void Start()
		{
			if (!PlayerPrefs.HasKey("muteSound"))
			{
				PlayerPrefs.SetInt("muteSound", 0);
				Load();
			}
			else
			{
				Load();
			}

			GameObject.FindWithTag("Sound").GetComponent<AudioSource>().mute = muteSound;

		}

		private void Update()
		{
			UpdateToggle();

		}

		public void SoundTogglePress()
		{
			if (muteSound == false)
			{
				muteSound = true;
				GameObject.FindWithTag("Sound").GetComponent<AudioSource>().mute = true;
			}

			else
			{
				muteSound = false;
				GameObject.FindWithTag("Sound").GetComponent<AudioSource>().mute = false;
			}

			Save();
			UpdateToggle();
		}


		public void UpdateToggle()
		{
			if (muteSound == false)
			{

				targetButton.sprite = buttonSprites[0];
				return;
			}
			else
			{

				targetButton.sprite = buttonSprites[1];
			}
		}

		private void Load()
		{
			muteSound = PlayerPrefs.GetInt("muteSound") == 1;
		}

		private void Save()
		{
			PlayerPrefs.SetInt("muteSound", muteSound ? 1 : 0);
		}

	}
