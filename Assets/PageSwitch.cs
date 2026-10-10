
using UnityEngine;

public class MenuAR : MonoBehaviour
{
    [Header("Telas")]
    [SerializeField] private GameObject canvasInicial;
    [SerializeField] private GameObject canvasInformacoes;
    [SerializeField] private GameObject canvasGaleria;
    [SerializeField] private GameObject canvasDetalhes;

    private void Start()
    {
        VoltarInicio();
    }

    public void VoltarInicio()
    {
        canvasInicial.SetActive(true);
        canvasInformacoes.SetActive(false);
        canvasGaleria.SetActive(false);
        canvasDetalhes.SetActive(false);
    }

    public void AbrirInformacoes()
    {
        MostrarAba(canvasInformacoes);
    }

    public void AbrirGaleria()
    {
        MostrarAba(canvasGaleria);
    }

    public void AbrirDetalhes()
    {
        MostrarAba(canvasDetalhes);
    }

    private void MostrarAba(GameObject aba)
    {
        canvasInicial.SetActive(false);
        canvasInformacoes.SetActive(false);
        canvasGaleria.SetActive(false);
        canvasDetalhes.SetActive(false);

        aba.SetActive(true);
    }
}