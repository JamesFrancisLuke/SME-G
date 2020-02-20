using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{  
    private float minX,maxX;
    // Start is called before the first frame update
    void Start()
    { // convert screen coordinate to unity world point
        Vector3 coor = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,0));
        //o.6f is the basket scale, add it that the basket will not go half 
        // minX = -coor.x;
        //maxX = coor.x ;
        maxX = coor.x - 0.6f;
        minX = -coor.x + 0.6f;
       
    }

    // Update is called once per frame
    void Update()
    {//getting current position of the basket
        //if the current position bigger than the max position, it will equal to the max
        Vector3 temp = transform.position;
        if (temp.x > maxX)
            temp.x = maxX;

        if (temp.x < minX)
            temp.x = minX;
        //reset the position back
        transform.position = temp;
        if(transform.position.x>maxX|| transform.position.x<minX)
        Debug.Log(transform.position);
    }
}
