using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMSP : MonoBehaviour
{
    public AudioSource _AudioSourceSp;

    // Start is called before the first frame update
    void Start()
    {
        _AudioSourceSp = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayMusic()
    {
        if (_AudioSourceSp != null)
            _AudioSourceSp.Play();
    }
}
