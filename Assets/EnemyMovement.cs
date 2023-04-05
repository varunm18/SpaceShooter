using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    bool first = true;
    bool sec = false;
    bool third = false;
    bool left = false;
    bool right = false;
    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.x > 0)
        {
            left = true;
        }
        else
        {
            right = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, -40, transform.position.z);
        transform.rotation = Quaternion.Euler(0, 0, 0);
        if (transform.position.z<-300)
        {
            Destroy(this.gameObject);
        }

        if(first)
        {
            transform.Translate(Vector3.back * 150f * Time.deltaTime);
            if (transform.position.z < -50)
            {
                first = false;
                sec = true;
            }
        }

        if(sec && right)
        {
            transform.Translate(new Vector3(1, 0, 1) * 150f * Time.deltaTime);
            if (transform.position.z > 130 || transform.position.x > 290)
            {
                sec = false;
                third = true;
            }
        }

        if(sec && left)
        {
            transform.Translate(new Vector3(-1, 0, 1) * 150f * Time.deltaTime);
            if (transform.position.z > 130 || transform.position.x < -290)
            {
                sec = false;
                third = true;
            }
        }

        if(third)
        {
            transform.Translate(Vector3.back * 150f * Time.deltaTime);
        }

        
    }
}
