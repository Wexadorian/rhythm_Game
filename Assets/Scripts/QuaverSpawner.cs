using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaverSpawner : MonoBehaviour
{
    public GameObject quaverPrefab;
    public GameObject quaver2Prefab;    
    public Transform spawnPoint;
    public Transform spawnPoint2;    
    public AudioSource musicSource;      

    [System.Serializable]
    public class NoteData
    {
        public float time;               // When to spawn the note (in seconds)
    }

    public List<NoteData> notes = new List<NoteData>();
    private int noteIndex = 0;

    void Update()
    {
        if (noteIndex < notes.Count && musicSource.time >= notes[noteIndex].time)
        {
            SpawnQuaver1();
            SpawnQuaver2();
            noteIndex++;
        }
    }

    void SpawnQuaver1()
    {
        Instantiate(quaverPrefab, spawnPoint.position, Quaternion.identity);

    }

    void SpawnQuaver2()
    {
        Instantiate(quaver2Prefab, spawnPoint2.position, Quaternion.identity);
    }
}
