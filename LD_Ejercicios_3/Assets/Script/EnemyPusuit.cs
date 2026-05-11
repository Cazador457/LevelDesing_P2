using UnityEngine;
using UnityEngine.AI;

public class EnemyPusuit : Enemy
{
    public Player Player;
    public GameObject player;
    private NavMeshAgent agent;
    public float proximity = 22f;
    public float catching = 1.5f;
    private Transform targetT;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    public override void OnEnable()
    {
        LightMovPatrol.OnPursuit += Pursuit;
    }
    private void OnDisable()
    {
        LightMovPatrol.OnPursuit -= Pursuit;
    }
    void Pursuit()
    {
        float distance = Vector3.Distance(agent.nextPosition, targetT.position);
        if (distance < proximity)
        {
            agent.SetDestination(targetT.position);
        }
        if (distance < catching)
        {
            if (Player.health > 0) Player.respawnPanel.SetActive(true);

            else Player.diePanel.SetActive(true);
        }
    }
}

