using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebInfo : MonoBehaviour {

	
	void Start () {
		// ShowWeb(Baidu);
		// Hello("MK");
		string name;
		name = "MK";
		name = "C#";
		Debug.Log(name);
		WebInfoDel webInfoDel;
		webInfoDel = Baidu;
		webInfoDel += Ali;
		webInfoDel += MKCode;
		webInfoDel -=Baidu;
		webInfoDel();
	}
	private delegate void WebInfoDel ();
	private void Baidu()
	{
		Debug.Log("Baidu.com");
	}
	private void Ali()
	{
		Debug.Log("Ali.com");
	}
	private void MKCode()
	{
		Debug.Log("MKCode.com");
	}

	private void ShowWeb(WebInfoDel web)
	{
		web();
	}
	private void Hello(string name)
	{
		Debug.Log("Hello" + name);
	}
}
