﻿using System;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Events;

namespace TwistedFate
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Loading.OnLoadingComplete += OnLoadingComplete;
        }

        private static void OnLoadingComplete(EventArgs args)
        {
            if (ObjectManager.Player.ChampionName.ToLower() != "twistedfate")
            {
                return;
            }
            Bootstrap.Init(null);
            Config.CallMenu();
            Spells.LoadSpells();
            Tf.Init();
        }
    }
}