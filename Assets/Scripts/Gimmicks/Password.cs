using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Password : MonoBehaviour
{
    //Passwordが正解だったら、ゲームクリア
    //Passwordの正解の数字とPasswordButtonの数字が一致
    //したらクリア

    public int[] correctPassword;
    [SerializeField] PasswordButton[] passwordButtons;

    public void CheckClear()
    {
        if (IsClear())
        {
           Debug.Log("Clear!!!");
        }
    }

    public bool IsClear()
    {
        // 全て正解していた場合クリア
        // →1つでも不正解ならダメ
        for(int i = 0; i < correctPassword.Length; i++)
        {
            if(correctPassword[i] != passwordButtons[i].number)
            {
                return false;
            }
        }
        return true;
    }
}
