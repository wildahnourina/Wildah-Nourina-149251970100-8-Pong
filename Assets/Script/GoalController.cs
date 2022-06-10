using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    //public Collider2D bola;
    public bool IsRight;
    public ScoreManager manager;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bola")
        {
            if (IsRight)
            {
                manager.AddLeftScore(1);
            }
            else
            {
                manager.AddRightScore(1);
            }
        }
    }
}
