using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetting_setting : MonoBehaviour
{
    [SerializeField]
    private GameObject threeDCamera;
    [SerializeField]
    private GameObject twoDCamera;
    public bool kirikae;
    // Start is called before the first frame update
    void Start()
    {
        kirikae = true;
        threeDCamera.SetActive(true);
        twoDCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //true=3D false=2D
        if (Input.GetKeyDown("n"))
        {
            if (kirikae == true)
            {
                threeDCamera.SetActive(false);
                twoDCamera.SetActive(true);
                kirikae = false;
            }
            else 
            {
                threeDCamera.SetActive(true);
                twoDCamera.SetActive(false);
                kirikae = true;
            }
        }
    }
}
