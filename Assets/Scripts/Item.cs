using System;
using UnityEngine;

[Serializable]
public class Item 
{
    //　列挙型：種類を列挙する
    public enum Type
    {
        Cube,
        Ball,
    }

    public Type type; //種類
    public Sprite sprite;　//Slotに表示する画像

    public Item(Type type, Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}
