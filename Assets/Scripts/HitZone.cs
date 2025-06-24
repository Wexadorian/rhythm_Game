using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitZone : MonoBehaviour
{
    public string rating;
    private GameObject currentNote = null;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Note"))
        {
     
            currentNote = other.gameObject;
            Hit();
            
        }
        
        
        
        

    }





    void Update()
    {
        if (currentNote != null && Input.GetKeyDown(KeyCode.Space))
        {
            float distance = Mathf.Abs(currentNote.transform.position.y - transform.position.y);
            

           

            Destroy(currentNote);
            currentNote = null;
        }


    }

    public void Hit()
    {
        rating = "Hit";
        Debug.Log(rating);
    }
    public void Miss()
    {
   
        
            rating = "Miss";
            Debug.Log(rating);
        
       
    }
   

}
