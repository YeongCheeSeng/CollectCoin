using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

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
