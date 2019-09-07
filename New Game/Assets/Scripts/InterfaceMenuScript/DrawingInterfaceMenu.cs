using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DrawingInterfaceMenu : MonoBehaviour
{
	// Кнопка для вызова меню
	public Image ButtonInterfaceMenu;

	public Image ButtonCloseInterface;
	
	[Header("Иконки")]
	// Кнопки отвечающие за меню
	public Image[] InterfaceMenu;

	[Header("Текст иконок")]
	public GameObject[] InterfaceNameIcon;

	[Header("Скорость отрисовки")]
	public float speedDrawing;

	[Header("Задержка отрисовки")]
	public float time;
	// Начала и конец отрисовки меню
	bool StartDrawingGUI { get; set; }
	bool EndDrawingGUI { get; set; }

	float SpeedDrawing { get; set; }
	float timeDrawing { get; set; }

	public void EnterCallInterface()
	{
		StartDrawingGUI = true;
		StartCoroutine(StartDrawingGUIInterface(timeDrawing));
	}

	public void CloseInterface()
	{
		EndDrawingGUI = true;
		StartCoroutine(CloseDrawingGUIInterface(timeDrawing));
	}

    void Start()
    {
		StartDrawingGUI = false;
		EndDrawingGUI = false;
		timeDrawing = time;

		SpeedDrawing = speedDrawing;
    }

	IEnumerator StartDrawingGUIInterface(float time)
	{
		while (StartDrawingGUI)
		{
			for (int i = 0; i < InterfaceMenu.Length; i++)
			{
				InterfaceMenu[i].fillAmount += SpeedDrawing;
				ButtonInterfaceMenu.fillAmount -= SpeedDrawing;
				ButtonCloseInterface.fillAmount += SpeedDrawing;
			}

			if (InterfaceMenu[0].fillAmount >= 1)
			{
				StartDrawingGUI = false;
				EndDrawingGUI = true;

				for (int i = 0; i < InterfaceNameIcon.Length; i++)
				{
					InterfaceNameIcon[i].SetActive(true);
				}

				yield break;
			}

			yield return new WaitForSeconds(time);
		}
	
	}

	IEnumerator CloseDrawingGUIInterface(float time)
	{
		while (EndDrawingGUI)
		{
			for (int i = 0; i < InterfaceMenu.Length; i++)
			{
				InterfaceMenu[i].fillAmount -= SpeedDrawing;
				ButtonInterfaceMenu.fillAmount += SpeedDrawing;
				ButtonCloseInterface.fillAmount -= SpeedDrawing;
			}

			if (InterfaceMenu[0].fillAmount <= 0)
			{
				EndDrawingGUI = false;
				for (int i = 0; i < InterfaceNameIcon.Length; i++)
				{
					InterfaceNameIcon[i].gameObject.SetActive(false);
				}
				yield break;
			}

			yield return new WaitForSeconds(time);
		}
	}
}