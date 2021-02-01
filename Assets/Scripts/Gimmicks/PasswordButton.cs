using UnityEngine;
using TMPro;

public class PasswordButton : MonoBehaviour
{
    public int number;
    [SerializeField] TMP_Text tmpText;

    void Start()
    {
        number = 0;
        tmpText.text = number.ToString();
    }


    public void OnClick()
    {
        number++;
        if(number > 9)
        {
            number = 1;
        }
        tmpText.text = number.ToString();
    }
}
