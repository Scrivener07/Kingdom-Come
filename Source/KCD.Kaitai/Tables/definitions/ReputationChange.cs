// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai.Tables
{
    public partial class ReputationChange : KaitaiStruct
    {
        public static ReputationChange FromFile(string fileName)
        {
            return new ReputationChange(new KaitaiStream(fileName));
        }

        public ReputationChange(KaitaiStream p__io, KaitaiStruct p__parent = null, ReputationChange p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, ReputationChange p__parent = null, ReputationChange p__root = null) : base(p__io)
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
            private ReputationChange m_root;
            private ReputationChange m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public ReputationChange M_Root { get { return m_root; } }
            public ReputationChange M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, ReputationChange p__parent = null, ReputationChange p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _reputationChangeId = m_io.ReadS4le();
                _name = m_io.ReadS4le();
                _change = m_io.ReadF4le();
                _reputationChangeTargetId = m_io.ReadS4le();
                _canChangeHostility = m_io.ReadS1();
                _reputationCap = m_io.ReadF4le();
                _reputationNotificationId = m_io.ReadS4le();
            }
            private int _reputationChangeId;
            private int _name;
            private float _change;
            private int _reputationChangeTargetId;
            private sbyte _canChangeHostility;
            private float _reputationCap;
            private int _reputationNotificationId;
            private ReputationChange m_root;
            private ReputationChange m_parent;
            public int ReputationChangeId { get { return _reputationChangeId; } }
            public int Name { get { return _name; } }
            public float Change { get { return _change; } }
            public int ReputationChangeTargetId { get { return _reputationChangeTargetId; } }
            public sbyte CanChangeHostility { get { return _canChangeHostility; } }
            public float ReputationCap { get { return _reputationCap; } }
            public int ReputationNotificationId { get { return _reputationNotificationId; } }
            public ReputationChange M_Root { get { return m_root; } }
            public ReputationChange M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private ReputationChange m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public ReputationChange M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
