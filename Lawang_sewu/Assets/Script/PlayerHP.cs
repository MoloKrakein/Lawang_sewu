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
            Bottom.enabled = false;
            bot.SetActive(false);
        }
        else if (hp == 1 && mid != null)
        {
            Mid.enabled = false;
            mid.SetActive(false);
        }
        else if (hp == 0 && top != null)
        {
            Top.enabled = false;
            top.SetActive(false);
        }
        else if(hp == 0)
        {
            Top.enabled = true;
            top.SetActive(true);
        }
        else if(hp == 1)
        {
            Mid.enabled = true;
            mid.SetActive(true);
        }
        else if(hp == 2)
        {
            Bottom.enabled = true;
            bot.SetActive(true);
        }
        else if (hp == -1)
        {
            Debug.Log("YOU LOSE");
            Time.timeScale = 0;
            Destroy(gameObject);
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

        if (collision.CompareTag("Health"))
        {
            if(hp < 3)
            {
                hp += 1;
                Debug.Log("Get HP");
            }
            Destroy(collision.gameObject);
        }

    }
}
