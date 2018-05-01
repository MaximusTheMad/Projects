using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    [HideInInspector] public bool facingRight = true;
    [HideInInspector] public bool jump = true;

    private Rigidbody2D grad;
    private BoxCollider2D hitBox;

    public float moveForce = 365f;
    public float maxSpeed = 2f;

    private int moveDir;
    // Use this for initialization
    void Start() {
        grad = GetComponent<Rigidbody2D>();
        hitBox = GetComponent<BoxCollider2D>();
        moveDir = -1;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "InvisWall")
        {
            Flip();
            moveDir = moveDir * (-1);
        }
        else if(collision.gameObject.tag=="Player")
        {

        }
    }
    // Update is called once per frame
    void Update() {

    }

    private void FixedUpdate()
    {
        if ((moveDir * grad.velocity.x) < maxSpeed)
        {
            grad.AddForce(Vector2.right * moveDir * moveForce);
        }
        if (Mathf.Abs(grad.velocity.x) > maxSpeed)
        {
            grad.velocity = new Vector2(Mathf.Sign(grad.velocity.x) * maxSpeed, grad.velocity.y);
        }

    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x = theScale.x * -1;
        transform.localScale = theScale;
    }
}
