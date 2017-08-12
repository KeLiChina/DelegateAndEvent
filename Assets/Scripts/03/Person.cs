using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person<T,K> {

	public T info;
	public int age;
	public string name;
	public K mes;
	public void ShowPerson()
	{
		Debug.Log(string.Format("{0}---{1}---{2}----{3}",name,age,info,mes));
	}
	public T ShowInfo()
	{
		return info;
	}
	public T ShowName<T>(T name)
	{
		return name;
	}
}
