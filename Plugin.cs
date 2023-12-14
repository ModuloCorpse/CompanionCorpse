namespace CompanionCorpse
{
    public class Plugin(string id)
    {
        private readonly Dictionary<string, ACompanionAction> m_Actions = [];
        private readonly string m_ID = id;

        public string ID => m_ID;

        public ACompanionAction? GetAction(string id) => (m_Actions.TryGetValue(id, out ACompanionAction? action)) ? action : null;
    }
}
