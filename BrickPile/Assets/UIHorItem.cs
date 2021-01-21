using UnityEngine;
using System.Collections;

public class UIHorItem : MonoBehaviour
{
    private bool isGenerateNewItem = true;
    public GameObject[] items;
    private const float deadLinePosY = -305f;
    public const float itemHeight = 40f;
    private float generateGap;

    void Start()
    {
        if (isGenerateNewItem)
        {
            HideItem();
            generateGap = MainController.instance.uiGamePanel.firstItemPos.y - itemHeight;
        }
    }

    public void HideItem()
    {
        int itemTemp = Random.Range(0, items.Length);
        items[itemTemp].SetActive(false);
    }

    public void ShowItemByDir(UIGamePanel.FirDir firDir)
    {
        items[(int)firDir].SetActive(true);
    }

    public bool ShowItemEnable(UIGamePanel.FirDir firDir)
    {
        return items[(int)firDir].activeInHierarchy;
    }

    public void AddNewItem(UIGamePanel.FirDir firDir)
    {
        ShowAllItem(false);
        items[(int)firDir].SetActive(true);
        isGenerateNewItem = false;
    }

    public void ShowAllItem(bool isShow)
    {
        for (int i = 0; i < items.Length; i++)
        {
            items[i].SetActive(isShow);
        }
    }

    public bool IsAllItemEnable()
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (!items[i].activeInHierarchy)
            {
                return false;
            }
        }
        return true;
    }

    private Vector3 localPos;

    void Update()
    {
        if (!MainController.instance.uiGamePanel.isGameOver)
        {
            localPos = gameObject.transform.localPosition;
            gameObject.transform.localPosition = new Vector3(localPos.x, 
                localPos.y - Time.deltaTime * MainController.instance.uiGamePanel.moveSpeed, 
                localPos.z);
            if (isGenerateNewItem)
            {
                if (gameObject.transform.localPosition.y < generateGap)
                {
                    MainController.instance.uiGamePanel.GenerateNewItem();
                    isGenerateNewItem = false;
                }
            }
            if (gameObject.transform.localPosition.y < deadLinePosY)
            {
                MainController.instance.uiDialogPanel.ShowInfo("游戏结束");
                MainController.instance.uiGamePanel.isGameOver = true;
            }
        }
    }
}
