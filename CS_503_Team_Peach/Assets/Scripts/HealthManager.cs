using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour {

    //might use this for lives
    public int lives;

    //will we have levels and upgrades? 
    public int level = 1;

    public static int BASE = 100;
    public int maxHealth;
    public int curHealth;
    public bool critical;



	// Use this for initialization
	void Start ()
    {
        maxHealth = BASE * level;
        curHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
        if(curHealth ==0)
        {
            //reduce lives by one
            //deactivate and respawn player 
           // gameObject.SetActive(false);
            //reload game

        }

        if (curHealth < maxHealth * 0.33)
            critical = true;
        else
            critical = false;
	}
    public void SetMaxHealth()
    {

        //upgrade health or level

    }


    public void HealPlayer()

    {
        //current + add
        //if higher than max, make max

    }


}
