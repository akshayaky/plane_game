using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class playerAnim : MonoBehaviour
{
    public Animator animator;
    public GameObject gb;
    public Rigidbody2D rb;
    
    private Entity plane;
    private float prevSpeed = -1f;
    // public AudioSource a_src;
    void Start()
    {
        plane = gb.GetComponent<Entity>();

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Entity target = col.gameObject.GetComponent<Entity>();
        float speed = (rb.velocity.magnitude/15) * 100;
        if(target != null)
        {

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
                    // Debug.Log(gameObject.name);
                }

                
                prevSpeed = speed;
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
        // Debug.Log(speed);

        // else
        // {
        //     Debug.Log("There");
        // }
               
    }
    void OnTriggerStay2D(Collider2D col)
    {
        Entity target = col.gameObject.GetComponent<Entity>();
        if(target != null && gameObject.name != "plane")
        {
            // Debug.Log(gameObject.name);
            // AudioManager.instance.PlaySoundClip(Sfx.burning, a_src);
            plane.DamagePercent(0.3f);
        }
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
