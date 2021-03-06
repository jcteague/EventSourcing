﻿using System.Linq;
using UnitTests;

namespace EventSourcing.Db4o.Tests
{
    [Specification]
    public class WhenStoringEventsToAnExistingStream : InContextOfStoringEvents
    {
        protected string[] _additionalEvents;

        protected override void SetupDependencies()
        {
            base.SetupDependencies();
            _additionalEvents = new [] {"6","7","8","9","10","11"};
            _subjectUnderTest.StoreEvents(_streamId, _events);
            _events = _events.Concat(_additionalEvents).ToArray();
        }

        protected override void When()
        {
            _subjectUnderTest.StoreEvents(_streamId,_additionalEvents);
        }
    }
}