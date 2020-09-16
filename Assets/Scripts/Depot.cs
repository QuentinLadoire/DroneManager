using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Depot : MonoBehaviour
{
    [SerializeField] Vector3 startPosition = Vector3.zero;
    [SerializeField] Vector3 offset = Vector3.zero;

    Resource[] resources = new Resource[180];
    int count = 0;

    public void AddResource(Resource resource)
	{
        if (count < 180)
        {
            resource.PlaceAt(transform.position + startPosition + Vector3.Scale(offset, new Vector3(count % 60 % 6, count / 60, count % 60 / 6)), transform);

            resources[count] = resource;
            count++;
        }
	}
    public Resource GetRessource()
	{
        if (count > 0)
        {
            count--;

            var toReturn = resources[count];
            resources[count] = null;

            return toReturn;
        }

        return null;
	}
}
