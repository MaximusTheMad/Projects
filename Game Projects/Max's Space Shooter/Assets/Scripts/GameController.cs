﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {

    public GameObject[] hazards;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public GUIText scoreText;
    public GUIText restartText;
    public GUIText gameOverText;
    private int score;
    private bool gameOver;
    private bool restart;
	// Use this for initialization
	void Start () {
        score = 0;
        gameOver = false;
        gameOverText.text = "";
        restart = false;
        restartText.text = "";
        UpdateScore();
        StartCoroutine(SpawnWaves());
	}

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    private void Update()
    {
        if(restart)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }
        }
    }
    public void GameOver()
    {

        gameOverText.text = "Game Over";
        gameOver = true;
    }
    public void AddScore(int newScore)
    {
        score=score+ newScore;
        UpdateScore();
    }
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while(true)
        {
            for(int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);

            if(gameOver)
            {
                restartText.text = "Press 'R' to Try Again";
                restart = true;
            }
        }
    }
}
