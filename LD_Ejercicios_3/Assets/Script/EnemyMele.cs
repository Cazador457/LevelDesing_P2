using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class EnemyMele : Enemy
{
    [Header("Resources")]
    private PatrolForPoints _patrolMovement;
    public Player Player;
    public GameManager GameManager;

    [Header("Patrol")]
    public Transform[] patrolPoints;
    private NavMeshAgent agent;
    private int patrolIndex;
    public float arrival = 1.2f;

    public Transform player;

    [Header("Vision Settings")]
    public float perseptionRange = 4f;
    public float catching = 2f;

    private bool isChasing = false;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        _patrolMovement = new PatrolForPoints(agent, patrolPoints, patrolIndex, arrival);
    }

    void Update()
    {
        if (GameManager.LightOUT==true)
        {
            agent.speed = GameManager.enemySpeed;
        }
        if (GameManager.LightOUT ==true)
        {
            agent.speed = 2;
        }
        
        StartCoroutine(ChasingDelay());
        CanSeePlayer();
        if (!isChasing)
        {
            _patrolMovement?.ChangeDestination();
        }
        else
        {
            agent.SetDestination(player.position);
        }
    }
    void CanSeePlayer()
    {
        Vector3 direction = player.position - transform.position;
        float distance = direction.magnitude;

        if (distance > perseptionRange)
            isChasing = false;

        if (distance < perseptionRange)
            isChasing = true;

        if (distance < catching)
        {
            Player.gamePanel.SetActive(false);
            Player.respawnPanel.SetActive(true);
        }
    }

    IEnumerator ChasingDelay()
    {
        yield return new WaitForSeconds(1f);
        CanSeePlayer();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, perseptionRange);
    }
    public override void OnEnable()
    {
        isChasing = false;
    }
}

