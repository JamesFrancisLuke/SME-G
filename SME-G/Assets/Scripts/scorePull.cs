using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class scorePull : MonoBehaviour
{
    string selectedGame;
    string gameScore = "";
    // Start is called before the first frame update
    void Start()
    {
        getGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void getGame(){
        // Game 1 = Catch the Fruit
        // Game 2 = Racing
        // Game 3 = Balancing
        selectedGame = PlayerPrefs.GetString("selectedGame", "1");

        switch (selectedGame){
            case "1": 
                gameScore ="fruitScore";
                getScore();
                break;
            case "2":
                gameScore ="racingScore";
                getScore();
                break;
            case "3":
                gameScore ="balancingScore";
                getScore();
                break;
        }
    }

    void getScore(){
    	Text Score = GameObject.Find("Scoretxt").GetComponent<Text>();
        Debug.Log("Get Score" + gameScore);
    	string player_score = PlayerPrefs.GetString(gameScore);
    	Debug.Log("Score=" + player_score);
    	Score.text = player_score;
    }

}
