using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rules : MonoBehaviour
{
    string[] gameRules = new string[5];

    int game=1; //Change to get selected game
    // Game 1 = Catch the Fruit
    // Game 2 = Racing
    // Game 3 = Balancing
    // Game 4 = Dodge

    // Start is called before the first frame update
    void Start()
    {
        getRules();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void displayRules(){
        // get game object
        Text rulesList = GameObject.Find("RulesText").GetComponent<Text>();

        // set text
        rulesList.text= gameRules[0];
    }

    void getRules(){
        //all rules
        string[] rulesCatchFruit = new string[] {"1. Use arrow keys/ A or D to move the avatar left or right.", "2. Use the avatar to collect the fruit and gain a point.","3. Collect as many fruit as you can before the time runs out.", "4. Avoid the BOMB!"};
        string[] rulesRacing = new string[] {"2"};
        string[] rulesBalancing = new string[] {"3"};
        string[] rulesDodge = new string[] {"4"};

        // get rules for selected game 
        if (game==1){
            gameRules= rulesCatchFruit;
        }else if(game==2){
            gameRules= rulesRacing;
        }else if(game==3){
            gameRules= rulesBalancing;
        }else if(game==4){
            gameRules= rulesDodge;
        }

        displayRules();    
    }

}
