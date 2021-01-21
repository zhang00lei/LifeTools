using UnityEngine;
using System.Collections;

public abstract class BaseClickListener : MonoBehaviour
{
	public UIEventListener[] btnListeners;
	protected Transform myTrans;

	protected void Start ()
	{
		myTrans = transform;
		_addClickListener ();
	}

	protected void _addClickListener ()
	{
		UIButtonScale scale;
		for (int i = 0; i < btnListeners.Length; i++) {
			btnListeners [i].onClick += _btnClickListener;
			if (!btnListeners [i].transform.name.Contains ("NoScale")) {
				if (btnListeners [i].GetComponent <UIButtonScale > () == null) {
					scale = btnListeners [i].gameObject.AddComponent <UIButtonScale> ();
					scale.tweenTarget = btnListeners [i].transform;
				}
			}
		}
	}

	public abstract void  _btnClickListener (GameObject go);
}
