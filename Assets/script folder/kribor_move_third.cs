using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kribor_move_third : MonoBehaviour
{
    public bool yokoidou = true;
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (yokoidou == true)
        {
            this.transform.position += this.transform.forward * 0.05f;
        }
        else if (yokoidou == false)
        {
            this.transform.position -= this.transform.forward * 0.05f;
        }
    }
    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "enemy"|| hit.gameObject.tag == "wall")
        {
            yokoidou = false;
        }
        if (hit.gameObject.tag == "wall")
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
