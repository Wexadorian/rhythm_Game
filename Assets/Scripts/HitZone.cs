using UnityEngine;
using UnityEngine.SceneManagement;

public class HitZone : MonoBehaviour
{

    private GameObject currentNote = null;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Note"))
        {
            currentNote = other.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Note") && other.gameObject == currentNote)
        {
            //fix this, stop it from outputting every time
            

            Destroy(currentNote);
            currentNote = null;
        }
    }


    void Update()
    {
        if (currentNote != null && Input.GetKeyDown(KeyCode.Space))
        {
            float distance = Mathf.Abs(currentNote.transform.position.y - transform.position.y);
            string rating;

            if (distance < 0.1f)
            {
                rating = "Perfect";
            }
            else if (distance < 0.25f)
            {
                rating = "Good";
            }
            else
            {
                rating = "Miss";
            }

            Debug.Log(rating);

            Destroy(currentNote);
            currentNote = null;
        }
    }

}
