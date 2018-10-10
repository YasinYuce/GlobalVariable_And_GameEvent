using UnityEngine;

public class TowerInputManager : InputManager 
{
	protected override int layerMask {
		get {
			return 1<<8;
		}
	}

	protected override void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0)) {
			RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero, 11f, layerMask);
			if (hit.transform != null) {
				//hereee
			}
		}
	}
}
