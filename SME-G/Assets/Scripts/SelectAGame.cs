﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectAGame : MonoBehaviour
{
     // create button objects
    public Button fruit;
    public Button racing;
    public Button balancing;       

    // game numbers 
    string fruitGame="1", racingGame="2", balancingGame="3";

    // Start is called before the first frame update
    void Start(){
        formatButtonText(); 
    }

    // Update is called once per frame
    void Update(){}

    void formatButtonText(){
        // set text
        GameObject.Find("CatchFruitButton").GetComponentInChildren<Text>().text = "Catch the Fruit";
        GameObject.Find("RacingButton").GetComponentInChildren<Text>().text = "Racing";
        GameObject.Find("BalancingButton").GetComponentInChildren<Text>().text = "Balance the Ball";

        // add event listener to buttons
        fruit = GameObject.Find("CatchFruitButton").GetComponentInChildren<Button>();
		fruit.onClick.AddListener(()=> switchScenes(fruitGame));

        racing = GameObject.Find("RacingButton").GetComponentInChildren<Button>();
		racing.onClick.AddListener(()=> switchScenes(racingGame));
        
        balancing = GameObject.Find("BalancingButton").GetComponentInChildren<Button>();
		balancing.onClick.AddListener(()=> switchScenes(balancingGame)); 
    }

    void switchScenes(string game){
        // get chosen game and load scene
        switch (game){
            case "1": 
                // save 'game chosen'
                PlayerPrefs.SetString("selectedGame", fruitGame);
                // tests
                Debug.Log("Game selected: Catch the Fruit");
                // switch scenes. Scene 1: HowToPlay
                SceneManager.LoadScene(3);
                break;
            case "2":
                PlayerPrefs.SetString("selectedGame", racingGame);
                Debug.Log("Game selected: Racing");
                SceneManager.LoadScene(3);
                break;
            case "3":
                PlayerPrefs.SetString("selectedGame", balancingGame);
                Debug.Log("Game selected: Balancing");
                SceneManager.LoadScene(3);
                break;
        }
    }
}
