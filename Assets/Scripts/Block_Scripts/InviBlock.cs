using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InviBlock : MonoBehaviour
{
    SpriteRenderer sprite;
    BoxCollider2D boxCollider;
    Color targetColor;

    void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        targetColor = sprite.color;
        StartCoroutine(FadeOutEffect());
        
    }

    IEnumerator FadeOutEffect()
    {
        yield return new WaitForSeconds(5f);
        while (true)
        {
            targetColor.a -= 0.05f;
            sprite.color = targetColor;
            if (sprite.color.a <= 0)
            {
                boxCollider.enabled = false;
                break;
            }
            yield return new WaitForSeconds(0.1f);
        }
       
    }
}
