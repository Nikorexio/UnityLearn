using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeValue : Singleton<VolumeValue>
{
    void Start()
    {

    }

    public void OnChange()
    {
        GameManager.Instance._audioSource.volume = GetComponent<Slider>().value;
    }

    void Update()
    {
        
    }
}
