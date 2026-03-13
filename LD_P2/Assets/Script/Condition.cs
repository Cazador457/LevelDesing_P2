using UnityEngine;
using System.Collections;

public class Condition : MonoBehaviour
{
    public Player player;
    public UIGame ui;
    public GameObject Player;
    public GameObject checkpoint;
    public GameObject newCheckpoint;

    void Awake()
    {
        newCheckpoint = checkpoint;
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    

    public void Lose()
    {
        if(player.Life>0)
        if (player.Life <= 0)
        {
            Player.transform.position = checkpoint.transform.position;
            Araise();
            ui.PanelWin.SetActive(true);
        }
    }
    public void Win()
    {
        ui.PanelWin.SetActive(true);
    }
    public void Araise()
    {
        Player.transform.position = newCheckpoint.transform.position;
    }
    IEnumerator TakeDamage()
    {
        yield return new WaitForSeconds(1f);
        
    }
}
