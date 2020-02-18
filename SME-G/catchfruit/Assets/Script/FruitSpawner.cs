using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public int Size;
    [SerializeField]
    private GameObject[] fruits;
    private BoxCollider2D col;
        float x1, x2;
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log(Size);
        col = GetComponent<BoxCollider2D>();
         x1 = transform.position.x - col.bounds.size.x / 2f;
       x2 = transform.position.x + col.bounds.size.x / 2f;
    }

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(SpawnFruits(1f));
    }
    IEnumerator SpawnFruits(float time) { 
       yield return new WaitForSecondsRealtime(time);
        
        Vector3 temp = transform.position;
        temp.x = Random.Range(x1, x2);
        Instantiate(fruits[Random.Range(0, fruits.Length)], temp, Quaternion.identity);
        StartCoroutine(SpawnFruits(Random.Range(1f, 2f)));
    }
}
