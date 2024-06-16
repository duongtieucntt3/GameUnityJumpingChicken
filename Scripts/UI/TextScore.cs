using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScore : BaseText
{
    protected virtual void FixedUpdate()
    {
        this.UpdateScore();
    }
    protected virtual void UpdateScore()
    {
        this.textMeshPro.SetText(Random.Range(1, 1000).ToString());
    }
}
