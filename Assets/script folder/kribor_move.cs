using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kribor_move : MonoBehaviour
{
    public bool yokoidou = true;
    public GameObject particle;
    public bool ParticleStart;
    public float hayasa; 
    //true = wall2 false = wall1
    // Start is called before the first frame update
    void Start()
    {
        hayasa = 0.05f;
    }
    // Update is called once per frame
    void Update()
    {
        /*if(yokoidou == true)
        {
            this.transform.position += this.transform.forward * 0.05f;
        }
        else if (yokoidou == false)
        {
            this.transform.position -= this.transform.forward * 0.05f;
        }
        */
        transform.position += transform.forward * hayasa;
        if (transform.position.x >= -12)
        {
            hayasa = -0.05f;
        }
        if (transform.position.x <= -18)
        {
            hayasa = +0.05f;
        }
    }
    void OnCollisionEnter(Collision hit)
    {
        if(transform.position.x > -12) 
        {
            yokoidou = false;
            //Debug.Log("wwwww");
        }
        if (hit.gameObject.tag == "wall")
        {
            yokoidou = true;
            //Debug.Log("nnnnnn");
        }
        if(hit.gameObject.tag == "Player")
        {
            if (hit.transform.position.x < transform.position.x)
            {
                StartCoroutine(Wait(true));
                //Debug.Log("aaaaaoooooooooo");
            }
            if (transform.position.x < hit.transform.position.x)
            {
                StartCoroutine(Wait(false));
                //Debug.Log("ooooooooooooooo");
            }
        }
    }
    private void OnTriggerEnter(Collider Die)
    {
        if(Die.tag == "Player")
        {
            //Debug.Log("foooooooooooooooooooooooo");
            Instantiate(particle,transform.position,Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
    IEnumerator Wait(bool t)
    {
        yield return new WaitForSeconds(0.1f);
        yokoidou = t;
    }
}       
