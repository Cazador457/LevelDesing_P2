using UnityEngine;
using TMPro;
using System.Collections;

public class UIGame : MonoBehaviour
{
    public Player player;
    public Condition condition;
    public GameObject PanelWin;
    public GameObject PanelLose;
    public GameObject PanelGame;

    public TextMeshProUGUI Life;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CurrentLife();
    }
    public void Restard()
    {
        player.Life = 3;
        player.currentFruit = 0;
        player.speed = 3f;
        player.transform.position=condition.checkpoint.transform.position;
        PanelWin.SetActive(false);
        PanelLose.SetActive(false);
        PanelGame.SetActive(true);
    }
    public void Lose()
    {
        if (player.Life <= 0)
        {
            PanelLose.SetActive(true);
            PanelGame.SetActive(false);
        }
    }
    public void Win()
    {

    }
    public void DamageUI()
    {

    }
    public void CurrentLife() => Life.text = player.Life.ToString();
    IEnumerator Hit()
    {
        yield return new WaitForSeconds(1f);
    }
}
