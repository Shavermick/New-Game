using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

	public Button ContButton;

	// Главное меню
	public GameObject MainMenu;

	[Space(15)]

	#region Для работы с опциями

	public GameObject SettingPanel;
	
	public GameObject MusicSetting;
	
	public GameObject VideoSetting;
	
	public GameObject ManagerSetting;

	#endregion

	[Space(15)]

	[SerializeField] private int kolSave;

	void Awake()
	{
		// Есть ли каталог
		if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Save"))
		{
			// Есть ли сохранения
			string[] fileName = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Save");

			foreach (string s in fileName)
			{
				kolSave++;
			}

			if (kolSave > 0)
			{
				ContButton.gameObject.SetActive(true);
			}
			else
			{
				ContButton.gameObject.SetActive(false);
			}
		}
		else
		{
			Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Save"); // Если нет,то создадим его
		}
	}

	#region Диалоговое окно

	// Показ диалогового окна
	public void ExitGameButton(GameObject Dialog)
	{
		Dialog.SetActive(true);
	}

	// Если нажали да
	public void DialogYes()
	{
		Application.Quit();
	}

	// Если нажали нет
	public void DialogNo(GameObject Dialog)
	{
		Dialog.SetActive(false);
	}

	#endregion

	#region Опции игры

	// Открытие опций
	public void OpentPanelOptions()
	{
		SettingPanel.SetActive(!SettingPanel.activeSelf);
		MainMenu.SetActive(!MainMenu.activeSelf);


	}

	// Открытие параметров видео
	public void OpenSettingVideo()
	{

	}

	// ОТкрытие параметра звука
	public void OpenSettingMusic()
	{

	}

	// Открытие параметров управления
	public void OpenSettingManager()
	{

	}

	// Закрыть панель
	public void CloseSetting()
	{
		SettingPanel.SetActive(!SettingPanel.activeSelf);
		MainMenu.SetActive(!MainMenu.activeSelf);
	}

	// Сохранить настройки
	public void SaveSetting()
	{

	}

	#endregion

	void Start()
    {
		// Отключение панели
		SettingPanel.SetActive(!SettingPanel.activeSelf);
		//MusicSetting.SetActive(isOpenMusicSetting);
		//VideoSetting.SetActive(isOpenVideoSetting);
		//ManagerSetting.SetActive(isOpenManagerSetting);

	}

    void Update()
    {
        
    }
}