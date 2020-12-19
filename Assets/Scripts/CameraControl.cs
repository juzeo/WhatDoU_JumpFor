using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float cameraSpeed = 5.0f;
    float maxY = 0;
    float x;

    public GameObject player;

   void Update()
    {
        /*Vector3 dir = player.transform.position - this.transform.position;
        Vector3 moveVector = new Vector3(dir.x * cameraSpeed * Time.deltaTime, dir.y * cameraSpeed * Time.deltaTime, 0.0f);
        this.transform.Translate(moveVector);*/

        MoveCamera();
    }

    void MoveCamera()
    {

        if (transform.position.y > maxY)
        {
            maxY = player.transform.position.y;
            x = player.transform.position.x;

            Camera.main.transform.position = new Vector3(x,maxY+2f,-10);

        }

    }
}
