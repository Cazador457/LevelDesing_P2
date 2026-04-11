using UnityEngine;

public class CheckPointUpdate : MonoBehaviour
{
    public Condition condition;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            condition.newCheckpoint = this.gameObject;
        }
    }
}
