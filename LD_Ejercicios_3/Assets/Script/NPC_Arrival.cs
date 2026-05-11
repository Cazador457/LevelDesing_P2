using UnityEngine;

public class NPC_Arrival : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
