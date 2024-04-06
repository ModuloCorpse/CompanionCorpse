namespace CorpseLib.Remote
{
    public class ButtonAction : ARemoteAction
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
