using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersScoreCounter : MonoBehaviour
{
    private int coins = 0;
    private int score = 0;

    void Start()
    {
        
    }

    void Update()
    {
        setScore();
    }

    public int getCoins()
    {
        return coins;
    }

    public void upCoins(int score)
    {
        this.coins += score;
    }

    public void setScore()
    {
        score = (int) this.transform.position.z;
    }

    public int getScore()
    {
        return score;
    }
}
