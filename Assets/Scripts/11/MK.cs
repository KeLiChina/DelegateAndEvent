using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public delegate void UnityDelegate (string info);
public class MK : MonoBehaviour {
	public static MK instance;
	private string info = "C# Delegate And Event have been Updated!";
	public event UnityDelegate unityDel;
	void Awake()
	{
		instance = this;
	}
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			unityDel(info);
		}
	}
}
