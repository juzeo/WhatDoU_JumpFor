using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    GameObject gauage;//게이지바 오브젝트
    Image gauageBar;//게이지 바 fill
    public float touchTime = 0;//터치 타임
    Rigidbody2D Player_Rig;//플레이어 중력
    bool TimeDir = true;//true 상승 false 하락
    public int Amp = 50;//이동 값 증폭
    public float JumpX=0.5f;//X 이동 값
    public float JumpY = 2;//Y이동 값
    Vector2 touchPoint;//처음 터치위치 저장
    SpriteRenderer Render;//플레이어 spriteRenderer
    public Sprite Normal;
    public Sprite JumpAct;

    // Start is called before the first frame update
    void Start()
    {
        gauage = transform.GetChild(0).gameObject;
        gauageBar = gauage.transform.GetChild(1).GetComponent<Image>();
        Player_Rig = gameObject.GetComponent<Rigidbody2D>();
        Render = GetComponent<SpriteRenderer>();



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                touchPoint = touch.position;
                gauage.SetActive(true);
                if (touchPoint.x > Screen.width / 2)//화면 가운데 기준 좌우 구분
                {
                    Render.flipX = true;//캐릭터 바라보는 방향 변경

                }
                else
                {
                    Render.flipX = false;//캐릭터 바라보는 방향 변경

                }

            }
            //터치 중
            if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                //true==상승 false==하락
                if (TimeDir == true)
                {
                    touchTime += Time.deltaTime;
                }
                else
                {
                    touchTime -= Time.deltaTime;
                }
                if (touchTime > 1 || touchTime < 0) //터치가 1을 넘거나 0 이하면 시간 TimeDir(시간 이동방향)를 바꿈
                {
                    TimeDir = !TimeDir;
                }
                gauageBar.fillAmount = touchTime;
            }
            if (touch.phase == TouchPhase.Ended)
            {
                Jump(touchPoint, touchTime);
                gauage.SetActive(false);
                touchTime = 0;
            }
        }


    }
   

    //오른쪽은 +, 왼쪽은 -으로 구별
    void Jump(Vector2 touchPos,float touchTime)
    {

        if (touchPos.x > Screen.width / 2)//화면 가운데 기준 좌우 구분
        {
          
            Player_Rig.AddForce(new Vector2(JumpX, JumpY) * Amp* touchTime);

        }
        else
        {
          
            Player_Rig.AddForce(new Vector2(-JumpX, JumpY) * Amp* touchTime);
        }

    }

}
