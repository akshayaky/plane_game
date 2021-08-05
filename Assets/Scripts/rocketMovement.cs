using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    
    public GameObject back;
    
    public CircleCollider2D cirCol;
    
    public bool exploded = false;

    public Animator animator;
    void Start()
    {
        rb.velocity = transform.up * speed;

        cirCol.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(!col.gameObject.CompareTag("Player") && !col.tag.Contains("surrounding") )
        {
            animator.SetBool("exploded", true); 
            exploded = true;
            cirCol.enabled = true;
            rb.velocity = new Vector3(0,0,0);
            Destroy(back);
        }
    }
}
