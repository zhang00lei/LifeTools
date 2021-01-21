using UnityEngine;
using System.Collections;

public class UIItem : MonoBehaviour
{
	public Vector2 pos;

	public Vector2 Pos {
		get {
			return pos;
		}
		set {
			float position_X = GameConfig.firstItemPosition.x + value.x * GameConfig.itemGamp;
			float position_Y = GameConfig.firstItemPosition.y - value.y * GameConfig.itemGamp;
			MyTrans.localPosition = new Vector3 (position_X, position_Y, 0);
			pos = value;
		}
	}

	public UILabel labValue;
	public UISprite spriteBk;
	private int itemValue;

	public int ItemValue {
		get {
			return itemValue;
		}
		set {
			if (value.Equals (0)) {
				labValue.text = string.Empty;
			} else {
				labValue.text = value.ToString ();
			}
			itemValue = value;
		}
	}

	public Transform myTrans;

	public Transform MyTrans {
		get {
			if (myTrans == null) {
				myTrans = transform;
			}
			return myTrans;
		}
		set {
			myTrans = value;
		}
	}

	public void SetInfo (Vector2 pos)
	{
		MyTrans.name = string.Format ("{0}:{1}", pos.x, pos.y);
		ItemValue = 0;
		this.Pos = pos;
	}


}
