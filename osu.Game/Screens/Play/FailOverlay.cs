﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Framework.Graphics.Containers;
using osu.Framework.Input;
using OpenTK.Input;
using osu.Game.Graphics;
using OpenTK.Graphics;

namespace osu.Game.Screens.Play
{
    public class FailOverlay : InGameOverlay
    {
        protected override bool OnKeyDown(InputState state, KeyDownEventArgs args)
        {
            if (args.Key == Key.Escape)
            {
                if (State == Visibility.Hidden) return false;
                OnQuit();
                return true;
            }

            return base.OnKeyDown(state, args);
        }

        protected override void AddButtons(OsuColour colours)
        {
            AddButton(@"Retry", colours.YellowDark, OnRetry);
            AddButton(@"Quit to Main Menu", new Color4(170, 27, 39, 255), OnQuit);
        }

        public FailOverlay()
        {
            title = @"failed";
            description = @"you're dead, try again?";
        }
    }
}
