using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calc : MonoBehaviour {
	public delegate void CalcDelegate(int a,int b);

	void Start()
	{
		int numA = 10;
		int numB = 5;
		// JiaFa(numA,numB);
		// JianFa(numA,numB);
		// ChengFa(numA,numB);
		// ChuFa(numA,numB);
		MyCalc(numA,numB,JiaFa);
	}

	private void JiaFa(int a,int b)
	{
		Debug.Log(string.Format("{0} + {1} = {2}",a,b,a + b));
	}
	private void JianFa(int a,int b)
	{
		Debug.Log(string.Format("{0} - {1} = {2}",a,b,a - b));
	}
	private void ChengFa(int a,int b)
	{
		Debug.Log(string.Format("{0} * {1} = {2}",a,b, a*b));
	}
	private void ChuFa(int a,int b)
	{
		Debug.Log(string.Format("{0} / {1} = {2}",a,b, a/b));
	}

	private void MyCalc(int a,int b, CalcDelegate dg)
	{
		dg(a,b);
	} 

}
