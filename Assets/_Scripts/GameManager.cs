using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] SoundManager soundManager;
    [SerializeField] TMP_Text noteCountTxt;
    [SerializeField] TMP_Text clearGameTxt;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);   // มีตัวอื่นอยู่แล้ว ลบทิ้ง
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);  // ไม่หายตอนเปลี่ยนฉาก
    }

    private void Start()
    {
        clearGameTxt.gameObject.SetActive(false);

        noteCountTxt.gameObject.SetActive(true);
        noteCountTxt.text = "Note Left: " + noteCount;
    }

    public int noteCount = 5;
    public string wingameNoti = "Game Cleared !!";
    
    public void OnCollectNote()
    {
        noteCount -= 1;
        noteCountTxt.text = "Note Left: " + noteCount;
        soundManager.BurnPaper();
        if (noteCount <= 0)
            OnWinGame();
    }

    public void OnWinGame()
    {
        soundManager.ClearGame();
        clearGameTxt.gameObject.SetActive(true);
        clearGameTxt.text = wingameNoti;
    }
}
