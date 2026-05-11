using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.Experimental.GlobalIllumination;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Transform[] respawnPosition;
    public Light[] lightFaro;
    public int respawnPos = 0;
    public GameObject player;
    public Player Player;
    public float enemySpeed = 0.5f;
    public bool LightOUT = false;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void Start()
    {
        Application.targetFrameRate = 120;
    }
    public void Update()
    {

    }
    //Items Room
    public void LightOFF()
    {
        LightOUT = true;
        foreach(var obj in lightFaro)
        {
            if(obj != null)
                obj.enabled = false;
        }
    }

    //Respawn
    IEnumerator Respawn()
    {
        player.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        player.transform.position = respawnPosition[respawnPos].position;
        player.SetActive(true);
        Player.respawnPanel.SetActive(false);
        Player.gamePanel.SetActive(true);
    }
    public void Res()
    {
        StartCoroutine(Respawn());
    }
}
