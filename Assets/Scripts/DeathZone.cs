using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    private GameObject currentNote = null;
    private HealthManager healthManager;
    private HitZone hitZone;
    public string winSceneName = "WinScene";
    public bool hit = false;

    void Start()
    {
        healthManager = FindFirstObjectByType<HealthManager>();
        hitZone = FindFirstObjectByType<HitZone>();
        if (healthManager == null)
        {
            Debug.LogError("HealthManager not found in the scene!");
        }
        if (hitZone == null)
        {
            Debug.LogError("HitZone not found in the scene!");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Note"))
        {
            currentNote = other.gameObject;
            Destroy(currentNote);

            if (healthManager != null && hitZone != null)
            {

                healthManager.TakeDamage(1);
                hitZone.Miss1();
            }
        }

        else if (other.CompareTag("BadNote"))
        {
            currentNote = other.gameObject;
            Destroy(currentNote);
            Debug.Log("BadNote");
            
        }

        else
        {
            Debug.Log("Win!");
            SceneManager.LoadScene(winSceneName);
        }
    }
}
