using System;

namespace OAuthServer.Entities
{
    public class User 
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int RegisterTypeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string AlternativeEmail { get; set; }
        public int NumberOfAccessAttempts { get; set; }
        public int NumberOfAccess { get; set; }
        public int StatusId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ApplicationId { get; set; }
    }
}
