// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class Sequence : KaitaiStruct
    {
        public static Sequence FromFile(string fileName)
        {
            return new Sequence(new KaitaiStream(fileName));
        }

        public Sequence(KaitaiStream p__io, KaitaiStruct p__parent = null, Sequence p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _table = new Header(m_io, this, m_root);
            _rows = new List<Row>((int) (Table.RowCount));
            for (var i = 0; i < Table.RowCount; i++)
            {
                _rows.Add(new Row(m_io, this, m_root));
            }
            _strings = new List<string>((int) (Table.UniqueStringsCount));
            for (var i = 0; i < Table.UniqueStringsCount; i++)
            {
                _strings.Add(System.Text.Encoding.GetEncoding("utf-8").GetString(m_io.ReadBytesTerm(0, false, true, true)));
            }
        }
        public partial class Header : KaitaiStruct
        {
            public static Header FromFile(string fileName)
            {
                return new Header(new KaitaiStream(fileName));
            }

            public Header(KaitaiStream p__io, Sequence p__parent = null, Sequence p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _version = m_io.ReadS4le();
                _descriptorsHash = m_io.ReadU4le();
                _layoutHash = m_io.ReadU4le();
                _tableVersion = m_io.ReadS4le();
                _rowCount = m_io.ReadS4le();
                _stringDataSize = m_io.ReadS4le();
                _uniqueStringsCount = m_io.ReadS4le();
            }
            private int _version;
            private uint _descriptorsHash;
            private uint _layoutHash;
            private int _tableVersion;
            private int _rowCount;
            private int _stringDataSize;
            private int _uniqueStringsCount;
            private Sequence m_root;
            private Sequence m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public Sequence M_Root { get { return m_root; } }
            public Sequence M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, Sequence p__parent = null, Sequence p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _sequenceId = m_io.ReadS4le();
                _next = m_io.ReadS4le();
                _script = m_io.ReadS4le();
                _priority = m_io.ReadS4le();
                _uiPrompt = m_io.ReadS4le();
                _group = m_io.ReadS4le();
                _type = m_io.ReadS4le();
                _skillCheckDifficultyId = m_io.ReadS4le();
                _flags = m_io.ReadS4le();
                _timeout = m_io.ReadS4le();
                _speechCoef = m_io.ReadF4le();
                _reputation = m_io.ReadS4le();
            }
            private int _sequenceId;
            private int _next;
            private int _script;
            private int _priority;
            private int _uiPrompt;
            private int _group;
            private int _type;
            private int _skillCheckDifficultyId;
            private int _flags;
            private int _timeout;
            private float _speechCoef;
            private int _reputation;
            private Sequence m_root;
            private Sequence m_parent;
            public int SequenceId { get { return _sequenceId; } }
            public int Next { get { return _next; } }
            public int Script { get { return _script; } }
            public int Priority { get { return _priority; } }
            public int UiPrompt { get { return _uiPrompt; } }
            public int Group { get { return _group; } }
            public int Type { get { return _type; } }
            public int SkillCheckDifficultyId { get { return _skillCheckDifficultyId; } }
            public int Flags { get { return _flags; } }
            public int Timeout { get { return _timeout; } }
            public float SpeechCoef { get { return _speechCoef; } }
            public int Reputation { get { return _reputation; } }
            public Sequence M_Root { get { return m_root; } }
            public Sequence M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private Sequence m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public Sequence M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
