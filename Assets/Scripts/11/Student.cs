using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : MonoBehaviour {

	// Use this for initialization
	void Start () {
		MK.instance.unityDel +=QQ;
	}
	
	private void QQ(string info)
	{
		Debug.Log(gameObject.name + " " + info);
	}
}
