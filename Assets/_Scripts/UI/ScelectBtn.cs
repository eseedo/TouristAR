using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ScelectBtn : MonoBehaviour
{
    public RectTransform routineImg;
    public Sprite btnPressed;
    public Sprite btnUnPressed;
    private bool isShowing;

    public void OnPressed()
    {
        if (isShowing)
        {
            GetComponent<Image>().sprite = btnUnPressed;
//            routineImg.DOAnchorPosY(0.5f, 640);
            StartCoroutine(ScrollUI(640));
            isShowing = false;
        }
        else
        {
            GetComponent<Image>().sprite = btnPressed;
//            routineImg.DOMoveY(0.5f, 225);
            StartCoroutine(ScrollUI(225));

            isShowing = true;
        }
    }

    IEnumerator ScrollUI(float endValue)
    {
        if (routineImg.position.y < endValue)
        {
            while (routineImg.position.y < endValue)
            {
                routineImg.position += Vector3.up * (endValue / 15);
                yield return new WaitForSeconds(0.01f);
            }
        }
        else
        {
            while (routineImg.position.y >= endValue)
            {
                routineImg.position -= Vector3.up * (endValue / 15);
                yield return new WaitForSeconds(0.01f);
            }
        }

    }
}