using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_move : MonoBehaviour
{

    void Update()
    {
        transform.position = new Vector3(transform.position.x,  transform.parent.position.y+3- transform.parent.position.y/7, 2);
    }
}
