using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class quitGame : MonoBehaviour
{
    public Button quitGameBtn;
    // Start is called before the first frame update
    void Start()
    {
        loadButton();
    }

    void loadButton()
    {
        quitGameBtn = GameObject.Find("QuitButton").GetComponentInChildren<Button>();
        quitGameBtn.onClick.AddListener(() => exitGame());
    }

    // Update is called once per frame
    void exitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
        Debug.Log("exit");
    }
}
