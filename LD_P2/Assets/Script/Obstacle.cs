using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Condition condition;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = GetComponent<Player>();
            if (player != null)
            {
                player.Life--;
            }
            condition.Araise();
        }
    }
}
