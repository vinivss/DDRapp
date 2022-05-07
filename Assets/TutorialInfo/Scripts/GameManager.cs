using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public GameObject desiredBPM;

    public GameObject SongBPM;
    private string desiredBPMTxT;
    private string SongBPMTxT;

    public float desiredBPMNum;
    public float SongBPMNum;

    private void Update()
    {
        desiredBPMTxT = desiredBPM.GetComponent<TMPro.TMP_InputField>().text;
        SongBPMTxT = SongBPM.GetComponent<TMPro.TMP_InputField>().text;

        float.TryParse(desiredBPMTxT, out desiredBPMNum);
        float.TryParse(SongBPMTxT, out SongBPMNum);
    }
}
