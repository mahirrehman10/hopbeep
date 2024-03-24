using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Itemcollector : MonoBehaviour
{
    private int cherries = 0;

    [SerializeField] private Text cherriesText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.CompareTag("cherry"))
        {
            collectionSoundEffect.Play();
            Destroy(Collision.gameObject);
            cherries++;
            cherriesText.text = "cherries" + cherries;
        }
    }

}

