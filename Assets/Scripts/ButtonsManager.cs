using UnityEngine;
using System.Collections;

public class ButtonsManager : MonoBehaviour {
	public enum Screens
	{
		MainScreen,
		QuestScreen,
		SummonScreen,
		PvpScreen,
		EnhanceScreen,
		MenuScreen
	}
	public Screens CurrentScreen;
	public Screens NavigateScreen;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnClick(){
		if(CurrentScreen!= NavigateScreen)
			Debug.Log("Current Screen: "+CurrentScreen+"/Next Screen: "+ NavigateScreen);
		GameObject panel2  = GameObject.Find(NavigateScreen.ToString());
		NGUITools.SetActive(panel2,true);       
		GameObject panel1  = GameObject.Find(CurrentScreen.ToString());         
		NGUITools.SetActive(panel1,false);

	}

}
