using System;
using TMPro;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{
    public ClockTiming clock;
    public TextMeshProUGUI dayWeek;
    public TextMeshProUGUI dayNumber;

    public TextMeshProUGUI time, ampm, usedTimeText;
    public Slider usedHourSlider;
    
    public TextMeshProUGUI kuru;

    public TextMeshProUGUI justNowTitle;
    public TextMeshProUGUI justNowText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateFirstTime();
        StartCoroutine(UpdateInGameTime());
        dayWeek.text = DateTime.Today.DayOfWeek.ToString().ToUpper();
        dayNumber.text = "Day " + "1";
        kuru.text = "26";
        justNowTitle.text = "Boss asked for overtime".ToUpper();
        justNowText.text = "The project behind schedule. What will you do?";
    }

    private void UpdateFirstTime()
    {
        time.text = clock.Hour.text + ":" + clock.Minute.text;
        ampm.text = clock.AMPM.text;
        usedTimeText.text = "<color=#FCC011>" + clock._hour + "</color>" + " / 24 HOURS USED";
        usedHourSlider.value = clock._hour;
    }
    private IEnumerator UpdateInGameTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(30f);
            time.text = clock.Hour.text + ":" + clock.Minute.text;
            ampm = clock.AMPM;
            usedTimeText.text = "<color=#FCC011>" + clock._hour + "</color>" + " / 24 HOURS USED";
            usedHourSlider.value = clock._hour;
        }
    }
}
