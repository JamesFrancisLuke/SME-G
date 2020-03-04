using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameSelection : MonoBehaviour
{
    public Button selectGame;
    // Start is called before the first frame update
    void Start()
    {
        loadButton();
    }

    void loadButton()
    {
        selectGame = GameObject.Find("ButtonGameSelection").GetComponentInChildren<Button>();
        selectGame.onClick.AddListener(() => goToStart());
    }

    // Update is called once per frame
    void goToStart()
    {
        SceneManager.LoadScene(1);
    }
}
