using UnityEngine;
using System.Collections;

public class ScreensManager : MonoBehaviour {
	// Use this for initialization
	void Start () {
		initBottomBar();
	}
	
	// Update is called once per frame
	void Update () {
		  
	}
	void initBottomBar(){
		switch(name){
		case "MainScreen":
			UISprite MainBtn = GameObject.Find("MainBtn").GetComponent<UISprite>();
			MainBtn.spriteName = "btn_bottomBar_active";
			break;
		case "QuestScreen":
			UISprite QuestnBtn = GameObject.Find("QuestBtn").GetComponent<UISprite>();
			QuestnBtn.spriteName = "btn_bottomBar_active";
			break;
		}
	}
	void OnClick(){

	}
}
