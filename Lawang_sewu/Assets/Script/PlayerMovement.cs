using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public TMP_InputField textBox;
    private Transform playerPos;
    private string commandText;
    
    // Start is called before the first frame update
    void Start()
    {
        playerPos = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(commandText == "Left")
            {
                if(playerPos.position.x > -2)
                {
                    playerPos.position += new Vector3(-2, 0, 0);
                }
                Debug.Log("Ke kiri");
            }
            
            if(commandText == "Right")
            {
                if(playerPos.position.x < 2)
                {
                    playerPos.position += new Vector3(2, 0, 0);
                }
                Debug.Log("Ke kanan");
            }
        }
    }

    public void GetText()
    {
        commandText = textBox.text;
        Debug.Log(textBox.text);
    }
}
