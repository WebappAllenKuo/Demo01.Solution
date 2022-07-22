using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace WA.EStore.Domains
{
    public class Member
    {
	    public string Account { get; private set; }
	    public string Password { get; private set; }

	    public Member(string account, string password)
	    {
		    Account = account;
		    Password = password;

		    List<ValidationResult> errors = Validate();
	    }

	    private List<ValidationResult> Validate()
	    {
		    // todo

		    return new List<ValidationResult>();
	    }
    }
}
