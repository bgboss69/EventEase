using EventEase.Models;
using System.Collections.Generic;

namespace EventEase.Services
{
    public class SessionState
    {
        public Event? SelectedEvent { get; set; } // Tracks the currently selected event
        public List<Attendee> RegisteredAttendees { get; private set; } = new List<Attendee>();

        public void RegisterAttendee(Attendee attendee)
        {
            RegisteredAttendees.Add(attendee);
        }
    }
}