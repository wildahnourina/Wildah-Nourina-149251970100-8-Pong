using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUExtendPaddle : MonoBehaviour
{
    public PowerUpManager manager;
    public PadelController pedalkanan;
    public PadelController pedalkiri;
    public Collider2D bola;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == bola)
        {
            pedalkanan.ExtendPedal();
            pedalkiri.ExtendPedal();
            manager.RemovePowerUp(gameObject);
            
        }
    }
}
