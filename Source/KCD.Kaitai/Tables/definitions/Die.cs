// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai.Tables
{
    public partial class Die : KaitaiStruct
    {
        public static Die FromFile(string fileName)
        {
            return new Die(new KaitaiStream(fileName));
        }

        public Die(KaitaiStream p__io, KaitaiStruct p__parent = null, Die p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, Die p__parent = null, Die p__root = null) : base(p__io)
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
            private Die m_root;
            private Die m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public Die M_Root { get { return m_root; } }
            public Die M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, Die p__parent = null, Die p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _itemId = m_io.ReadBytes(16);
                _sideWeight1 = m_io.ReadF4le();
                _sideWeight2 = m_io.ReadF4le();
                _sideWeight3 = m_io.ReadF4le();
                _sideWeight4 = m_io.ReadF4le();
                _sideWeight5 = m_io.ReadF4le();
                _sideWeight6 = m_io.ReadF4le();
                _sideValue1 = m_io.ReadS4le();
                _sideValue2 = m_io.ReadS4le();
                _sideValue3 = m_io.ReadS4le();
                _sideValue4 = m_io.ReadS4le();
                _sideValue5 = m_io.ReadS4le();
                _sideValue6 = m_io.ReadS4le();
            }
            private byte[] _itemId;
            private float _sideWeight1;
            private float _sideWeight2;
            private float _sideWeight3;
            private float _sideWeight4;
            private float _sideWeight5;
            private float _sideWeight6;
            private int _sideValue1;
            private int _sideValue2;
            private int _sideValue3;
            private int _sideValue4;
            private int _sideValue5;
            private int _sideValue6;
            private Die m_root;
            private Die m_parent;
            public byte[] ItemId { get { return _itemId; } }
            public float SideWeight1 { get { return _sideWeight1; } }
            public float SideWeight2 { get { return _sideWeight2; } }
            public float SideWeight3 { get { return _sideWeight3; } }
            public float SideWeight4 { get { return _sideWeight4; } }
            public float SideWeight5 { get { return _sideWeight5; } }
            public float SideWeight6 { get { return _sideWeight6; } }
            public int SideValue1 { get { return _sideValue1; } }
            public int SideValue2 { get { return _sideValue2; } }
            public int SideValue3 { get { return _sideValue3; } }
            public int SideValue4 { get { return _sideValue4; } }
            public int SideValue5 { get { return _sideValue5; } }
            public int SideValue6 { get { return _sideValue6; } }
            public Die M_Root { get { return m_root; } }
            public Die M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private Die m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public Die M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
