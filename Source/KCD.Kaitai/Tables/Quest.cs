// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class Quest : KaitaiStruct
    {
        public static Quest FromFile(string fileName)
        {
            return new Quest(new KaitaiStream(fileName));
        }

        public Quest(KaitaiStream p__io, KaitaiStruct p__parent = null, Quest p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, Quest p__parent = null, Quest p__root = null) : base(p__io)
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
            private Quest m_root;
            private Quest m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public Quest M_Root { get { return m_root; } }
            public Quest M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, Quest p__parent = null, Quest p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _questId = m_io.ReadS4le();
                _questName = m_io.ReadS4le();
                _longDesc = m_io.ReadS4le();
                _counter = m_io.ReadS4le();
                _pos1 = m_io.ReadS4le();
                _pos2 = m_io.ReadS4le();
                _pos3 = m_io.ReadS4le();
                _group = m_io.ReadS4le();
                _comment = m_io.ReadS4le();
                _smartObject = m_io.ReadS4le();
                _isActivated = m_io.ReadS1();
                _questTypeId = m_io.ReadS4le();
                _isProgressVisible = m_io.ReadS1();
                _computerName = m_io.ReadS4le();
                _timestamp = m_io.ReadS4le();
            }
            private int _questId;
            private int _questName;
            private int _longDesc;
            private int _counter;
            private int _pos1;
            private int _pos2;
            private int _pos3;
            private int _group;
            private int _comment;
            private int _smartObject;
            private sbyte _isActivated;
            private int _questTypeId;
            private sbyte _isProgressVisible;
            private int _computerName;
            private int _timestamp;
            private Quest m_root;
            private Quest m_parent;
            public int QuestId { get { return _questId; } }
            public int QuestName { get { return _questName; } }
            public int LongDesc { get { return _longDesc; } }
            public int Counter { get { return _counter; } }
            public int Pos1 { get { return _pos1; } }
            public int Pos2 { get { return _pos2; } }
            public int Pos3 { get { return _pos3; } }
            public int Group { get { return _group; } }
            public int Comment { get { return _comment; } }
            public int SmartObject { get { return _smartObject; } }
            public sbyte IsActivated { get { return _isActivated; } }
            public int QuestTypeId { get { return _questTypeId; } }
            public sbyte IsProgressVisible { get { return _isProgressVisible; } }
            public int ComputerName { get { return _computerName; } }
            public int Timestamp { get { return _timestamp; } }
            public Quest M_Root { get { return m_root; } }
            public Quest M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private Quest m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public Quest M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
