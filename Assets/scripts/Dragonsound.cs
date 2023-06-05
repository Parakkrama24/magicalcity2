using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dragonsound : MonoBehaviour
{
    [SerializeField] private AudioSource m_AudioSource;
    [SerializeField] private Transform playerTransform;
    void Start()
    {
        m_AudioSource= GetComponent<AudioSource>();
        m_AudioSource.volume = 0f;
    }

 
    void Update()
    {
        float playerDistance= Vector3.Distance(playerTransform.position,gameObject.transform.position);
        Debug.Log(playerDistance);
        if (playerDistance <= 15)
        {
            m_AudioSource.Play();
            float upVolume = 1 / playerDistance;
            m_AudioSource.volume = upVolume;
        }
    }
}
