using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NotEnoughtMoneyResponse : FadeAwayText, IResponse, IPointerDownHandler
{

	#region IResponse implementation

	public void Response ()
	{
		startFadeRoutine ();
	}

	#endregion

	#region IPointerUpHandler implementation

	public void OnPointerDown (PointerEventData eventData)
	{
		if (textToFade.enabled)
			stopFadeRoutine ();
	}

	#endregion
}
