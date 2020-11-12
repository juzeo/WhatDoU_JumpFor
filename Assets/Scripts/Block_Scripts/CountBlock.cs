using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountBlock : MonoBehaviour
{
    int BlockCount = 2;


    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("aa");
        BlockCount--;
        if (BlockCount==0)
        {
            Destroy(gameObject);
        }
    }
}
