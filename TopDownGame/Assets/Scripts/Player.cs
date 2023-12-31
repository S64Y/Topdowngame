using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //importing SceneManagement Library

public class Player : MonoBehaviour
{
    public float speed = 0.02f;
    public bool hasKey = false;

    public GameObject key;

    public static Player instance; //creating an object of the class to be findable 

    // Start is called before the first frame update
    void Start()
    {
        if (instance != null) //check if instance is in the scene 
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        GameObject.DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;

        if (Input.GetKey("w"))
        {
            //player moves up
            newPosition.y += speed;
        }

        if (Input.GetKey("s"))
        {
            //player moves down
            newPosition.y -= speed;
        }

        //player moves left
        if (Input.GetKey("a"))
        {
            newPosition.x -= speed;
        }

        //player moves right
        if (Input.GetKey("d"))

        {
            newPosition.x += speed;
        }


        transform.position = newPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Door"))
        {
            Debug.Log("hit");
            SceneManager.LoadScene(2); //access SceneManager class for LoadScene function
        }

        if (collision.gameObject.tag.Equals("Key"))
        {
            Debug.Log("obtained key");
            key.SetActive(false); //key disappears
            hasKey = true; //player has the key now
        }

        //write code for exiting second scene and go back to first scene
        if (collision.gameObject.tag.Equals("DoorTwo"))
        {
            Debug.Log("hit");
            SceneManager.LoadScene(1);
        }

        if (collision.gameObject.tag.Equals("end") && hasKey == true) //needs to satisfy both
                                                                      //conditions to enter the end door 
        {
            Debug.Log("hit");
        }

        if (collision.gameObject.tag.Equals("end") && hasKey == true)
        {
            Debug.Log("hit");
            SceneManager.LoadScene(3); //access SceneManager class for LoadScene function
        }

        if (collision.gameObject.tag.Equals("ExitOutside"))
        {
            Debug.Log("hit");
            SceneManager.LoadScene(1); //access SceneManager class for LoadScene function
        }

        if (collision.gameObject.tag.Equals("keypass"))
        {
            Debug.Log("obtained keypass");
            //key.SetActive(false); //key disappears
            hasKey = true; //player has the key now
        }

        if (collision.gameObject.tag.Equals("DoorToRoom"))
        {
            Debug.Log("hit");
            SceneManager.LoadScene(4); //access SceneManager class for LoadScene function
        }


        if (collision.gameObject.tag.Equals("Cash"))
        {
            Debug.Log("obtained CASH");
            key.SetActive(false); //CASH disappears
            hasKey = true; //player has the CASH now
        }

        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Debug.Log("hit");
            SceneManager.LoadScene(5); //access SceneManager class for LoadScene function
        }


        if (collision.gameObject.tag.Equals("CaveDoor"))
        {
            Debug.Log("hit");
            SceneManager.LoadScene(6); //access SceneManager class for LoadScene function

        }
    }
}
         
    
        
 






  
