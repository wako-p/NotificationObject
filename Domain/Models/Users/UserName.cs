using System;

namespace Domain.Models.Users
{
    public sealed class UserName
    {
        private readonly string value;

        public string Value { get { return this.value; } }

        public UserName(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (!IsValid(value))
            {
                throw new ArgumentException(nameof(value));
            }

            this.value = value;
        }

        private static bool IsValid(string value)
        {
            return true; // 仕様がないのでとりまtrueを返す
        }
    }
}
