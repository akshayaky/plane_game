using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform firePoint;
    public List<GameObject> projectiles;
    // public GameObject rocketPrefab;
    
    public float fireTime = 0.1f; 
    private float nextFire = 0f;
    public int index = 0;

    public bool shoot = false;
    public bool changeAmmo = false; 
    void Update()
    {
        if(changeAmmo)
        {
            index = (index + 1 ) % projectiles.Count;
            changeAmmo = false;
        }
        nextFire += Time.deltaTime; 
        if( shoot && nextFire >= fireTime) 
        {
            nextFire = 0;
            Shoot();
        }


        
        // if( (Input.GetKeyUp(KeyCode.Mouse0) || Input.GetKeyUp("w") || Input.GetKeyUp("up")) 
        //     && nextFire >= fireTime/2) 
        // {
        //     nextFire = 0;
        //     Shoot();
        // }
    }

    void Shoot() 
    {
        // Debug.Log(firePoint.position);
        Instantiate(projectiles[index], firePoint.position, firePoint.rotation);
    }
}
