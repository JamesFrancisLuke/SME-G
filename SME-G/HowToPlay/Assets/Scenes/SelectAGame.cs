using System.Collections;
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
    public Button dodge;

    // Start is called before the first frame update
    void Start()
    {
        formatButtonText();
    }

    // Update is called once per frame
    void Update(){}

    void formatButtonText(){
        // set text
        GameObject.Find("CatchFruitButton").GetComponentInChildren<Text>().text = "Catch the Fruit";
        GameObject.Find("RacingButton").GetComponentInChildren<Text>().text = "Racing";
        GameObject.Find("BalancingButton").GetComponentInChildren<Text>().text = "Balance the Block";
        GameObject.Find("DodgeButton").GetComponentInChildren<Text>().text = "Dodge the Dog";

        // add event listener to buttons
        fruit = GameObject.Find("CatchFruitButton").GetComponentInChildren<Button>();
		fruit.onClick.AddListener(()=> switchScenes("1"));

        racing = GameObject.Find("RacingButton").GetComponentInChildren<Button>();
		racing.onClick.AddListener(()=> switchScenes("2"));
        
        balancing = GameObject.Find("BalancingButton").GetComponentInChildren<Button>();
		balancing.onClick.AddListener(()=> switchScenes("3")); 
        
        dodge = GameObject.Find("DodgeButton").GetComponentInChildren<Button>();
		dodge.onClick.AddListener(()=> switchScenes("4"));
    }

    void switchScenes(string game){
        // get chosen game and load scene
        switch (game){
            case "1": 
                // Annabel: SAVE CHOSEN GAME
                // switch scenes. Scene 0: HowToPlay
                Debug.Log("Game selected: Catch the Fruit");
                SceneManager.LoadScene(1);
                break;
            case "2":
                Debug.Log("Game selected: Racing");
                SceneManager.LoadScene(1);
                break;
            case "3":
                Debug.Log("Game selected: Balancing");
                SceneManager.LoadScene(1);
                break;
            case "4":
                Debug.Log("Game selected: Dodge");
                SceneManager.LoadScene(1);
                break;
        }
    }
}
