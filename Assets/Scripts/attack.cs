using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D col)
    {
        if(!col.gameObject.CompareTag("Player") && col.gameObject.GetComponent<Entity>() != null)
        {
            col.gameObject.GetComponent<Entity>().Damage(Time.deltaTime*5);
        }
        
    }
}
