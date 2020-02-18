using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour
{
    private Text ScoreText;
    private int score = 0;
    // Start is called before the first frame update
    void Awake()
    {
        ScoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        ScoreText.text = "0";
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D t)

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

        }
    }
    IEnumerator ReStartGame() {
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);



    }
}
