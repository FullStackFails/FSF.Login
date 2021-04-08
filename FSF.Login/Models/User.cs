using Microsoft.AspNetCore.Identity;
using System;

namespace FSF.Login.Models
{
  public class User : IdentityUser
  {
    [PersonalData]
    public string FirstName { get; set; }

    [PersonalData]
    public string LastName { get; set; }
  }
}
