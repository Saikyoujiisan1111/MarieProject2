using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_two : MonoBehaviour
{
    public Vector3 tmp;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        tmp = player.transform.position;
        transform.position = new Vector3(tmp.x, tmp.y + 3, tmp.z + 15);
    }
}
