﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Add Attacker class parent
[RequireComponent (typeof(Attacker))]
public class Lizard : MonoBehaviour {

	private Animator anime;
	private Attacker attacker;

	// Use this for initialization
	void Start () {
		anime = GetComponent<Animator>();
		attacker = GetComponent<Attacker>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider) {
		GameObject obj = collider.gameObject;

		// Leave the method if not colliding with defender
		if (!obj.GetComponent<Defender>()) {
			return;
		}
		anime.SetBool ("isAttacking", true);
		attacker.Attack(obj);
	}
}
