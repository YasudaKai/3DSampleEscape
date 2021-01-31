using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleGimmicks : MonoBehaviour
{
    [SerializeField] Item.Type clearItem;
    public void OnClickObj()
    {
        bool hasClearItem = ItemBox.instance.TryUseItem(clearItem);
        if(hasClearItem == true)
        {
            gameObject.SetActive(false);
        }
    }
}
