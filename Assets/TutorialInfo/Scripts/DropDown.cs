using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DropDown : MonoBehaviour
{
    TMPro.TMP_Dropdown thisDrop;

    private void Awake()
    {
        thisDrop = gameObject.GetComponent<TMPro.TMP_Dropdown>();
    }

}
