using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActionScript : MonoBehaviour
{
  public GameObject UIpanel;

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.Escape))
    {
      Application.Quit(0);
    }
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.tag == "Player")
    {
      UIpanel.SetActive(true);
      Cursor.lockState = CursorLockMode.Confined;
    }
  }

  public void EnterMall()
  {
    SceneManager.LoadScene("Indoor");
    Cursor.lockState = CursorLockMode.Locked;
  }

  public void ExitMall()
  {
    SceneManager.LoadScene("Playground");
    Cursor.lockState = CursorLockMode.Locked;
  }

  public void AnswerNo()
  {
    Cursor.lockState = CursorLockMode.Locked;
    UIpanel.SetActive(false);
  }
}
