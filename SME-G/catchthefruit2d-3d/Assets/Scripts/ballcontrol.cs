using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballcontrol : MonoBehaviour
{
    Transform cam;
    Rigidbody rigid;
    Vector3 force;
    public float power;

    Boolean finished = false;
    public float timer = 0;
    [SerializeField] Text outputTime;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.transform;
        rigid = this.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()

    {
       // rigid.AddForce(Vector3.forward* 50, ForceMode.Force);
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 forward = (transform.position - cam.position);
        forward.y = 0;

        forward = forward.normalized;
        Vector3 right = Quaternion.Euler(0, 90, 0) * forward;
        force = forward * v + right * h;


        if (finished != true)
        {
            timer += Time.deltaTime;
            outputTime.text = "" + Math.Round(timer * 100) / 100;
        }
    }
    private void FixedUpdate()
    {
        rigid.AddForce(force*power);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Detected");
        if (other.gameObject.tag == "endGame")
        {
            Debug.Log("Finish Line");
            finished = true;
        }
    }

}
