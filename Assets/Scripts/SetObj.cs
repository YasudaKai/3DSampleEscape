using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObj : MonoBehaviour
{
    [SerializeField] Item.Type useItem;
    [SerializeField] GameObject setObj;
   public void OnClickThis()
   {
        bool hasItem = ItemBox.instance.TryUseItem(useItem);
        if(hasItem)
        {
            setObj.SetActive(true);
        }
    }
}
