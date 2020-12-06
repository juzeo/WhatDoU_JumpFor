using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaBlock : MonoBehaviour
{
    float time;

    void Update()
    {
        if (time < 5f)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, time / 5);
        }
        else {

            time = 0;
            this.gameObject.SetActive(false);
       
        }

        time += Time.deltaTime;
    }

     void Reset()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
        this.gameObject.SetActive(true);
   
    }
}

