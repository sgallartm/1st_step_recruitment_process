using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class SCR_No_Play_Twice : MonoBehaviour
{
    public GameObject wrongBtn;                                 // it avoids to push buttons more than once before its action finishes
    public AudioSource AC;
    public AudioClip myAudio;

    public void IsPlaying() {
        AC.PlayOneShot(myAudio);
        Invoke("AudioFinished", AC.clip.length);                // launch the Audiofinished function after the audioClip lenght
    }
    void AudioFinished() {
        wrongBtn.SetActive(false); }                            // allow push buttons again
}
