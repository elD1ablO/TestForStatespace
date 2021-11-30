using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject turret;

    public Text scoreText;

    public GameObject completeLevelUI;
    public Text endScore;


    float finalScore;

    bool gameHasEnded = false;
    void Awake()
    {
        //completeLevelUI.SetActive(false);
        Instantiate(turret, new Vector3(0, 0.5f, 0), Quaternion.identity);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            //Debug.Log("GAME OVER");
            finalScore = Time.timeSinceLevelLoad;
            endScore.text = ("Score: " + finalScore.ToString("0.0") + "seconds");
            completeLevelUI.SetActive(true);
            
            //Debug.Log("Score: " + finalScore.ToString("0.0"));
        }
        
    }
    
    // Update is called once per frame
    void Update()
    {
        scoreText.text = ("Score: " + Time.timeSinceLevelLoad.ToString("0.0"));
    }
    
}
