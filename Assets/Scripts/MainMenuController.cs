using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	void Start(){
		Time.timeScale = 1f;
	}

	public void OnClickPlay(){
		SceneManager.LoadScene (1);
	}

	public void OnClickQuit(){
		Application.Quit ();
	}
}
