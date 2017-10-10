using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//スタート画面からカレンダーへ移行
	public void ChangeCalenderScene(){
		SceneManager.LoadScene ("Calender");
		Debug.Log ("CalenderScene");
	}
	//ボーナス画面へ移行
	public void ChangeBonusScene(){
		SceneManager.LoadScene ("Bonus");
		Debug.Log ("changeBonusScene");
	}
	//設定画面へ移行
	public void ChangeSettingScene(){
		SceneManager.LoadScene ("Settings");
		Debug.Log ("changeSettingScene");
	}
}
