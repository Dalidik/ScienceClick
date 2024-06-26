using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class Request : MonoBehaviour
{

    public void OpenRequest()
    {
        RequestWindow();
    }
    void RequestWindow()
    {
       
        if (!Permission.HasUserAuthorizedPermission(Permission.ExternalStorageRead))
        {
            Permission.RequestUserPermission(Permission.ExternalStorageRead);
        }
    }
}
