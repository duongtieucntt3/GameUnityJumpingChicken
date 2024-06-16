using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnLevel : BaseButton
{
    [SerializeField] Transform MenuLevel;
    protected override void OnClick()
    {
        Debug.Log("OnClick Button Volume");
        transform.parent.gameObject.SetActive(false);
        this.MenuLevel.gameObject.SetActive(true);
    }
}
