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
            if (commandText == "Left" || commandText == "left" || commandText == "LEFT")
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

            else if (commandText == "Right" || commandText == "right" || commandText == "RIGHT")
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
        }
    }

    public void GetText()
    {
        commandText = textBox.text;
        textBox.text = "";
        textBox.ActivateInputField();
        textBox.Select();
    }
}
