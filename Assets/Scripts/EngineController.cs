using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineObsacleController : MonoBehaviour
{
    public float speed = 0.1f;

    private CharacterController cc;
    private Vector3 move;

    private bool start = false;

    void Start()
    {
        move = new Vector3(0, 0, speed * -1.0f);
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
            cc.Move(move);
    }

    public void startMove()
    {
        start = true;
    }
}
