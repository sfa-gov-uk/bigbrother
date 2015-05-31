﻿namespace Common.Telemetry.Events
{
    using Microsoft.ApplicationInsights.DataContracts;

    public partial class BulkImportEvent
    {
        public EventTelemetry ToEventTelemetry()
        {
            var eventTelementry = new EventTelemetry {Name = GetType().Name};

            eventTelementry.Properties["BatchId"] = BatchId.ToString();
            eventTelementry.Properties["RecordId"] = RecordId.ToString();
            eventTelementry.Properties["Failed"] = Failed.ToString();
            eventTelementry.Properties["EventType"] = EventType.ToString();
            eventTelementry.Properties["Message"] = Message;

            return eventTelementry;
        }
    }
}
