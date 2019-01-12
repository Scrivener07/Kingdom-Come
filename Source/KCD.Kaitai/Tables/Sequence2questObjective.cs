// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class Sequence2questObjective : KaitaiStruct
    {
        public static Sequence2questObjective FromFile(string fileName)
        {
            return new Sequence2questObjective(new KaitaiStream(fileName));
        }

        public Sequence2questObjective(KaitaiStream p__io, KaitaiStruct p__parent = null, Sequence2questObjective p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, Sequence2questObjective p__parent = null, Sequence2questObjective p__root = null) : base(p__io)
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
            private Sequence2questObjective m_root;
            private Sequence2questObjective m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public Sequence2questObjective M_Root { get { return m_root; } }
            public Sequence2questObjective M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, Sequence2questObjective p__parent = null, Sequence2questObjective p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _sequenceId = m_io.ReadS4le();
                _questId = m_io.ReadS4le();
                _objectiveId = m_io.ReadS4le();
                _action = m_io.ReadS4le();
                _orderBy = m_io.ReadS4le();
                _condition = m_io.ReadS4le();
            }
            private int _sequenceId;
            private int _questId;
            private int _objectiveId;
            private int _action;
            private int _orderBy;
            private int _condition;
            private Sequence2questObjective m_root;
            private Sequence2questObjective m_parent;
            public int SequenceId { get { return _sequenceId; } }
            public int QuestId { get { return _questId; } }
            public int ObjectiveId { get { return _objectiveId; } }
            public int Action { get { return _action; } }
            public int OrderBy { get { return _orderBy; } }
            public int Condition { get { return _condition; } }
            public Sequence2questObjective M_Root { get { return m_root; } }
            public Sequence2questObjective M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private Sequence2questObjective m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public Sequence2questObjective M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
