using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_SFXController : MonoBehaviour
{

    [SerializeField] AudioSource audio_Source;
    [SerializeField] AudioClip sfx_ColorChange, sfx_Lose;
    public static sc_SFXController instance;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        audio_Source = GetComponent<AudioSource>();
    }

    public void PlayColorSFX()
    {
        audio_Source.PlayOneShot(sfx_ColorChange);
    }

    public void PlayLoseSFX()
    {
        audio_Source.PlayOneShot(sfx_Lose);
    }
}
