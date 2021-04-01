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
        playMusic(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playPlayerSound(int listItem)
    {
        audioPlayer.clip = playerSounds[listItem];
        audioPlayer.Play(0);
    }

    public void playEnemySound(int listItem)
    {
        audioPlayer.clip = enemySounds[listItem];
        audioPlayer.Play(0);
    }

    public void playMusic(int listItem)
    {
        audioPlayer.clip = music[listItem]; //select music from the list
        audioPlayer.Play(0);  // start play
        audioPlayer.loop = true; //make sure it's looping
    }

    public void playAmbience(int listItem)
    {
        audioPlayer.clip = ambience[listItem]; //select ambience from the list
        audioPlayer.Play(0);  // start play
        audioPlayer.loop = true; //make sure it's looping
    }
}
