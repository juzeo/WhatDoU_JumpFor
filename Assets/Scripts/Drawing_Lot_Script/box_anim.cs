using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_anim : MonoBehaviour
{
    Animation boxAnim;
    bool finish;
    private void Start()
    {
        boxAnim = GameObject.Find("box").GetComponent<Animation>();
    }

private void Update()
{
    if (!boxAnim.isPlaying&finish==false)
    {
            finish = true;
    
        draw_lot.instance.Start_Draw_lot(Drawing_lot_Able_Character.instance.Drawing_Type);
     }
}
}
