using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GSQfirst :MonoBehaviour {

	public void GreatCat()
	{
//		AdController.instance.ShowVideoOrInterstitialAD();
		SceneManager.LoadScene ("GreatCat");
		
	}
	public void SmallCat()
	{
		SceneManager.LoadScene ("SmallCat");
	}
	public void Exitt()
	{
	//	AdController.instance.ShowVideoOrInterstitialAD();
		Application.Quit ();
		//AdsManager.instance.Adsver ();
	}
	 void Awake()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

}
