using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject UI;
    public GameObject col;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            UI.SetActive(true);
            col.SetActive(true);
        }

    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            UI.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
