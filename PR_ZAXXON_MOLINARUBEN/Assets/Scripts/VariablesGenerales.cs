using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VariablesGenerales : MonoBehaviour
{

    [SerializeField] Text scoreText;

    
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.PlayerScore > GameManager.HighScore)
        {
            GameManager.HighScore = GameManager.PlayerScore;
            scoreText.text = "Score: " + Mathf.Round(GameManager.PlayerScore) + "Km/h";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
