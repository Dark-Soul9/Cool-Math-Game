using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equation : MonoBehaviour
{
    [SerializeField] private Transform[] doorSpawnPos;
    [SerializeField] private GameObject fakeDoorPrefab;
    [SerializeField] private GameObject realDoorPrefab;
    private float speed = 3f;
    private void Start()
    {
        for(int i = 0; i < doorSpawnPos.Length; i++)
        {
            if(i == Random.Range(0, doorSpawnPos.Length))
            {
                Instantiate(realDoorPrefab, doorSpawnPos[i].transform.position, realDoorPrefab.transform.rotation, transform);
                Debug.Log("i = " + i);
                i++;
            }
            Instantiate(fakeDoorPrefab, doorSpawnPos[i].transform.position, fakeDoorPrefab.transform.rotation, transform);
        }
    }
    private void Update()
    {
        //transform.Translate(Vector3.back * speed * Time.deltaTime);
        if(transform.position.z < -11f)
        {
            Destroy(gameObject);
        }
    }
}
