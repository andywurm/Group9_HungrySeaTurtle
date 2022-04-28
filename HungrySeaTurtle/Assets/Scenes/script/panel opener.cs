using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelopener : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }
}
