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
    void Update()
    {
        
    }

    void formatButtonText(){
        // set text
        GameObject.Find("CatchFruitButton").GetComponentInChildren<Text>().text = "Catch the Fruit";
        GameObject.Find("RacingButton").GetComponentInChildren<Text>().text = "Racing";
        GameObject.Find("BalancingButton").GetComponentInChildren<Text>().text = "Balance the Block";
        GameObject.Find("DodgeButton").GetComponentInChildren<Text>().text = "Dodge the Dog";

        add event listener to buttons
        Button btn1 = fruit.GetComponent<Button>();
		btn1.onClick.AddListener(() => onClick(1));

        Button btn2 = racing.GetComponent<Button>(); 
		btn2.onClick.AddListener(() => onClick(2));

        Button btn3 = balancing.GetComponent<Button>();
		btn3.onClick.AddListener(() => onClick(3));

        Button btn4 = dodge.GetComponent<Button>();
		btn4.onClick.AddListener(() => onClick(4));
    }

    void onClick(int game){

    }

    // void onFruit(){
    //     // selectedGame =1;
    //     switchScenes("1");
    // }
    // void onRacing(){
    //     // selectedGame =2;
    //     switchScenes("2");
    // }
    // void onBalancing(){
    //     // selectedGame =3;
    //     switchScenes("3");
    // }
    // void onDodge(){
    //     // selectedGame =4;
    //     switchScenes("4");
    // }

    void switchScenes(string game){
        // switch scene
        SceneManager.LoadScene("HowToPlay");
    }


}
