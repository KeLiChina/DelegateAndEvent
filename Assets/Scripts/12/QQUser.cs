using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QQUser : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// QQGroud.instance.loginDel += Login;
		// QQGroud.instance.messageDel += Message;
		QQGroud.instance.loginDel += delegate(string name)
		{
			Debug.Log(name + " is login !!!");
		};
		QQGroud.instance.messageDel += delegate(string name,string message)
		{
			Debug.Log(name +" say: "+message +"!!!");
		};
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void Login(string name)
	{
		
	}
	private void Message(string name, string message)
	{
		
	}
}
