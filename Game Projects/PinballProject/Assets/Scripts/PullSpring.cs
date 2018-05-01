using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullSpring : MonoBehaviour
{
    public GameObject ball;
    public AudioSource launchSound;
    public string inputButtonName = "Pull";
    public float distance = 50f;
    public float speed = 1f;
    public float power = 2000f;

    private bool ready = false;
    private bool fire = false;
    private float moveCount = 0f;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
            ready = true;
    }

    void Update ()
    {
		if (Input.GetButton(inputButtonName))
        {
            if (moveCount < distance)
            {
                transform.Translate(0, 0, -speed * Time.deltaTime);
                moveCount += speed * Time.deltaTime;
                fire = true;
                
            }
        }
        else if (moveCount > 0)
        {
            if (fire && ready)
            {
                ball.transform.TransformDirection(Vector3.forward * 10);
                ball.GetComponent<Rigidbody>().AddForce(0, 0, moveCount * power);
                fire = false;
                ready = false;
            }
            transform.Translate(0, 0, 20 * Time.deltaTime);
            moveCount -= 20 * Time.deltaTime;
            launchSound.Play();
        }

        if (moveCount <= 0)
        {
            fire = false;
            moveCount = 0;
            
        }
	}
}
