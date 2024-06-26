using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
   public Placing placing;
    public bool ended;
    public bool nolicWin;
    public bool tae;
    public GameObject kresticEndScreen;
    public GameObject NolicEndScreen;
    public GameObject taeEndScreen;
      

    public void Start()
    {
        nolicWin = false;
        ended = false;
        kresticEndScreen.SetActive(false);
    }

    public void Check()
    {
        if(placing._holder[0] == 0 && placing._holder[1] == 0 && placing._holder[2] == 0)
        {
            ended = true;
            
            for(int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[3] == 0 && placing._holder[4] == 0 && placing._holder[5] == 0)
        {
            ended = true;
            
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[6] == 0 && placing._holder[7] == 0 && placing._holder[8] == 0)
        {
            ended = true;
          
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[0] == 0 && placing._holder[3] == 0 && placing._holder[6] == 0)
        {
            ended = true;
           
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[1] == 0 && placing._holder[4] == 0 && placing._holder[7] == 0)
        {
            ended = true;
           
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[2] == 0 && placing._holder[5] == 0 && placing._holder[8] == 0)
        {
            ended = true;
           
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[0] == 0 && placing._holder[4] == 0 && placing._holder[8] == 0)
        {
            ended = true;
           
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[2] == 0 && placing._holder[4] == 0 && placing._holder[6] == 0)
        {
            ended = true;
            
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[0] == 1 && placing._holder[1] == 1 && placing._holder[2] == 1)
        {
            nolicWin = true;
           
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[3] == 1 && placing._holder[4] == 1 && placing._holder[5] == 1)
        {
            nolicWin = true;
            
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[6] == 1 && placing._holder[7] == 1 && placing._holder[8] == 1)
        {
            nolicWin = true;
          
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[0] == 1 && placing._holder[3] == 1 && placing._holder[6] == 1)
        {
            nolicWin = true;
            
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[1] == 1 && placing._holder[4] == 1 && placing._holder[7] == 1)
        {
            nolicWin = true;
           
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[2] == 1 && placing._holder[5] == 1 && placing._holder[8] == 1)
        {
            nolicWin = true;
           
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[0] == 1 && placing._holder[4] == 1 && placing._holder[8] == 1)
        {
            nolicWin = true;
            
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else if (placing._holder[2] == 1 && placing._holder[4] == 1 && placing._holder[6] == 1)
        {
            nolicWin = true;
           
            for (int i = 0; i < 9; i++)
            {
                placing.interactable[i] = false;
            }
        }
        else
        {
            if (placing.move == 9)
            {
               
                ended = true;
                for (int i = 0; i < 9; i++)
                {
                    placing.interactable[i] = false;
                }
            }
        }

        if (ended == true)
        {
            kresticEndScreen.SetActive(true);
            placing.turnText.gameObject.SetActive(false);
        }
        if (nolicWin == true)
        {
            NolicEndScreen.SetActive(true);
            placing.turnText.gameObject.SetActive(false);
        }
        if (tae == true)
        {
            taeEndScreen.SetActive(true);
            placing.turnText.gameObject.SetActive(false);
        }
    }

    public void Again()
    {
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Repeat()
    {
        placing.interactable[placing._holder.Length] = true;
        placing._holder = new []{0};
       placing.Place(holder: 0);
       placing.move = 0;
    }
}
