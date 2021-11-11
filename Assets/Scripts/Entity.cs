using UnityEngine;

public class Entity : MonoBehaviour
{
    public float maxHealth = 10f;
    public float health;

    public Color m_NewColor;
    public Color m_OldColor;
    public  SpriteRenderer m_SpriteRenderer;

    private float colourResetTime= 0.2f;
    private float timeRemaining;

    void Start()
    {
        // health = maxHealth;
        // m_NewColor = Color.red;
        // m_OldColor = Color.white;
    }

    public void Damage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Destroy(gameObject, 1.0f);
        }
        // if(gameObject.CompareTag("Player"))
        // {
        //     Debug.Log(health);
        // }
        m_SpriteRenderer.color = m_NewColor;
        timeRemaining = damage * 0.2f;
    }

    public void DamagePercent(float percent)
    {
        Damage(maxHealth * (percent/100));
    }

    void Update()
    {
        if(m_SpriteRenderer.color == m_NewColor)
        {
            timeRemaining -= Time.deltaTime;
            if(timeRemaining <= 0)
            {
                timeRemaining = colourResetTime;
                m_SpriteRenderer.color = m_OldColor;
            }
        }   
    }
}
