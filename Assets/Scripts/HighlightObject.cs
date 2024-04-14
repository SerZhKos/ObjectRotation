using UnityEngine;

public class HighlightObject : MonoBehaviour
{
    private Color startColor;
    private Renderer renderers;

    private void Start()
    {
        renderers = GetComponent<Renderer>();
        startColor = renderers.material.color;
    }

    private void OnMouseEnter()
    {
        renderers.material.color = Color.yellow; // изменяем цвет на желтый при наведении курсора
    }

    private void OnMouseExit()
    {
        renderers.material.color = startColor; // возвращаем исходный цвет при уходе курсора
    }
}
