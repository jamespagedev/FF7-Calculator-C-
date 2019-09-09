using System;
using System.Collections.Generic;
using System.Text;

namespace FF7LevelUpCalculator
{
    public abstract class CalculateLevelUp
    {
        //******************************************************************************************************************
        //**************************************************** Variables ***************************************************
        //******************************************************************************************************************
        public static readonly String[] characterNames = CharactersInfo.characterNames;
        public static readonly int[] rndNums = { 1, 2, 3, 4, 5, 6, 7, 8 };
        public static readonly int maxRndNum = rndNums[rndNums.Length - 1];
        public static readonly int minRndNum = rndNums[0];
        public static readonly int maxHpValue = 9999;
        public static readonly int maxMpValue = 999;
        public static readonly int maxPrimaryAndLuckStatsValue = 100; // your primary and luck stats can not increase beyond 100 naturally through levels (you can use source items to get 255 max)
        public static readonly String[] primaryStatName = {"Str", "Dex", "Vit", "Mag", "Spr"}; // Luck is excluded, because it has it's own stat variable tables

    }
}
