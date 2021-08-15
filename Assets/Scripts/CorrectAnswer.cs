using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswer : MonoBehaviour
{
    public CanvasGroup canvasC;
    public CanvasGroup canvasI;
    public AudioSource clipI;
    public AudioSource clipC;
    private void Start()
    {
        canvasC.alpha = 0;
        canvasC.interactable = false;
        canvasC.blocksRaycasts = false;

        canvasI.alpha = 0;
        canvasI.interactable = false;
        canvasI.blocksRaycasts = false;
    }

    public void Correct()
    {
        canvasC.alpha = 1;
        canvasC.blocksRaycasts = true;
        canvasC.interactable = true;
        clipC.Play();
    }

    public void Incorrect()
    {
        canvasI.alpha = 1;
        canvasI.blocksRaycasts = true;
        canvasI.interactable = true;
        clipI.Play();
    }
}
