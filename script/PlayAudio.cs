using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource m_MyAudioSource;
    public int level1;
    public int level2;


    //Play the music
    bool m_Play;
    //Detect when you use the toggle, ensures music isn’t played multiple times
    bool m_ToggleChange;

    void Start()
    {
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
        //Ensure the toggle is set to true for the music to play at start-up
        m_Play = true;
    }

    void Update()
    {
        if (Contact1.distanceTravelled == level1)//add
        {
            m_MyAudioSource.Play();
        }
        else if (Contact1.distanceTravelled > level2)
        {
            m_MyAudioSource.Stop();
        }
    }

}