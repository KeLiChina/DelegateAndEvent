using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void HPDelegate(int value);
public delegate void MPDelegate(float value);

public class PlayerController : MonoBehaviour {
	
	public static PlayerController instance;
	public event HPDelegate hpDel;
	public event MPDelegate mpDel;
	private int hp;
	private float mp;
	public int Hp 
	{
		get{return hp;}
		set{hp = value;}
	}
	public float Mp  
	{
		get{return mp;}
		set{mp =value;}
	}
	void Awake()
	{
		instance = this;
	}
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.A))
		{
			Hp --;
			Debug.Log("HP: " + Hp);
			// update hp ui
			hpDel(Hp);
		}
		if(Input.GetKeyDown(KeyCode.B))
		{
			Mp --;
			Debug.Log("MP: " + Mp);
			// update mp ui
			mpDel(Mp);
		}
	}
}
