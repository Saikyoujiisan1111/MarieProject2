using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kakushiblock : MonoBehaviour
{
    public bool junp;
    // Start is called before the first frame update
    void Start()
    {
        junp = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (junp == false)
        {
            if (other.tag == "Player")
            {
                if (other.transform.position.y < transform.position.y)
                {
                    junp = true;
                    //transform.parent
                    //GetComponentInParent<MeshRenderer>().enabled = true;
                    //transform.parent.GetComponent<BoxCollider>().isTrigger = false;
                    Debug.Log("jjjjjj");
                    foreach(Transform item in transform)
                    {
                        item.gameObject.SetActive(true);
                    }
                }
            }
        }
    }

}
