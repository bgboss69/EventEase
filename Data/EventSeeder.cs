using EventEase.Models;

namespace EventEase.Data{
    public static class EventSeeder
    {
        public static List<Event> getEvents()
        {
            return new List<Event>{
                new Event{
                    Id = 1,
                    Name = "Tech Conference",
                    Date = new DateTime(2025, 10, 15),
                    Location = "New York",
                    Description = "A conference for tech enthusiasts."
                },
                new Event{
                    Id = 2,
                    Name = "Art Exhibition",
                    Date = new DateTime(2025, 11, 20),
                    Location = "Los Angeles",
                    Description = "An exhibition showcasing modern art."
                },              
                new Event{
                    Id = 3,
                    Name = "Music Festival",
                    Date = new DateTime(2025, 12, 5),
                    Location = "Chicago",
                    Description = "A festival featuring various music genres."
                },
            };
        }
    }
}
