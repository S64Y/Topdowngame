using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameover;
    public GameObject gameoverscreen;
    public void Awake()
    {
        isGameover= false;
    }
    // Start is called before the first frame update 
    void start()
    {


    }

    // Update is called once per frame 
    void Update()
    {
        if (isGameover)
        {
            gameoverscreen.SetActive(true);
        }
    }
}
