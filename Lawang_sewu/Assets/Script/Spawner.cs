using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject doorPrefab;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(doorPrefab, new Vector3(0, 7, 0), Quaternion.identity);
        }
    }

    public void LaneClicked()
    {
        Instantiate(doorPrefab);
    }
}
