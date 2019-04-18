﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class InteractiveObject : MonoBehaviour, IInteractive
{
    [Tooltip("Text that will display in the UI when the player looks at this object in the world.")]
    [SerializeField]
    protected string displayText = nameof(InteractiveObject);

    [SerializeField]
    private bool needsFlashlight;



    public virtual string DisplayText => displayText;
    protected AudioSource audioSource;


    protected virtual void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public virtual void InteractWith()
    {
        try
        {
        audioSource.Play();

        }
        catch (System.Exception)
        {

            throw new System.Exception("Missing AudioSource component: InteractiveObject requires an AudioSource");
        }
        Debug.Log($"Player just interacted with {gameObject.name}.");
    }
}
