using System;
using System.Collections.Generic;
using System.Text;

namespace set2.Entities
{
    class User
    {
        public int number { get; set; }

        public User(int number)
        {
            this.number = number;
        }

        public override int GetHashCode()
        {
            return number.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is User))
            {
                return false;
            }
            User aux = obj as User;
            return number.Equals(aux.number);
        }
    }
}
