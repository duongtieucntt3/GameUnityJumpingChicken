using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLevel3 : BaseButton
{
    protected override void OnClick()
    {
        Debug.Log("OnClick Button Level 3 ");
        SceneManager.LoadScene("Level 3");
    }
}
