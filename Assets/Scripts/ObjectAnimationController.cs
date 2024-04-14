using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectAnimationController : MonoBehaviour
{
    public Animator animator;
    public Text buttonText;

    private bool isAnimationActive = false;

    void Start()
    {
        animator.enabled = false; // устанавливаем параметр PlayOnAwake в значение false
    }

    public void ToggleAnimation()
    {
        isAnimationActive = !isAnimationActive;

        animator.enabled = true;

        if (isAnimationActive)
        {
            animator.Play("DestructionAnimation"); // название анимации распада
            buttonText.text = "Выкл";
        }
        else
        {
            animator.Play("RestorationAnimation"); // название анимации собраться в единое
            buttonText.text = "Вкл";
        }
    }
}
