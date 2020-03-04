using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topDownCamera : MonoBehaviour
{

    [SerializeField]Transform observable;
    [SerializeField] float aheadSpeed;
    [SerializeField] float followDamping;
    [SerializeField] float cameraHeight;

    Rigidbody _observableRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        _observableRigidBody = observable.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (observable == null)
            return;
        Vector3 targetPoisition = observable.position + Vector3.up * cameraHeight + _observableRigidBody.velocity * aheadSpeed;

        transform.position = Vector3.Lerp(transform.position, targetPoisition, followDamping * Time.deltaTime);
    }
}
