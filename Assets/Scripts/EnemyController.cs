using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
	public NavMeshAgent enemy;

	void FixedUpdate ()
	{
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		enemy.SetDestination (player.transform.position);
	}

}
