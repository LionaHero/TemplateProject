using System;

namespace Model {
	public class User {
		public int Id { get; set; }
		public int? GenderId { get; set; }
		public string Email { get; set; }
		public string Mobile { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string MiddleName { get; set; }
		public string Skype { get; set; }
		public string BirthDate { get; set; }
		public string PasswordHash { get; set; }
		public DateTime? CreatedDateUtc { get; set; }
	}
}
