namespace CorpseRemote
{
    public class EventData
    {
        public enum Type
        {
            PRESSED,
            HELD,
            RELEASED,
            ROTATED
        }

        private readonly object m_Data;
        private readonly Type m_Type;

        public Type EventType => m_Type;
    }
}
