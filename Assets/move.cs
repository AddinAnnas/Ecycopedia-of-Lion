using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour {

	public void JaguarM()
	{
		SceneManager.LoadScene ("Jaguar");
	}
	public void TigerM()
	{
		SceneManager.LoadScene ("Tiger");
	}
	public void LeopardM()
	{
		SceneManager.LoadScene ("Leopard");
	}
	public void LionM()
	{
		SceneManager.LoadScene ("Lion");
	}
	public void SnowLeopardM()
	{
		SceneManager.LoadScene ("SnowLeopard");
	}
	public void CheetahM()
	{
		SceneManager.LoadScene ("Cheetah");
	}

}
