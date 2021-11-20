using UnityEngine;

public class rocketMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    
    public GameObject back;
    
    public CircleCollider2D cirCol;
    
    public bool exploded = false;

    public Animator animator;

    private AudioSource a_src;
    void Start()
    {
        rb.velocity = transform.up * speed;

        cirCol.enabled = false;
        a_src = gameObject.GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(!col.gameObject.CompareTag("Player") && !col.tag.Contains("surrounding") )
        {
            animator.SetBool("exploded", true); 
            exploded = true;
            cirCol.enabled = true;
            rb.velocity = new Vector3(0,0,0);
            AudioManager.instance.PlaySoundClip(Sfx.rocket_hit,gameObject.GetComponent<AudioSource>());
            // Destroy(back);
        }
    }
}
