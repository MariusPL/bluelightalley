using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrPlayerAudioManager : MonoBehaviour {

    public AudioSource music;
    public AudioSource ambient;
    public AudioSource rain;
    public bool leftconnect;
    public bool leftoutside;
    public bool rightconnect;
    public bool rightoutside;
    public GameObject roof;
    public ParticleSystem rainparticle;

    public AudioLowPassFilter mFilter;
    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (leftconnect)
        {
            mFilter.lowpassResonanceQ = 1;
            mFilter.cutoffFrequency = 1000;
            music.volume = 0.9F;
            music.panStereo = -0.5F;
        }
        else if (rightconnect)
        {
            mFilter.lowpassResonanceQ = 1;
            mFilter.cutoffFrequency = 1000;
            music.volume = 0.7F;
            music.panStereo = 0.5F;

        }
        else if (leftoutside)
        {
            mFilter.lowpassResonanceQ = 1;
            mFilter.cutoffFrequency = 200;
            music.volume = 0.8F;
            music.panStereo = -1F;


        }
        else if (rightoutside)
        {
            mFilter.lowpassResonanceQ = 1;
            mFilter.cutoffFrequency = 600;
            music.volume = 0.5F;
            music.panStereo = 1F;

        }
        else
        {
            mFilter.cutoffFrequency = 7000;
            mFilter.lowpassResonanceQ = 0;
            music.volume = 1F;
            music.panStereo = 0;
        }


        if (rightconnect)
        {
            ambient.volume = 0.5F;
            if (!ambient.isPlaying)
            { ambient.Play(); }
            else if (ambient.mute)
            { ambient.mute = false; }
            rain.Stop();
            rainparticle.Stop();
            roof.SetActive(false);
        }
        else if (rightoutside)
        {
            ambient.volume = 1F;
            if (!rain.isPlaying)
            { rain.Play(); }
            roof.SetActive(true);
            if (!rainparticle.isPlaying)
            { rainparticle.Play(); }
            

        }
        else
        {
            roof.SetActive(false);
            ambient.mute =true;
            


        }
	}
}
