using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IPAddressGame : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI targetIPText; // ��� ����������� �������� IP
    [SerializeField] private TextMeshProUGUI resultText;  // ��� ��������� ����������
    private List<string> allIPs = new List<string>(); // ������ ��� IP-������
    private string targetIP; // �������� ��������� ������� IP
    public bool isStarted = false;

    private void Start()
    {
        // ������� ��� ������� � IP ��������
        IPv4Address[] ipScripts = FindObjectsOfType<IPv4Address>();
        foreach (IPv4Address script in ipScripts)
        {
            // �������� ��� IP ������ � ������

            allIPs.Add(script.textMeshPro.text);
        }

        // �������� ������� IP-�������
        if (allIPs.Count == 0)
        {
            Debug.LogError("��� IP-������� ��� ����!");
            return;
        }
    }
    private void Update()
    {
        if (isStarted)
        {
            // �������� ��������� IP �� ������
            targetIP = allIPs[Random.Range(0, allIPs.Count)];

            // ���������� ������� IP �� ������
            targetIPText.text = "����� ���� IP: " + targetIP;
            resultText.text = ""; // ������� ����� ����������
            isStarted = false;
        }
    }

    public void CheckIPAddress(string playerChoice)
    {
        Debug.Log(playerChoice + " " + targetIP);
        // ���������� ����� ������ � ������� IP
        if (playerChoice == targetIP)
        {
            
            resultText.text = "���������! �� ����� IP: " + targetIP;
        }
        else
        {
            resultText.text = "�����������! �������� �����.";
        }
    }
}
