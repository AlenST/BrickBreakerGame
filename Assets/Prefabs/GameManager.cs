using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   public int lives;
    public int score;
    public Text livesText;
    public Text scoreText;
    public bool gameOver;
    public GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "Lives: "+lives;
        scoreText.text = "Score: "+score;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateLives(int changeInLives){
      lives+=changeInLives;
      //check for no lives left and trigger end of the game
      if(lives<=0)
      {
        lives=0;
        GameOver();
      }
      livesText.text = "Lives: "+lives;
    }

    public void UpdateScore(int points){
      score+=points;
      scoreText.text = "Score: "+score;

      if(score>=33)
      {
        GameOver();
      }
    }

    public void GameOver()
    {
      gameOver = true;
      gameOverPanel.SetActive (true);
    }

    public void PlayAgain(){
      SceneManager.LoadScene("SampleScene");
    }
    public void Quit(){
      Application.Quit();
      Debug.Log ("Game Quit");
    }
}
