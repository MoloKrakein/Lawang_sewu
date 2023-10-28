using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public TMP_InputField textBox;
    private Transform playerPos;
    private string commandText;
    private bool isMoving;
    [SerializeField] private float speed;

    private Vector3 destinationPosition;

    void Start()
    {
        playerPos = transform; // You don't need gameObject.transform; transform is a reference to the current object's Transform.
        textBox.ActivateInputField();
        textBox.Select();
    }

    void Update()
    {
        if (isMoving)
        {
            // Move towards the destination position
            transform.position = Vector3.MoveTowards(transform.position, destinationPosition, Time.deltaTime * speed);

            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (transform.position == destinationPosition)
                {
                    isMoving = false;
                }

            }
        }
    }

    public void GetText()
    {
        commandText = textBox.text.ToLower();
        textBox.text = "";
        textBox.ActivateInputField();
        textBox.Select();

        if (commandText == "left")
        {
            MoveLeft();
        }
        else if (commandText == "right")
        {
            MoveRight();
        }
        else
        {
            Debug.Log("Typo");
        }
    }

    public void MoveLeft()
    {
        if (transform.position.x > -2)
        {
            isMoving = true;
            destinationPosition = new Vector3(transform.position.x - 2, transform.position.y, 0);
        }
        else
        {
            Debug.Log("Anda Gagal, Terbentur Dinding Kiri");
        }
    }

    public void MoveRight()
    {
        if (transform.position.x < 2)
        {
            isMoving = true;
            destinationPosition = new Vector3(transform.position.x + 2, transform.position.y, 0);
        }
        else
        {
            Debug.Log("Anda Gagal, Terbentur Dinding Kanan");
        }
    }
}
