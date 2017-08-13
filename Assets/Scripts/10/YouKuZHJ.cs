using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void ZHJDelegate(string info);
public class YouKuZHJ : MonoBehaviour {

	public static YouKuZHJ instance;
	private int index = 1; 
	public event ZHJDelegate zhjDel;
	void Awake()
	{
		instance = this;
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			index ++;
			zhjDel("ZHJ Update To : " + index + " Season");
			
		}
	}
	private void test(string str)
	{

	}
}
