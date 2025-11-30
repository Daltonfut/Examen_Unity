using TMPro;
using UnityEngine;

public class Puntos : MonoBehaviour 
{
    public static Puntos instance;
    public TMP_Text textoPuntos;
    private int puntos;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        puntos = 0;
        textoPuntos.text = "0";
    }

    public void SumaPuntos()
    {
        puntos++;
        textoPuntos.text = puntos.ToString();
    }
}