using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 1f;
    public float tilt = 0f;
    public bool speedBoost;

    private float speedLimit = 15f;
    private float speedBoostTime = 1f;
    private float timeRemaining;
    private  SpriteRenderer m_SpriteRenderer;

    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        // Debug.Log(m_SpriteRenderer.color.a);
        timeRemaining = speedBoostTime;

        
    }

    void FixedUpdate()
    {
        if(speedBoost)
        {
            var temp = m_SpriteRenderer.color; 
            temp.a = 0.7f;
            m_SpriteRenderer.color = temp;
            speedLimit = 50f;
            speed = 5;
        }

        // float tilt = playerControl.fly.move.ReadValue<float>(); 
        // var tilt = Input.GetAxisRaw("Horizontal");
        if(Math.Abs(tilt) > 4)
        {
            tilt = 4 * Math.Sign(tilt);
        }
        var rot = transform.localEulerAngles;
        rot.z -= tilt * 1.5f;
        transform.localEulerAngles = rot;

        Vector3 force = (7 - 4 * Math.Abs(tilt)) * transform.up;
        
        rb.AddForce(force * speed);
        
        if(rb.velocity.magnitude > speedLimit)
        {
            rb.velocity = rb.velocity.normalized * speedLimit;
            // rb.AddForce(force.normalized);
        }
        // Debug.Log(rb.velocity.magnitude);
    }

    void Update()
    {
        if(speedLimit == 50f)
        {
            timeRemaining -= Time.deltaTime;
            if(timeRemaining <= 0)
            {
                var temp = m_SpriteRenderer.color; 
                temp.a = 1f;
                m_SpriteRenderer.color = temp;
                Debug.Log("deactivate");
                timeRemaining = speedBoostTime;
                speedLimit = 15f;
                speed = 1;
            }
        }   
    }
}
