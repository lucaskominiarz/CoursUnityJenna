using System;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UIElements;

public class MultiUI : MonoBehaviour
{
    [SerializeField] private UIDocument uiDocument;

    private void Start()
    {
        Button hostbutton = uiDocument.rootVisualElement.Q<Button>("HostButton");
        Button clientbutton = uiDocument.rootVisualElement.Q<Button>("ClientButton");
        Button serverbutton = uiDocument.rootVisualElement.Q<Button>("ServerButton");
        hostbutton.clicked += OnHostClicked;
        serverbutton.clicked += OnServerClicked;
        clientbutton.clicked += OnClientCLicked;
    }

    void OnHostClicked()
    {
        NetworkManager.Singleton.StartHost();
    }

    void OnServerClicked()
    {
        NetworkManager.Singleton.StartServer();
    }

    void OnClientCLicked()
    {
        NetworkManager.Singleton.StartClient();
    }
}
