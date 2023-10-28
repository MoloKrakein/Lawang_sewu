using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public Image Top;
    public Image Mid;
    public Image Bottom;

    GameObject top;
    GameObject mid;
    GameObject bot;

    bool isHit;

    public static int hp;
    void Start()
    {
        hp = 3;
        bot = GameObject.Find(Bottom.name);
        mid = GameObject.Find(Mid.name);
        top = GameObject.Find(Top.name);

    }

    void Update()
    {
        if (hp == 2 && bot != null)
        {
            Destroy(Bottom);
            Destroy(bot);
        }
        else if (hp == 1 && mid != null)
        {
            Destroy(Mid);
            Destroy(mid);
        }
        else if (hp == 0 && top != null)
        {
            Destroy(Top);
            Destroy(top);
            Debug.Log("YOU LOSE");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            isHit = true;
            hp -= 1;
        }
        else
        {
            isHit = false;
        }

    }
}
