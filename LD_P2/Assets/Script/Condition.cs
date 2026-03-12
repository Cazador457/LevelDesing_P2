using UnityEngine;

public class Condition : MonoBehaviour
{
    public Player player;
    public UIGame ui;
    public GameObject Player;
    public GameObject Return;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Lose()
    {
        if(player.Life>0)
        Player.transform.position = Return.transform.position;
        if (player.Life <= 0)
        {
            ui.PanelWin.SetActive(true);
        }
    }
    public void Win()
    {
        ui.PanelWin.SetActive(true);
    }
}
