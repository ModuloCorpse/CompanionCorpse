using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanionCorpse
{
    public abstract class ACompanionAction
    {
        private readonly string m_ActionID;

        public string ID => m_ActionID;

        protected ACompanionAction(string actionID)
        {
            m_ActionID = actionID;
        }
    }
}
