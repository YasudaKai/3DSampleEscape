using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestGimmick : MonoBehaviour
{
    public void Open()
    {
        GetComponent<Animation>().Play();
    }
}
