﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeEnemies : MonoBehaviour
{
    public GameObject objectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemies()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}
