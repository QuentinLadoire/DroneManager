using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Drone : MonoBehaviour
{
    NavMeshAgent agent = null;

	private void Awake()
	{
		agent = GetComponent<NavMeshAgent>();
	}

	public void MoveTo(Vector3 position)
	{
		agent.SetDestination(position);
	}
}
