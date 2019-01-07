// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai.Tables
{
    public partial class QuestRewardExp : KaitaiStruct
    {
        public static QuestRewardExp FromFile(string fileName)
        {
            return new QuestRewardExp(new KaitaiStream(fileName));
        }

        public QuestRewardExp(KaitaiStream p__io, KaitaiStruct p__parent = null, QuestRewardExp p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, QuestRewardExp p__parent = null, QuestRewardExp p__root = null) : base(p__io)
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
            private QuestRewardExp m_root;
            private QuestRewardExp m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public QuestRewardExp M_Root { get { return m_root; } }
            public QuestRewardExp M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, QuestRewardExp p__parent = null, QuestRewardExp p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _questId = m_io.ReadS4le();
                _objectiveId = m_io.ReadS4le();
                _expChangeId = m_io.ReadS4le();
                _rpgAttr = m_io.ReadS4le();
                _isImmediate = m_io.ReadS1();
                _pos = m_io.ReadS4le();
            }
            private int _questId;
            private int _objectiveId;
            private int _expChangeId;
            private int _rpgAttr;
            private sbyte _isImmediate;
            private int _pos;
            private QuestRewardExp m_root;
            private QuestRewardExp m_parent;
            public int QuestId { get { return _questId; } }
            public int ObjectiveId { get { return _objectiveId; } }
            public int ExpChangeId { get { return _expChangeId; } }
            public int RpgAttr { get { return _rpgAttr; } }
            public sbyte IsImmediate { get { return _isImmediate; } }
            public int Pos { get { return _pos; } }
            public QuestRewardExp M_Root { get { return m_root; } }
            public QuestRewardExp M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private QuestRewardExp m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public QuestRewardExp M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
