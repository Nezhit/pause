using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pause : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		
	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!");
		if(Time.timeScale == 0)
        {
			Time.timeScale = 1;
        }
		else 
        {
			Time.timeScale = 0;
        }
	}
	
}