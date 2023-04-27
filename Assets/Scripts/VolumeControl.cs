using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{  
    public Slider slider;
    public AudioSource component;
    public AudioClip click;
    public void playClick(){
        component.PlayOneShot(click);
    }
    private void Update() {
        component.volume = slider.value;
    }
}

