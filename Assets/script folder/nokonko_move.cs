using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nokonko_move : MonoBehaviour
{
    bool shutugenn = true;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーとノコノコ（もしくはこのスクリプトを持っている何か）の距離が００以下だったら
        if(player.transform.position.x - this.transform.position.x < 15)
        {
            this.transform.position -= this.transform.right * -0.05f;
        }
    }
}
