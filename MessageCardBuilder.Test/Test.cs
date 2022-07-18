using MessageCard.Builder;
using MessageCard.Builder.Builders;
using MessageCard.Builder.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageCardBuilder.Test
{
    public class Test
    {
        [Fact]
        public void TestIt()
        {
            var b = new MessageBuilder();
            b.WithText("").WithTitle("").AddSection(section => section.WithIsStartGroup(true));
            var m = b.Build();
        }
    }
}
