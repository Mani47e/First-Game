using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite defimg;
    public Sprite pressimg;
    public KeyCode keypress;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
        if(Input.GetKeyDown(keypress))
        {
            sr.sprite = pressimg; 
        }

        if(Input.GetKeyUp(keypress))
        {
            sr.sprite = defimg; 
        }

    }
}
