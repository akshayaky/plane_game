using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingAnim : MonoBehaviour
{
    public GameObject gb;

    public Animator animator;

    private Entity ent;

    public BoxCollider2D boxCol;

    public EdgeCollider2D edgeCol;

    void Start()
    {
        ent = gb.GetComponent<Entity>();
        boxCol.enabled = true;
        if(edgeCol != null)
        {
            edgeCol.enabled = false;
        }
    }

    void Update()
    {
        // Debug.Log(ent.health);
        if(ent.health <= ent.maxHealth/2)
        {
            animator.SetBool("damage", true);
            boxCol.enabled = false;
            if(edgeCol != null)
            {
                edgeCol.enabled = true;                
            }
            if(ent.health <= 0)
            {
                animator.SetBool("destroyed",true);
            }
        }
    }
}
