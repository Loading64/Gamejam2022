using UnityEngine;
using UnityEngine.AI;

public class MeleeSlime : Slime
{
    void Start()
    {
        damage = 1;
        // Cache agent component and destination
        agent = GetComponent<NavMeshAgent>();
        destination = agent.destination;
    }
}
