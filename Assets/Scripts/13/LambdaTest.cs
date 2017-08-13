using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void ShowDelegate();
public delegate void NameDelegate(string name);
public class LambdaTest : MonoBehaviour {

	public event ShowDelegate showDel;
	public event NameDelegate nameDel;
	void Start () {
		showDel += Hello;
		showDel += delegate(){
			Debug.Log("MK by nobody");
		};
		showDel +=() =>
		{
			Debug.Log("MK by Lambda");
		};
		showDel();
		// lambda

		nameDel += (string name) =>
		{
			Debug.Log("MK name is "+ name);
		};
		nameDel += (string name) => {Debug.Log("MK name is "+ name);};
		nameDel += name => {Debug.Log("MK name is "+ name);};
		nameDel += info => Debug.Log("MK name is "+ info);
		nameDel("MKKK");
	}
	private void Hello()
	{
		Debug.Log("MK");
	}
	
}
