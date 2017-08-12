using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Debug.Log( Android5("XiaoMi"));
		MyAndroid("huawei",Android6);
		// Debug.Log( MyIos(6000,Ios5));
		MyIos(600,Ios5);
		
	}
	
	private int Android5(string name)
	{
		Debug.Log("Android 5 Phone: "+ name);
		return 5;
	}
	private int Android6(string name)
	{
		Debug.Log("Android 6 Phone: "+ name);
		return 6;
	}
	private string Ios5 (int price)
	{
		return "Ios5 price: " + price;
	}
	private string Ios6 (int price)
	{
		return "Ios6 price: " + price;
	}
	public delegate int Android5Delegate(string name);
	public delegate string IosDelegate(int price);
	private void MyAndroid(string name,Android5Delegate dg)
	{
		dg(name);
	}
	private void MyIos(int price,IosDelegate dg)
	{
		dg(price);
		Debug.Log(dg(price));
	}
}
