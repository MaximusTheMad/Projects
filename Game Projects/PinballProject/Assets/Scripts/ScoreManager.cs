using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;

    TextMesh textMesh;
    private int lastScore = 0;
    private int livesGiven = 0;

    void Awake()
    {
        textMesh = GetComponent<TextMesh>();
        score = 0;
    }


    void Update()
    {
        if (score < 10)
            textMesh.text = "000" + score;
        else if (score < 100)
            textMesh.text = "00" + score;
        else if (score < 1000)
            textMesh.text = "0" + score;
        else
            textMesh.text = "" + score;
        if (score >= lastScore + 500)
        {
            LivesManager.lives++;
            livesGiven++;
            lastScore = 500 * livesGiven;
        }

    }
}