using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinContoller : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayersScoreCounter counter = other.gameObject.GetComponent<PlayersScoreCounter>();
        if (counter != null)
        {
            counter.upCoins(1);
            //Debug.Log("Score up. Current score: " + counter.getCoins());
            Destroy(gameObject);
        }
    }
}
