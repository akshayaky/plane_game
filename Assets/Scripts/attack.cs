using UnityEngine;

public class attack : MonoBehaviour
{
    public AudioSource a_src;
    private bool playing = false;
    void OnTriggerStay2D(Collider2D col)
    {
        if(!col.gameObject.CompareTag("Player") && col.gameObject.GetComponent<Entity>() != null)
        {
            col.gameObject.GetComponent<Entity>().Damage(Time.deltaTime*5);
            if(!playing)
            {
                AudioManager.instance.PlaySoundClip(Sfx.burning, a_src);
                playing = true;
            }
        }
        
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(!col.gameObject.CompareTag("Player") && col.gameObject.GetComponent<Entity>() != null)
        {
                AudioManager.instance.StopSoundClip(Sfx.burning, a_src);
                playing = false;

        }
    }
}
