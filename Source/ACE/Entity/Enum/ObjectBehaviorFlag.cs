﻿using System;

namespace ACE.Entity
{
    [Flags]
    public enum ObjectDescriptionFlag
    {
        None                   = 0x00000000,
        CanOpen                = 0x00000001,
        Inscribable            = 0x00000002,
        Stuck                  = 0x00000004,
        Player                 = 0x00000008,
        Attackable             = 0x00000010,
        PlayerKiller           = 0x00000020,
        HiddenAdmin            = 0x00000040,
        Hidden                 = 0x00000080,
        Book                   = 0x00000100,
        Vendor                 = 0x00000200,
        PkSwitch               = 0x00000400,
        NpkSwitch              = 0x00000800,
        Door                   = 0x00001000,
        Corpse                 = 0x00002000,
        LifeStone              = 0x00004000,
        Food                   = 0x00008000,
        Healer                 = 0x00010000,
        LockPick               = 0x00020000,
        Portal                 = 0x00040000,
        Admin                  = 0x00100000,
        FreePkStatus           = 0x00200000,
        ImmuteCellRestrictions = 0x00400000,
        RequiresPackSlot       = 0x00800000,
        Ratained               = 0x01000000,
        PkLiteStatus           = 0x02000000,
        AdditionFlags          = 0x04000000,
        BindStone              = 0x08000000,
        VolatileRare           = 0x10000000,
        WeildOnUse             = 0x20000000,
        WeildLeft              = 0x40000000,
    }
}
