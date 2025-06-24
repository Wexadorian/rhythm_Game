using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public GameObject notePrefab;
    public GameObject winNotePrefab;
    public Transform spawnPoint;         
    public AudioSource musicSource;     

    [System.Serializable]
    public class NoteData
    {
        public float time;         
    }

    public List<NoteData> notes = new List<NoteData>();
    private int noteIndex = 0;
    public List<NoteData> winNotes = new List<NoteData>();
    private int winNoteIndex = 0;

    void Update()
    {
        if (noteIndex < notes.Count && musicSource.time >= notes[noteIndex].time)
        {
            SpawnNote();
            noteIndex++;
        }
        if (winNoteIndex < winNotes.Count && musicSource.time >= winNotes[winNoteIndex].time)
        {
            SpawnFinalWinNote();
            winNoteIndex++;
        }
    }

    void SpawnFinalWinNote()
    {
        Instantiate(winNotePrefab, spawnPoint.position, Quaternion.identity);
    }

    void SpawnNote()
    {
        Instantiate(notePrefab, spawnPoint.position, Quaternion.identity);
    }
}
