using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot[] slots;
    [SerializeField] Slot selectedSlot;
    
    

    public static ItemBox instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        slots = GetComponentsInChildren<Slot>();
    }

    public void OnSelectSlot(int position)
    {
        //一旦スロットの選択を非表示にする。
        foreach (Slot slot in slots)
        {
            slot.HideSlotBGPanel();
        }

        selectedSlot = null;
        //この処理方法がわからず、ZoomPanelが開き続けていた。

        //Slotで選択された箇所のみBackGroundをつける。
        if (slots[position].OnSelectedSlot())
        {
            selectedSlot = slots[position];
        }
        //selectedSlotに一旦itemがはいるとtrueになり続けるから
        //どこかのSlotが常に選択状態になる
        //そのせいで、他のSlotを押してもitemは入っていなくても
        //ItemBoxのSelectedSlotにはSlotが入り続ける
        //ほかのSlotを押してもZoomPanelが開いてしまう。
    }

    public Item GetSelectedItem()
    {
        if(selectedSlot != null)
        {
            return selectedSlot.GetItem();
        }
        return null;
    }

    //現状キューブを選択状態じゃないと、ギミック解除
    //できない。他のアイテムを選択状態でも解除したい
    // -> 対応する数を増やすためには（ここでは他のアイテムを
    // 持っている場合)引数を使えばいい。
    public bool TryUseItem(Item.Type type)
    {
        if(selectedSlot == null)
        {
            return false;
        }
        
        if (selectedSlot.GetItem().type == type)
        {
            Debug.Log(type);
            return true;
        }
        return false;
    }


    public void SetItem(Item item)
    {
        foreach(Slot slot in slots)
        {
            if (slot.isEmpty())
            {
                slot.SetItem(item);
                break;
            }
        }
    }
}
//Slotクラスでstatic化して使わないのは何故？
//Slotクラスは使う頻度があまりないため
//static化せずにinspecterから代入してる？

//そもそもこのItemBoxクラスを作る必要性はあるのか？
//わざわざitemをセットする際、直接Slotクラスで
//Set関数を使ってやればいいのでは？
