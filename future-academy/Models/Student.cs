﻿namespace future_academy.Models
{
    public class Student
    {
        public int id { get; set; }
        public int? groupId { get; set; }
        public Group? group { get; set; }
        public string? department { get; set; }
        public int? accountId { get; set; }
        public Account account { get; set; }
    }
}
