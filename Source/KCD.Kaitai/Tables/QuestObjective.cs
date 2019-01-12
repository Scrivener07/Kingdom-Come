// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class QuestObjective : KaitaiStruct
    {
        public static QuestObjective FromFile(string fileName)
        {
            return new QuestObjective(new KaitaiStream(fileName));
        }

        public QuestObjective(KaitaiStream p__io, KaitaiStruct p__parent = null, QuestObjective p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, QuestObjective p__parent = null, QuestObjective p__root = null) : base(p__io)
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
            private QuestObjective m_root;
            private QuestObjective m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public QuestObjective M_Root { get { return m_root; } }
            public QuestObjective M_Parent { get { return m_parent; } }
        }
        public partial class Padding : KaitaiStruct
        {
            public static Padding FromFile(string fileName)
            {
                return new Padding(new KaitaiStream(fileName));
            }

            public Padding(KaitaiStream p__io, KaitaiStruct p__parent = null, QuestObjective p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _paddingType = m_io.ReadBytes(16);
            }
            private byte[] _paddingType;
            private QuestObjective m_root;
            private KaitaiStruct m_parent;
            public byte[] PaddingType { get { return _paddingType; } }
            public QuestObjective M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, QuestObjective p__parent = null, QuestObjective p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _objectiveId = m_io.ReadS4le();
                _questId = m_io.ReadS4le();
                _objectiveName = m_io.ReadS4le();
                _experienceCoef = m_io.ReadF4le();
                _isHidden = m_io.ReadS1();
                _isExclusive = m_io.ReadS1();
                _time = m_io.ReadS4le();
                _autocompleteTimeout = m_io.ReadS4le();
                _condition = m_io.ReadS4le();
                _pos = m_io.ReadS4le();
                _expirationTimeoutStr = m_io.ReadS4le();
                _autocompleteTimeoutStr = m_io.ReadS4le();
            }
            private int _objectiveId;
            private int _questId;
            private int _objectiveName;
            private float _experienceCoef;
            private sbyte _isHidden;
            private sbyte _isExclusive;
            private int _time;
            private int _autocompleteTimeout;
            private int _condition;
            private int _pos;
            private int _expirationTimeoutStr;
            private int _autocompleteTimeoutStr;
            private QuestObjective m_root;
            private QuestObjective m_parent;
            public int ObjectiveId { get { return _objectiveId; } }
            public int QuestId { get { return _questId; } }
            public int ObjectiveName { get { return _objectiveName; } }
            public float ExperienceCoef { get { return _experienceCoef; } }
            public sbyte IsHidden { get { return _isHidden; } }
            public sbyte IsExclusive { get { return _isExclusive; } }
            public int Time { get { return _time; } }
            public int AutocompleteTimeout { get { return _autocompleteTimeout; } }
            public int Condition { get { return _condition; } }
            public int Pos { get { return _pos; } }
            public int ExpirationTimeoutStr { get { return _expirationTimeoutStr; } }
            public int AutocompleteTimeoutStr { get { return _autocompleteTimeoutStr; } }
            public QuestObjective M_Root { get { return m_root; } }
            public QuestObjective M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private QuestObjective m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public QuestObjective M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
