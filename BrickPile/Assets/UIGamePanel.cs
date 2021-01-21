using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UIGamePanel : MonoBehaviour
{
    public UILabel labMaxScore;
    public UILabel labScore;
    private int score;

    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            labScore.text = "得分：" + score.ToString();
        }
    }
    public float moveSpeed;
    public UIEventListener[] clickListeners;
    public GameObject itemParent;
    public UIHorItem uiHorItem;
    public GameObject objFireItem;
    public bool isGameOver;
    public readonly Vector3 firstItemPos = new Vector3(0, 403, 0);
    private List<UIHorItem> horItemList;
    private int genCount = 0;

    public enum FirDir
    {
        LEFT = 0,
        MID_LEFT = 1,
        MID_RIGHT = 2,
        RIGHT = 3,
    }

    void Start()
    {
        for (int i = 0; i < clickListeners.Length; i++)
        {
            clickListeners[i].onClick = _objClick;
        }
        Init();
    }

    public void Init()
    {
        if (horItemList != null)
        {
            while (horItemList.Count != 0)
            {
                NGUITools.Destroy(horItemList[0].gameObject);
                horItemList.RemoveAt(0);
            }
        }
        isGameOver = false;
        moveSpeed = 20;
        Score = 0;
        genCount = 0;
        horItemList = new List<UIHorItem>();
        GenerateNewItem();
        labMaxScore.text = string.Format("最高得分：{0}",PlayerPrefs.GetInt("MAX_SCORE"));
    }

    public void GenerateNewItem()
    {
        GameObject obj = NGUITools.AddChild(itemParent, uiHorItem.gameObject);
        obj.transform.localPosition = firstItemPos;
        obj.SetActive(true);
        obj.name = genCount.ToString();
        horItemList.Add(obj.GetComponent<UIHorItem>());
        genCount++;
    }

    private void _objClick(GameObject obj)
    {
        switch (obj.name)
        {
            case "SprLeft":
                _fireNewItem(FirDir.LEFT);
                break;
            case "SprMidLeft":
                _fireNewItem(FirDir.MID_LEFT);
                break;
            case "SprMidRight":
                _fireNewItem(FirDir.MID_RIGHT);
                break;
            case "SprRight":
                _fireNewItem(FirDir.RIGHT);
                break;
        }
    }

    private void _fireNewItem(FirDir firDir)
    {
        GameObject objTemp = NGUITools.AddChild(itemParent, objFireItem);
        Vector3 startPos = Vector3.zero;
        switch (firDir)
        {
            case FirDir.LEFT:
                startPos = new Vector3(-162, -360, 0);
                break;
            case FirDir.MID_LEFT:
                startPos = new Vector3(-53.5f, -360, 0);
                break;
            case FirDir.MID_RIGHT:
                startPos = new Vector3(53.5f, -360, 0);
                break;
            case FirDir.RIGHT:
                startPos = new Vector3(162, -360, 0);
                break;
        }
        objTemp.GetComponent<FireItem>().curDir = firDir;
        objTemp.transform.localPosition = startPos;
        objTemp.SetActive(true);
    }

    public UIHorItem GetHorItemByPos(Vector3 itemPos)
    {
        Vector3 tempVec;
        for (int i = 0; i < horItemList.Count; i++)
        {
            tempVec = horItemList[i].transform.localPosition;
            if (itemPos.y > tempVec.y - UIHorItem.itemHeight / 2 && itemPos.y < tempVec.y + UIHorItem.itemHeight / 2)
            {
                return horItemList[i];
            }
        }
        return null;
    }

    public UIHorItem GetHorItemByName(string itemName)
    {
        for (int i = 0; i < horItemList.Count; i++)
        {
            if (horItemList[i].name == itemName)
            {
                return horItemList[i];
            }
        }
        return null;
    }

    public void AddNewHorItem(Vector3 lastItemPos, FirDir firDir)
    {
        GameObject obj = NGUITools.AddChild(itemParent, uiHorItem.gameObject);
        obj.transform.localPosition = new Vector3(0, lastItemPos.y - UIHorItem.itemHeight, 0);
        UIHorItem horItem = obj.GetComponent<UIHorItem>();
        horItem.AddNewItem(firDir);
        obj.SetActive(true);
        obj.name = genCount.ToString();
        genCount++;
        horItemList.Insert(0, horItem);
    }

    public void AddItemNewPile(string itemName, FirDir firDir)
    {
        UIHorItem horItem = GetHorItemByName(itemName);
        if (horItem)
        {
            horItem.ShowItemByDir(firDir);
            if (horItem.IsAllItemEnable())
            {
                for (int i = 0; i < horItemList.Count; i++)
                {
                    if (horItemList[i].name != itemName)
                    {
                        Vector3 vecTemp = horItemList[i].transform.localPosition;
                        horItemList[i].transform.localPosition = new Vector3(vecTemp.x, vecTemp.y + UIHorItem.itemHeight, vecTemp.z);
                    }
                    else
                    {
                        Score = Score + 1;
                        moveSpeed += 1;
                        int temp = PlayerPrefs.GetInt("MAX_SCORE", 0);
                        if (Score > temp)
                        {
                            PlayerPrefs.SetInt("MAX_SCORE", Score);
                            labMaxScore.text = string.Format("最高得分：{0}",Score);
                        }
                        horItemList.RemoveAt(i);
                        break;
                    }
                }
                NGUITools.Destroy(horItem.gameObject);
            }
        }
    }
}
