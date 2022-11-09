using UnityEngine;

public class Screen : MonoBehaviour
{
    public void SubmitSliderSetting(float volume)
    {

        Debug.Log("Volume sekarang : " + volume);
    }

    public void SubmitDropDown(int res)
    {
        if (res == 0)
        {
            Debug.Log("Resolusi Sekarang : 1920 x 1080");
        }
        else if (res == 1)
        {
            Debug.Log("Resolusi Sekarang : 1280 x 720");
        }
        else if (res == 2)
        {
            Debug.Log("Resolusi Sekarang : 854 x 480");
        }
    }
    public void SubmitDropDownDisplay(int res)
    {
        if (res == 0)
        {
            Debug.Log("Display Sekarang : Fullscreen");
        }
        else if (res == 1)
        {
            Debug.Log("Display Sekarang : Windowed");
        }
    }

    public void ToggleMute(bool mute)
    {
        if (mute)
        {
            AudioListener.volume = 0;
            Debug.Log("Volume sekarang : Mute");
            Debug.Log("Kondisi mute hanya me-nonaktifkan audio listener, bukan mengubah value slider");
        }
        else
        {
            AudioListener.volume = 1;
            Debug.Log("Voume Sekarang : Unmute");
        }
    }

    public void MotionBlur(bool motion)
    {
        if (motion)
        {
            Debug.Log("Motion Blur : ON");
        }
        else
        {
            Debug.Log("Motion Blur : OFF");
        }
    }
    public void AntiAliasing(bool anti)
    {
        if (anti)
        {
            Debug.Log("Anti-Aliasing : ON");
        }
        else
        {
            Debug.Log("Anti-Aliasing : OFF");
        }
    }
}