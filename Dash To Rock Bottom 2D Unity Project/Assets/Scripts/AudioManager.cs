using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    public static AudioManager instance;
    
    // Start is called before the first frame update
    void Awake()
    {

       //Destory the audio manager in any scene that is moved into from the starting one
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        //Dont destory the original auido manager when a scene is loaded
        DontDestroyOnLoad(gameObject);
        
        foreach (Sound s in sounds)
        {
           //Sound array
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start()
    {
        //Plays the background music upon the game starting
        Play("GameBackgroundMusic");
    }

   public void Play (string name)
    {
        //If the sound name is typed wrong in Unity, a warning message is put to the console
        Sound s = Array.Find(sounds, sound => sound.name == name);
       if (s == null)
        {
            Debug.LogWarning("Sound: " + name + "not found!");
            return;
        }
        
        s.source.Play();
    }
}
