using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IPAddressGame : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI targetIPText; // Для отображения целевого IP
    [SerializeField] private TextMeshProUGUI resultText;  // Для подсказки результата
    private List<string> allIPs = new List<string>(); // Хранит все IP-адреса
    private string targetIP; // Случайно выбранный целевой IP
    public bool isStarted = false;

    private void Start()
    {
        // Находим все объекты с IP адресами
        IPv4Address[] ipScripts = FindObjectsOfType<IPv4Address>();
        foreach (IPv4Address script in ipScripts)
        {
            // Собираем все IP адреса в список

            allIPs.Add(script.textMeshPro.text);
        }

        // Проверка наличия IP-адресов
        if (allIPs.Count == 0)
        {
            Debug.LogError("Нет IP-адресов для игры!");
            return;
        }
    }
    private void Update()
    {
        if (isStarted)
        {
            // Выбираем случайный IP из списка
            targetIP = allIPs[Random.Range(0, allIPs.Count)];

            // Отображаем целевой IP на экране
            targetIPText.text = "Найди этот IP: " + targetIP;
            resultText.text = ""; // Очищаем текст результата
            isStarted = false;
        }
    }

    public void CheckIPAddress(string playerChoice)
    {
        Debug.Log(playerChoice + " " + targetIP);
        // Сравниваем выбор игрока с целевым IP
        if (playerChoice == targetIP)
        {
            
            resultText.text = "Правильно! Ты нашел IP: " + targetIP;
        }
        else
        {
            resultText.text = "Неправильно! Попробуй снова.";
        }
    }
}
