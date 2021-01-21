using UnityEngine;
using System.Collections;

public class MainController : MonoBehaviour
{
    public static MainController instance;
    public UIDialogPanel uiDialogPanel;
    public UIGamePanel uiGamePanel;

    void Awake()
    {
        instance = this;
    }
}
