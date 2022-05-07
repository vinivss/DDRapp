using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ModifierValue : MonoBehaviour
{
    public GameManager gameManager;
    public TMPro.TextMeshProUGUI Text;
    private float DesiredBPM;
    private float SongBPM;
    public float nRDV;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        DesiredBPM = gameManager.desiredBPMNum;
        SongBPM = gameManager.SongBPMNum;
        if (DesiredBPM <= 0 && SongBPM > 0)
        {
            Text.text = "Error 'Your BPM' is Invalid'";
            return;
        }

        if (SongBPM <= 0 && DesiredBPM > 0)
        {
            Text.text = "Error 'Song BPM' is Invalid'";
            return;
        }
        if (SongBPM <= 0 && DesiredBPM <= 0)
        {
            Text.text = "Please Input Valid Values";
            return;
        }
        else
        {
            nRDV = DesiredBPM / SongBPM;

            float RDV = ((Mathf.Round((nRDV - 0.25f) * 2)) / 2) + 0.25f;

            Text.text = RDV.ToString();
        }
    }
}
