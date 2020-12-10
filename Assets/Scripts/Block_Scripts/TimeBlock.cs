using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBlock : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Invoke("DestroyBlock", 5);
        
    }

    void DestroyBlock()
    {
        Destroy(gameObject);

    }
}
