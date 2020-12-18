using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCountManager : MonoBehaviour
{
    public player_move player;
    public static int lifeCount = 3;
    public GameObject GAMEOVER;
    public Text countDownText;
    public float HitEnemy;
    // Start is called before the first frame update
    void Start()
    {
     
    }
    // Update is called once per frame
    void Update()
    {
        countDownText.text = "X" + lifeCount; 
        if(lifeCount == 0)
        {
            GAMEOVER.SetActive(true);
            player.enabled = false;
        }
    }
    public void Damage()
    {
        lifeCount --;
    }
}
