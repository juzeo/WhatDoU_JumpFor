using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDestory : MonoBehaviour
{
    public static StartDestory instance;
    public List<GameObject> Object;
    void Start()
    {
        instance = this;
        for (int i = 0; i < transform.childCount; i++)
        {
            Object.Add( transform.GetChild(i).gameObject);
        }
        
    }

    public void Show()
    {
        for (int i = 0; i < Object.Count; i++)
        {
            Object[i].SetActive(true);
        }

    }

    public void Hide()
    {
        for (int i = 0; i < Object.Count; i++)
        {
            Object[i].SetActive(false);
        }
    }

}
