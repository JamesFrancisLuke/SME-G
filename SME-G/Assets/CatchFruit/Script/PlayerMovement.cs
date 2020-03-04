using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5; 
    private  Transform transform;     // Use this for initialization   
    void Start()    {        transform = this.GetComponent<Transform>();    }     // Update is called once per frame  
    void Update()    {        float h = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * h * speed * Time.deltaTime);
    }

    }

   
    

