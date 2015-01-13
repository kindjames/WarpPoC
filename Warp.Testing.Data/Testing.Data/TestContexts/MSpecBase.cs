using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Fakes;
using Machine.Specifications;
using ThenIt = Machine.Specifications.It;

namespace Testing.Data.TestContexts
{
    public class MSpecBase<TSubject> where TSubject : class
    {
        Establish _context { get; set; }
        Because _of { get; set; }
        It _should { get; set; }
    
    }
}
