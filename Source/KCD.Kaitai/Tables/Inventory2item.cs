// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class Inventory2item : KaitaiStruct
    {
        public static Inventory2item FromFile(string fileName)
        {
            return new Inventory2item(new KaitaiStream(fileName));
        }

        public Inventory2item(KaitaiStream p__io, KaitaiStruct p__parent = null, Inventory2item p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, Inventory2item p__parent = null, Inventory2item p__root = null) : base(p__io)
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
            private Inventory2item m_root;
            private Inventory2item m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public Inventory2item M_Root { get { return m_root; } }
            public Inventory2item M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, Inventory2item p__parent = null, Inventory2item p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _inventoryId = m_io.ReadBytes(16);
                _itemId = m_io.ReadBytes(16);
                _health = m_io.ReadF4le();
                _amount = m_io.ReadS4le();
                _amountRandomAdd = m_io.ReadS4le();
                _healthOffset = m_io.ReadF4le();
                _priority = m_io.ReadF4le();
            }
            private byte[] _inventoryId;
            private byte[] _itemId;
            private float _health;
            private int _amount;
            private int _amountRandomAdd;
            private float _healthOffset;
            private float _priority;
            private Inventory2item m_root;
            private Inventory2item m_parent;
            public byte[] InventoryId { get { return _inventoryId; } }
            public byte[] ItemId { get { return _itemId; } }
            public float Health { get { return _health; } }
            public int Amount { get { return _amount; } }
            public int AmountRandomAdd { get { return _amountRandomAdd; } }
            public float HealthOffset { get { return _healthOffset; } }
            public float Priority { get { return _priority; } }
            public Inventory2item M_Root { get { return m_root; } }
            public Inventory2item M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private Inventory2item m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public Inventory2item M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
