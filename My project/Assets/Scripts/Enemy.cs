using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : NPC
{
    public float moveSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent.speed = moveSpeed;
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
    }
}
