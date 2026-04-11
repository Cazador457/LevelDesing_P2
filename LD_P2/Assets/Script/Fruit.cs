using UnityEngine;

public class Fruit : MonoBehaviour
{
    public int fruit = 2;
    public GameObject[] Banish;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.currentFruit += fruit;
                foreach (var fruit in Banish) { fruit.SetActive(!fruit.activeSelf); }
                this.gameObject.SetActive(false);
            }
        }
        
    }
}
