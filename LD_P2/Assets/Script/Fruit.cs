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
        Player player = other.GetComponent<Player>();
        if (player==null)
        {

        }
        
    }
}
