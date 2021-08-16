using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketDamage : MonoBehaviour
{
    public float ROCKET_DAMAGE = 5;
    public GameObject rocket;
    private  rocketMovement m_rocketMovement;
    private float timeRemaining = 0.5f;
    private HashSet<int> ids;

    void Start()
    {
        ids = new HashSet<int>(){};
        m_rocketMovement = rocket.GetComponent<rocketMovement>();
    }

    void OnTriggerStay2D(Collider2D col)
    {

        // Debug.Log(col.gameObject.name);
        if (col.gameObject.GetComponent<Entity>() != null && !ids.Contains(col.gameObject.GetInstanceID()))
        {
            // Debug.Log(col.gameObject.GetInstanceID());
            // Debug.Log(ids.Contains(col.gameObject.GetInstanceID()));
            col.gameObject.GetComponent<Entity>().Damage(ROCKET_DAMAGE);
            ids.Add(col.gameObject.GetInstanceID());
        }
        
    }

    void Update()
    {
        if(m_rocketMovement.exploded)
        {
            timeRemaining -= Time.deltaTime;
            // Debug.Log(timeRemaining);
            if(timeRemaining <= 0)
            {
                Destroy(rocket);
            }
        }   
    }
}
