using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplatEffect : MonoBehaviour
{

    public AudioClip[] deathSounds;

    private void Start()
    {
        GetComponent<AudioSource>().clip = deathSounds[Random.Range(0, 2)];
        GetComponent<AudioSource>().Play();
        Invoke("ObjectDestroyerHAHAHAHAHA", 1);
    }

    private void ObjectDestroyerHAHAHAHAHA()
    {
        Destroy(gameObject);
    }
}
