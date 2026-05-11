using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    //public UI ui;
    public float health = 3f;
    public int maxLife = 3;
    public int currentLife;
    public Image[] lifeSprite;

    public int playerRes = 0;

    public GameObject diePanel;
    public GameObject gamePanel;
    public GameObject respawnPanel;
    void Start()
    {
        diePanel.SetActive(false);
        respawnPanel.SetActive(false);
        gamePanel.SetActive(true);
    }

    void Update()
    {
        LifeValue();
    }
    public void RestLife()
    {
        if (health <= 0)
        {
            GameManager.Instance.respawnPos = 0;

        }
        if (health > 0)
        {
            health--;
        }

    }

    public void Reset()
    {
        GameManager.Instance.respawnPos = playerRes;
        diePanel.SetActive(false);
        respawnPanel.SetActive(false);
        gamePanel.SetActive(true);
        GameManager.Instance.Res();
        Time.timeScale = 1;
    }
    public int playerQuit = 10;
    public void Quit()
    {
        GameManager.Instance.respawnPos = playerQuit;
        diePanel.SetActive(false);
        GameManager.Instance.Res();
    }

    public void DieSh()
    {
        diePanel.SetActive(true);
        gamePanel.SetActive(false);
        Time.timeScale = 0;
    }
    private void OnEnable()
    {
        health = 3f;
    }
    public TextMeshProUGUI healtUI;
    public void LifeValue() => healtUI.text = $"{health}";
}
