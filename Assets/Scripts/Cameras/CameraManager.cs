using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // カメラの切り替え
    // どこにどのカメラを有効にするか
    // どこに
    // ・mainの全体を回転するカメラ
    // ・ズームしたときのカメラ

    // 全体を回転するカメラのポジションを作成

    // Start is called before the first frame update
    [SerializeField] Transform[] mainCameraTransforms = default;
    int currentMainPosition;
    Camera currentCamera;
    Camera mainCamera;

    public static CameraManager instance;
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        mainCamera = Camera.main;
        currentCamera = Camera.main;

        currentMainPosition = 0;
        currentCamera.transform.position = mainCameraTransforms[currentMainPosition].position;
        currentCamera.transform.rotation = mainCameraTransforms[currentMainPosition].rotation;
    }

    public void TurnLeft()
    {
        currentMainPosition--;
        if(currentMainPosition < 0)
        {
            currentMainPosition = mainCameraTransforms.Length - 1;
        }
        currentCamera.transform.position = mainCameraTransforms[currentMainPosition].position;
        currentCamera.transform.rotation = mainCameraTransforms[currentMainPosition].rotation;
    }

    public void TurnRight()
    {
        currentMainPosition++;
        if (currentMainPosition >= mainCameraTransforms.Length)
        {
            currentMainPosition = 0;
        }
        currentCamera.transform.position = mainCameraTransforms[currentMainPosition].position;
        currentCamera.transform.rotation = mainCameraTransforms[currentMainPosition].rotation;
    }

    public void SetZoomCamera(Camera camera)
    {

        mainCamera.gameObject.SetActive(false);
        camera.gameObject.SetActive(true);
        currentCamera = camera;
    }

    public void TurnBack()
    {
        mainCamera.gameObject.SetActive(true);
        currentCamera.gameObject.SetActive(false);
        currentCamera = Camera.main;
    }

}
