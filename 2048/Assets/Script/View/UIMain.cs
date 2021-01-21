using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UIMain : MonoBehaviour
{
	public Transform itemParent;
	public List<UIItem> itemList = new List<UIItem> ();
	public GameMap gameMap;

	void Start ()
	{
		_instanceMap ();
		gameMap = new GameMap ();
		gameMap.RandomPosValue ();
		ResetMap ();
	}

	private void _instanceMap ()
	{
		UIItem item;
		string prefabName = "Item";
		GameObject obj;
		for (int i = 0; i < GameConfig.MAP_Y; i++) {
			for (int j = 0; j < GameConfig.MAP_X; j++) {
				obj = Utility.InstanceGameObject (prefabName, itemParent);
				obj.SetActive (true);
				item = obj.GetComponent<UIItem> ();
				item.SetInfo (new Vector2 (j, i));
				itemList.Add (item);
			}
		}
	}

	public void ResetMap ()
	{
		int index;
		int[,] itemsValue = gameMap.GetItemsValue ();
		for (int i = 0; i < GameConfig.MAP_Y; i++) {
			for (int j = 0; j < GameConfig.MAP_X; j++) {
				index = i * GameConfig.MAP_X + j;
				itemList [index].ItemValue = itemsValue [j, i];
			}
		}
	}

	private int downFrameCount;
	private Vector2 downPosition;

	private void _sliderStart (Vector2 upPosition)
	{
		float offset_x = upPosition.x - downPosition.x;
		float offset_y = upPosition.y - downPosition.y;
		if (Mathf.Abs (offset_x) > Mathf.Abs (offset_y)) {
			//横向移动
			if (Mathf.Abs (offset_x) > GameConfig.minGap) {
				if (offset_x > 0) {
					_slilderMove (EnumClass.SliderDirection.RIGHT);
				} else {
					_slilderMove (EnumClass.SliderDirection.LEFT);
				}
			}
		} else {
			//纵向移动
			if (Mathf.Abs (offset_y) > GameConfig.minGap) {
				if (offset_y > 0) {
					_slilderMove (EnumClass.SliderDirection.UP);
				} else {
					_slilderMove (EnumClass.SliderDirection.DOWN);
				}
			}
		}
	}

	void Update ()
	{
		#if UNITY_EDITOR || UNITY_STANDALONE
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			_slilderMove (EnumClass.SliderDirection.UP);
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			_slilderMove (EnumClass.SliderDirection.DOWN);
		} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			_slilderMove (EnumClass.SliderDirection.LEFT);
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			_slilderMove (EnumClass.SliderDirection.RIGHT);
		}
		#elif UNITY_ANDROID || UNITY_IPHONE
		if (Input.GetMouseButtonDown (0)) {
		downFrameCount = Time.frameCount;
		downPosition = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp (0)) {
		if (Time.frameCount - downFrameCount < GameConfig.sliderFrameCount) {
		_sliderStart (Input.mousePosition);
		}
		}
		#endif
	}

	private void _slilderMove (EnumClass.SliderDirection sliderDirection)
	{
		if (gameMap.SliderMap (sliderDirection)) {
			ResetMap ();
			if (gameMap.CheckGameOver ()) {
				MainController.instance.ShowDialog ("游戏结束", true, null);
			}
		}
	}
}
