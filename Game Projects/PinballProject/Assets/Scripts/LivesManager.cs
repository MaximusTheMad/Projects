using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LivesManager : MonoBehaviour
{
    public static int lives;


    TextMesh textMesh;


    void Awake()
    {
        textMesh = GetComponent<TextMesh>();
        lives = 6;
    }


    void Update()
    {
        //if (score >= 200)
        //{
        //    text.text = "You win!\nHigh Score: " + score;
        //}
        //else
        //{
        if (lives < 10)
            textMesh.text = "0" + lives;
        else
            textMesh.text = "" + lives;
        //}

    }
}