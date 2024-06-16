using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Text;


public class ItemCollecter : MonoBehaviour
{
    private int score;

    [SerializeField] private Text EggsText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Egg"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            score++;
            EggsText.text = "Score: " + score;
            if (GameController.instance != null)
            {
                GameController.instance._setScore(score);
            }
        }
    }

}
