using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    private Transform door;
    [SerializeField] private float moveSpeed;

    private void Start()
    {
        door = this.transform;
    }

    private void Update()
    {
        door.Translate(new Vector3(0, -1 * Time.deltaTime * moveSpeed, 0));
    }
}
