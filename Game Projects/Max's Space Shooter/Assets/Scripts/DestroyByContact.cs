using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    public GameObject explosion;
    public GameObject playerExplosion;
    public int scoreValue;
    private GameController gameController;


    private void Start()
    {
        GameObject gameControl = GameObject.FindGameObjectWithTag("GameController");
        if(gameControl!=null)
        {
            gameController = gameControl.GetComponent<GameController>();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary" || other.tag=="Enemy" || other.tag=="EnemyBolt")
        {
            return;
        }
        if(other.tag=="EndBarrier")
        {
            Destroy(gameObject);
            return;
        }
        if (explosion != null)
        {

            Instantiate(explosion, transform.position, transform.rotation);
        }

        if (other.tag=="Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            gameController.GameOver();
        }
        if (other.tag == "Bolt")
        {

            Destroy(other.gameObject.transform.parent.gameObject);
 
        }
        gameController.AddScore(scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);
        
        
    }
}
