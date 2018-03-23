using UnityEngine;
using System.Collections;

public class NodeB : MonoBehaviour
{
	[SerializeField]
	float debugDrawRadius = 1.0F;

	void OnDrawGizmos()
	{
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(transform.position, debugDrawRadius);
	}
}