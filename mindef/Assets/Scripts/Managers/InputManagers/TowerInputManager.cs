using UnityEngine;
using System.Linq;

public class TowerInputManager : InputManager 
{
	protected override int layerMask {
		get {
			return 1<<8;
		}
	}

	TowerClickResponse _lastProcessedTower;
	protected override void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0)) {
			
			TowerClickResponse clicked = raycastForTower ();
			startTowerClickResponse (clicked);
			setLastProcessedAndInformBefore (clicked);

		}
	}

	private void setLastProcessedAndInformBefore(TowerClickResponse clicked){
		if (_lastProcessedTower != null && _lastProcessedTower != clicked)
			_lastProcessedTower.LosedFocus ();
		_lastProcessedTower = clicked;
	}

	private void startTowerClickResponse(TowerClickResponse clicked){
		if (clicked)
			clicked.Response ();
	}

	private TowerClickResponse raycastForTower(){
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		RaycastHit2D[] hits = Physics2D.RaycastAll (mousePos, Vector2.zero, 11f, layerMask);
		if (hits.Length > 0f)
			return hits.Select (x => x.transform).ToArray ().FindClosestTransformToGivenPoint (mousePos).GetComponent<TowerClickResponse> ();
		return null;
	}
}
