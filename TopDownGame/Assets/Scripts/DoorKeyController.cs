using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKeyController : MonoBehaviour
{

    private void OntriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            Destroy(gameObject);
        }
    }

}
