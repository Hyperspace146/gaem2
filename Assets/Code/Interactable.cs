﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Interactable : MonoBehaviour
{

    public static Interactable script;


    public event Action InteractableInRange;


    private void Awake() {
        script = this;
    }

    public void OnInteractableTriggerPlayerAbilityToInteract() {

        if (InteractableInRange != null) {
            InteractableInRange(); //invoke the action
        }
    
    }

    //trigger event as "happened" if player touches
    private void OnTriggerEnter2D(Collider2D other) {

        //call the event system and tell it to dispatch the event
        script.OnInteractableTriggerPlayerAbilityToInteract();
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
