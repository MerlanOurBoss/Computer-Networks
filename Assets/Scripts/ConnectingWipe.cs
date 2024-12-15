using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConnectingWipe : MonoBehaviour
{
    public GameObject _player;
    public Animator wipes;
    public TMP_Dropdown cableTypeDropdown; // ���������� ���� ��� ���� ������
    public TMP_Dropdown standard1Dropdown; // ���������� ���� ��� ������� ����� ������
    public TMP_Dropdown standard2Dropdown; // ���������� ���� ��� ������� ����� ������
    public TextMeshProUGUI feedbackText; // ����� ���������
    public Manager man;
    public GameObject miniGame;

    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        _player = GameObject.FindGameObjectWithTag("MainCamera");
        if (_player == null)
        {
            Debug.Log("djansdojanw");
        }
        man = FindObjectOfType<Manager>();
    }

    private void Update()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void CheckConnection(string connectionType)
    {
        string cableType = cableTypeDropdown.options[cableTypeDropdown.value].text;
        string standard1 = standard1Dropdown.options[standard1Dropdown.value].text;
        string standard2 = standard2Dropdown.options[standard2Dropdown.value].text;

        bool isCorrect = false;
        Debug.Log(cableType + " " + standard1 + " " + standard2);
        switch (connectionType)
        {
            case "RouterToSwitch":
                if (cableType == "������" && standard1 == standard2)
                {
                    isCorrect = true;
                }
                else
                {
                    feedbackText.text = "��� ����������� ������� � ����������� ����� ������ ������ � ����������� �����������!";
                }
                break;

            case "ComputerToSwitch":
                if (cableType == "������" && standard1 == standard2)
                {
                    isCorrect = true;
                }
                else
                {
                    feedbackText.text = "��� ����������� ���������� � ����������� ����� ������ ������ � ����������� �����������!";
                }
                break;

            case "SwitchToSwitch":
            case "RouterToRouter":
                if (cableType == "���������" && standard1 != standard2)
                {
                    isCorrect = true;
                }
                else
                {
                    feedbackText.text = "��� ����������� ���������� ��������� ����� ��������� ������ � ������� �����������!";
                }
                break;
        }

        if (isCorrect)
        {
            man.score += 1;
            wipes.Play("InsertCabel");
            StartCoroutine(WaitForFiveSeconds());
        }
    }

    private IEnumerator WaitForFiveSeconds()
    {
        // ��� 5 ������
        yield return new WaitForSeconds(5f);

        _player.SetActive(true);
        miniGame.SetActive(false);
    }

    private void ReturnToPlayer()
    {
        _player.SetActive(true);
        miniGame.SetActive(false);
    }
}
