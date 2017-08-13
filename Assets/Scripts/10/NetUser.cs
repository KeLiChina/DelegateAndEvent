using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetUser : MonoBehaviour {

	// Use this for initialization
	void Start () {
		YouKuZHJ.instance.zhjDel += Show;
	}
	
	private void Show(string info)
	{
		Debug.Log(gameObject.name + " Get New Mesegger" + info);
	}
}
