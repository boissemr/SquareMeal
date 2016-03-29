using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuObject : MonoBehaviour {

	public MenuSystem	menuSystem;
	public bool			lockPosition,
						lockRotation,
						lockScale;

	[HideInInspector] public Vector3	targetPosition;

	Text[] textSubObjects;
	Image[] imageSubObjects;

	float opacity;

	void Start() {
		textSubObjects = GetComponentsInChildren<Text>();
		imageSubObjects = GetComponentsInChildren<Image>();
		targetPosition = transform.position;
	}

	void Update() {
		if(!lockPosition) {
			transform.position = Vector3.Lerp(transform.position, targetPosition, menuSystem.menuLerpSpeed * Time.deltaTime);
		}
	}

	public void fadeTo(float opacity, float duration) {
		foreach(Text o in textSubObjects) {
			o.CrossFadeAlpha(opacity, duration, false);
		}
		foreach(Image o in imageSubObjects) {
			o.CrossFadeAlpha(opacity, duration, false);
		}
	}

	public void setRaycastTarget(bool state) {
		foreach(Text o in textSubObjects) {
			o.raycastTarget = false;
		}
		foreach(Image o in imageSubObjects) {
			o.raycastTarget = false;
		}
	}
}
