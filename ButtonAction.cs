namespace CompanionCorpse
{
    public class ButtonAction : ACompanionAction
    {
        public ButtonAction(string actionID) : base(actionID)
        {
        }
    }

    public class ButtonAction<TData> : ButtonAction
    {
        public ButtonAction(string actionID) : base(actionID)
        {
        }
    }
}
