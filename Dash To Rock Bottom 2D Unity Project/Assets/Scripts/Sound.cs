using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound 
{
   //This code has variables for the volume and pitch of the sounds, with a range that they can be between
    
    public string name;

    public AudioClip clip;
    
    [Range(0f, 1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;
    //This allows the sound to be looped if checked
    public bool loop;
    //The audo source won't appear in the inspector
    [HideInInspector]
    public AudioSource source;
}
