using UnityEngine;
using System.Collections;

public class MenuSystem : MonoBehaviour {

	public MenuObject	title,
						mainMenu,
						tapToBeginText;
	public float		menuLerpSpeed,
						menuTransitionDuration;

	void Start() {
	}

	public void tapToBegin() {
		mainMenu.targetPosition = Camera.main.ViewportToScreenPoint(new Vector3(0.5f, 0.5f, 0));
		title.targetPosition = Camera.main.ViewportToScreenPoint(new Vector3(0.25f, 0.5f, 0));
		tapToBeginText.fadeTo(0, menuTransitionDuration);
		tapToBeginText.setRaycastTarget(false);
	}
}
