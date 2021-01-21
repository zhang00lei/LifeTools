using UnityEngine;
using System.Collections;

public class UIDialogPanel : MonoBehaviour
{
    public UILabel labInfo;
    public UIEventListener[] clickListeners;

    void Start()
    {
        for (int i = 0; i < clickListeners.Length; i++)
        {
            clickListeners[i].onClick = _objClick;
        }
    }

    private void _objClick(GameObject obj)
    {
        if (obj.name == "BtnStartAgain")
        {
            MainController.instance.uiGamePanel.Init();
        }
        gameObject.SetActive(false);
    }

    public void ShowInfo(string info)
    {
        gameObject.SetActive(true);
        labInfo.text = info;
    }
}
