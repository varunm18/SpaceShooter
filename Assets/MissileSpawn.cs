using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSpawn : MonoBehaviour
{
    public Rigidbody prefab;
    Rigidbody clone;
    public GameObject spawn;
    public GameObject spawn2;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            count++;
            if(count % 2 == 0)
            {
                clone = Instantiate(prefab, spawn.transform.position, prefab.transform.rotation);
            }
            else
            {
                clone = Instantiate(prefab, spawn2.transform.position, prefab.transform.rotation);
            }
        }
    }
}
