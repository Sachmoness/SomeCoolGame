using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // needed for Actions

public static class EventHandler
{
    public static Action PlayerRed; // need to diable blue platforms!

    public static Action PlayerBlue; // need to disbale red platforms!

    public static Action PlayerFell; // need to play death sound

    public static Action CoinReached; // need to play level win sound

    public static Action PlayerJumped; // need to  play jump sound
}
