using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel2 : BaseButton
{
    protected override void OnClick()
    {
        Debug.Log("OnClick Button Level 2 ");
        SceneManager.LoadScene("Level 2");
    }
    //public void LoadLV2(string nameLevel)
    //{
    //    SceneManager.LoadScene("Level 2");
    //}
}
