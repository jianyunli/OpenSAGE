﻿namespace OpenSage.Scripting
{
    // TODO: BFME re-used existing ScriptConditionType values, so we can't have one enum for all SAGE games.
    // We can either have separate enums per game, or rely in InternalName, but this wasn't available in some
    // earlier Generals maps.
    public enum ScriptConditionType : uint
    {
        False = 0,
        Counter = 1,
        Flag = 2,
        True = 3,
        TimerExpired = 4,
        PlayerAllDestroyed = 5,
        PlayerAllBuildFacilitiesDestroyed = 6,
        TeamInsideAreaPartially = 7,
        TeamDestroyed = 8,
        CameraMovementFinished = 9,
        TeamHasUnits = 10,
        TeamStateIs = 11,
        TeamStateIsNot = 12,
        NamedInsideArea = 13,
        NamedOutsideArea = 14,
        NamedDestroyed = 15,
        NamedNotDestroyed = 16,
        TeamInsideAreaEntirely = 17,
        TeamOutsideAreaEntirely = 18,
        NamedAttackedByObjectType = 19,
        TeamAttackedByObjectType = 20,
        NamedAttackedByPlayer = 21,
        TeamAttackedByPlayer = 22,
        BuiltByPlayer = 23,
        NamedCreated = 24,
        TeamCreated = 25,
        PlayerHasCredits = 26,
        NamedDiscovered = 27,
        TeamDiscovered = 28,
        MissionAttempts = 29,
        NamedOwnedByPlayer = 30,
        TeamOwnedByPlayer = 31,
        PlayerHasNOrFewerBuildings = 32,
        PlayerHasPower = 33,
        NamedReachedWaypointsEnd = 34,
        TeamReachedWaypointsEnd = 35,
        NamedSelected = 36,
        NamedEnteredArea = 37,
        NamedExitedArea = 38,
        TeamEnteredAreaEntirely = 39,
        TeamEnteredAreaPartially = 40,
        TeamExitedAreaEntirey = 41,
        TeamExitedAreaPartially = 42,
        MultiPlayerAlliedVictory = 43,
        MultiPlayerAlliedDefeat = 44,
        MultiPlayerDefeat = 45,
        PlayerHasNoPower = 46,
        HasFinishedVideo = 47,
        HasFinishedSpeech = 48,
        HasFinishedAudio = 49,
        BuildingEnteredByPlayer = 50,
        EnemySighted = 51,
        UnitHealth = 52,
        BridgeRepaired = 53,
        BridgeBroken = 54,
        NamedDying = 55,
        NamedTotallyDead = 56,
        PlayerHasObjectComparison = 57,
        Placeholder_58 = 58,
        Placeholder_59 = 59,
        PlayerTriggeredSpecialPower = 60,
        PlayerCompletedSpecialPower = 61,
        PlayerMidwaySpecialPower = 62,
        PlayerTriggeredSpecialPowerFromNamed = 63,
        PlayerCompletedSpecialPowerFromNamed = 64,
        PlayerMidwaySpecialPowerFromNamed = 65,
        Placeholder_66 = 66,
        Placeholder_67 = 67,
        PlayerBuiltUpgrade = 68,
        PlayerBuiltUpgradeFromNamed = 69,
        PlayerDestroyedNBuildingsPlayer = 70,
        Placeholder_71 = 71,
        Placeholder_72 = 72,
        PlayerHasComparisonUnitTypeInTriggerArea = 73,
        PlayerHasComparisonUnitKindInTriggerArea = 74,
        UnitEmptied = 75,
        TypeSighted = 76,
        NamedBuildingIsEmpty = 77,
        PlayerHasNOrFewerFactionBuildings = 78,
        UnitHasObjectStatus = 79,
        TeamAllHasObjectStatus = 80,
        TeamObjectStatusPartial = 81,
        PlayerPowerComparePercent = 82,
        PlayerExcessPowerCompareValue = 83,
        SkirmishSpecialPowerReady = 84,
        SkirmishValueInArea = 85,
        SkirmishPlayerFaction = 86,
        SkirmishSuppliesValueWithinDistance = 87,
        SkirmishTechBuildingWithinDistance = 88,
        SkirmishCommandButtonReadyAll = 89,
        SkirmishCommandButtonReadyPartial = 90,
        SkirmishUnownedFactionUnitExists = 91,
        SkirmishPlayerHasPrerequisiteToBuild = 92,
        SkirmishPlayerHasComparisonGarrisoned = 93,
        SkirmishPlayerHasComparisonCapturedUnits = 94,
        SkirmishNamedAreaExist = 95,
        SkirmishPlayerHasUnitsInArea = 96,
        SkirmishPlayerHasBeenAttackedByPlayer = 97,
        SkirmishPlayerIsOutsideArea = 98,
        SkirmishPlayerHasDiscoveredPlayer = 99,
        PlayerAcquiredScience = 100,
        PlayerHasSciencePurchasePoints = 101,
        PlayerCanPurchaseScience = 102,
        MusicTrackHasCompleted = 103,
        PlayerLostObjectType = 104,
        SupplySourceSafe = 105,
        SupplySourceAttacked = 106,
        StartPositionIs = 107,
        NamedHasFreeConstructionSlots = 108,

        // Added in BFME
        CounterCounter = 111,
        CounterSeconds = 112,
        DistanceBetweenObj = 113,
        DistanceBetweenTeam = 114,
        UnitThreadLevel = 115,
        TeamThreatLevel = 116,
        UnitHasGainedLevel = 117,
        NamedBaseUnpackableForPlayer = 121,
        HasCommandPointsToBuildTeam = 125,
        HasCommandPointsToBuildUnit = 126,
        CanBuildAtBase = 127,
        PlayerHasKilledKindOfUnits = 128,
        PlayerHasKilledTypeUnits = 129,
        PlayerHasNOrFewerBases = 131,
        CameraEnteredArea = 132,
        EnemySightedByTeam = 133,
        ComparisonTreesInTriggerArea = 134,
        GateIsOpen = 135,
        UnitCanPathToWaypoint = 136,
        TeamCanPathToWaypoint = 139,
        TeamHasCustomState = 143,
        UnitCompareRank = 144,
        PlayerCompareRank = 145,
        PlayerHasObjectOfVeterancy = 146,
        ObjectOfTypeOrListInsideRefdBase = 147,
        PlayerHasNumberObjectsWithModelCondition = 160,
        PlayerHasNumberUnitsDistanceFromObject = 161,
        UnitHasPassenger = 162,
        TeamIsAttackedAndCannotRetaliate = 165,
        IsGameInSkirmishOrMultiplayer = 166,
        RegionCampsShouldUnpack = 167,
        CompareNumPlayersInGame = 168,
        CanBuildObjectTypeAtBase = 169,
        TeamHasFewerThanXUnitsWithKindOf = 170,
        SkirmishFireSpecialPowerOnTeam = 171,
        NamedRankLevel = 172,
        PlayerHasReachedLevelCap = 173,
        EvalTeamHealth = 174,
        AnyHeroReachedRank = 176,
        NumUnitsLeveledUp = 177,
        PlayerHasNumUnitsWithUpgrade = 178,
        UnitHasToggledWeapon = 180,
        AnyUnitsUsingBloodthirsty = 181,
        UnitUsingAutoPickup = 182,
        UnitInAltFormation = 183,
    }
}