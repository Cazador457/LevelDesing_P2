using UnityEngine;
using TMPro;

public class UIGame : MonoBehaviour
{
    public Player player;
    public GameObject PanelWin;
    public GameObject PanelLose;

    public TextMeshProUGUI Life;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Restard()
    {
        player.Life = 3;
        player.currentFruit = 0;
        PanelWin.SetActive(false);
        PanelLose.SetActive(false);
    }
    public void CurrentLife()
    {

    }
}
