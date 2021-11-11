using UnityEngine;

public class healthBar : MonoBehaviour
{
    public GameObject plane;
    private Entity planeEntity;
    private float size;
    void Start()
    {
        planeEntity = plane.GetComponent<Entity>();
        size = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        var scaleX = transform.localScale;
        scaleX.x = (planeEntity.health/planeEntity.maxHealth) * size;
        if(scaleX.x < 0)
            scaleX.x = 0;
        transform.localScale = scaleX;

         // Debug.Log(planeEntity.health/planeEntity.maxHealth);
    }
}
