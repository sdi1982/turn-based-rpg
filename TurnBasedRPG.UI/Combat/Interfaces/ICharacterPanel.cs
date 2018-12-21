﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnBasedRPG.UI.Combat.EventArgs;

namespace TurnBasedRPG.UI.Combat.Interfaces
{
    /// <summary>
    /// Panel responsible for rendering a character's stats and extra information.
    /// </summary>
    public interface ICharacterPanel : IReceiveInputPanel
    {
        event EventHandler<KeyPressedEventArgs> KeyPressed;
    }
}
