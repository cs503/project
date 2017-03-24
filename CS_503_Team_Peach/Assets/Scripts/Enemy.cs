using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player; // the player character GameObject

    private Vector3 startPosition; // respawn positon for the character

    public float playerRespawnX; // X coordinate of player respawn position, set in unity
    public float playerRespawnY; // Y coordinate of player respawn position, set in unity

    public double patrolLengthX; // distance patroller moves horizontally, set in unity
    public double patrolLengthY; // distance patroller moves vertically, set in unity

    private float speed; // speed at which patroller moves

    private int counter; // number of frames patroller has been moving in a certain direction

    private string direction; // direction in which the patroller will move

    // Use this for initialization
    void Start()
    {
        counter = 0;
        direction = "right";
        player = GameObject.FindGameObjectWithTag("Player");
        speed = 0.035f;

        startPosition = new Vector3(playerRespawnX, playerRespawnY, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // If this collider is touching the player, reset player position to respawn location
        if (this.GetComponent<Collider2D>().IsTouching(player.GetComponent<Collider2D>()))
        {
            // GameObject.FindGameObjectWithTag("HUD").lives--;
            player.transform.position = startPosition;
        }

        // move patroller along set path
        if (direction == "up" & counter < 100 * patrolLengthY)
        {
            transform.position += new Vector3(0, speed, 0);
            counter++;
        }
        else if (direction == "right" & counter < 100 * patrolLengthX)
        {
            transform.position += new Vector3(speed, 0, 0);
            counter++;
        }
        else if (direction == "down" & counter < 100 * patrolLengthY)
        {
            transform.position += new Vector3(0, -speed, 0);
            counter++;
        }
        else if (direction == "left" & counter < 100 * patrolLengthX)
        {
            transform.position += new Vector3(-speed, 0, 0);
            counter++;
        }
        else
        {
            counter = 0;
            if (direction == "up")
            {
                direction = "right";
            }
            else if (direction == "right")
            {
                direction = "down";
            }
            else if (direction == "down")
            {
                direction = "left";
            }
            else if (direction == "left")
            {
                direction = "up";
            }
        }
    }
}
