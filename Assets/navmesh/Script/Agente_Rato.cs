using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agente_Rato : MonoBehaviour {

	public Transform queijo;
	public NavMeshAgent rato;
	public Vector3 queijoposition;



	void Start () 
	{
			if(queijo != null)
			{
				Vector3 queijoposition = queijo.transform.position;
				rato.SetDestination(queijoposition);
			}
	}

}
