using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playerAnim : MonoBehaviour
{
    public Animator animator;
    public GameObject gb;
    public Rigidbody2D rb;
    
    private Entity plane;
    
    void Start()
    {
        plane = gb.GetComponent<Entity>();

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Entity target = col.gameObject.GetComponent<Entity>();
        if(target != null)
        {
            Debug.Log("Here");
            float speed = (rb.velocity.magnitude/15) * 100;
            float damage = 0;
            if (col.tag.Contains("target"))
            {
                // m_SpriteRenderer.color = m_NewColor;
                // Debug.Log(gameObject.name);
                if(gameObject.name == "back")
                {
                    damage = 2*(speed/100);
                    animator.SetBool("backDamage", true);                
                }

                else if(gameObject.name == "left")
                {
                    damage = 3*(speed/100);
                    animator.SetBool("leftDamage", true);                
                }

                else if(gameObject.name == "right")
                {
                    damage = 3*(speed/100);
                    animator.SetBool("rightDamage", true);
                }
                else if(gameObject.name == "front")
                {
                    damage = 5*(speed/100);
                    // Debug.Log("front");
                }
                else
                {
                    Debug.Log(gameObject.name);
                }
                if (col.gameObject.CompareTag("target"))
                {
                    if(damage != 0)
                    {
                        // Debug.Log("kshfjkafikafakm");
                    // }
                        plane.Damage(damage);
                    }
                }
                if(damage != 0)
                {
                    target.Damage(damage/2);
                }


            }
        }
        // else
        // {
        //     Debug.Log("There");
        // }
               
    }

    // void Update()
    // {
    //     if(m_SpriteRenderer.color == m_NewColor)
    //     {
    //         timeRemaining -= Time.deltaTime;
    //         // Debug.Log(timeRemaining);
    //         if(timeRemaining <= 0)
    //         {
    //             timeRemaining = colourResetTime;
    //             m_SpriteRenderer.color = m_OldColor;
    //         }
    //     }   
    // }
}
