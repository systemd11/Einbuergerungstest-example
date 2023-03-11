using System;

 namespace app.Services {

 public class TimeService {
        
    public bool isRunning;
    public DateTime startTime;
    public TimeSpan elapsedTime;

    public string buttonText => isRunning ? "Stop" : "Start";
    public string currentTime => elapsedTime.ToString(@"hh\:mm\:ss\.ff");

    public void ToggleTimer()
    {
        if (isRunning)
        {
            elapsedTime = DateTime.Now - startTime;
            isRunning = false;
        }
        else
        {
            startTime = DateTime.Now - elapsedTime;
            isRunning = true;
        }
    }

    public void ResetTimer()
    {
        elapsedTime = TimeSpan.Zero;
        isRunning = false;
    }
  }
}