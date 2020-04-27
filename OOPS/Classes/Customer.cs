using System;

namespace Oops.BL
{
	public class Customer
	{
		public Customer()
		{
			InstanceCount++;
		}
		public int Id { get;  }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }
		public Address HomeAddress { get; set; }
		public Address WorkAddress { get; set; }
		public static int InstanceCount { get; set; }
		public string Name {
			get {
				var fullName = LastName;
				if (!string.IsNullOrWhiteSpace(fullName))
				{
					if (!string.IsNullOrWhiteSpace(FirstName))
					{
						fullName += ", ";
					}					
				}
				fullName += FirstName;
				return fullName;
			}
		}
		public bool Validate()
		{
			bool isValid = true;
			if (string.IsNullOrWhiteSpace(LastName))
				isValid = false;
			if (string.IsNullOrWhiteSpace(EmailAddress))
				isValid = false;
			return isValid;
		}

		public Customer Retrieve()
 		{
			return null;
		}

		public void Save()
		{

		}
	}
}
