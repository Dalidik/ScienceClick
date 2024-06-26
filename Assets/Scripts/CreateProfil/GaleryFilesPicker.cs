using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GaleryFilesPicker : MonoBehaviour
{
    public RawImage _myRawImage;
    public RawImage RangImage;
    public String PathString;
    private void Start()
    {
        PathString = PlayerPrefs.GetString("image_path");
        Texture2D texture = NativeGallery.LoadImageAtPath(PathString, -1, false, false);
        _myRawImage.texture = texture;
        RangImage.texture = texture;
    }

    public void PickImage(string _path)
    {
        NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((_path) =>
        {
            Debug.Log("Image path: " + _path);
            
            if (_path != null)
            {
               
                Texture2D texture = NativeGallery.LoadImageAtPath(_path, -1, false, false);
                _myRawImage.texture = texture;
                RangImage.texture = texture;
                
                PlayerPrefs.SetString("image_path", _path);
            }

            
        });
    }
    
    
}
