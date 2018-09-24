using System;

namespace buffteks
{
    class project
    {
        public int ProjectID { get; set; } //Primary Key

        public string ProjectName { get; set; }
        public client ClientID { get; set; } //FK from client
        public team TeamID { get; set; } //FK from team

    }
}
