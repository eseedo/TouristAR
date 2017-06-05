using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;
using Battlehub.SplineEditor;

public class PhotoManager : MonoBehaviour
{
    public bool hideGUI;
    public Texture2D texture;
    public Image screenshot;

    private int count = 1;
    private string path;


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

    private void Start()
    {
        path = Application.persistentDataPath + "/";
    }

    
    public void TakePhoto()
    {
        ScreenshotManager.SaveScreenshot("pic", "红石林" + count, "jpeg");
        if (hideGUI)
        {
            UIController.instance.HideGuideUI();
        }


        count++;
    }
    
    private void ScreenshotSaved(string path)
    {
        //TODO 显示保存成功的UI
    }

    private void ScreenshotTaken(Texture2D image)
    {
        Debug.Log("TakePhoto");
        screenshot.sprite = Sprite.Create(image, new Rect(0, 0, image.width, image.height), new Vector2(.5f, .5f));
        screenshot.color = Color.white;
        screenshot.gameObject.SetActive(true);
        
        UIController.instance.ShowGuideUI();
        UIController.instance.ShowPhotoUI();

        //更新Content，准备分享

    }


    public void ShareToWechatMoments()
    {
        
    }
}