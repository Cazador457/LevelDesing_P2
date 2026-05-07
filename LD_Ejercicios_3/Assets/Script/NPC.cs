using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    private PatrolForPoints _patrolMovement;

    public float range = 5f;
    public GameObject player;
    public GameObject npc;

    //AI
    public NavMeshAgent agent;
    public Transform[] patrolPoints;
    public int patrolIndex;
    public float arrival = 0.5f;

    public bool onRange;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        VisionNPC();
        PatrolOrChasing();
    }

    //AI de patrulla del NPC
    public void PatrolOrChasing()
    {
        if (onRange)
        {
            agent.SetDestination(player.transform.position);
            Debug.Log("En rango");
        }
        if (!onRange)
        {
            Library_AI.Destination(agent, patrolPoints, patrolIndex);
            Library_AI.ChangeDestination(agent, patrolPoints, patrolIndex,arrival);
        }
    }

    //Rango de vision del NPC
    public void VisionNPC()
    {
        onRange = Library_Mat.ObjectiveOnRange(range, npc, player);
        /*float Distancia=Vector3.Distance(player.transform.position,transform.position);
        if(Distancia<=range) onRange = true;
        else onRange = false;*/
    }
    public void OnDrawGizmosSelected()
    {
        Library_Mat.ViewSphereRange(range, player.transform);
    }

}
