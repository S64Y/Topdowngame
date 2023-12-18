using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int letters = 0;

    [SerializeField] private Text gemsText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GEM"))
        {
            Destroy(collision.gameObject);
            letters++;
            gemsText.text = "Letters: " + letters;
        }

    }




}
