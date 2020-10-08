using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    // Start is called before the first frame update
    public int ClickCount;
    void Start()
    {
        Screen.SetResolution(1440, 2960, true);
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
}
