using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    internal class Builder
    {
        public void Construct(IAccount builder, IOwner builder2)
        {
            builder.BuildSMS();
            builder.BuildBalance();
            builder.BuildOpendate();
            builder.BuildType();
            builder.BuildNum();
            builder2.BuildBirthdate();
            builder2.BuildName();
            builder2.BuildPassport();
        }
    }
}
