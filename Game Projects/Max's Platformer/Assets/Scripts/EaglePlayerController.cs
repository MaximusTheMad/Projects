using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EaglePlayerController : MonoBehaviour {

    [HideInInspector] public bool facingRight = true;
    [HideInInspector] public bool jump = true;

    public Text winText;
    public Text countText;
    public AudioClip jumpClip;
    public AudioClip winClip;
    public AudioClip deathClip;
    public float moveForce = 365f;
    public float maxSpeed = 5f;

    public float jumpForce = 1000f;
    public Transform groundCheck;

    private int countCoins;
    private bool grounded = false;
    private Animator anim;
    private Rigidbody2D rb2d;
    private AudioSource aS;
    private bool restart;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        aS = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start () {
        countCoins = 0;
        winText.text = "";
        UpdateCount();
        restart = false;
        rb2d.drag = 5.14f;

    }


    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ladder"))
        {
            canClimb = true;
            rb2d.gravityScale = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            canClimb = false;
            playerColl.gravityScale = 1;
        }
    }
    */
    // Update is called once per frame
    void Update () {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Main");
            }
        }
        else
        {
            grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
            if (Input.GetButtonDown("Jump") && grounded)
            {
                jump = true;
            }
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
            countCoins++;
            UpdateCount();
        }
        else if(other.gameObject.CompareTag("Enemy"))
        {
            Death();
        }

    }

    private void UpdateCount()
    {
        countText.text = "CURRENT CREDITS: " + this.countCoins + "/45";

        if (countCoins >= 45)
        {
            winText.text = "CONGRATULATIONS ON PASSING YOUR FRESHMAN YEAR\nPress R To Play Again";
            restart = true;
            aS.clip = winClip;
            aS.Play();
        }
    }
    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(h));

        if ((h * rb2d.velocity.x) < maxSpeed)
        {
            rb2d.AddForce(Vector2.right * h * moveForce);
        }
        if (Mathf.Abs(rb2d.velocity.x) > maxSpeed)
        {
            rb2d.velocity = new Vector2(Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);
        }
        if (h > 0 && !facingRight)
            Flip();
        else if (h < 0 && facingRight)
            Flip();

        if (jump)
        {
            aS.loop = false;
            anim.SetTrigger("IsJumping");
            rb2d.AddForce(new Vector2(0f, jumpForce));
            aS.clip = jumpClip;
            aS.Play();
            jump = false;
        }

    }

    private void Death()
    {
        anim.SetTrigger("Death");
        winText.text="Unfortunately you didn't get enough credits.\nPlease Try Again\nPress R To Restart";
        rb2d.drag = 1000000;
        aS.clip = deathClip;
        restart = true;
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x = theScale.x * -1;
        transform.localScale = theScale;
    }

}
