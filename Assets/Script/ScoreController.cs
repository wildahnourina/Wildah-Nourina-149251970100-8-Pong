using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text kiri;
    public Text kanan;

    public ScoreManager manager;

    void Update()
    {
        kiri.text = manager.leftscore.ToString();
        kanan.text = manager.rightscore.ToString();
    }
}
