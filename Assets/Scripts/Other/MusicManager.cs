using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Image = UnityEngine.UIElements.Image;

public class MusicManager : MonoBehaviour
{
        private bool muted = true;
	

        [SerializeField]
        private Sprite[] buttonSprites;

        [SerializeField]
        private Image targetButton;
        
   	   
       	
       	private void Start()
       	{
       		if (!PlayerPrefs.HasKey("muted"))
       		{
       			PlayerPrefs.SetInt("muted", 0);
       			Load();
       		}
       		else
       		{
       			Load();
       		}
	        
   		    GameObject.FindWithTag("Music").GetComponent<AudioSource>().mute = muted;
	        
        }
       
       	private void Update()
       	{
       		UpdateToggle();
	        
        }
       	
       	public void MusicTogglePress()
       	{
       		if (muted == false)
       		{
		        muted = true;
   			    GameObject.FindWithTag("Music").GetComponent<AudioSource>().mute = true;
   		    }
       
       		else
       		{
		       muted = false;
   			    GameObject.FindWithTag("Music").GetComponent<AudioSource>().mute = false;
       		}
       		
       		Save();
       		UpdateToggle();
       	}
   	  
       
       	public void UpdateToggle()
       	{
       		if (muted == false)
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
	        muted = PlayerPrefs.GetInt("muted") == 1;
       	}
       
       	private void Save()
       	{
       		PlayerPrefs.SetInt("muted", muted ? 1 : 0);
       	}
}
