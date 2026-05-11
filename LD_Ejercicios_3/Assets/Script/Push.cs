using UnityEngine;

public class Push : MonoBehaviour
{
    public GameManager GameManager;
    public GameObject player;
    public float near = 2;
    public GameObject LaightOUT;
    void Update()
    {
        Proximity();
    }
    void Proximity()
    {
        float distancia = Vector3.Distance(player.transform.position, transform.position);
        if(distancia > near)
        {
            LaightOUT.SetActive(false);
        }
        if(distancia < near)
        {
            LaightOUT.SetActive(true);
        }
    }
    public void BotonLight()
    {
        GameManager.LightOFF();
        LaightOUT.SetActive(false);
    }
}
