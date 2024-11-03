using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioplay : MonoBehaviour
{
    public AudioSource audioSource;
    void OnTriggerEnter(Collider other)
{
    if (other.tag == "Player" && !audioSource.isPlaying)
    {
        Debug.Log("Player entered the trigger.");
    audioSource.Play();
    }
    
}

void OnTriggerExit(Collider other)
{
if (other.tag == "Player" && audioSource.isPlaying)
{
    Debug.Log("Player exit the trigger.");
    audioSource.Stop();
}
}

}
    

