using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
	public void PlaceAt(Vector3 position, Transform parent = null)
	{
		transform.parent = parent;
		transform.position = position;
	}
}
