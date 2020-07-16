using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    bool pressed = false;
    public Sprite sprite1;
    public Sprite sprite2;
    Sprite newSprite;
    Image theImage;
    public void PauseGame ()
    {
        if (pressed)
        {
            newSprite = sprite1;
            theImage = GameObject.FindWithTag("pause").GetComponent<Image>();
            theImage.sprite = newSprite;
            Time.timeScale = 0f;
            pressed = false;
        }
        else
        {
            newSprite = sprite2;
            theImage = GameObject.FindWithTag("pause").GetComponent<Image>();
            theImage.sprite = newSprite;
            Time.timeScale = 1;
            pressed = true;
        }
    }
}
