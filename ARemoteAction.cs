namespace CorpseRemote
{
    public abstract class ARemoteAction(string actionID)
    {
        private readonly Dictionary<string, object> m_Properties = [];
        private readonly string m_ActionID = actionID;

        public string ID => m_ActionID;

        protected object? GetProperties(string property)
        {
            if (m_Properties.TryGetValue(property, out object? value))
                return value;
            return null;
        }

        protected void SetProperties(string property, object value) => m_Properties[property] = value;
    }
}
