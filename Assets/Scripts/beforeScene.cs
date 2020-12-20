using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class beforeScene : MonoBehaviour
{
    public static beforeScene instance;
    public string beforename;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
        beforename = "Shop";
    }

   public void LoadScene()
    {
        beforename = SceneManager.GetActiveScene().name;
    }
}
