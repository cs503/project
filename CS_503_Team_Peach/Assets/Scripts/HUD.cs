using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; //NEEDED for interacting with Text boxes
using UnityEngine;

public class HUD : MonoBehaviour {

    /*
     * The HUD uses the health manager, time manager, and score manager
     * each one is an object in game, whose fields will be used to modify the
     * the display. The text boxes simply get and display the values from
     * those objects 
     */

    public HealthManager HP;
    public ScoreManager PTS;
    public TimeManager CLK;

    //Text boxes to be modified
    public Text Health;
    public Text Time;
    public Text Score;

    //Special Texts
    string LOWHEALTH = "DANGER!!!";
    string LOWTIME   = "HURRY UP!!!";
    

    //to keep the hud when changing rooms and levels
    private static bool hudExists;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Health displays, rudimentary warnings
        Health.text = "" + HP.curHealth + "/" + HP.maxHealth;
        if (HP.critical)
        {
            Health.text += ("/n" + LOWHEALTH);
        }

        //Time display, rudimentary warnings
        Time.text = "" + CLK.min + ":" + CLK.sec;
        if (CLK.crunch)
            Time.text += ("/n" + LOWTIME);

        //score
        Score.text = "" + PTS.score;
	}
}
