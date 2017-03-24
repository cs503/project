using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour {

    private GameObject player; // the player character GameObject

    public int value; // the score value of this item

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        // If this collider is touching the player, 
        if (this.GetComponent<Collider2D>().IsTouching(player.GetComponent<Collider2D>()))
        {
            // GameObject.FindGameObjectWithTag("HUD").score += value;
            Destroy(GameObject.FindGameObjectWithTag("Item1"));
        }
    }
}
