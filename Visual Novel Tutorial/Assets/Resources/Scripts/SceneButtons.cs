using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;

public class SceneButtons : MonoBehaviour {

	public void LoadScene(){
		//look at button name
		//get numbers from button name
		//load scene + those numbers
		string buttonName = this.name;
		string buttonNumber = Regex.Replace (buttonName, "[^0-9]", "");
		int levelNumber = int.Parse (buttonNumber);
		SceneManager.LoadScene ("Scene" + levelNumber.ToString());
	}
}
