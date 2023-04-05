using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -300)
        {
            pos.x -= 0.4f;
            transform.position = pos;
            transform.position.Set(transform.position.x, 0, transform.position.z);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 45), Time.deltaTime * 12f);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 300)
        {
            pos.x += 0.4f;
            transform.position = pos;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -45), Time.deltaTime * 12f);
        }
        else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime * 12f);
        }
    }
}
