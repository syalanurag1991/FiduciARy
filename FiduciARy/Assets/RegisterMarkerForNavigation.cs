using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisterMarkerForNavigation : MonoBehaviour
{
	[HideInInspector]
	public List<Transform> PointersToMarkersTransforms;

	public MeshRenderer arrowRenderer;

	private bool colorSet = false;

	void Awake()
	{
		PointersToMarkersTransforms = new List<Transform>();
	}

	void Update()
    {
		Debug.Log("Length of registered pointers: " + PointersToMarkersTransforms.Count.ToString());

		if (PointersToMarkersTransforms.Count > 0)
		{
			//arrowRenderer.material.SetColor(Shader.PropertyToID("_EmissionColor"), new Color(50, 255, 0));
			
			transform.LookAt(new Vector3(
				PointersToMarkersTransforms[0].position.x * 100f,
				PointersToMarkersTransforms[0].position.y * 100f,
				PointersToMarkersTransforms[0].position.z * 100f
				), Vector3.up);
		}
		else
		{
			//arrowRenderer.material.SetColor(Shader.PropertyToID("_EmissionColor"), new Color(255, 50, 0));
		}

	}
}
