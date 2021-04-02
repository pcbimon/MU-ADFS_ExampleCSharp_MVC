using System.Collections.Generic;
using System.Security.Claims;

namespace OpenID.Models
{
    public class UserProfile
    {
        private string _PPID = "";
        private string _UPN = "";
        private string _email = "";
        private string _givenName = "";
        private string _surname = "";
        private string _winAccountName = "";
        private string _nameID = "";
        Dictionary<string, string> _claim = new Dictionary<string, string>();

        public UserProfile(System.Security.Claims.ClaimsIdentity ci)
        {
            foreach (Claim c in ci.Claims)
            {
                _claim.Add(c.Type, c.Value);
            }
        }

        public Dictionary<string, string> Claims { get { return _claim; } }
    }
}