using System;

namespace UserManagerLib
{
    public class User
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailId { get; set; }
        public string? PANCardNo
        {
            get;
            set;
        }

        public string ValidatePANCardNumber(string panCard)
        {
            if (string.IsNullOrEmpty(panCard))
            {
                throw new NullReferenceException("Invalid Pan Card Number");
            }
            else if (panCard.Length != 10)
            {
                throw new FormatException("Pan Card Number Should contain only 10 characters");
            }
            else
            {
                return "Valid";
            }

        }

        public void CreateUser(User user)
        {
            if (ValidatePANCardNumber(user.PANCardNo).Equals("Valid"))
            {
                //Do something
            }
        }
    }
}
