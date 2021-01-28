using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObj : MonoBehaviour
{
    [SerializeField] Item.Type itemType;
    Item item;


    private void Start()
    {
        //　itemTypeに応じてitemを生成する
        item = ItemGenerater.instance.Spawn(itemType);
    }

    public void OnClickObj()
    {
        //static化なしでItemBoxクラスの関数使う
        //→結果：可能
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false);
    }
}


