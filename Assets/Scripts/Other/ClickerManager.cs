using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickerManager : MonoBehaviour
{
	
	public TextMeshProUGUI ScoreText;
	public Single CurrentScore;
	public Single ClickPower;
	public TextMeshProUGUI ClickPowerText;
	
	
	public Int32 FirstUpgradeButton ;
	public TextMeshProUGUI FirstUpgradeText;
	
	public Int32 SecondUpgradeButton ;
	public TextMeshProUGUI SecondUpgradeText;

	public Int32 BonusButton;
	public TextMeshProUGUI BonusButtonText;
	
	public Button FirstBonus;
	public Button SecondBonus;
	public Button ThirdBonus;
	
	public Boolean _firstBonusCanOpen;
	public Boolean _secondBonusCanOpen;
	public Boolean _thirdBonusCanOpen;
	
	
	
	void Start()
    {
	    
	    CurrentScore = 0;
	    ClickPower = 1;

	    FirstUpgradeButton = 100;
	    SecondUpgradeButton = 900;
	    BonusButton = 10000;

	    FirstBonus.enabled = false;
	    SecondBonus.enabled = false;
	    ThirdBonus.enabled = false;

	    _firstBonusCanOpen = false;
	    _secondBonusCanOpen = false;
	    _thirdBonusCanOpen = false;

	    CurrentScore = PlayerPrefs.GetInt("CurrentScore", 0);
	    ClickPower = PlayerPrefs.GetInt("ClickPower", 1);
	   
	    _firstBonusCanOpen = (PlayerPrefs.GetInt("_firstBonusCanOpen") != 0);
	    _secondBonusCanOpen = (PlayerPrefs.GetInt("_secondBonusCanOpen") != 0);
	    _thirdBonusCanOpen = (PlayerPrefs.GetInt("_thirdBonusCanOpen") != 0);
    }

   
    void Update()
    {
	   
	    ScoreText.text = (int)CurrentScore+"";
	    ClickPowerText.text = (int)ClickPower+"";
	    
	    BonusButtonText.text = "1 bonus - " + BonusButton;
	    FirstUpgradeText.text = "1x - " + FirstUpgradeButton;
	    SecondUpgradeText.text = "10x - " + SecondUpgradeButton;
	    
	    PlayerPrefs.SetInt("ClickPower", (int)ClickPower);
	    PlayerPrefs.SetInt("CurrentScore", (int)CurrentScore);
	    
	    PlayerPrefs.SetInt("_firstBonusCanOpen", (_firstBonusCanOpen ? 1 : 0));
	    PlayerPrefs.SetInt("_secondBonusCanOpen", (_secondBonusCanOpen ? 1 : 0));
	    PlayerPrefs.SetInt("_thirdBonusCanOpen", (_thirdBonusCanOpen ? 1 : 0));
    }

    public void Click()
    {
	    CurrentScore += ClickPower;
    }

    public void FirstUpgrade()
    {
	    if (CurrentScore >= FirstUpgradeButton)
	    {
		    CurrentScore -= FirstUpgradeButton;
		    ClickPower += 1;
		    ClickPowerText.text = (int)ClickPower+ "";
	    }
    }
    
    public void SecondUpgrade()
    {
	    if (CurrentScore >= SecondUpgradeButton)
	    {
		    CurrentScore -= SecondUpgradeButton;
		    ClickPower += 10;
		    ClickPowerText.text = (int)ClickPower+ "";
	    }
    }

    public void FirstBonusClick( )
    {
	    if (CurrentScore >= BonusButton && _secondBonusCanOpen == false && _firstBonusCanOpen == false)
	    {
		    CurrentScore -= BonusButton;
		    FirstBonus.enabled = true;
	    }
    }
    
    public void SecondBonusClick()
    {
	    if (CurrentScore >= BonusButton && _secondBonusCanOpen == false && _firstBonusCanOpen == true)
	    {
		    CurrentScore -= BonusButton;
		    SecondBonus.enabled = true;
	    }
    }
    
    public void ThirdBonusClick()
    {
	    if (CurrentScore >= BonusButton &&  _secondBonusCanOpen == true && _thirdBonusCanOpen == false)
	    {
		    CurrentScore -= BonusButton;
		    ThirdBonus.enabled = true;
	    }
    }
    
    public void CanOpenFirstBonus()
    {
	    _firstBonusCanOpen = true;
    }


    public void CanOpenSecondBonus()
    {
	    _secondBonusCanOpen = true;
    }
    
    
    public void CanOpenThirdBonus()
    {
	    _thirdBonusCanOpen = true;
    }

   
    public void OpenAllBonuses()
    {
	    
	    if ( _thirdBonusCanOpen == true)
	    {
		    ThirdBonus.enabled = true;
		    FirstBonus.enabled = true;
		    SecondBonus.enabled = true;
	    }
	    if ( _secondBonusCanOpen == true)
	    {
		    FirstBonus.enabled = true;
		    SecondBonus.enabled = true;
	    }
	    if (_firstBonusCanOpen == true)
	    {
		    FirstBonus.enabled = true;
	    }
    }
    
}
