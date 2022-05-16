using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] AudioClip sizzleSFX;
    [SerializeField] AudioClip explosionSFX;
    //[SerializeField] Sprite bombSprite;
    //[SerializeField] Sprite explosionSprite;

    AudioSource audioSource;
    // Start is called before the first frame update

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySizzleSFX()
    {
        if (audioSource.clip == sizzleSFX) return;
        audioSource.Stop();
        audioSource.clip = sizzleSFX;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void PlayExplosionSFX()
    {
        if (audioSource.clip == explosionSFX) return;
        audioSource.Stop();
        audioSource.clip = explosionSFX;
        audioSource.loop = false;
        audioSource.PlayOneShot(explosionSFX);
    }
}
