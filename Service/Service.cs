namespace Core
{
    using System;

    public class Service
    {
        public required string Name { get; set; }
        public decimal BaseCost { get; set; }
        public bool IsWorkingDayService { get; set; }
        public DayOfWeek StartDayOfWeek { get; set; }
        public DayOfWeek EndDayOfWeek { get; set; }
    }
}
