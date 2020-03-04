using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public Button startGame;       
    // Start is called before the first frame update
    void Start()
    {
        // Set text of button
        GameObject.Find("PlayGameButton").GetComponentInChildren<Text>().text = "Play Game";
				getGame();
    }

    void getGame(){
        // Game 1 = Catch the Fruit
        // Game 2 = Racing
        // Game 3 = Balancing

        // get selected game from player preferences
        string selectedGame = PlayerPrefs.GetString("selectedGame", "1"); //get the game. If NULL selected Catch the fruit by default

        Debug.Log("game index: " + selectedGame);
				setOnClick(selectedGame);
    }
		
		void setOnClick(string game) {
				startGame = GameObject.Find("PlayGameButton").GetComponentInChildren<Button>();
				startGame.onClick.AddListener(()=> switchScenes(game)); 
		}
		
		void switchScenes(string game){
        // get chosen game and load scene
        switch (game){
            case "1": 
                SceneManager.LoadScene(5);
                break;
            case "2":
                SceneManager.LoadScene(4);
                break;
            case "3":
                SceneManager.LoadScene(2);
                break;
        }
    }
}
