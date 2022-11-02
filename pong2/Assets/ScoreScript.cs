using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int player1Score = 0;
    public int player2Score = 0;
    public Text p1Text;
    public Text p2Text;
    [SerializeField]
    GameObject Spin1;
    [SerializeField]
    GameObject Spin2;


    public void AddP1Score()
    {
        player1Score++;
        p1Text.text = player1Score.ToString();
    }

    public void AddP2Score()
    {
        player2Score++;
        p2Text.text = player2Score.ToString();
    }
    void Update()
    {
        if(player1Score == player2Score)
        {
            Spin1.SetActive(false);
            Spin2.SetActive(false);
        }
        else
        {
            Spin1.SetActive(true);
            Spin2.SetActive(true);
        }
    }
}

 