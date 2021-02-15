using Clean.Architecture.SharedKernel;
using System;

namespace Clean.Architecture.Core.Entities
{
    public class GuestbookEntry : BaseEntity
    {
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTimeOffset DateTimeCreated { get; set; }
        public GuestbookEntry()
        {
            DateTimeCreated = DateTime.UtcNow;
        }
    }
}