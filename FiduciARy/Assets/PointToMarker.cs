using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToMarker : MonoBehaviour
{
	public RegisterMarkerForNavigation ArrowHolderAttachedToARCamera;

	void Start()
	{
		ArrowHolderAttachedToARCamera.PointersToMarkersTransforms.Add(gameObject.transform);
	}

    void Update()
    {
		transform.LookAt(Camera.main.transform.position, Vector3.up);
	}

	private void OnDestroy()
	{
		if (ArrowHolderAttachedToARCamera.PointersToMarkersTransforms.Contains(gameObject.transform))
			ArrowHolderAttachedToARCamera.PointersToMarkersTransforms.Remove(gameObject.transform);
	}
}
