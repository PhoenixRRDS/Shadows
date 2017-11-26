using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class WaveMusic : MonoBehaviour {

    [SerializeField]
    AudioClip[] musics;
    AudioSource audio;

    float approxSecondsToFade;

    bool isFadingIn, isFadingOut;

    public static WaveMusic instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("> 1 wave music");
        }
        else {
            instance = this;
        }
    }

	// Use this for initialization
	void Start () {
        isFadingIn = false;
        isFadingOut = false;

        audio = GetComponent<AudioSource>();
        approxSecondsToFade = 1.0f;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (isFadingIn) {
            if (audio.volume < 1.0f)
            {
                audio.volume = audio.volume + (Time.deltaTime / (approxSecondsToFade + 1));
            }
            else {
                isFadingIn = false;
            }
        }

        if (isFadingOut)
        {
            if (audio.volume > 0.0f)
            {
                audio.volume = audio.volume - (Time.deltaTime / (approxSecondsToFade + 1));
            }
            else
            {
                isFadingOut = false;
            }
        }
    }

    public void StartWaveSound()
    {
        audio.clip = musics[Random.Range(0, musics.Length - 1)];
        audio.Play();
        isFadingIn = true;
    }

    public void StopWaveSound()
    {
        isFadingOut = true;
    }
}
