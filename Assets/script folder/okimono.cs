using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class okimono : MonoBehaviour
{
    Renderer _renderer;
    GameObject cube;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionStay(Collision hit)
    {
        if (hit.gameObject.tag == "player")
        {
            _renderer = cube.GetComponent<Renderer>();
            _renderer.enabled = true;
        }
    }
}
      
      
 
