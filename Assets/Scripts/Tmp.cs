using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tmp : MonoBehaviour
{
	[SerializeField] new Camera camera = null;
	[SerializeField] Drone drone = null;
	[SerializeField] Depot depot = null;
	[SerializeField] Resource resourcePrefab = null;

	List<Resource> resourcePool = new List<Resource>();

	Resource GetNewResource()
	{
		Resource toReturn = null;

		if (resourcePool.Count > 0)
		{
			toReturn = resourcePool[resourcePool.Count - 1];
			resourcePool.RemoveAt(resourcePool.Count - 1);
		}
		else
		{
			toReturn = Instantiate(resourcePrefab);
		}

		return toReturn;
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			RaycastHit hit;
			if (Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition), out hit))
			{
				drone.MoveTo(hit.point);
			}
		}

		if (Input.GetKeyDown(KeyCode.KeypadPlus))
		{
			depot.AddResource(GetNewResource());
		}
		if (Input.GetKeyDown(KeyCode.KeypadMinus))
		{
			var tmp = depot.GetRessource();
			if (tmp != null)
			{
				tmp.PlaceAt(new Vector3(0, -5, 0));

				resourcePool.Add(tmp);
			}
		}
	}
}
