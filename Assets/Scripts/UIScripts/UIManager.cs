using System.Collections;
using UnityEngine;
using DG.Tweening;
using UnityEditor.VersionControl;
using UnityEngine.UI;
public partial class UIManager : MonoBehaviour
{
    [Header("Splash Screen")] 
    [SerializeField] private Image OvertimeImage;
    [SerializeField] private Button playButton;
    [SerializeField] private GameObject mainMenu;

    [Header("Main Menu")] 
    [SerializeField] private Button startDay;
    [SerializeField] private Button journal;
    [SerializeField] private Button stats;
    [SerializeField] private Button settings;

    [SerializeField] private GameObject statPannel;
    [SerializeField] private GameObject settingPannel;
    [SerializeField] private GameObject journalPannel;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        registerButtons();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playButtonOnSplashScreen()
    {
        OvertimeImage.gameObject.GetComponent<Animator>().Play("move");
        playButton.gameObject.GetComponent<Animator>().Play("move");
        
        StartCoroutine(ActiveDeactiveItems(new GameObject[] {mainMenu}, 
                                                new GameObject[] {playButton.gameObject}, 
                                                        0.5f));
    }

    private IEnumerator ActiveDeactiveItems(GameObject[] activeItem, GameObject[] deactiveItem, float delay = 0)
    {
        yield return new WaitForSeconds(delay);
        foreach (GameObject item in activeItem) item.SetActive(true);
        foreach(GameObject item in deactiveItem) item.SetActive(false);
    }


    public void registerButtons()
    {
        playButton.onClick.AddListener(playButtonOnSplashScreen);
        
        settings.onClick.AddListener(() => settingPannel.SetActive(true));
        journal.onClick.AddListener(() => journalPannel.SetActive(true));
        stats.onClick.AddListener(() => statPannel.SetActive(true) );
    }
}
