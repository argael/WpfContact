using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfContact.Models
{
	public class Contact
	{
		public string? Name { get; set; }

		public string? Phone { get; set; }

		public Contact(string? name, string? phone)
		{
			Name = name?.Trim(); 
			Phone = phone?.Trim();
		}

		public bool isValid()
		{
			return !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Phone);
		}

		public override string ToString()
		{
			return $"{Name} ({Phone ?? "n.a."})".Trim();
		}
	}
}
