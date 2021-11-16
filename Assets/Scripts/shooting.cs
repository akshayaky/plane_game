using System;
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
    public int changeAmmo = 0; 
    public AudioSource a_src;
    

    void Update()
    {
        // switch (changeAmmo + index)
        //     {
        //         case (0):
        //             break;
        //         case (-1):
        //             index = projectiles.Count - 1;
        //             break;
        //         default:
        //             index = (index + changeAmmo) % projectiles.Count;
        //             break;
        //         changeAmmo = 0;
        //     }
        // if (changeAmmo != 0)
        // {
        //     ChangeAmmo(changeAmmo);
        //     changeAmmo = 0;
        // }
        nextFire += Time.deltaTime; 
        if( shoot && nextFire >= fireTime) 
        {
            nextFire = 0;
            Shoot(index);
        }


        
        // if( (Input.GetKeyUp(KeyCode.Mouse0) || Input.GetKeyUp("w") || Input.GetKeyUp("up")) 
        //     && nextFire >= fireTime/2) 
        // {
        //     nextFire = 0;
        //     Shoot();
        // }
    }
    public void ChangeAmmo(int change = 0,int indexVal = -1)
    {
        index =  change == -1? projectiles.Count - 1:(index + Math.Abs(change)) % projectiles.Count;
    }
    void Shoot(int index) 
    {
        // Debug.Log(firePoint.position);
        Instantiate(projectiles[index], firePoint.position, firePoint.rotation);
        if(index == 0)
            AudioManager.instance.PlaySoundClip(Sfx.bullet_shoot, a_src);
        else if(index == 1)
            AudioManager.instance.PlaySoundClip(Sfx.rocket_shoot, a_src);
    }
}
