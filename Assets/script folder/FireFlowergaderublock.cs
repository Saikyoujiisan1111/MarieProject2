using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFlowergaderublock : MonoBehaviour
{
    public GameObject FireFlower;
    public bool junp3;
    public Material colorB;
    //public bool balldeta;
    // Start is called before the first frame update
    void Start()
    {
        junp3 = true;
        //balldeta = false;
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
                Debug.Log("hihihi");
                if (junp3 == true)
                {
                    junp3 = false;
                    //transform.parent
                    //GetComponentInParent<MeshRenderer>().enabled = true;
                    //transform.parent.GetComponent<BoxCollider>().isTrigger = false;
                    Debug.Log("hihihi");
                    float x = transform.position.x;
                    float y = transform.position.y;
                    float z = transform.position.z;
                    Instantiate(FireFlower, new Vector3(x, y + 1.38f, z), Quaternion.identity);
                    GetComponent<Renderer>().material.color = colorB.color;
                    transform.parent.GetComponent<Renderer>().GetComponent<Renderer>().material.color = colorB.color;
                    foreach (Transform item in transform)
                    {
                        item.gameObject.SetActive(true);
                    }
                    //balldeta = true;
                }
            }
        }
    }
}
