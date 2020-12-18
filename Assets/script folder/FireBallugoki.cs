using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallugoki : MonoBehaviour
{
    private int TukuKaisuu = 0;
    public float gtry;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //gtry = GameObject.Find("player").transform.rotation.y;
        //if (-90 < gtry && gtry < 90)
        this.transform.position += this.transform.right * -0.05f;
        if (-90 < gtry && gtry < 90)
        {
            Debug.Log("yy");
            this.transform.position += this.transform.right * -0.05f;
        }
        /*if (gtry < -90 && gtry > 90)
        {
                this.transform.position += this.transform.right * 0.05f;
                Debug.Log(gtry);
        }*/
        //this.transform.position += this.transform.right * -0.05f;
        if (TukuKaisuu == 3)
        {
            Destroy(this.gameObject);
            TukuKaisuu = 0;
        }
    }
    void OnCollisionEnter(Collision tuku)
    {
        if (tuku.gameObject.tag == "Ground")
        {
            TukuKaisuu++;
            Debug.Log(TukuKaisuu);
        }
    }
}
