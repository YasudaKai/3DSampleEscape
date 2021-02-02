using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomObj : MonoBehaviour
{
    // クリックしたら、用意してあるカメラに切り替える
    [SerializeField] Camera zoomCamera;
    public void OnClickThis()
    {
        Debug.Log("カメラ切り替え");
        //zoomCamera.gameObject.SetActive(true);
        CameraManager.instance.SetZoomCamera(zoomCamera);
    }
}
