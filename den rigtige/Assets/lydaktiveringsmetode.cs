using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lydaktiveringsmetode : MonoBehaviour
{
    public AudioSource audioSource;

    void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
    }
}