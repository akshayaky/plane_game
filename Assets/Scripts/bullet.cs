using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public float PROJECTILE_DAMAGE = 0.5f;

    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(!col.tag.Contains("surrounding"))
        {
            if(col.gameObject.GetComponent<Entity>() != null)
            {
                col.gameObject.GetComponent<Entity>().Damage(PROJECTILE_DAMAGE);                
            }
            // AudioManager.instance.PlaySoundClip(Sfx.rocket_hit);
                
        // }
        // if(!col.gameObject.CompareTag("Finish"))
        // {
            // Debug.Log(col.gameObject.name);
            Destroy(gameObject);
        }
    }
}
