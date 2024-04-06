namespace CorpseLib.Remote
{
    public class Plugin(string id)
    {
        private readonly Dictionary<string, ARemoteAction> m_Actions = [];
        private readonly string m_ID = id;

        public string ID => m_ID;

        public ARemoteAction? GetAction(string id) => (m_Actions.TryGetValue(id, out ARemoteAction? action)) ? action : null;
    }
}
