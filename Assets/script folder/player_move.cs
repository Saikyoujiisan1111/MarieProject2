using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_move : MonoBehaviour
{
    public int py;
    public int oriru = 0;
    Rigidbody juuryoku;
    public GameObject FireBall;
    public LifeCountManager lifeCountManager;
    public Rigidbody rb;
    public bool grounded = true;
    Vector3 size;
    bool muteki = false;
    bool shutugenn = true;
    public GameObject nokonoko;
    public bool firejoutai;
    public float orirutakasa;
    //public bool zenkinou = true;
    public bool sousa = true;
    // Start is called before the first frame update
    void Start()
    {
        juuryoku = this.GetComponent<Rigidbody>();
        size = transform.localScale;
        firejoutai = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (sousa == true)
        {
            if (transform.position.x < -80)
            {
                if (shutugenn == true)
                {
                    Instantiate(nokonoko, new Vector3(-95, 1, 0), Quaternion.identity);
                    shutugenn = false;
                }
            }
            if (grounded == false)
            {
                rb.AddForce(Vector3.down * 10);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (grounded == true)
                {
                    rb.AddForce(-15, 0, 0);
                }
                else
                {
                    rb.AddForce(-5, 0, 0);
                }
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (grounded == true)
                {
                    rb.AddForce(15, 0, 0);
                }
                else
                {
                    rb.AddForce(5, 0, 0);
                }
            }  //Debug.Log("hogehoge");
            if (transform.position.y < -10)
            {
                //transform.position = new Vector3(14,4,0);
                lifeCountManager.Damage();
                SceneManager.LoadScene("SampleScene");
            }
            /*if (firejoutai == true)
            {
                if (Input.GetKey(KeyCode.B))
                {
                    //発射される;
                    float x = transform.position.x;
                    float y = transform.position.y;
                    float z = transform.position.z;
                    Instantiate(FireBall, new Vector3(x, y + 1.38f, z), Quaternion.identity);
                }
            }*/
        }

    }
    void OnCollisionStay(Collision hit)
    {
        if (hit.gameObject.tag == "Ground")
        {
            if (Input.GetKey(KeyCode.Space))
            {
                //transform.position = new Vector3(0, 4, 0);
                rb.AddForce(0, 7, 0, ForceMode.Impulse);
            }
            grounded = true;

            ////Debug.Log("hit Ground");
            //if (Input.GetKey(KeyCode.Space)) 
            //{
            //    //Debug.Log(" Space");
            //    transform.position += new Vector3(0, 2, 0);  
        }
        if (hit.gameObject.tag == "enemy" && muteki == false)
        {
            if (size.y == 0.5f)
            {
                //transform.position = new Vector3(14, 4, 0);
                lifeCountManager.Damage();
                SceneManager.LoadScene("SampleScene");
            }
            if (size.y == 1)
            {
                size.y = 0.5f;
                transform.localScale = size;
                StartCoroutine(Muteki());
                firejoutai = false;
            }
        }
        if (hit.gameObject.tag == "kinoko")
        {
            //Debug.Log("okokokokokok");
            Destroy(hit.gameObject);
            size.y = 1l;
            transform.localScale = size;
        }
        if (hit.gameObject.tag == "FireFlower")
        {
            //Debug.Log("okokokokokok");
            Destroy(hit.gameObject);
            size.y = 1l;
            transform.localScale = size;
            firejoutai = true;
        }
    }
    private void OnCollisionExit(Collision hit)
    {
        if (hit.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }
    IEnumerator Muteki()
    {
        muteki = true;
        yield return new WaitForSeconds(2);
        muteki = false;
    }
    void OnCollisionEnter(Collision fureru)
    {
        if (fureru.gameObject.tag == "Goal")
        {
            sousa = false;
            juuryoku.useGravity = false;
            grounded = true;
            Debug.Log("hoge");
            orirutakasa = (int)transform.position.y;
            Debug.Log(orirutakasa);
            orirutakasa--;
            Debug.Log(orirutakasa);
            /*while (transform.position.y > 2.5)
            {
                this.transform.position -= this.transform.up * -0.00001f;
                Debug.Log("ok");
            }*/
            //↑↑↑これ使ったらフリーズするから注意
            /*for (float i = 0; i < ?; i--)
            {
                transform.position = new Vector3(0, i, 0);
                Debug.Log("ff");
            }
            juuryoku.useGravity = true;*/
            /*for (float i = 0; i > orirutakasa; i++)
            {
                transform.position = new Vector3(0, 4, 0);
                //transform.position = new Vector3(0, i *-1, 0);
                //transform.position = new Vector3(0, i, 0);
                Debug.Log("ff");
            }*/
            for (float i = orirutakasa; i < 0; i -= 0.05f)
            {
                Debug.Log(i);
                transform.position = new Vector3(0, i, 0);
            }
            juuryoku.useGravity = true;
        }
    }
}
    



    