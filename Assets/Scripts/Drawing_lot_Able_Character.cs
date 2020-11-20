using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawing_lot_Able_Character : MonoBehaviour
{
    public static Drawing_lot_Able_Character instance;
    public List<Sprite> Able_Img_List;
    public string Drawing_Type;
    public Sprite GetCharacter;
    // Start is called before the first frame update
    void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        instance = this;
        DontDestroyOnLoad(this.gameObject);

        Able_Img_List = new List<Sprite>();
       
    }

    
}
