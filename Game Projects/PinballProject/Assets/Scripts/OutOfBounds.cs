using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfBounds : MonoBehaviour
{
    public Transform ball;

    //public int lives;
    private Vector3 startingPos;
    
	void Start ()
    {
        startingPos = ball.position;
        LivesManager.lives=6;
	}
	
	void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("out of bounds");
            other.rigidbody.velocity = Vector3.zero;
            other.transform.position = startingPos;
            
            if(LivesManager.lives > 0)
            {
                LivesManager.lives--;
            }
            else
            {
                Debug.Log("out of balls");
                //reset score
                ScoreManager.score = 0;
                Start();
            }
        }
    }
}
