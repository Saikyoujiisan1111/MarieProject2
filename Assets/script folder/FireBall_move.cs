using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall_move : MonoBehaviour
{
    float time = 0.0f;
    public GameObject FireBall;
    public player_move pm;
    //public GameObject threecamera;
    public float gtry;
    // Start is called before the first frame update
    void Start()
    {
        //gtry = GameObject.Find("3Dcamera").transform.rotation.y;
    }

    // Update is called once per frame
    void Update()
    {

        //gtry = GameObject.Find("3Dcamera").transform.rotation.y;
        if (pm.firejoutai == true)
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                //発射される;
                float x = transform.position.x;
                float y = transform.position.y;
                float z = transform.position.z;
                Instantiate(FireBall, new Vector3(x, y, z), Quaternion.identity);
                    /*time = time + Time.deltaTime;  // ←経過した時間を足していく
                    if (time >= 1.0f)              // ←タイマーが5より大きくなったら
                {
                        time = 0;                  // ←タイマーを0にもどす
                        Debug.Log("1秒後");
                }*/

            }
        }
    }
}
