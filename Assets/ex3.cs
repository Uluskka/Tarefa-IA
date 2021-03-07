using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ex3 : MonoBehaviour
{
    public NavMeshAgent cubo;
    public Transform Player;


    
    void Start()
    {

    }

    
    void Update()
    {
        cubo.SetDestination(Player.position);
    }
}
