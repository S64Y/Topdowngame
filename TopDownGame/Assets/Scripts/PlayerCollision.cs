using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerCollison : MonoBehaviour
{
    private void OncollisionEnter2D(Collision2D collision)

    {
        if (collision.transform.tag == "Enemy")
        {
            PlayerManager.isGameover = true;
            gameObject.SetActive(false);
        }
    }
}
