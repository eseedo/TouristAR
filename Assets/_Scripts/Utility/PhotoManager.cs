using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class PhotoManager : MonoBehaviour
{
    public bool hideGUI = false;
    public Texture2D texture;
    public CanvasGroup ui;
    public Image screenshot;

    private void OnEnable()
    {
        ScreenshotManager.OnScreenshotTaken += ScreenshotTaken;
        ScreenshotManager.OnScreenshotSaved += ScreenshotSaved;
    }

    private void OnDisable()
    {
       ScreenshotManager.OnScreenshotTaken -= ScreenshotTaken;
       ScreenshotManager.OnScreenshotSaved -= ScreenshotSaved;
    }

    private void ScreenshotSaved(string s)
    {
        //TODO 显示保存成功的UI
    }

     private void ScreenshotTaken(Texture2D image)
    {
        Debug.Log("TakePhoto");
        screenshot.sprite = Sprite.Create(image, new Rect(0, 0, image.width, image.height), new Vector2(.5f, .5f));
        screenshot.color = Color.white;
        screenshot.gameObject.SetActive(true);
        ui.alpha = 1;

    }

    public void TakePhoto()
    {
        ScreenshotManager.SaveScreenshot("pic", "红石林", "jpeg");
        if (hideGUI)
        {
            ui.alpha = 0;
        }

    }
}