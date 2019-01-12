// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class Statistic : KaitaiStruct
    {
        public static Statistic FromFile(string fileName)
        {
            return new Statistic(new KaitaiStream(fileName));
        }

        public Statistic(KaitaiStream p__io, KaitaiStruct p__parent = null, Statistic p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, Statistic p__parent = null, Statistic p__root = null) : base(p__io)
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
            private Statistic m_root;
            private Statistic m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public Statistic M_Root { get { return m_root; } }
            public Statistic M_Parent { get { return m_parent; } }
        }
        public partial class Padding : KaitaiStruct
        {
            public static Padding FromFile(string fileName)
            {
                return new Padding(new KaitaiStream(fileName));
            }

            public Padding(KaitaiStream p__io, KaitaiStruct p__parent = null, Statistic p__root = null) : base(p__io)
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
            private Statistic m_root;
            private KaitaiStruct m_parent;
            public byte[] PaddingType { get { return _paddingType; } }
            public Statistic M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, Statistic p__parent = null, Statistic p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _statisticId = m_io.ReadS4le();
                _statisticGroupId = m_io.ReadS4le();
                _statisticName = m_io.ReadS4le();
                _uiName = m_io.ReadS4le();
                _uiDesc = m_io.ReadS4le();
                _type = m_io.ReadS4le();
                _uiMaxValue = m_io.ReadF4le();
                _uiOrder = m_io.ReadS4le();
                _isGlobal = m_io.ReadS1();
                _psnId = m_io.ReadS4le();
                _statisticUnitId = m_io.ReadS4le();
            }
            private int _statisticId;
            private int _statisticGroupId;
            private int _statisticName;
            private int _uiName;
            private int _uiDesc;
            private int _type;
            private float _uiMaxValue;
            private int _uiOrder;
            private sbyte _isGlobal;
            private int _psnId;
            private int _statisticUnitId;
            private Statistic m_root;
            private Statistic m_parent;
            public int StatisticId { get { return _statisticId; } }
            public int StatisticGroupId { get { return _statisticGroupId; } }
            public int StatisticName { get { return _statisticName; } }
            public int UiName { get { return _uiName; } }
            public int UiDesc { get { return _uiDesc; } }
            public int Type { get { return _type; } }
            public float UiMaxValue { get { return _uiMaxValue; } }
            public int UiOrder { get { return _uiOrder; } }
            public sbyte IsGlobal { get { return _isGlobal; } }
            public int PsnId { get { return _psnId; } }
            public int StatisticUnitId { get { return _statisticUnitId; } }
            public Statistic M_Root { get { return m_root; } }
            public Statistic M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private Statistic m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public Statistic M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
