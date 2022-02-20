using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InicioJuego : MonoBehaviour
{
    public float juegoSpeed;
    public float naveSpeed;
    bool alive;

    public float score;

    //UI

    [SerializeField] Text speedText;
    [SerializeField] GameObject GameOverCanvas;
    [SerializeField] Button ButtonRetry;
    [SerializeField] GameObject HUDCanvas;

    // Start is called before the first frame update
    void Start()
    {
        juegoSpeed = 20f;
        naveSpeed = 5f;
        alive = true;

        GameOverCanvas.SetActive(false);
        HUDCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (alive)
        {
            juegoSpeed += 0.005f;
        }

        float veloc = (juegoSpeed * 3600) / 1000;
        speedText.text = "S: " + Mathf.Round(veloc) + "Km/h";
    }

    void Morir()
    {
        juegoSpeed = 0f;
        naveSpeed = 0f;
        alive = false;
        Invoke("MostrarGameOver", 2f);

        /*if (score > GameManager.HighScore)
        {
            GameManager.HighScore = score;

        }*/
    }

    void MostrarGameOver()
    {
        GameOverCanvas.SetActive(true);
        ButtonRetry.Select();
        HUDCanvas.SetActive(false);
        
    }
}
