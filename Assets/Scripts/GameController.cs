using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

	public GameObject gameWonUI;
	public GameObject pauseMenu;

	private const int MAIN_MENU = 0;

	private bool GameIsComplete = false;
	private bool GameIsPaused = false;


	void Start ()
	{
		Time.timeScale = 1;
	}

	void Update ()
	{
		OnClickEscape ();
	}

	private void OnClickEscape ()
	{
		if (Input.GetKeyDown (KeyCode.Escape) && !GameIsComplete) {
			if (GameIsPaused)
				Resume ();
			else
				Pause ();
		}
	}

	private void Pause ()
	{
		pauseMenu.SetActive (true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

	public void GameWon ()
	{
		Time.timeScale = 0;
		gameWonUI.SetActive (true);
		GameIsComplete = true;
	}

	public void OnClickAgain ()
	{
		Scene scene = SceneManager.GetActiveScene ();
		SceneManager.LoadScene (scene.name);
	}

	public void OnClickMenu ()
	{
		SceneManager.LoadScene (MAIN_MENU);
	}

	public void OnClickQuit ()
	{
		Application.Quit ();
	}

	public void Resume ()
	{
		pauseMenu.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}
}
