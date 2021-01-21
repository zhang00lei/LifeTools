using UnityEngine;
using System.Collections;

public class UIDialog : BaseClickListener
{
	public delegate void DialogDelegate (GameObject go);

	public static event DialogDelegate dialogBtnEvent;

	public UILabel labMsg;
	public GameObject objOneBtn;
	public GameObject objTwoBtn;

	public override void _btnClickListener (GameObject go)
	{
		switch (go.name) {
		case "BtnOK":
		case "BtnConfirm":
		case "BtnCancel":
			if (dialogBtnEvent != null) {
				dialogBtnEvent (go);
			}
			MainController.instance.UiDialog = null;
			break;
		default :
			break;
		}
	}

	public void ShowMsgHaveBtn (string msg, bool isOneBtn, DialogDelegate dealMethod)
	{
		dialogBtnEvent = null;
		objOneBtn.SetActive (isOneBtn);
		objTwoBtn.SetActive (!isOneBtn);
		labMsg.text = msg;
		dialogBtnEvent = dealMethod;
	}

	public void ShowMsgNoBtn (string msg)
	{
		objOneBtn.SetActive (false);
		objTwoBtn.SetActive (false);
		labMsg.text = msg;
	}
}