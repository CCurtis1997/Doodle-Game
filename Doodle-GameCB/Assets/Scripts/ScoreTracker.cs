using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    public Text scoreText;

    public int scoreAmount;
    public int moneyBagScore;
    public int coinScore;
    public int diamondScore;


    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreAmount.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            scoreAmount += coinScore;
        }else if(collision.gameObject.tag == "Money Bag")
        {
            scoreAmount += moneyBagScore;
        }else if(collision.gameObject.tag == "Diamond")
        {
            scoreAmount += diamondScore;
        }

        
    }
}
