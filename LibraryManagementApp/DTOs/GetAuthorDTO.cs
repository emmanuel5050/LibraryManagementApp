﻿namespace LibraryManagementApp.DTOs
{
    public class GetAuthorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
    }
}
