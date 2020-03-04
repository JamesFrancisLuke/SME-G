using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour
{
    Text ScoreText;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        ScoreText.text = "0";
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider t)

    {
        if (t.tag == "Bomb") {
            transform.position = new Vector2(0,100);
            t.gameObject.SetActive(false);
            
            StartCoroutine(ReStartGame());
        }
        if (t.tag == "Fruit") {
            t.gameObject.SetActive(false);
            score++;
            ScoreText.text = score.ToString();
            PlayerPrefs.SetString("fruitScore", score.ToString());
        }
    }
    IEnumerator ReStartGame() {
        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);



    }
}
