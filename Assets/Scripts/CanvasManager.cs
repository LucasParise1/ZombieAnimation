using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private float _startTime;
    [SerializeField] private GameObject _zombie;

    private void Start() => Invoke(nameof(ActivateZombie), _startTime);
    private void ActivateZombie() => _zombie.SetActive(true);
    public void ResetButton() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    public void QuitButton() => Application.Quit();
}
