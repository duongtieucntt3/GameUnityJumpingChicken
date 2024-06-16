using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel1 : BaseButton
{
    protected override void OnClick()
    {
        Debug.Log("OnClick Button Level 1 ");
        SceneManager.LoadScene("Level 1");
    }
    //public void LoadLV1(string nameLevel)
    //{
    //    Debug.Log("a");
    //    SceneManager.LoadScene("Level 1");
    //}   
}
