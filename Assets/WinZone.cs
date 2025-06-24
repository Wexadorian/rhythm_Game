using UnityEngine;
using UnityEngine.SceneManagement;

public class WinZone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("WinTrigger"))
        {
            SceneManager.LoadSceneAsync(4);

        }





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
