using System;
using UnityEngine;

public class Clock : MonoBehaviour {

    public Transform hours_transform;
    public Transform minutes_transform;
    public Transform seconds_transform;
    const float degrees_per_hour = 30f;
    const float degrees_per_minute = 6f;
    const float degrees_per_second = 6f;
    public bool continuous;

    void Update() {
        if (continuous)
        {
            TimeSpan time = DateTime.Now.TimeOfDay;
            hours_transform.localRotation = Quaternion.Euler(0f, (float)time.TotalHours * degrees_per_hour, 0f);
            minutes_transform.localRotation = Quaternion.Euler(0f, (float)time.TotalMinutes * degrees_per_minute, 0f);
            seconds_transform.localRotation = Quaternion.Euler(0f, (float)time.TotalSeconds * degrees_per_second, 0f);

        }
        else
        {
            DateTime time = DateTime.Now;
            hours_transform.localRotation = Quaternion.Euler(0f, time.Hour * degrees_per_hour, 0f);
            minutes_transform.localRotation = Quaternion.Euler(0f, time.Minute * degrees_per_minute, 0f);
            seconds_transform.localRotation = Quaternion.Euler(0f, time.Second * degrees_per_second, 0f);
        }
        
    }


}