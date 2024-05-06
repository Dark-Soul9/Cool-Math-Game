using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject equationPrefab;
    private float startDelay = 1;
    private float repeatDelay = 5;
    private void Start()
    {
        InvokeRepeating("SpawnEquation", startDelay, repeatDelay);
    }
    void SpawnEquation()
    {
        Vector3 spawnPos = new Vector3(-2.5f, 0, 9);
        Instantiate(equationPrefab, spawnPos, equationPrefab.transform.rotation);
    }
}
