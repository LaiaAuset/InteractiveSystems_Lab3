using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance; 

    public AudioClip GameCoin; 
   

    private Vector3 cameraPosition; 

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this; 
        cameraPosition = Camera.main.transform.position; 
    }
    private void PlaySound(AudioClip clip) // 1
    {
        AudioSource.PlayClipAtPoint(clip, cameraPosition); // 2
    }

    public void PlayGameCoin()
    {
        PlaySound(GameCoin);
    }
}
