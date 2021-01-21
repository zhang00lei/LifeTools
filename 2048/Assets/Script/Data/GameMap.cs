using UnityEngine;
using System.Collections.Generic;
using System;

public class GameMap
{
	private int[,] itemsValue = new int[GameConfig.MAP_X, GameConfig.MAP_Y];
	List<int > randomValueList = new List<int> ();

	public GameMap ()
	{
		randomValueList.Add (2);
		randomValueList.Add (2);
		randomValueList.Add (2);
		randomValueList.Add (4);
	}

	/// <summary>
	/// 检查是否游戏结束
	/// </summary>
	/// <returns><c>true</c>, if game over was checked, <c>false</c> otherwise.</returns>
	public bool CheckGameOver ()
	{
		int currentValue;
		for (int i = 0; i < GameConfig.MAP_Y; i++) {
			for (int j = 0; j < GameConfig.MAP_X; j++) {
				currentValue = itemsValue [j, i];
				if (currentValue.Equals (0)) {
					return false;
				}
				if (currentValue.Equals (GetValue (j - 1, i))) {
					return false;
				}
				if (currentValue.Equals (GetValue (j + 1, i))) {
					return false;
				}
				if (currentValue.Equals (GetValue (j, i - 1))) {
					return false;
				}
				if (currentValue.Equals (GetValue (j, i + 1))) {
					return false;
				}
			}
		}
		return true;
	}

	/// <summary>
	/// 获取某一个位置点处的值
	/// 如果此点不存在，则返回-1
	/// </summary>
	/// <returns>The value.</returns>
	/// <param name="x">The x coordinate.</param>
	/// <param name="y">The y coordinate.</param>
	public int GetValue (int x, int y)
	{
		if (x >= 0 && x < GameConfig.MAP_X) {
			if (y >= 0 && y < GameConfig.MAP_Y) {
				return itemsValue [x, y];
			}
		}
		return -1;
	}

	/// <summary>
	/// 随机在一个位置上生成一个随机值
	/// </summary>
	public bool RandomPosValue ()
	{
		int index = GetRandomIndex ();
		if (index.Equals (-1)) {
			return false;
		}
		int randomValue = randomValueList [UnityEngine.Random.Range (0, randomValueList.Count)];
		SetInfoByIndex (index, randomValue);
		return true;
	}

	/// <summary>
	/// 随机获取一个空白点位置索引
	/// </summary>
	/// <returns>如果不存在返回-1</returns>
	public int GetRandomIndex ()
	{
		List<int> blankArea = new List<int> ();
		for (int i = 0; i < GameConfig.MAP_Y; i++) {
			for (int j = 0; j < GameConfig.MAP_X; j++) {
				if (itemsValue [j, i].Equals (0)) {
					blankArea.Add (ConvertPosToIndex (j, i));
				}
			}
		}
		if (blankArea.Count.Equals (0)) {
			return -1;
		} else {
			return blankArea [UnityEngine.Random.Range (0, blankArea.Count)];
		}
	}

	/// <summary>
	/// 获取对应的索引
	/// </summary>
	/// <param name="horIndex">列索引X</param>
	/// <param name="rowIndex">行索引Y</param>
	public int ConvertPosToIndex (int map_x, int map_y)
	{
		int index = map_x + map_y * GameConfig.MAP_Y;
		return index;
	}

	/// <summary>
	/// 索引转化为位置
	/// </summary>
	/// <returns>对应的位置</returns>
	/// <param name="index">对应的索引</param>
	public Vector2 ConvertIndexToPos (int index)
	{
		int x = index % GameConfig.MAP_X;
		int y = index / GameConfig.MAP_X;
		Vector2 pos = new Vector2 (x, y);
		return pos;
	}

	public void SetInfoByIndex (int index, int value)
	{
		Vector2 pos = ConvertIndexToPos (index);
		itemsValue [(int)(pos.x), (int)(pos.y)] = value;
	}

	public int[,] GetItemsValue ()
	{
		return itemsValue;
	}

	public bool SliderMap (EnumClass.SliderDirection direction)
	{
		int[,] itemsValueTemp = new int[GameConfig.MAP_X, GameConfig.MAP_Y]; 
		Array.Copy (itemsValue, itemsValueTemp, itemsValue.Length);
		switch (direction) {
		case EnumClass.SliderDirection.LEFT:
			_sliderLeft ();
			break;
		case EnumClass.SliderDirection.RIGHT:
			_sliderRight ();
			break;
		case EnumClass.SliderDirection.DOWN:
			_sliderDown ();
			break;
		case EnumClass.SliderDirection.UP:
			_sliderUP ();
			break;
		default :
			return false;
		}
		if (_isSliderSucess (itemsValueTemp)) {
			RandomPosValue ();
			return true;
		}
		return false;
	}

	/// <summary>
	/// 检查是否拖动成功
	/// </summary>
	/// <returns><c>true</c>, if slider sucess was ised, <c>false</c> otherwise.</returns>
	private bool _isSliderSucess (int[,]tempValues)
	{
		for (int i = 0; i < GameConfig.MAP_Y; i++) {
			for (int j = 0; j < GameConfig.MAP_X; j++) {
				if (!tempValues [j, i].Equals (itemsValue [j, i])) {
					return true;
				}
			}
		}
		return false;
	}

	/// <summary>
	/// 右侧滑动
	/// </summary>
	private void _sliderRight ()
	{
		for (int j = 0; j < GameConfig.MAP_Y; j++) {
			for (int i = GameConfig.MAP_X - 1; i >= 0; i--) {
				if (!itemsValue [i, j].Equals (0)) {
					for (int k = i - 1; k >= 0; k--) {
						if (!itemsValue [k, j].Equals (0)) {
							if (itemsValue [k, j].Equals (itemsValue [i, j])) {
								itemsValue [i, j] *= 2;
								itemsValue [k, j] = 0;
							} 
							break;
						}
					}
				}
			}
			for (int i = GameConfig.MAP_X - 1; i >= 0; i--) {
				if (itemsValue [i, j].Equals (0)) {
					for (int k = i - 1; k >= 0; k--) {
						if (!itemsValue [k, j].Equals (0)) {
							itemsValue [i, j] = itemsValue [k, j];
							itemsValue [k, j] = 0;
							break;
						}
					}
				}
			}
		}
	}

	/// <summary>
	/// 左侧滑动
	/// </summary>
	private void _sliderLeft ()
	{
		for (int j = 0; j < GameConfig.MAP_Y; j++) {
			for (int i = 0; i < GameConfig.MAP_X; i++) {
				if (!itemsValue [i, j].Equals (0)) {
					for (int k = i + 1; k < GameConfig.MAP_X; k++) {
						if (!itemsValue [k, j].Equals (0)) {
							if (itemsValue [k, j].Equals (itemsValue [i, j])) {
								itemsValue [i, j] *= 2;
								itemsValue [k, j] = 0;
							} 
							break;
						}
					}
				}
			}
			for (int i = 0; i < GameConfig.MAP_X; i++) {
				if (itemsValue [i, j].Equals (0)) {
					for (int k = i + 1; k < GameConfig.MAP_X; k++) {
						if (!itemsValue [k, j].Equals (0)) {
							itemsValue [i, j] = itemsValue [k, j];
							itemsValue [k, j] = 0;
							break;
						}
					}
				}
			}
		}
	}

	/// <summary>
	/// 顶部滑动
	/// </summary>
	private void _sliderUP ()
	{
		for (int i = 0; i < GameConfig.MAP_X; i++) {
			for (int j = 0; j < GameConfig.MAP_Y; j++) {
				if (!itemsValue [i, j].Equals (0)) {
					for (int k = j + 1; k < GameConfig.MAP_Y; k++) {
						if (!itemsValue [i, k].Equals (0)) {
							if (itemsValue [i, k].Equals (itemsValue [i, j])) {
								itemsValue [i, j] *= 2;
								itemsValue [i, k] = 0;
							}
							break;
						}
					}
				}
			}
			for (int j = 0; j < GameConfig.MAP_Y; j++) {
				if (itemsValue [i, j].Equals (0)) {
					for (int k = j + 1; k < GameConfig.MAP_Y; k++) {
						if (!itemsValue [i, k].Equals (0)) {
							itemsValue [i, j] = itemsValue [i, k];
							itemsValue [i, k] = 0;
							break;
						}
					}
				}
			}
		}
	}

	/// <summary>
	/// 底部滑动
	/// </summary>
	private void _sliderDown ()
	{
		for (int i = 0; i < GameConfig.MAP_X; i++) {
			for (int j = GameConfig.MAP_Y - 1; j >= 0; j--) {
				if (!itemsValue [i, j].Equals (0)) {
					for (int k = j - 1; k >= 0; k--) {
						if (!itemsValue [i, k].Equals (0)) {
							if (itemsValue [i, k].Equals (itemsValue [i, j])) {
								itemsValue [i, j] *= 2;
								itemsValue [i, k] = 0;
							} 
							break;
						}
					}
				}
			}
			for (int j = GameConfig.MAP_Y - 1; j >= 0; j--) {
				if (itemsValue [i, j].Equals (0)) {
					for (int k = j - 1; k >= 0; k--) {
						if (!itemsValue [i, k].Equals (0)) {
							itemsValue [i, j] = itemsValue [i, k];
							itemsValue [i, k] = 0;
							break;
						}
					}
				}
			}
		}
	}
}
