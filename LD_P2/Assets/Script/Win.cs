using UnityEngine;

public class Win : MonoBehaviour
{
    public UIGame ui;
    public Player player;
    public void OnTriggerEnter2D(Collider2D other)
    {
        player.speed = 0f;
        ui.PanelWin.SetActive(true);
    }
}
