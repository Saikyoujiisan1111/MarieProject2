using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour
{
    public GameObject Player;
    public Transform verRot;
    public Transform horRot;

    //public float rotateSpeed = 180.0f;




    // Start is called before the first frame update
    void Start()
    {
        verRot = transform.parent;
        horRot = GetComponent<Transform>();
    }
        
    // Update is called once per frame
    void Update()
    {
        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        verRot.transform.Rotate(0, X_Rotation*10, 0);
        horRot.transform.Rotate(-Y_Rotation*10, 0, 0);
        //float angle = Input.GetAxis("Horizontal") * rotateSpeed;

        //Vector3 playerPos = Player.transform.position;

        //transform.RotateAround(playerPos, Vector3.up, angle);
    }
}
