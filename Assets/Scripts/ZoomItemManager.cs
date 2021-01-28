using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomItemManager : MonoBehaviour
{
    [SerializeField] GameObject panel;

    public void ShowZoomPanel()
    {
        Item item = ItemBox.instance.GetSelectedItem();
        if(item != null)
        {
            panel.SetActive(true);
        }
    }

    public void CloseZoomPanel()
    {
        panel.SetActive(false);
    }
   
}
