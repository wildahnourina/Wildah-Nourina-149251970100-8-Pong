using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadelController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody2D rb;

    public bool poweringupExtend;
    public bool poweringupSpeed;

    private float timer;
    public int duration;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveopedal(GetInput());
        if (poweringupExtend == true)
        {
            timer += Time.deltaTime;
            if (timer > duration)
            {
                ResetExtend();
                timer -= duration;
            }
        }
        if (poweringupSpeed == true)
        {
            timer += Time.deltaTime;
            if (timer > duration)
            {
                ResetSpeed();
                timer -= duration;
            }
        }
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void moveopedal(Vector2 move)
    {
        rb.velocity = move;
        //Debug.Log("kecepatan padle" + move);
    }

    
    public void ExtendPedal()
    {
        poweringupExtend = true;
        //Debug.Log("Pedal bertambah panjang");
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * 2, transform.localScale.z);
        //ResetExtend();
    }

    public void SpeedUpPedal()
    {
        poweringupSpeed = true;
        speed = speed * 2;
    }

    private void ResetExtend()
    {
        poweringupExtend = false;
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y / 2, transform.localScale.z);
    }

    private void ResetSpeed()
    {
        poweringupSpeed = false;
        speed = speed / 2;
    }
}
