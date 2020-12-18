using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kinoko_move00 : MonoBehaviour
{
    public float hayasaK;
    public GameObject cupsule;
    public Rigidbody kinoko_rb;
    public bool yokoidou2 = false;
    // Start is called before the first frame update
    private void Start()
    {
        kinoko_rb = this.GetComponent<Rigidbody>();
        hayasaK = -0.1f;
    }

    void Update()
    {
        /*if (yokoidou2 == true)
        {
            this.transform.position += this.transform.right * 0.1f;
        }
        else if (yokoidou2 == false)
        {
            this.transform.position -= this.transform.right * 0.1f;
        }*/
        transform.position += transform.right * hayasaK;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "wall")
        {
            hayasaK = 0.1f;
        }
        /*if (other.gameObject.tag == "wall6")
        {
            yokoidou2 = true;
        }*/
    }
    private void FixedUpdate()
    {
        kinoko_rb.AddForce(Vector3.down * 10, ForceMode.Acceleration);
    }
}

