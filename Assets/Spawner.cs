using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject spawnObject;
    public int ballCount;
    
    //Var  Hur  När




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < ballCount; i++)
            {
                Instantiate(spawnObject, spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);
            }

        }
    }
}
