using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Annabel
public class Timer : MonoBehaviour
{
    public float timeStart = 60;
    public Text TimerText; 
    
    void Awake(){
        // find element in UI
        TimerText = GameObject.Find("TimerText").GetComponent<Text>();
        TimerText.text = "60";
    }

	// Use this for initialization
	void Start () {
        TimerText.text = timeStart.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        timeStart -= Time.deltaTime;
        TimerText.text = Mathf.Round(timeStart).ToString();

        if (timeStart <= 0){
            // restarts game 
            //CHANGE TO: displayEndOfGameMenu()
            StartCoroutine(ReStartGame());
        }
	}
    IEnumerator ReStartGame() {
        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}


