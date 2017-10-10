using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSavings : SavableSingleton<PlayerSavings> {

	public string playerName = "";
	public int experience = 0;
	public List<ItemNames> items = new List<ItemNames>();
	public List<int> itemNumber = new List<int>();

	public enum ItemNames {
		Hoge,
		Fuga
	}

	void SaveScore(string playerName){
		PlayerSavings.Instance.playerName = "Cat";
		PlayerSavings.Instance.experience = 10;
		PlayerSavings.Instance.items.Add (PlayerSavings.ItemNames.Hoge);
		PlayerSavings.Instance.items.Add (PlayerSavings.ItemNames.Fuga);
		PlayerSavings.Instance.Save ();
	}
	void SaveScores(int score){
		PlayerSavings.Instance.playerName = "Cat";
		PlayerSavings.Instance.experience = 10;
		PlayerSavings.Instance.items.Add (PlayerSavings.ItemNames.Hoge);
		PlayerSavings.Instance.items.Add (PlayerSavings.ItemNames.Fuga);
		PlayerSavings.Instance.Save ();
	}


	/*	void SaveScore(int score){
		PlayerSavings.Instance.playerName = "Cat";
		PlayerSavings.Instance.experience = 10;
		PlayerSavings.Instance.items.Add (PlayerSavings.ItemNames.Hoge);
		PlayerSavings.Instance.items.Add (PlayerSavings.ItemNames.Fuga);
		PlayerSavings.Instance.Save ();
	}

Debug.Log(TestSaveData.Instance.playerName);
	*/

}