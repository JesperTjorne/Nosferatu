﻿using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

    private bool m_initTile;
    [SerializeField]
    private GameObject m_HumanContainer;
    [SerializeField]
    private GameObject m_tombstones;
    private Vector3[] m_SpawnPoints;
    private GameObject[] m_Humans;
    // Use this for initialization

    void OnEnable()
    {
        InitTile();
        ResetTile();
    }

    void OnDisable()
    {

    }

    void Awake ()
    {
        InitTile();
	}

    void InitTile()
    {
        if (!m_initTile)
        {
            m_initTile = true;
            m_Humans = new GameObject[m_HumanContainer.transform.childCount];
            m_SpawnPoints = new Vector3[m_HumanContainer.transform.childCount];
            for (int i = 0; i < m_HumanContainer.transform.childCount; i++)
            {
                m_SpawnPoints[i] = m_HumanContainer.transform.GetChild(i).gameObject.transform.position;
            }
            //REMEMBER TO IMPLEMENT NEW TOMBSTONES
        }

    }

    void ResetTile()
    {
        for (int i = 0; i < m_SpawnPoints.Length; i++)
        {

        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
