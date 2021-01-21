using UnityEngine;
using System.Collections;

public class FireItem : MonoBehaviour
{
    public UIGamePanel.FirDir curDir;
    public float moveSpeed = 500;
    private UIHorItem horItem;
    private bool itemEnable;
    private string lastGetName;

    void Update()
    {
        gameObject.transform.localPosition = 
            new Vector3(transform.localPosition.x, 
            transform.localPosition.y + Time.deltaTime * moveSpeed, 
            transform.localPosition.z);
        horItem = MainController.instance.uiGamePanel.GetHorItemByPos(transform.localPosition);
        if (gameObject.transform.localPosition.y > 404)
        {
            NGUITools.Destroy(gameObject);
            return;
        }
        if (horItem != null)
        {
            itemEnable = horItem.ShowItemEnable(curDir);
            if (itemEnable)
            {
                if (string.IsNullOrEmpty(lastGetName))
                {
                    //生成新的一行
                    MainController.instance.uiGamePanel.AddNewHorItem(horItem.transform.localPosition,curDir);
                }
                else
                {
                    //去掉一行
                    MainController.instance.uiGamePanel.AddItemNewPile(lastGetName,curDir);

                }
                NGUITools.Destroy(gameObject);
            }
            else
            {
                lastGetName = horItem.name;
            }
        }
    }
}
