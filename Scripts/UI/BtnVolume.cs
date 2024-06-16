using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnVolume : BaseButton
{
    [SerializeField] Transform MenuAudio;
    protected override void OnClick()
    {
        Debug.Log("OnClick Button Volume");
        transform.parent.gameObject.SetActive(false);
        this.MenuAudio.gameObject.SetActive(true);
    }
}
