using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    public static GameManage instance;
    // Start is called before the first frame update
    public int ClickCount;
    

     static int stageLevel; // 씬 시작 인덱스 번호 수정 필요


    public GameObject Player;

    Vector3 StartingPos;
    Quaternion StartingRotate;

    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
          
        }
        stageLevel = DataController.instance.dataSave.nowStage;

        /*
        Screen.SetResolution(1440, 2960, true);

        StartingPos = GameObject.FindGameObjectWithTag("Start").transform.position;
        StartingRotate = GameObject.FindGameObjectWithTag("Start").transform.rotation;
        if (stageLevel > 0) StartGame(); //0값 수정 필요 */


    }

    // Update is called once per frame
    void Update()
    {
        //뒤로가기 두번 클릭시 종료
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ClickCount++;
            if (!IsInvoking("DoubleClick"))
                Invoke("DoubleClick", 1.0f);

        }
        else if (ClickCount == 2)
        {
            CancelInvoke("DoubleClick");
            Application.Quit();

        }

    }
    void DoubleClick()
    {
        ClickCount = 0;
    }
    public void Next()
    {
        NextStage();
    }
    public static void NowStage()
    {
        SceneManager.LoadScene("Scenes/Stages/Stage" + DataController.instance.dataSave.nowStage);
    }
    // 스테이지 이동
    public static void NextStage() {

        stageLevel++;
        nowStage.instance.Upstage();
        DataController.instance.dataSave.nowStage = stageLevel;
        SceneManager.LoadScene("Scenes/Stages/Stage" + stageLevel);
        GPGSBoard.instance.topLeaderboard(DataController.instance.dataSave.nowStage);



        /*
        if (stageLevel == 8) // 마지막 스테이지면 종료
        {
            // 추가 필요
        }
        else //마지막 스테이지가 아니면 다음 스테이지 로드
        {
            SceneManager.LoadScene(stageLevel, LoadSceneMode.Single);

        }
    */
    }

    void StartGame()
    {
       
        GameObject standingCamera = GameObject.FindGameObjectWithTag("MainCamera");
        standingCamera.SetActive(false);

        StartingPos = new Vector3(StartingPos.x, StartingPos.y + 2f, StartingPos.z);
        Instantiate(Player, StartingPos, StartingRotate);
    }

}
