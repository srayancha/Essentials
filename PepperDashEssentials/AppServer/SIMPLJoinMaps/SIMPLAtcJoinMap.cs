﻿using System.Linq;
using Crestron.SimplSharp.Reflection;

using PepperDash.Essentials.Core;


namespace PepperDash.Essentials.AppServer
{
    public class SIMPLAtcJoinMap : JoinMapBaseAdvanced
    {
        [JoinName("EndCall")]
        public JoinDataComplete EndCall = new JoinDataComplete(new JoinData() {  JoinNumber = 21, JoinSpan = 1 }, new JoinMetadata() { Label = "Hang Up", JoinCapabilities = eJoinCapabilities.ToSIMPL,  JoinType = eJoinType.Digital });
        [JoinName("IncomingAnswer")]
        public JoinDataComplete IncomingAnswer = new JoinDataComplete(new JoinData() { JoinNumber = 51, JoinSpan = 1 }, new JoinMetadata() { Label = "Answer Incoming Call", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinType = eJoinType.Digital });
        [JoinName("IncomingReject")]
        public JoinDataComplete IncomingReject = new JoinDataComplete(new JoinData() { JoinNumber = 52, JoinSpan = 1 }, new JoinMetadata() { Label = "Reject Incoming Call", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinType = eJoinType.Digital });
        [JoinName("SpeedDialStart")]
        public JoinDataComplete SpeedDialStart = new JoinDataComplete(new JoinData() { JoinNumber = 41, JoinSpan = 4 }, new JoinMetadata() { Label = "Speed Dial", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinType = eJoinType.Digital });
        [JoinName("CurrentDialString")]
        public JoinDataComplete CurrentDialString = new JoinDataComplete(new JoinData() { JoinNumber = 1, JoinSpan = 1 }, new JoinMetadata() { Label = "Current Dial String", JoinCapabilities = eJoinCapabilities.ToFromSIMPL, JoinType = eJoinType.Serial });
        [JoinName("CurrentCallNumber")]
        public JoinDataComplete CurrentCallNumber = new JoinDataComplete(new JoinData() { JoinNumber = 11, JoinSpan = 1 }, new JoinMetadata() { Label = "Current Call Number", JoinCapabilities = eJoinCapabilities.FromSIMPL, JoinType = eJoinType.Serial });
        [JoinName("CurrentCallName")]
        public JoinDataComplete CurrentCallName = new JoinDataComplete(new JoinData() { JoinNumber = 12, JoinSpan = 1 }, new JoinMetadata() { Label = "Current Call Name", JoinCapabilities = eJoinCapabilities.FromSIMPL, JoinType = eJoinType.Serial });
        [JoinName("CurrentHookStateCallName")]
        public JoinDataComplete HookState = new JoinDataComplete(new JoinData() { JoinNumber = 21, JoinSpan = 1 }, new JoinMetadata() { Label = "Current Hook State", JoinCapabilities = eJoinCapabilities.FromSIMPL, JoinType = eJoinType.Serial });
        [JoinName("CallDirection")]
        public JoinDataComplete CallDirection = new JoinDataComplete(new JoinData() { JoinNumber = 22, JoinSpan = 1 }, new JoinMetadata() { Label = "Current Call Direction", JoinCapabilities = eJoinCapabilities.FromSIMPL, JoinType = eJoinType.Serial });
        [JoinName("0")]
        public JoinDataComplete Dtmf0 = new JoinDataComplete(new JoinData() { JoinNumber = 10, JoinSpan = 1 }, new JoinMetadata() { Label = "DTMF 0", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinType = eJoinType.Digital });
        [JoinName("1")]
        public JoinDataComplete Dtmf1 = new JoinDataComplete(new JoinData() { JoinNumber = 1, JoinSpan = 1 }, new JoinMetadata() { Label = "DTMF 1", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinType = eJoinType.Digital });
        [JoinName("2")]
        public JoinDataComplete Dtmf2 = new JoinDataComplete(new JoinData() { JoinNumber = 2, JoinSpan = 1 }, new JoinMetadata() { Label = "DTMF 2", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinType = eJoinType.Digital });
        [JoinName("3")]
        public JoinDataComplete Dtmf3 = new JoinDataComplete(new JoinData() { JoinNumber = 3, JoinSpan = 1 }, new JoinMetadata() { Label = "DTMF 3", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinType = eJoinType.Digital });
        [JoinName("4")]
        public JoinDataComplete Dtmf4 = new JoinDataComplete(new JoinData() { JoinNumber = 4, JoinSpan = 1 }, new JoinMetadata() { Label = "DTMF 4", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinType = eJoinType.Digital });
        [JoinName("5")]
        public JoinDataComplete Dtmf5 = new JoinDataComplete(new JoinData() { JoinNumber = 5, JoinSpan = 1 }, new JoinMetadata() { Label = "DTMF 5", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinType = eJoinType.Digital });
        [JoinName("6")]
        public JoinDataComplete Dtmf6 = new JoinDataComplete(new JoinData() { JoinNumber = 6, JoinSpan = 1 }, new JoinMetadata() { Label = "DTMF 6", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinType = eJoinType.Digital });
        [JoinName("7")]
        public JoinDataComplete Dtmf7 = new JoinDataComplete(new JoinData() { JoinNumber = 7, JoinSpan = 1 }, new JoinMetadata() { Label = "DTMF 7", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinType = eJoinType.Digital });
        [JoinName("8")]
        public JoinDataComplete Dtmf8 = new JoinDataComplete(new JoinData() { JoinNumber = 8, JoinSpan = 1 }, new JoinMetadata() { Label = "DTMF 8", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinType = eJoinType.Digital });
        [JoinName("9")]
        public JoinDataComplete Dtmf9 = new JoinDataComplete(new JoinData() { JoinNumber = 9, JoinSpan = 1 }, new JoinMetadata() { Label = "DTMF 9", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinType = eJoinType.Digital });
        [JoinName("*")]
        public JoinDataComplete DtmfStar = new JoinDataComplete(new JoinData() { JoinNumber = 11, JoinSpan = 1 }, new JoinMetadata() { Label = "DTMF *", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinType = eJoinType.Digital });
        [JoinName("#")]
        public JoinDataComplete DtmfPound = new JoinDataComplete(new JoinData() { JoinNumber = 12, JoinSpan = 1 }, new JoinMetadata() { Label = "DTMF #", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinType = eJoinType.Digital });

        /// <summary>
        /// Constructor that passes the joinStart to the base class
        /// </summary>
        /// <param name="joinStart"></param>
        public SIMPLAtcJoinMap(uint joinStart)
            : base(joinStart)
        {

        }
    }
}