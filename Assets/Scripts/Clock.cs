using System;

public enum TickRate { Second };

public static class Clock
{
    public static Action onSecondTick;

    public static void RunSecondTick() {
        onSecondTick?.Invoke();
    }
}
