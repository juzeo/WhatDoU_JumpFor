using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character_Selecter : MonoBehaviour
{
    
    public List<GameObject> Character_set;

    public Transform NowCharacter;
    public float selectScale;
    public float elementScale;
    
    private void Start()
    {
        GameObject[] Character_Temp = GameObject.FindGameObjectsWithTag("Coin");
        for (int i = 0; i < Character_Temp.Length; i++)
        {
            Character_set.Add(Character_Temp[i]);
        }
       


    }
    public string GetNowCharacter()
    {
        return NowCharacter.GetComponent<SpriteRenderer>().sprite.name;
    }
    private void Update()
    {
       
            Ray2D ray = new Ray2D(transform.position, Vector2.zero);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            if (hit.collider != null)
            {
                if (hit.transform.tag == "Coin")
                {

                    
                    for (int i = 0; i < Character_set.Count; i++)
                    {
                        if (Character_set[i] == hit.transform.gameObject)
                        {
                            hit.transform.localScale = new Vector3(selectScale, selectScale, selectScale);
                            NowCharacter = hit.transform.GetComponent<Transform>();
                          
                        }
                        else
                            Character_set[i].transform.localScale = new Vector3(elementScale, elementScale, elementScale);
                    }
                   
                }
            
           
           
             }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            BannerAds.instance.showBanner();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            FullAds.instance.show();
        }
    }
}
