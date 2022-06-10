using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int leftscore;
    public int rightscore;
    public int maxscore;

    public BallController bola;

    public void AddRightScore(int increment)
    {
        rightscore += increment;
        bola.ResetBall();
        if (rightscore >= maxscore)
        {
            GameOver();
        }
    }
    public void AddLeftScore(int increment)
    {
        leftscore += increment;
        bola.ResetBall();
        if (leftscore >= maxscore)
        {
            GameOver();
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene("Menu");
    }
}
