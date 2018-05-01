﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;

    private AudioSource aS;
	// Use this for initialization
	void Start () {
        aS = GetComponent<AudioSource>();
        InvokeRepeating("Fire", delay, fireRate);
	}
	
	// Update is called once per frame
	void Fire () {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        aS.Play();
	}
}
