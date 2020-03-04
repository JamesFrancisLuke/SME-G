using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Set text of button
        GameObject.Find("BackButton").GetComponentInChildren<Text>().text = "Change Game";
        // find game object in UI
        Button backButton = GameObject.Find("BackButton").GetComponentInChildren<Button>();
        // add onclick listener to 'Select a Game' button
        backButton.onClick.AddListener(()=> onSelectGame());

    }

    // Update is called once per frame
    void Update()
    {
    }

    void onSelectGame(){
        // scene 0: Select a Game
        SceneManager.LoadScene(1);
    }
}
