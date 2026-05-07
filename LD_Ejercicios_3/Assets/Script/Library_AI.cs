using UnityEngine;
using UnityEngine.AI;

public static class Library_AI
{
    //Estos 2 son necesarios paraque una AI de patrullaje por posiciones utilizand NavMesh.

    public static void Destination(NavMeshAgent Agent,Transform[] PatrolPoints, int PatrolIndex)
    {
        if (PatrolPoints == null && PatrolPoints.Length == 0) return;

        PatrolIndex = 0;
        Agent.SetDestination(PatrolPoints[PatrolIndex].position);
    }
    public static void ChangeDestination(NavMeshAgent Agent, Transform[] PatrolPoints, int PatrolIndex, float Arrival)
    {
        if (PatrolPoints == null || PatrolPoints.Length == 0) return;

        if (!Agent.pathPending && Agent.remainingDistance < Arrival)
        {
            PatrolIndex = (PatrolIndex + 1) % PatrolPoints.Length;
            Agent.SetDestination(PatrolPoints[PatrolIndex].position);
        }
    }

    //Esto es necesario para una AI persecucion si entras en tango de vision

    //Esto es para que IA tenga funcion de vision utilizando RayCast

    public static void DrawVision(Transform Object,float VisionDistance,Color Color)
    {
        Gizmos.DrawRay(Object.position, Object.forward*VisionDistance);
    }
}
