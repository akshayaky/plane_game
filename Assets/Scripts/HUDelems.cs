using UnityEngine;
using UnityEngine.UI;

public class HUDelems : MonoBehaviour
{
    public Image img;
    public GameObject plane;
    private int index = 0;
    private shooting s;
    void Start()
    {
        s = plane.GetComponent<shooting>();
    }

    // Update is called once per frame
    void Update()
    {
        if(s.index != index)
        {
            index = s.index;
            img.overrideSprite = s.projectiles[index].GetComponent<SpriteRenderer>().sprite;   
        }
    }
}
