using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; set; }
    
    public GameObject turret;
    public Text scoreText;

    public GameObject completeLevelUI;
    public Text endScore;
    float finalScore;

    void Awake()
    {                
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        SpawnTurret();
    }

    public void EndGame()
    {                          
        finalScore = Time.timeSinceLevelLoad;
        endScore.text = ("Score: " + finalScore.ToString("0.0") + "seconds");
        completeLevelUI.SetActive(true); 
    }
        
    void Update()
    {
        scoreText.text = ("Score: " + Time.timeSinceLevelLoad.ToString("0.0"));
    }
    
    public void SpawnTurret()
    {
        Instantiate(turret, new Vector3(0, 0.5f, 0), Quaternion.identity);
    }
}
