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
        animator.enabled = false; // ������������� �������� PlayOnAwake � �������� false
    }

    public void ToggleAnimation()
    {
        isAnimationActive = !isAnimationActive;

        animator.enabled = true;

        if (isAnimationActive)
        {
            animator.Play("DestructionAnimation"); // �������� �������� �������
            buttonText.text = "����";
        }
        else
        {
            animator.Play("RestorationAnimation"); // �������� �������� ��������� � ������
            buttonText.text = "���";
        }
    }
}
