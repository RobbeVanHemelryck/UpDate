using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UpDate
{
    public class Scenario
    {
        public Scenario()
        {
            this.Actions = new List<Action>();
            this.Conditions = new List<Expression<Predicate<string>>>();
        }
        public List<Action> Actions { get; set; }
        public List<Expression<Predicate<string>>> Conditions { get; set; }
    }
}
