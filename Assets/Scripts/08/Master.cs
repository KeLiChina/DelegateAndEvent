using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void EatDelegate();
public class Master : MonoBehaviour {

	public static Master instance;
	public event EatDelegate  eatDel ;
	void Awake()
	{
		instance = this;
	}
	
	void Start () {
		WebReg webReg = new WebReg();
		webReg.UserName = "MK";
		webReg.Password = "123456";
		webReg.Show();
	}
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			EatFood();
		}
	}
	
	private void EatFood()
	{
		Debug.Log("Dinner Time");
		eatDel();
	}
}
