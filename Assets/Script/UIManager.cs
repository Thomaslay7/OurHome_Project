using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

	// Use this for initialization
	public GameObject login,create,createprofil,choosetasks,choosegroceries,back,add, family/*,next,groceries,tasks,family,rewards,calendar*/;

	void Start () {
		login.transform.localScale = Vector3.zero;
		create.transform.localScale = Vector3.zero;
		family.transform.localScale = Vector3.zero;
		createprofil.transform.localScale =  Vector3.zero;
		choosetasks.transform.localScale = Vector3.zero;
		choosegroceries.transform.localScale =  Vector3.zero;
		add.transform.localScale =  Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void showOurHome()
	{

		back.transform.parent.localScale = new Vector3 (1.0f, 1.0f, 1.0f);
		Debug.Log ("check back");

	}
	public void showLogin()
	{
		
		login.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
		Debug.Log ("check login");

	}
	public void showCreateFamily()
	{

		create.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
		Debug.Log ("check create family");
	}

	public void showcreateprofile()
	{

		createprofil.transform.localScale = Vector3.one;
		Debug.Log ("check create profile");
	}
/*	public void shownext()
	{

		next.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
		Debug.Log ("check next");
	}*/
	public void showchoosetask()
	{

		choosetasks.transform.localScale = Vector3.one;
		Debug.Log ("check next TASK");
	}
	public void showchoosegroceries()
	{

		choosegroceries.transform.localScale = Vector3.one;
		Debug.Log ("check next");
	}
	public void showAdd()
	{

		add.transform.localScale = Vector3.one;
		Debug.Log ("check next");
	}
	public void showFamily()
	{

		family.transform.localScale = Vector3.one;
		Debug.Log ("check family");
	}
}
