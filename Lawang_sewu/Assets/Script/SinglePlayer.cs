using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinglePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject closeDoorPrefab;
    [SerializeField] private GameObject openDoorPrefab;
    public float time = 3f;
    private bool leftLaneClicked = false;
    private bool rightLaneClicked = false;
    private bool middleLaneClicked = false;

    public Button Left;
    public Button Mid;
    public Button Right;

    bool isFull;

    private void Start()
    {
        // InvokeRepeating("SpawnDoor", 2f, 3f);
        StartCoroutine(SpawnDoorRandom());
        
    }

    private void Update()
    {

        // Left.onClick.AddListener(LeftLaneClicked);
        // Mid.onClick.AddListener(MiddleLaneClicked);
        // Right.onClick.AddListener(RightLaneClicked);
        

    }

    private void SpawnDoor()
    {
        if(leftLaneClicked)
        {
            Instantiate(openDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            Instantiate(closeDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            Instantiate(openDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
            leftLaneClicked = false;

            if (middleLaneClicked)
            {
                Instantiate(closeDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
                Instantiate(closeDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
                Instantiate(openDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
                middleLaneClicked = false;
            }
            else if (rightLaneClicked)
            {
                Instantiate(openDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
                Instantiate(closeDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
                Instantiate(closeDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
                rightLaneClicked = false;
            }
            else
            {
                Instantiate(openDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
                Instantiate(closeDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
                Instantiate(openDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
            }
        }


        else if (middleLaneClicked)
        {
            Instantiate(closeDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            Instantiate(openDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            Instantiate(openDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
            middleLaneClicked = false;

            if (leftLaneClicked)
            {
                Instantiate(closeDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
                Instantiate(closeDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
                Instantiate(openDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
                leftLaneClicked = false;
            }
            else if (rightLaneClicked)
            {
                Instantiate(closeDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
                Instantiate(openDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
                Instantiate(closeDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
                rightLaneClicked = false;
            }
            else
            {
                Instantiate(closeDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
                Instantiate(openDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
                Instantiate(openDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
            }
        }

        else if(rightLaneClicked)
        {
            Instantiate(openDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            Instantiate(openDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            Instantiate(closeDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
            rightLaneClicked = false;

            if (leftLaneClicked)
            {
                Instantiate(openDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
                Instantiate(closeDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
                Instantiate(closeDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
                leftLaneClicked = false;
            }
            else if (middleLaneClicked)
            {
                Instantiate(closeDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
                Instantiate(openDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
                Instantiate(closeDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
                middleLaneClicked = false;
            }
            else
            {
                Instantiate(openDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
                Instantiate(openDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
                Instantiate(closeDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
            }
        }
        else
        {
            Instantiate(openDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            Instantiate(openDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            Instantiate(openDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
        }
    }

    public void LeftLaneClicked()
    {
        leftLaneClicked = true;
    }

    public void MiddleLaneClicked()
    {
        middleLaneClicked = true;
    }

    public void RightLaneClicked() 
    {
        rightLaneClicked = true;
    }

    public void CheckFull()
    {

    }

    IEnumerator SpawnDoorRandom(){
        int random = Random.Range(0, 3);
        if(random == 0){
            // Instantiate(openDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            // Instantiate(openDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            Instantiate(openDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
        }
        else if(random == 1){
            Instantiate(openDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            // Instantiate(closeDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            // Instantiate(openDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
        }
        else{
            // Instantiate(openDoorPrefab, new Vector3(0, 7, 0), Quaternion.identity); //pintu tengah
            // Instantiate(openDoorPrefab, new Vector3(-2, 7, 0), Quaternion.identity); //pintu kiri
            Instantiate(closeDoorPrefab, new Vector3(2, 7, 0), Quaternion.identity); //pintu kanan
        }
    yield return new WaitForSeconds(time);
    StartCoroutine(SpawnDoorRandom());
    }
}
    {
        
    }
}
