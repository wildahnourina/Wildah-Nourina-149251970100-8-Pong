using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 ResetPosition;
    private Rigidbody2D rb;

    private bool poweringUp;
    private float timer;
    public int duration;

    public float magnitude;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;
    }

    void Update()
    {
        if (poweringUp == true)
        {
            timer += Time.deltaTime;
            if (timer > duration)
            {
                DeactivePUSpeedUp(magnitude);
                timer -= duration;
            }
        }
    }

    public void ResetBall()
    {
        //transform.position = ResetPosition;
        transform.position = new Vector3 (ResetPosition.x, ResetPosition.y, 2);
    }

    public void ActivePUSpeedUp(float magnitude)
    {
        poweringUp = true;
        rb.velocity *= magnitude;
    }

    public void DeactivePUSpeedUp(float magnitude)
    {
        poweringUp = false;
        rb.velocity /= magnitude;
    }
}
