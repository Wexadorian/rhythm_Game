using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public GameObject notePrefab;
    public GameObject winNotePrefab;
    public Transform spawnPoint;         
    public AudioSource musicSource;     

    //class to store time of each note
    [System.Serializable]
    public class NoteData 
    {
        //time the note should spawn
        public float time;         
    }

    //lists of notes and spawn timing, and an index to check what note to spawn next
    public List<NoteData> notes = new List<NoteData>();
    private int noteIndex = 0;

    //list of notes that win the game, and index
    public List<NoteData> winNotes = new List<NoteData>();
    private int winNoteIndex = 0;

    void Update()
    {
        //checks if there are more notes to spawn, and that the time is at the time the next note should spawn
        if (noteIndex < notes.Count && musicSource.time >= notes[noteIndex].time)
        {
            SpawnNote();
            //increments note index by one
            noteIndex++;
        }

        //checks if there are more win notes to spawn, and that the time is at the time the next note should spawn
        if (winNoteIndex < winNotes.Count && musicSource.time >= winNotes[winNoteIndex].time)
        {
            SpawnFinalWinNote();
            //increments winNote index by one
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
