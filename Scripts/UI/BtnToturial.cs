using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnToturial: BaseButton
{
    [SerializeField] Transform MenuToturial;
    protected override void OnClick()
    {
        Debug.Log("OnClick Button Toturial");
        transform.parent.gameObject.SetActive(false);
        this.MenuToturial.gameObject.SetActive(true);
    }
}
