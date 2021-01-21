using UnityEngine;
using System.Collections;

public static class Utility
{
	/// <summary>
	/// 实例化UI
	/// </summary>
	/// <param name="prefabName">Prefab name.</param>
	/// <param name="parentObj">Parent object.</param>
	public static GameObject InstanceUIObj (string prefabName, Transform parentObj)
	{
		string prefabPath = "Prefabs/UI/" + prefabName;
		if (parentObj != null) {
			GameObject obj = NGUITools.AddChild (parentObj.gameObject, Resources.Load (prefabPath, typeof(GameObject)) as GameObject);
			obj.name = prefabName;
			return obj;
		} else {
			Debug.LogError ("父物体不可为空");
			return null;
		}
	}

	/// <summary>
	/// 实例化物体
	/// </summary>
	/// <returns>The game object.</returns>
	/// <param name="prefabName">对应预制体的名字</param>
	/// <param name="parentObj">预制体的父物体（如果为null则物体创建位置为最外侧）</param>
	public static GameObject InstanceGameObject (string prefabName, Transform parentObj)
	{
		string prefabsPath = "Prefabs/" + prefabName;
		GameObject go;
		go = Resources.Load (prefabsPath, typeof(GameObject)) as GameObject;
		go = GameObject.Instantiate (go) as GameObject;

		if (parentObj != null) {
			go.transform.parent = parentObj;
		} 
		go.transform.localScale = Vector3.one;
		go.name = prefabName;
		return go;
	}

	/// <summary>
	/// 删除某个物体
	/// </summary>
	/// <param name="component">对应的组件</param>
	public static void DestroyObj (Component component)
	{
		if (component != null) {
			NGUITools.Destroy (component.gameObject);
		}
	}

	/// <summary>
	/// 删除一个物体下面的所有子物体
	/// </summary>
	/// <param name="compoent">对应的父物体组件</param>
	public static void DestroyChildrenInTransform (Component component)
	{
		if (component != null) {
			Transform parent = component.transform;
			while (parent.childCount != 0) {
				DestroyObj (parent.GetChild (0));
			}
		}
	}
}
