public class BreathingActivity : Activity
{
    int _inDuration;
    int _outDuration;
 public BreathingActivity(string name, string explanation, int inDuration, int outDuration) : base(name, explanation)
 {
    _inDuration = inDuration;
    _outDuration = outDuration;
 }

 public void BreathIn()
 {
    Console.WriteLine("  ");
    Console.Write($"Breath in...");
    // Console.WriteLine();
    PauseTimer(_inDuration);
    // Console.WriteLine();

 }

 public void BreathOut()
 {
    Console.WriteLine("  ");
    Console.Write($"Breath out...");
    PauseTimer(_outDuration);
    Console.WriteLine("  ");
 }

 public void RunBreathingActivity()
 {
    DisplayStartMessage();
    Console.WriteLine("Get ready...");
    PauseSpinner(4);
    int repeats = _duration / 10;
    for (int i = 0; i < repeats; i++)
    {
        BreathIn();
        BreathOut();
    }
    DisplayEndMessage();
 }


}