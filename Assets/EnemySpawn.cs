using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class EnemySpawn : MonoBehaviour
{
    public Rigidbody prefab;
    Rigidbody clone;
    double time, waves;
    Random rand = new Random();
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        waves = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > waves)
        {
            changePos();
            StartCoroutine(SpawnEnemies());
            waves = time + 5;
        }

        
    }

    IEnumerator SpawnEnemies()
    {
        for (int i = 0; i < 3; i++)
        {
            clone = Instantiate(prefab, transform.position, prefab.transform.rotation);
            yield return new WaitForSeconds(0.7f);
        }
    }

    public void changePos()
    {
        transform.position = new Vector3(rand.Next(-250, 250), -40, 250);
    }
}