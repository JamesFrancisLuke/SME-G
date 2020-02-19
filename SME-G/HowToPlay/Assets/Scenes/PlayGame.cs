using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Set text of button
        GameObject.Find("PlayGameButton").GetComponentInChildren<Text>().text = "Play Game";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
