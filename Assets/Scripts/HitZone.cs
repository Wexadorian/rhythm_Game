using UnityEngine;
using TMPro;

public class HitZone : MonoBehaviour
{
    public string rating;
    private GameObject currentNote = null;
    private HealthManager healthManager;
    public TextMeshProUGUI ratingText;

    private void Start()
    {
        healthManager = FindFirstObjectByType<HealthManager>();
    }
    private void ShowRating(string text)
    {
        ratingText.text = text;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Note"))
        {
            currentNote = other.gameObject;
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Note"))
        {
            if (other.gameObject == currentNote)
            {
                currentNote = null;
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currentNote != null)
            {
                float distance = Mathf.Abs(currentNote.transform.position.y - transform.position.y);


                Hit();

                Destroy(currentNote);
                currentNote = null;
            }
            else
            {
                Miss();
            }
        }
    }

    public void Hit()
    {
        rating = "Hit";
        Debug.Log(rating);
        ShowRating("Hit!");
    }

    public void Miss()
    {
        rating = "Miss";
        Debug.Log(rating);
        ShowRating("Miss!");
        healthManager.TakeDamage(1);
    }

    public void Miss1()
    {
        rating = "Miss";
        Debug.Log(rating);
        ShowRating("Miss!");

    }

    public void Rest()
    {
        rating = "Rest";
        Debug.Log(rating);
        ShowRating("Rest!");

    }
}
