using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnBack: BaseButton
{
    [SerializeField] Transform MainMenu;
    protected override void OnClick()
    {
        Debug.Log("OnClick Button Back");
        transform.parent.gameObject.SetActive(false);
        this.MainMenu.gameObject.SetActive(true);
    }
}
