﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public Vector2 touchPoint;
    public List<Transform> ScrollItem;
    public int nowItemIndex=0;
    Transform nowItem;
    public Vector2 FirstPos;
    float ChangeItemLength = 200;//얼마나 드래그시 아이템이 바뀌는가
    float BetweenItemLengh = 1;//아이템 사이의 거리
    public float moveX;
    public Vector2 pastPos;
    public Vector2 nowPos;
    private void Start()
    {
        SetMainItem();
    }
    private void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                touchPoint = touch.position;



            }
            else if(touch.phase == TouchPhase.Moved)
            {
                float moveX = touchPoint.x - touch.position.x;
                //왼쪽으로
                if (moveX > 0)
                { 
                    if (moveX > ChangeItemLength)
                    {
                        touchPoint = touch.position;
                        nowItem = ScrollItem[nowItemIndex + 1];
                    }
                }
                //오른쪽으로
                if (moveX < 0)
                {
                    transform.Translate(moveX * (ChangeItemLength / BetweenItemLengh), 0, 0);
                    if (moveX < -ChangeItemLength)
                    {
                        touchPoint = touch.position;
                        nowItem = ScrollItem[nowItemIndex - 1];
                    }
                }
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                SetMainItem();
            }
        }
        //pc대응
        else if (Input.GetMouseButton(0))
        {

            Vector3 PcTouch = Input.mousePosition;
            if (Input.GetMouseButtonDown(0))
            {
               
                touchPoint = PcTouch;
                pastPos = new Vector2(0,0);
                nowPos = new Vector2(0, 0);


            }
            //터치 중
            else if (Input.GetMouseButton(0))
            {
                pastPos = nowPos;
                nowPos= Input.mousePosition;
                LiveX = pastPos.x-nowPos.x;
                moveX = touchPoint.x -  Input.mousePosition.x;
                //왼쪽으로
                if (LiveX > 0&&LiveX< 200)
                {
                    if (ScrollItem[ScrollItem.Count - 1].transform.position.x > FirstPos.x)
                    {
                        for (int i = 0; i < ScrollItem.Count; i++)
                        {
                            ScrollItem[i].position -= new Vector3(LiveX / ChangeItemLength, 0, 0);
                        }
                    }
                   
                    if (moveX > ChangeItemLength)
                    {
                        touchPoint = Input.mousePosition;
                        
            
                    }
                }
                //오른쪽으로
                if (LiveX < 0 && LiveX > -500)
                {
                    if (ScrollItem[0].transform.position.x < FirstPos.x)
                    {
                        for (int i = 0; i < ScrollItem.Count; i++)
                        {

                            ScrollItem[i].position -= new Vector3(LiveX / ChangeItemLength, 0, 0);
                        }
                    }
               
                   
                    if (moveX < -ChangeItemLength)
                    {
                        touchPoint = Input.mousePosition;
                       
                    }
                }
            }

        }
        else if (Input.GetMouseButtonUp(0))
        {
            SetMainItem();
        }
    }
    public float LiveX;
    void SetMainItem()
    {
        for (int i = 0; i < ScrollItem.Count; i++)
        {
            try
            {
                if (Character_Selecter.instance.NowCharacter == ScrollItem[i])
                {
                    nowItemIndex = i;
                }
            }
            catch
            {

            }
            
        }
        
        
        for (int i = 0; i < ScrollItem.Count; i++)
        {
            ScrollItem[i].position = new Vector2((i - nowItemIndex) * BetweenItemLengh, FirstPos.y);
        }
    }
}