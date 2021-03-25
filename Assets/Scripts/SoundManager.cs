using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public List<AudioClip> playerSounds;
    public List<AudioClip> ambience;
    public List<AudioClip> enemySounds;
    public List<AudioClip> music;
    AudioSource audioPlayer;

    // Start is called before the first frame update
    void Start()
    {
        audioPlayer = this.GetComponent<AudioSource>(); //get audioplayer component from this gameobject
        audioPlayer.clip = music[0]; //select first music audio file from music list
        audioPlayer.Play(0);  // start play
        audioPlayer.loop = true; //make sure it's looping
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
