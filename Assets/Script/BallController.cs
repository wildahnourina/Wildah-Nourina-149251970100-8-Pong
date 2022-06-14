using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 ResetPosition;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;
    }

    public void ResetBall()
    {
        //transform.position = ResetPosition;
        transform.position = new Vector3 (ResetPosition.x, ResetPosition.y, 2);
    }

    public void ActivePUSpeedUp(float magnitude)
    {
        rb.velocity *= magnitude;
    }
}
