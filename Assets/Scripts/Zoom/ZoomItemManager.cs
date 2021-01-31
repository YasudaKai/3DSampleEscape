using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomItemManager : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Transform objParent;
    GameObject zoomObj;

    private void Start()
    {
        panel.SetActive(false);
    }
    public void ShowZoomPanel()
    {
        Item item = ItemBox.instance.GetSelectedItem();
        if(item != null)
        {
            Destroy(zoomObj);

            panel.SetActive(true);

            GameObject zoomObjPrefab = ItemGenerater.instance.GetZoomItem(item.type);
            zoomObj = Instantiate(zoomObjPrefab, objParent);
        }
    }

    public void CloseZoomPanel()
    {
        panel.SetActive(false);
        Destroy(zoomObj);
    }

}
