using UnityEngine;

public class Fruit : MonoBehaviour
{
    public int fruit = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.currentFruit += fruit;
            }
        }
        
    }
}
