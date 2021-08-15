using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPick : MonoBehaviour
{
    public  CanvasGroup canvas;
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        canvas.alpha = 1;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canvas.alpha = 0;
    }
}
