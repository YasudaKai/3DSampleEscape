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
            Debug.Log("Clear");
            gameObject.SetActive(false);
        }
    }

    private void Start()
    {
        Debug.Log(clearItem);
    }
    //アイテムがクリックされたかどうか
    //特定のアイテムを持っているか
}
