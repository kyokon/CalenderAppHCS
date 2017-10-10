using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class CalendarButton : MonoBehaviour {
	public Calendermanagers calendar;
	public Button button;
	public Text text;
	public static int SceneNumber;

	/// <summary>マスの日時</summary>
	[HideInInspector]public DateTime dateValue;
	/// <summary>ボタン番号</summary>
	[HideInInspector]public int index;


	public GameObject gameManager;

	// Use this for initialization
	void Start () {
		buttonstarts ();

		gameManager = GameObject.Find ("Gamemanager");
	}

	/// <summary>色を指定</summary>
	Color GetColorDayOfWeek(DayOfWeek dayOfWeek)
	{
		if (dateValue.Month == calendar.current.Month)
		{
			switch (dayOfWeek)
			{
			case DayOfWeek.Saturday:
				return Color.blue;
			case DayOfWeek.Sunday:
				return Color.red;
			default:
				Color dcolor = Colors.Alpha(Colors.Orangered,1f);
				return dcolor;
			}
		}
		else
		{
			return Color.gray;
		}
	}


	public void buttonstarts(){
		calendar = FindObjectOfType<Calendermanagers>();
		button = GetComponent<Button>();
		button.onClick.AddListener(ChangeScenesWhenButtonClick);
		text = button.GetComponentInChildren<Text>();
		text.fontSize = 15;

		this.ObserveEveryValueChanged(date => date.dateValue)
			.Subscribe(_ =>
				{
					text.text = dateValue.isDefault() ? "" : dateValue.Day.ToString();
					text.color = GetColorDayOfWeek(dateValue.DayOfWeek);
					if(dateValue == DateTime.Today)
					{
						GetComponent<Image>().enabled = true;
					}
					else
					{
						//GetComponent<Image>().enabled = false;
					}
				});
	}

	//日付ボタンが押された際、ボーナスシーンへ移行するための関数
	public void ChangeScenesWhenButtonClick(){
		SceneNumber = 1;
		Debug.Log (SceneNumber);
		gameManager.GetComponent<scenemanager>().ChangeBonusScene();
	}


}


/// <summary>DateTime拡張</summary>
public static class DateTimeExtension
{
	/// <summary>デフォルトの0001/01/01が入る</summary>
	static DateTime Default = new DateTime();
	/// <summary>デフォルト値と比較</summary>
	public static bool isDefault(this DateTime d) { return d.Equals(Default); }
}
	
