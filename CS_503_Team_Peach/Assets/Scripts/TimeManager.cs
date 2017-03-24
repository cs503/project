using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour {

    //overall time left
   public int totalSeconds;
   
    public int min
    {
        get
        {
            return totalSeconds  / 60 ;
        }
    }

    public int sec
    {
        get
        {
            return totalSeconds % 60;
        }
    }

    //low time check
    public bool crunch;

    //might vary depending on level
    int levelTime;

	// Use this for initialization
	void Start () {

        //simply hard coding level time for now
        levelTime = 1000;

        totalSeconds = levelTime;
		
	}
	
	// Update is called once per frame
	void Update () {

        totalSeconds -= 1; //better implementation?


        if (totalSeconds < 100)
            crunch = true;
        else
            crunch = false;
        
	}


    public void addTime (int bonusTime)
    {
        totalSeconds += bonusTime;
    }
}
