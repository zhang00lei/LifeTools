using UnityEngine;
using System.Collections;

public class MainController : MonoBehaviour
{
	private UIDialog uiDialog;

	public UIDialog UiDialog {
		get {
			if (uiDialog == null) {
				string prefabName = "UIDialog";
				GameObject obj = Utility.InstanceUIObj (prefabName, transform);
				obj.SetActive (true);
				uiDialog = obj.GetComponent <UIDialog> ();
			}
			return uiDialog;
		}
		set {
			if (value == null) {
				Utility.DestroyObj (uiDialog);
			}
			uiDialog = value;
		}
	}

	public static MainController instance;

	void Start ()
	{
		instance = this;
		Application.CaptureScreenshot ("test.png");
	}

	public void ShowDialog (string msg, bool isOneBtn, UIDialog.DialogDelegate dealMethod)
	{
		UiDialog.ShowMsgHaveBtn (msg, isOneBtn, dealMethod);
	}

	public void ShowInfo (string msg)
	{
		UiDialog.ShowMsgNoBtn (msg);
	}
}
