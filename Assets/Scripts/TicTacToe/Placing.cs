using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Placing : MonoBehaviour
{
    public int turn;
    public GameObject[] holders = new GameObject[9];
    public Sprite x;
    public Sprite o;
    public bool[] interactable = new bool[9];
    public TextMeshProUGUI turnText;
    public int move;
    public int[] _holder = new int[9];
    public End end;

    void Start()
    {

        turn = 0; // x's turn
        for(int i = 0; i < 9; i++)
        {
            _holder[i] = 2;
            interactable[i] = true;
        }
        turnText.text = "Turn: X";
    }

    public void Place(int holder)
    {
        if (interactable[holder] == true)
        {
            if (turn == 0)
            {
                holders[holder].GetComponent<Image>().sprite = x;
                interactable[holder] = false;
                turn = 1;
                turnText.text = "Turn: O";
                move++;
                _holder[holder] = 0;
            }
            else
            {
                holders[holder].GetComponent<Image>().sprite = o;
                holders[holder].GetComponent<Image>().color = Color.black;
                interactable[holder] = false;
                turn = 0;
                turnText.text = "Turn: X";
                move++;
                _holder[holder] = 1;
            }
        }

        end.Check();
        
    }
}
