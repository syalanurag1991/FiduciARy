using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VuMarkID : MonoBehaviour
{

	public int identity = 1357;

    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
		Debug.Log("Instance ID = " + gameObject.GetInstanceID().ToString());
	}
}
