﻿using UnityEngine;
using System.Collections;

public class HumanBehaviour : MonoBehaviour {

    private Animator m_anim;
	// Use this for initialization
	void Start () {

        m_anim = GetComponent<Animator>();
        m_anim.Stop();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}