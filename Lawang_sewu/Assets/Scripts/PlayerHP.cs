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

    int hp;
    int currentHp;
    void Start()
    {
        hp = 3;
        isHit = false;
        bot = GameObject.Find(Bottom.name);

    }

    void Update()
    {
        /*currentHp = hp;
        if (hp == currentHp - 1)
        {
            isHit = true;
            Debug.Log("ADA");
        }
        else
        {
            Debug.Log("HILANG");
        }*/
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            Debug.Log("Hit");
        }


        if (collision.gameObject.tag == "Door")
        {
            isHit = true;
            currentHp -= 1;

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
        else
        {
            isHit = false;
        }
    }
}
