using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRotate : MonoBehaviour
{
    public float radius = 2;
    public float height = 2;
    public Transform target;
    int dirindex = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3[] poses = new Vector3[]
        {
            new Vector3(0,height,-radius),
            new Vector3(radius,height,0),
            new Vector3(0,height,radius),
            new Vector3(-radius,height,0),

        };
        if (Input.GetKeyDown(KeyCode.J))
        {
            dirindex++;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            dirindex--;
        }
        if (dirindex < 0) dirindex = 3;
        if (dirindex > 3) dirindex = 0;
        // transform.position = poses[dirindex]+target.position;
        // transform.LookAt(target.position);
        Vector3 offset = transform.position - target.position;
        offset.y = 0;
        Vector3 temp = poses[dirindex];
        offset = Vector3.Slerp(offset, temp, 0.1f);
        transform.position = offset + target.position + new Vector3(0, height, 0);
        transform.LookAt(target.position);

    }
}
