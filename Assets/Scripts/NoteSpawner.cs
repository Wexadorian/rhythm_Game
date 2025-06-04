using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public GameObject notePrefab;        // Drag the Note prefab here in the Inspector
    public Transform spawnPoint;         // Where the notes appear from
    public AudioSource musicSource;      // Your song audio source

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
            SpawnNote();
            noteIndex++;
        }
    }

    void SpawnNote()
    {
        Instantiate(notePrefab, spawnPoint.position, Quaternion.identity);
    }
}
