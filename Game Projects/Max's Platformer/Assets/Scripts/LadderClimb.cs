using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderClimb : MonoBehaviour {

    public GameObject player;

    private Rigidbody2D playerColl;
    private Animator anim;
    private bool canClimb = false;
    float speed = 5;
	// Use this for initialization
	void Start () {
        playerColl = player.GetComponent<Rigidbody2D>();
        anim = player.GetComponent<Animator>();
	}


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            canClimb = true;
            playerColl.gravityScale = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            canClimb = false;
            playerColl.gravityScale = 1;
        }
    }

    void Update()
    {
        if(canClimb==true)
        {
            if(Input.GetKey(KeyCode.Z))
            {
                player.transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed);
                anim.SetTrigger("IsClimbing");
                anim.SetBool("Climb", true);
            }
            else if(Input.GetKey(KeyCode.X))
            {
                player.transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * speed);
                anim.SetTrigger("IsClimbing");
                anim.SetBool("Climb", true);
            }
            else
            {
                anim.SetBool("Climb", false);
            }

        }
        else
        {
            anim.SetBool("Climb", false);
            
        }
    }

}
