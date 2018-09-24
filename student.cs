using System;

namespace buffteks
{
    class student
    {
        public int StudentID { get; set; } //Primary Key

        public string Name { get; set; }
        public string Role { get; set; }
        public team TeamID { get; set; } //Forward Key from Team
    }
}
