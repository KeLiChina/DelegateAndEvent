using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebReg  {

	private string userName;
	private string password;
	public string UserName 
	{
		get{return userName;}
		set{
			if (value == "Admin" || value == "admin")
			{
				userName = "Unligo";
			}
			else
				userName = value;
				}
	}
	public string Password  
	{
		get{return password;}
		set{
			if(value.Length <= 3)
			{
				password = "password length must be over 3";
			}
			else
				password = value;}
	}

	public void Show()
	{
		Debug.Log(string.Format("{0}---{1}",userName,password));
	}
}
