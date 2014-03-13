using System;

namespace HangFire.SqlServer.Entities
{
    internal class Job
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string InvocationData { get; set; }
        public string Arguments { get; set; }
        public string StateData { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ExpireAt { get; set; }

        public DateTime? FetchedAt { get; set; }
    }
}