using UnityEngine;

public class CheckPointUpdate : MonoBehaviour
{
    public GameManager condition;
    public int CheckPoint = 0;
    public GameObject player;
    public float near = 5f;

    void CheckpointUP()
    {
        float distance=Vector3.Distance(player.transform.position,transform.position);
        if (distance < near)
        {
            condition.respawnPos = CheckPoint;
        } 
    }
}
