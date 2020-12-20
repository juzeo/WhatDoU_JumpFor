using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float cameraSpeed = 5.0f;
    float maxY = 0;
    float x;

    GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
        maxY = player.transform.position.y;
    }
    //가끔 버벅이면서 이동하기에 FixedUpdate로 정규적으로 이동함으로써 버벅임 삭제
    void FixedUpdate()
    {
        /*Vector3 dir = player.transform.position - this.transform.position;
        Vector3 moveVector = new Vector3(dir.x * cameraSpeed * Time.deltaTime, dir.y * cameraSpeed * Time.deltaTime, 0.0f);
        this.transform.Translate(moveVector);*/
        Vector3 playerPos = new Vector3(player.transform.position.x, player.transform.position.y+2f, -10f);
        transform.position = Vector3.Lerp(transform.position, playerPos, Time.deltaTime * cameraSpeed);
        //MoveCamera();
    }

    void MoveCamera()
    {

        if (player.transform.position.y > maxY)
        {
            maxY = player.transform.position.y;
            x = player.transform.position.x;

            Camera.main.transform.position = new Vector3(x,maxY+2f,-10);

        }
        else if(player.transform.position.y < maxY){

            maxY = player.transform.position.y;
            x = player.transform.position.x;

            Camera.main.transform.position = new Vector3(x, maxY + 2f, -10);
        }

    }
}
