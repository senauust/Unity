using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


enum ZombieState {
    Idle = 0,
    Walk =1,
    Dead = 2,
    Attack=3,

}

public class ZombıeAI : MonoBehaviour
{

    //Idle
    //Walk
    //Attack
    //Dead
    // Start is called before the first frame update
    Animator animator;
    NavMeshAgent agent;
    ZombieState zombieState;
    GameObject playerObject;

    void Start()
    {   
        playerObject = GameObject.FindWithTag("Player"); 
        zombieState = ZombieState.Idle;
        animator = GetComponent<Animator>(); //üstteki animatoru kullan
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (zombieState)
        {
            case ZombieState.Dead:
                KillZombie();
                break;
            case ZombieState.Idle:
                SearchForTarget();
                break;
            case ZombieState.Walk:
                break;
            case ZombieState.Attack:
                break;
            default:
                break;

        }
    }

private void SearchForTarget()
{
    float distance = Vector3.Distance(transform.position,playerObject.transform.position);
    if (distance <10 )
    {
        MoveToPlayer();
    }

    else 
    {
        SetState(ZombieState.Idle);

    }

}

private void SetState(ZombieState state)
{
    zombieState = state;
    //Anımator
    animator.SetInteger("state",(int)state);
}
private void MoveToPlayer()
{

    agent.SetDestination (playerObject.transform.position);
    SetState(ZombieState.Walk);

}



private void KillZombie()
{

}




}

