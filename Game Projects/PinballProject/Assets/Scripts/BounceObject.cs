using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BounceObject : MonoBehaviour
{
    public float explosionStrength = 1500f;
    public int scoreValue = 10;
    private AudioSource bouncePlayer;
    public AudioClip[] bounceClips;
    public void Awake()
    {
        bouncePlayer = this.GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        {
            other.rigidbody.AddExplosionForce(explosionStrength, this.transform.position, 5);
            ScoreManager.score += scoreValue;
            bouncePlayer.clip = bounceClips[Random.Range(0, bounceClips.Length)];
            bouncePlayer.Play();
        }
    }
}
