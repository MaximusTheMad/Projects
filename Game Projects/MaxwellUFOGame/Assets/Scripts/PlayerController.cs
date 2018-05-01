using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class PlayerController : MonoBehaviour {

    private float speed;
    public float runspeed;
    public float minspeed;
    public Text countText;
    public Text winText;

    private Rigidbody2D rb2d;
    private int count;
    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        winText.text = "";
        SetCountText();

    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        if(Input.GetButton("Fire1"))
        {
            speed = runspeed;
        }
        else
        {
            speed = minspeed;
        }
        rb2d.AddForce(movement * speed);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("PickUp"))
        {
            collision.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }

    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString() + "/250";

        if(count>=250)
        {
            winText.text = "You win!";
        }
    }

    private void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            Application.Quit();
        }
    }
}
