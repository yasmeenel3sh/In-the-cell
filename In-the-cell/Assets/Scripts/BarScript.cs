using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour {

	public double fillAmount;

	public Image content;

	// Use this for initialization
	void Start () {
		fillAmount = 1;
	}
	
	// Update is called once per frame
	void Update () {
		HandleBar();
	}

	void HandleBar() {
		fillAmount = (fillAmount < 0 ? 0 : fillAmount > 1 ? 1 : fillAmount);
		content.fillAmount = (float) fillAmount;
	}


}
