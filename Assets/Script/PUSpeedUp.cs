using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUp : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D bola;
    public float magnitude;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == bola)
        {
            bola.GetComponent<BallController>().ActivePUSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
