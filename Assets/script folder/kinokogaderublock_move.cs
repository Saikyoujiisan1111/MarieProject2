using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kinokogaderublock_move : MonoBehaviour
{
    public GameObject kinoko;
    public bool junp3;
    public bool kaishi;
    public bool yokoidou2;
    public Material colorA;
    // Start is called before the first frame update
    void Start()
    {
        junp3 = true;
        kaishi = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {
            if (other.transform.position.y < transform.position.y) ;
            {
                if (junp3 == true)
                {
                    junp3 = false;
                    kaishi = false;
                    //transform.parent
                    //GetComponentInParent<MeshRenderer>().enabled = true;
                    //transform.parent.GetComponent<BoxCollider>().isTrigger = false;
                    Debug.Log("hahahaha");
                    float x = transform.position.x;
                    float y = transform.position.y;
                    float z = transform.position.z;
                    Instantiate(kinoko, new Vector3(x, y + 1.38f, z), Quaternion.identity);
                    GetComponent<Renderer>().material.color = colorA.color;
                    transform.parent.GetComponent<Renderer>().GetComponent<Renderer>().material.color = colorA.color;
                    foreach (Transform item in transform)
                    {
                        item.gameObject.SetActive(true);
                    }
                }
            }
        }
    }
}
