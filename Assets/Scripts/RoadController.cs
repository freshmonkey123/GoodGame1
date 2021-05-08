using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour
{
    public List<GameObject> movementObjects = new List<GameObject>();

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
            for (int i = 0; i < movementObjects.Count; i++)
            {
                movementObjects[i].GetComponent<EngineObsacleController>().startMove();
            }
        }
    }
}
