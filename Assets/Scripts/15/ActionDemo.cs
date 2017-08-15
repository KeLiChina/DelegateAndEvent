using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public delegate void MonkeyDelegate();
public class ActionDemo : MonoBehaviour {

	private MonkeyDelegate monkeyDel;
	private Action nameDel;
	private Action<int,int> myCalc;
	void Start () {
		monkeyDel = () => Debug.Log("MK");
		monkeyDel += () => {Debug.Log("MKCODE");};
		nameDel = () => Debug.Log("ACTION");
		monkeyDel();
		nameDel();
		myCalc = (int a ,int b) => Debug.Log(string.Format("{0} + {0} = {2}",a,b,a+b));
		myCalc += (a , b) => Debug.Log(string.Format("{0} * {1} = {2}",a,b,a*b));
		myCalc(2,5);
	}
	

}
