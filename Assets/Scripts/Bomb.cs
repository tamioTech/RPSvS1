using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] AudioClip sizzleSFX;
    [SerializeField] AudioClip explosionSFX;
    [SerializeField] Transform fuseTr;
    [SerializeField] Transform handleTr;
    //[SerializeField] Sprite bombSprite;
    //[SerializeField] Sprite explosionSprite;

    AudioSource audioSource;
    Camera camera;

    int x, y;
    // Start is called before the first frame update

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        camera = GetComponent<Camera>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FusePosition()
    {
        //Vector2 newPos = camera.WorldToScreenPoint(handleTr.position);
        //fuseTr.position = newPos/cg.canvas;
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
