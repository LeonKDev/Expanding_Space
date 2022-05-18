using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyscript : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;
    void Start()
    {
    }

    void fixedUpdate()
    {
        enemy.SetDestination(player.position);
    }
}
