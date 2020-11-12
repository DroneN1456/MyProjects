using System;
using System.Collections.Generic;
using System.Text;

namespace set1.Entities
{
    class log
    {
        public string user { get; set; }
        public DateTime logDate { get; set; }

        public log (string user, DateTime logDate)
        {
            this.user = user;
            this.logDate = logDate;
        }

        public override int GetHashCode()
        {
            return user.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is log))
            {
                return false;
            }
            log aux = obj as log;
            return user.Equals(aux.user);
        }
    }
}
