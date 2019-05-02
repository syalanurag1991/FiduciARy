using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VuMarkIDManager : MonoBehaviour
{
	public VuMarkTarget vumark;
	private VuMarkManager mVuMarkManager;

	public List<string> foundVuMarkIDs;
	public List<Transform> foundVuMarksTransforms;

	void Start()
	{
		mVuMarkManager = TrackerManager.Instance.GetStateManager().GetVuMarkManager();
		foundVuMarkIDs = new List<string>();
		foundVuMarksTransforms = new List<Transform>();
	}

	void Update()
	{
		foundVuMarkIDs.Clear();
		foundVuMarksTransforms.Clear();
		foreach (var bhvr in mVuMarkManager.GetActiveBehaviours())
		{
			vumark = bhvr.VuMarkTarget;
			var vuID = vumark.InstanceId;
			TextMesh discoveredVuMarkID = bhvr.GetComponentInChildren<TextMesh>();
			discoveredVuMarkID.text = vuID.ToString();

			Debug.Log("Found ID number: " + vuID.ToString() + " with instance ID: " + bhvr.GetInstanceID().ToString());

			if (!foundVuMarkIDs.Contains(vuID.ToString()))
			{
				foundVuMarkIDs.Add(vuID.ToString());
				foundVuMarksTransforms.Add(bhvr.gameObject.transform);
			}
				
		}
	}

	void OnGUI()
	{
		string showVumarkIDs = "IDs found (x, y, z):\n";
		for (int i = 0; i < foundVuMarkIDs.Count; i++)
		{
			string position =
				"@ " + Math.Round(foundVuMarksTransforms[i].position.x, 2).ToString() +
				", " + Math.Round(foundVuMarksTransforms[i].position.y, 2).ToString() +
				", " + Math.Round(foundVuMarksTransforms[i].position.z, 2).ToString();
			showVumarkIDs += foundVuMarkIDs[i] + position + "\n";
		}

		GUI.contentColor = Color.black;
		GUI.Label(new Rect(10, 10, 200, 200), showVumarkIDs);
	}
}
