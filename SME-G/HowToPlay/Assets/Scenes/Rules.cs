using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rules : MonoBehaviour
{
    // array to store rules to selected game 
    string[] gameRules = new string[5];

    // formatted string of rules to display
    string formattedRules ="";

    // Start is called before the first frame update
    void Start(){
        getGame();  
    }

    void displayRules(){
        // get game object
        Text rulesList = GameObject.Find("RulesText").GetComponent<Text>();

        // Create string of rules.
        for (int i=0; i<gameRules.Length; i++){
            // adds new line and extra line
            formattedRules += (gameRules[i] + Environment.NewLine + Environment.NewLine);
        }
        // set text
        rulesList.text= formattedRules;
    }

    void getRules(string game){
        //all rules
        string[] rulesCatchFruit = new string[] {"1. Use arrow keys/ A or D to move the avatar left or right.", "2. Use the avatar to collect the fruit and gain a point.","3. Collect as many fruit as you can before the time runs out.", "4. Avoid the BOMB!"};
        string[] rulesRacing = new string[] {"1. Move your mouse to rotate the vehicle.", "2. Left click your mouse to speed up.", "3. Right click your mouse to reverse.", "4. Race around the course and watch your time.", "5. Try again to beat your score!"};
        string[] rulesBalancing = new string[] {"1. Use WASD or the Arrows to control the ball.", "2. Try not to fall off the edge.", "3. Reach the end whilst watching your time.", "4.Check for alternative and faster routes. ", "5. Try again to beat your score!"};

        // get rules for selected game 
        if (game=="1"){
            gameRules= rulesCatchFruit;
        }else if(game=="2"){
            gameRules= rulesRacing;
        }else if(game=="3"){
            gameRules= rulesBalancing;
        }
        displayRules();
    }

    void getGame(){
        // Game 1 = Catch the Fruit
        // Game 2 = Racing
        // Game 3 = Balancing
        // Game 4 = Dodge

        // get selected game from player preferences
        string selectedGame = PlayerPrefs.GetString("selectedGame", "1"); //get the game. If NULL selected Catch the fruit by default

        Debug.Log("game index: " + selectedGame);

        getRules(selectedGame); 
    }
}
