using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Move : MonoBehaviour
{
   public void Move_To_Shop()
    {
        
        SceneManager.LoadScene("Shop");
    }
    public void Move_To_CoinShop()
    {
        
        SceneManager.LoadScene("CoinShop");
    }
    public void Move_To_Main()
    {
        //beforeScene.instance.LoadScene();
        SceneManager.LoadScene("main");
       
    }
    public void Move_To_Drawing_Lots()
    {
        
        SceneManager.LoadScene("drawing lots");
    }
    public void Move_To_Before()
    {
        beforeScene.instance.LoadScene();
        SceneManager.LoadScene(beforeScene.instance.beforename);
    }
}
