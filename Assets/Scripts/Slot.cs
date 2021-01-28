using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    Item item;
    [SerializeField] Image image;
    [SerializeField] GameObject bgPanel;
    private void Awake()
    {
        //image = GetComponent<Image>();
        bgPanel.SetActive(false);
    }

    public bool OnSelectedSlot()
    {
        if(item == null)
        {
            return false;
        }
        bgPanel.SetActive(true);
        //戻り値がある関数でも、戻り値の型以外を
        //関数の中に記述してもOK。bool型だとbool型の値の
        //return処理をすることだけに気を取られていた。
        //こちらの関数が実行されると戻り値を利用したい関数より
        //こちらの関数の中身から先に実行される。
        //わざわざbgPanel.SetActive(true);をしたいがために
        //新しく関数ShowSlotBGPanel()を作ってしまった。
        return true;
    }

    public void HideSlotBGPanel()
    {
        bgPanel.SetActive(false);
    }

    public bool isEmpty()
    {
        if(item == null)
        {
            return true;
        }
        return false;
    }

    public void SetItem(Item item)
    {
        this.item = item;
        UpdateImage(item);
    }

    public Item GetItem()
    {
         return item;
    }

    void UpdateImage(Item item)
    {
        image.sprite = item.sprite;
    }
}
