using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QQUser : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//普通方法
		// QQGroud.instance.loginDel += Login;
		// QQGroud.instance.messageDel += Message;

		//匿名方法
		// QQGroud.instance.loginDel += delegate(string name)
		// {
		// 	Debug.Log(name + " is login !!!");
		// };
		// QQGroud.instance.messageDel += delegate(string name,string message)
		// {
		// 	Debug.Log(name +" say: "+message +"!!!");
		// };

		// Lambda表达方式
		QQGroud.instance.loginDel += (string name) => 
		{
			Debug.Log(name + " Have Been Login By Lambda");
		};
		QQGroud.instance.messageDel += (string name,string message) => 
		{
			Debug.Log(name + " Say " + message + " by Lambda");
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
