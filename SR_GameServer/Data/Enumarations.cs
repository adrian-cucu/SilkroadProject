﻿namespace SR_GameServer.Data
{
    using System;

    public enum JobType
    {
        Trader = 0,
        Thief = 1,
        Hunter = 2,
    }

    public enum ItemType
    {
        CH_WEAPON_SWORD = 1,
        CH_WEAPON_BLADE = 2,
        CH_WEAPON_SPEAR = 3,
        CH_WEAPON_TBLADE = 4,
        CH_WEAPON_BOW = 5,
        CH_WEAPON_SHIELD = 6,
        CH_ARMOR_HEAVY = 7,
        CH_ARMOR_LIGHT = 8,
        CH_ARMOR_CLOTHES = 9,
        CH_ACCESSORY_NECKLACE = 10,
        CH_ACCESSORY_EARRING = 11,
        CH_ACCESSORY_RING = 12,
        EU_WEAPON_SWORD = 13,
        EU_WEAPON_TSWORD = 14,
        EU_WEAPON_DUALAXE = 15,
        EU_WEAPON_WROD = 16,
        EU_WEAPON_CROD = 17,
        EU_WEAPON_TSTAFF = 18,
        EU_WEAPON_CROSSBOW = 19,
        EU_WEAPON_DAGGER = 20,
        EU_WEAPON_HARP = 21,
        EU_WEAPON_SHIELD = 22,
        EU_ARMOR_HEAVY = 23,
        EU_ARMOR_LIGHT = 24,
        EU_ARMOR_ROBE = 25,
        EU_ACCESSORY_NECKLACE = 26,
        EU_ACCESSORY_EARRING = 27,
        EU_ACCESSORY_RING = 28,
        COSTUME_TRIANGLE = 29,
        COSTUME_AVATAR = 30,
        COSTUME_ETC = 31,
        COSTUME_NASRUN = 32,
        ALCHEMY_ELIXIR = 33,
        SOCKET_STONE = 34,
        ALCHEMY_ELEMENT = 35,
        ALCHEMY_MAGICSTONE = 36,
        ALCHEMY_ATTRSTONE = 37,
        ALCHEMY_TABLET = 38,
        ALCHEMY_MATERIAL = 39,
        COS_COS = 40,
        COS_ETC = 41,
        ARTICLES_RECOVERY = 42,
        ARTICLES_CURE = 43,
        ARTICLES_RETURN = 44,
        ARTICLES_FORTIFY = 45,
        ARTICLES_ARROW = 46,
        GUILD_ITEM = 47,
        FORTWAR_WEAPON = 48,
        FORTWAR_ITEM = 49,
        EXCHANGE_COIN = 50,
        EVENT_ITEM = 51,
        ETC_CHANGE = 52,
        ETC_SPECIAL = 53,
        ETC_SKILL = 54,
        ETC_CHAT = 55,
        ETC_REPAIR = 56,
        ETC_ETC = 57,
        NEW_TRADE_WEAPON = 58,
        NEW_TRADE_ARMOR = 59,
        NEW_TRADE_ACCESSORY = 60,
        NEW_TRADE_ALCHEMY = 61,
        NEW_TRADE_ETC = 62,
        ALCHEMY_UPGRADE = 63,
        GOLD = 64,
        ETC_FIREWORK = 65,
        ETC_CAMPFIRE = 66,
        ETC_TRADE_ITEM = 67,
        None,
        COSTUME_FRPVP = 999,
    }

    [Flags]
    public enum AuthType
    {
        None = 0,
        GM = 1,
    }
}