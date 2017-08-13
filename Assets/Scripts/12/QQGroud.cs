using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void LoginDelegate(string name);
public delegate void MessageDelegate(string name, string message);
public class QQGroud : MonoBehaviour {

	public static QQGroud instance;
	public event LoginDelegate loginDel;
	public event MessageDelegate messageDel;
	void Awake()
	{
		instance = this;
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.A))
		{
			loginDel("MK");
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			messageDel("MK","Welcome !");
		}
	}
}
