using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject equationPrefab;
    private float startDelay = 1;
    private float repeatDelay = 6;
    private void Start()
    {
        InvokeRepeating("SpawnEquation", startDelay, repeatDelay);
    }
    void SpawnEquation()
    {
        Vector3 spawnPos = new Vector3(0, 2.46f, 9);
        Instantiate(equationPrefab, spawnPos, equationPrefab.transform.rotation);
    }
}
