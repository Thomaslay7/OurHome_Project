using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	// Use this for initialization
	public GameObject login,create,createprofil,choosetasks,choosegroceries,back,adds, family, groceries,tasks,rewards,calendar,setting;
	public GameObject btnNext,btnBack, myaccount,sharepanel;

	void Start () {
		sharepanel.transform.localScale = Vector3.zero;
		setting.transform.localScale = Vector3.zero;
		login.transform.localScale = Vector3.zero;
		create.transform.localScale = Vector3.zero;
		family.transform.localScale = Vector3.zero;
		createprofil.transform.localScale =  Vector3.zero;
		choosetasks.transform.localScale = Vector3.zero;
		choosegroceries.transform.localScale =  Vector3.zero;
		adds.transform.localScale =  Vector3.zero;
		groceries.transform.localScale = Vector3.zero;
		tasks.transform.localScale = Vector3.zero;
		calendar.transform.localScale = Vector3.zero;
		rewards.transform.localScale = Vector3.zero;
		groceries.transform.localScale = Vector3.zero;
		myaccount.transform.localScale = Vector3.zero;
		//picture.SetActive(false);
	}

	public void HideAll()
	{

		sharepanel.transform.localScale = Vector3.zero;
		//picture.SetActive(false);
		setting.transform.localScale = Vector3.zero;
		login.transform.localScale = Vector3.zero;
		create.transform.localScale = Vector3.zero;
		family.transform.localScale = Vector3.zero;
		createprofil.transform.localScale =  Vector3.zero;
		choosetasks.transform.localScale = Vector3.zero;
		choosegroceries.transform.localScale =  Vector3.zero;
		adds.transform.localScale =  Vector3.zero;
		groceries.transform.localScale = Vector3.zero;
		tasks.transform.localScale = Vector3.zero;
		calendar.transform.localScale = Vector3.zero;
		rewards.transform.localScale = Vector3.zero;
		groceries.transform.localScale = Vector3.zero;
		myaccount.transform.localScale = Vector3.zero;
	}
	public void showOurHome()
	{
		HideAll ();
		back.transform.parent.localScale = new Vector3 (1.0f, 1.0f, 1.0f);
		Debug.Log ("check back");

	}
	public void showLogin()
	{
		HideAll ();
		login.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
		Debug.Log ("check login");

	}
	public void showCreateFamily()
	{
		HideAll();
		create.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
		Debug.Log ("check create family");
	}

	public void showcreateprofile()
	{
		HideAll();

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

		HideAll ();
		choosetasks.transform.localScale = Vector3.one;
		Debug.Log ("check next TASK");
	}
	public void showchoosegroceries()
	{

		HideAll ();
		choosegroceries.transform.localScale = Vector3.one;
		Debug.Log ("check next");
	}
	public void showAdd()
	{

		HideAll ();
		adds.transform.localScale = Vector3.one;
		Debug.Log ("check next");
	}
	public void showFamily()
	{

		HideAll ();
		family.transform.localScale = Vector3.one;
		Debug.Log ("check family");
	}
	public void showCalendar()
	{

		HideAll ();
		calendar.transform.localScale = Vector3.one;
		Debug.Log ("check calendar family");
	}
	public void showTasks()
	{

		HideAll ();
		tasks.transform.localScale = Vector3.one;
		Debug.Log ("check family tasks");
	}
	public void showRewards()
	{

		HideAll ();
		rewards.transform.localScale = Vector3.one;
		Debug.Log ("check family rewards");
	}
	public void showGroceries()
	{

		HideAll ();
		groceries.transform.localScale = Vector3.one;
		Debug.Log ("check family tasks");
	}

	public void showSetting()
	{

		HideAll ();
		setting.transform.localScale = Vector3.one;
		Debug.Log ("check family");
	}
	public void showAddProfilFamily()
	{

		HideAll ();
		btnBack.transform.localScale=Vector3.zero;
		btnNext.transform.localScale=Vector3.zero;
		createprofil.transform.localScale = Vector3.one;
		Debug.Log ("check family");
	}
	/*public void slide()
	{
		HideAll ();
		picture.SetActive(true);
	}*/
	public void showMyAccounts()
	{

		HideAll ();
		myaccount.transform.localScale = Vector3.one;
		Debug.Log ("check My account");
	}
	public void showSharePanel()
	{

		HideAll ();
		setting.transform.localScale = Vector3.one;
		sharepanel.transform.localScale = Vector3.one;
		Debug.Log ("check panel");
	}
}
