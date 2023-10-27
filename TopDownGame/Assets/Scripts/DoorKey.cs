using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey : MonoBehaviour
{

    public AudioSource DoorKeySound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OncollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("obtained DoorKey");
            DoorKeySound.Play();
            Destroy(this.gameObject); //destroy DoorKey object
        }
    }
}
