using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissileMovement : MonoBehaviour
{
    double time;
    Rigidbody missile;
    bool shot = false;
    public ParticleSystem explosion;
    ParticleSystem clone;

    // Start is called before the first frame update
    void Start()
    {
        missile = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time < 0.2)
        {
            transform.Translate(Vector3.down * 200f * Time.deltaTime);
        }
        else if(!shot)
        {
            shot = true;
            missile.AddForce(Vector3.forward * 400000f * Time.deltaTime, ForceMode.Impulse);
        }

        if (transform.position.z > 200)
        {
            Destroy(this.gameObject);
        }

        transform.position = new Vector3(transform.position.x, -40, transform.position.z);
    }


    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(this.gameObject);
        clone = Instantiate(explosion, transform.position, explosion.transform.rotation);
    }
}
