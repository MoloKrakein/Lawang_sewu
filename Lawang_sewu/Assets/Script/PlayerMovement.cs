using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public TMP_InputField textBox;
    private Transform playerPos;
    private string commandText;

    void Start()
    {
        playerPos = gameObject.transform;
        textBox.ActivateInputField();
        textBox.Select();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (commandText == "left")
            {
                if (playerPos.position.x > -2)
                {
                    playerPos.position += new Vector3(-2, 0, 0);
                }
                else if (playerPos.position.x == -2)
                {
                    Debug.Log("Anda Gagal, Terbentur Dinding Kiri");
                }
                commandText = null;
            }

            else if (commandText == "right")
            {
                if (playerPos.position.x < 2)
                {
                    playerPos.position += new Vector3(2, 0, 0);
                }
                else if (playerPos.position.x == 2)
                {
                    Debug.Log("Anda Gagal, Terbentur Dinding Kanan");
                }
                commandText = null;
            }
            else
            {
                Debug.Log("Typo");
            }
        }
    }

    public void GetText()
    {
        commandText = textBox.text.ToLower();
        textBox.text = "";
        textBox.ActivateInputField();
        textBox.Select();
    }
}
