// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class QuestFunction : KaitaiStruct
    {
        public static QuestFunction FromFile(string fileName)
        {
            return new QuestFunction(new KaitaiStream(fileName));
        }

        public QuestFunction(KaitaiStream p__io, KaitaiStruct p__parent = null, QuestFunction p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, QuestFunction p__parent = null, QuestFunction p__root = null) : base(p__io)
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
            private QuestFunction m_root;
            private QuestFunction m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public QuestFunction M_Root { get { return m_root; } }
            public QuestFunction M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, QuestFunction p__parent = null, QuestFunction p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _objectiveFunctionId = m_io.ReadS4le();
                _objectiveId = m_io.ReadS4le();
                _questId = m_io.ReadS4le();
                _objectiveFunctionTypeId = m_io.ReadS4le();
                _contextSoulId = m_io.ReadBytes(16);
                _callScript = m_io.ReadS1();
                _function = m_io.ReadS4le();
            }
            private int _objectiveFunctionId;
            private int _objectiveId;
            private int _questId;
            private int _objectiveFunctionTypeId;
            private byte[] _contextSoulId;
            private sbyte _callScript;
            private int _function;
            private QuestFunction m_root;
            private QuestFunction m_parent;
            public int ObjectiveFunctionId { get { return _objectiveFunctionId; } }
            public int ObjectiveId { get { return _objectiveId; } }
            public int QuestId { get { return _questId; } }
            public int ObjectiveFunctionTypeId { get { return _objectiveFunctionTypeId; } }
            public byte[] ContextSoulId { get { return _contextSoulId; } }
            public sbyte CallScript { get { return _callScript; } }
            public int Function { get { return _function; } }
            public QuestFunction M_Root { get { return m_root; } }
            public QuestFunction M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private QuestFunction m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public QuestFunction M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
