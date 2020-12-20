using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDestory : MonoBehaviour
{
    public static StartDestory instance;
    public GameObject Object;
    void Start()
    {
        instance = this;
        Object = transform.GetChild(0).gameObject;


    }

    public void Show()
    {
        Object.SetActive(true);


    }

    public void Hide()
    {
        Object.SetActive(false);
    }

}
