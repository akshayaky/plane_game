using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFire : MonoBehaviour
{
    
    public Transform firePoint;
    public GameObject projectile;

    public GameObject building;
    public GameObject firePointObj;

    public float fireTime = 0.1f; 
    private float nextFire = 0f;

    private float RotateSpeed = 5f;
    private float Radius = 5f;
 
    private Vector3 _center;
    private float _angle;
    private float x, y;
    void Start()
    {
        _center = building.transform.position;
        x = 0;
        y = 0;
    }

    void OnTriggerStay2D(Collider2D col)
    {

        // Debug.Log(col.gameObject.name);
         
        if (col.gameObject.CompareTag("Player") && nextFire >= fireTime)
        {
            // Debug.Log(col.gameObject.name);
            nextFire = 0;
            Shoot();
            // Debug.Log(ids.Contains(col.gameObject.GetInstanceID()));
            // col.gameObject.GetComponent<Entity>().Damage(5);
            // ids.Add(col.gameObject.GetInstanceID());
        }
        
    }

    void Shoot() 
    {
        // Debug.Log(firePoint.position);
        Instantiate(projectile, firePoint.position, firePoint.rotation);
    }

    void Update()
    {
        if(building == null)
        {
            Destroy(firePointObj);
            Destroy(this);
            return;
            // foreach(Transform child in transform)
            // {
            //     Destroy(child);
            // }
        }


        nextFire += Time.deltaTime;

        _angle = _angle + RotateSpeed * Time.deltaTime;
 
        var offset = new Vector3(Mathf.Sin(_angle), Mathf.Cos(_angle), 0) * Radius;
        firePoint.transform.position = _center + offset;
        var rot = firePoint.transform.localEulerAngles;

        var k = 45;
        if(firePoint.transform.position.y < building.transform.position.y)
        {
            rot.z = 180;
        }
        else
        {
            rot.z = 0;
            k *= -1;
        }
        if(firePoint.transform.position.x < building.transform.position.x)
        {
            rot.z -= k;
        }
        else
        {
            rot.z += k;
        }
        // rot.z = (rot.z - 5)%360;
        firePoint.transform.localEulerAngles = rot;
    }
}
