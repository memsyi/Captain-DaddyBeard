﻿using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour {

	// Use this for initialization
	void Start () {
		RPCWrapper.RegisterMethod (UpdateCamera);
	}
	
	public void UpdateCamera(Vector3 pos){
		transform.position = pos;
	}
}
