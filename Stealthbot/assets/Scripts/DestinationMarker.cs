﻿using UnityEngine;using System.Collections;/// <summary>
/// Script that controls a destination marker by forcing it to its agent's destination.
/// </summary>public class DestinationMarker : MonoBehaviour{	NavMeshAgent agent;	void Start()	{		agent = GetComponentInParent<NavMeshAgent>();	}		void LateUpdate()	{		transform.position = agent.destination;		transform.rotation = Quaternion.identity;	}}