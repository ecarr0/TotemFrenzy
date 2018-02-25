using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class AudioScript : MonoBehaviour {

	static bool AudioBegin = false;
    new AudioSource audio;
    void Awake()
    {
        audio = GetComponent<AudioSource>();
        if (!AudioBegin)
        {
            audio.Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
    void Update()
    {
        string name = SceneManager.GetActiveScene().name;
        if (name == "outside")
        {
            AudioBegin = false;
            Destroy(this.gameObject);
        }
    }
}
