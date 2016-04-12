﻿using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {

    [SerializeField]
    private float DistanceToPlayerUp = 15;
    [SerializeField]
    private float DistanceToPlayerForward = 10;
    private GameObject _pObject;
    private Rigidbody _pRb;
    private float _offsetY;
    
	// Use this for initialization
	void Start () {

        _pObject = GameController.Instance.Player;
        Vector3 eurot = gameObject.transform.rotation.eulerAngles;
        eurot.y = _pObject.transform.eulerAngles.y;
        transform.rotation = Quaternion.Euler(eurot);
        gameObject.transform.position = new Vector3(_pObject.transform.position.x, transform.position.y, _pObject.transform.position.z);
        _pRb = _pObject.GetComponent<Rigidbody>();
        //  _player = GameController.Instance.Player.transform;

    }

    // Update is called once per frame
    void FixedUpdate () {
        float carSpeed = _pObject.transform.InverseTransformDirection(_pRb.velocity).z / 2;
        float camMinSpeed = 0;

        if (carSpeed > camMinSpeed) {
            _offsetY = _pRb.velocity.magnitude / 2 - camMinSpeed;
        }

        if (_offsetY > 5f) _offsetY = 5f;


        //Debug.Log(_offsetY);
       // Debug.Log(_pObject.transform.InverseTransformDirection(_pRb.velocity));
        //transform.InverseTransformDirection(rigidbody.velocity);
        if (_pObject != null)
        //if (_player != null)
        {
            gameObject.transform.position = new Vector3(_pObject.transform.position.x, 
                _pObject.transform.position.y+DistanceToPlayerUp+_offsetY, 
                _pObject.transform.position.z+ DistanceToPlayerForward);

            //transform.position = new Vector3(_player.position.x, transform.position.y, _player.position.z);
        }

	
	}
}
