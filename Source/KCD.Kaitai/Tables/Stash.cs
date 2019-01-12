// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class Stash : KaitaiStruct
    {
        public static Stash FromFile(string fileName)
        {
            return new Stash(new KaitaiStream(fileName));
        }

        public Stash(KaitaiStream p__io, KaitaiStruct p__parent = null, Stash p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, Stash p__parent = null, Stash p__root = null) : base(p__io)
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
            private Stash m_root;
            private Stash m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public Stash M_Root { get { return m_root; } }
            public Stash M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, Stash p__parent = null, Stash p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _stashId = m_io.ReadBytes(16);
                _stashName = m_io.ReadS4le();
                _stashOriginalName = m_io.ReadS4le();
                _computerName = m_io.ReadS4le();
                _timestamp = m_io.ReadS4le();
                _levelName = m_io.ReadS4le();
                _locked = m_io.ReadS1();
                _difficulty = m_io.ReadF4le();
                _minimalShopItemPrice = m_io.ReadS4le();
                _inventoryDbId = m_io.ReadS4le();
            }
            private byte[] _stashId;
            private int _stashName;
            private int _stashOriginalName;
            private int _computerName;
            private int _timestamp;
            private int _levelName;
            private sbyte _locked;
            private float _difficulty;
            private int _minimalShopItemPrice;
            private int _inventoryDbId;
            private Stash m_root;
            private Stash m_parent;
            public byte[] StashId { get { return _stashId; } }
            public int StashName { get { return _stashName; } }
            public int StashOriginalName { get { return _stashOriginalName; } }
            public int ComputerName { get { return _computerName; } }
            public int Timestamp { get { return _timestamp; } }
            public int LevelName { get { return _levelName; } }
            public sbyte Locked { get { return _locked; } }
            public float Difficulty { get { return _difficulty; } }
            public int MinimalShopItemPrice { get { return _minimalShopItemPrice; } }
            public int InventoryDbId { get { return _inventoryDbId; } }
            public Stash M_Root { get { return m_root; } }
            public Stash M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private Stash m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public Stash M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
