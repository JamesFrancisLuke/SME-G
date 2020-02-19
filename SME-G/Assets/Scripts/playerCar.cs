using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerCar : MonoBehaviour
{
    [SerializeField] float acceleration = 8;
    [SerializeField] float turnSpeed = 5;
    Quaternion targetRotation;
    Rigidbody _rigidBody;
    Boolean finished = false;

    public float timer = 0;
    [SerializeField] Text outputTime;

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        SetRotationPoint();

        if (finished != true)
        {
            timer += Time.deltaTime;
            outputTime.text = "" + Math.Round(timer * 100) / 100;
        }
    }

    private void SetRotationPoint()
    {
        //Create a Ray
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up, Vector3.zero);
        float distance;
        if(plane.Raycast(ray, out distance))
        {
            Vector3 target = ray.GetPoint(distance);
            Vector3 direction = target - transform.position;
            float rotationAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg; //Rotate in 2D
            targetRotation = Quaternion.Euler(0, rotationAngle, 0);
        }
    }

    private void FixedUpdate()
    {
        float accelerationInput = acceleration * (Input.GetMouseButton(0) ? 1 : Input.GetMouseButton(1) ? -1 : 0) * Time.fixedDeltaTime;
        _rigidBody.AddRelativeForce(Vector3.forward * accelerationInput);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, turnSpeed * Time.fixedDeltaTime);
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
