using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kribor_move_second : MonoBehaviour
{
    public bool yokoidou = true;
    public GameObject particle;
    public float hayasa1;
    // Start is called before the first frame update
    void Start()
    {
        hayasa1 = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * hayasa1;
        if(transform.position.x >= -20)
        {
            hayasa1 = -0.05f;
        }
        if (transform.position.x <= -34)
        {
            hayasa1 = 0.05f;
        }
        /*if (yokoidou == true)
        {
            this.transform.position += this.transform.forward * 0.05f;
        }
        else if (yokoidou == false)
        {
            this.transform.position -= this.transform.forward * 0.05f;
        }*/

    }
    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "enemy")
        {
            hayasa1 = 0.05f;
        }
        if (hit.gameObject.tag == "wall")
        {
            yokoidou = false;
        }
        if (hit.gameObject.tag == "enemy"|| hit.gameObject.tag == "wall")
        {
            yokoidou = true;
        }
        if (hit.gameObject.tag == "Player")
        {
            if (hit.transform.position.x < transform.position.x)
            {
                StartCoroutine(Wait(true));
                Debug.Log("aaaaaoooooooooo");
            }
            if (transform.position.x < hit.transform.position.x)
            {
                StartCoroutine(Wait(false));
                Debug.Log("ooooooooooooooo");
            }
        }
    }
    private void OnTriggerEnter(Collider Die)
    {
        if (Die.tag == "Player")
        {
            //Debug.Log("foooooooooooooooooooooooo");
            Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
    IEnumerator Wait(bool t)
    {
        yield return new WaitForSeconds(0.1f);
        yokoidou = t;
    }
}
