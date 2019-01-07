// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai.Tables
{
    public partial class Shop : KaitaiStruct
    {
        public static Shop FromFile(string fileName)
        {
            return new Shop(new KaitaiStream(fileName));
        }

        public Shop(KaitaiStream p__io, KaitaiStruct p__parent = null, Shop p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, Shop p__parent = null, Shop p__root = null) : base(p__io)
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
            private Shop m_root;
            private Shop m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public Shop M_Root { get { return m_root; } }
            public Shop M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, Shop p__parent = null, Shop p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _shopId = m_io.ReadS4le();
                _shopTypeId = m_io.ReadS4le();
                _amountMultiplier = m_io.ReadF4le();
                _amountMultiplierRandomAdd = m_io.ReadF4le();
                _priceBuyMultiplier = m_io.ReadF4le();
                _priceSellMultiplier = m_io.ReadF4le();
                _shopName = m_io.ReadS4le();
                _restockDayMask = m_io.ReadS4le();
                _businessHoursBegin = m_io.ReadF4le();
                _businessHoursEnd = m_io.ReadF4le();
                _itemCategoryId = m_io.ReadS4le();
            }
            private int _shopId;
            private int _shopTypeId;
            private float _amountMultiplier;
            private float _amountMultiplierRandomAdd;
            private float _priceBuyMultiplier;
            private float _priceSellMultiplier;
            private int _shopName;
            private int _restockDayMask;
            private float _businessHoursBegin;
            private float _businessHoursEnd;
            private int _itemCategoryId;
            private Shop m_root;
            private Shop m_parent;
            public int ShopId { get { return _shopId; } }
            public int ShopTypeId { get { return _shopTypeId; } }
            public float AmountMultiplier { get { return _amountMultiplier; } }
            public float AmountMultiplierRandomAdd { get { return _amountMultiplierRandomAdd; } }
            public float PriceBuyMultiplier { get { return _priceBuyMultiplier; } }
            public float PriceSellMultiplier { get { return _priceSellMultiplier; } }
            public int ShopName { get { return _shopName; } }
            public int RestockDayMask { get { return _restockDayMask; } }
            public float BusinessHoursBegin { get { return _businessHoursBegin; } }
            public float BusinessHoursEnd { get { return _businessHoursEnd; } }
            public int ItemCategoryId { get { return _itemCategoryId; } }
            public Shop M_Root { get { return m_root; } }
            public Shop M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private Shop m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public Shop M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
