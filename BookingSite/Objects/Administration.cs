using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite
{
    internal class Administration
    {
        protected string _fullName { get; set; } = string.Empty;
        protected string _email { get; set; } = string.Empty;
        protected string _phoneNum { get; set; } = string.Empty;


        public Administration()
        {
            _fullName = string.Empty;
            _email = string.Empty;
            _phoneNum = string.Empty;
        }

        public Administration(string fullName, string email, string phoneNum)
        {
            if (!(String.IsNullOrEmpty(fullName) && String.IsNullOrEmpty(email) && String.IsNullOrEmpty(phoneNum)))
            {
                _fullName = fullName;
                _email = email;
                _phoneNum = phoneNum;
            }
        }

        public void SetFullName(string fullname)
        {
            _fullName = fullname;
        }

        public string GetFullName()
        {
            string fullName = String.Empty;
            fullName = _fullName;
            return fullName;
        }

        public void Setemail(string email)
        {
            _email = email;
        }

        public string Getemail()
        {
            string email = String.Empty;
            email = _email;
            return email;
        }
        public void SetphoneNum(string phoneNum)
        {
            _phoneNum = phoneNum;
        }

        public string GetphoneNum()
        {
            string phoneNum = String.Empty;
            phoneNum = _phoneNum;
            return phoneNum;
        }

        public string GetContacts()
        {

            return $"Admin Name:{_fullName}, email:{_email},phone number:{_phoneNum}";
        }
    }

}
