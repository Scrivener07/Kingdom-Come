// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class Armor : KaitaiStruct
    {
        public static Armor FromFile(string fileName)
        {
            return new Armor(new KaitaiStream(fileName));
        }

        public Armor(KaitaiStream p__io, KaitaiStruct p__parent = null, Armor p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, Armor p__parent = null, Armor p__root = null) : base(p__io)
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
            private Armor m_root;
            private Armor m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public Armor M_Root { get { return m_root; } }
            public Armor M_Parent { get { return m_parent; } }
        }
        public partial class Padding : KaitaiStruct
        {
            public static Padding FromFile(string fileName)
            {
                return new Padding(new KaitaiStream(fileName));
            }

            public Padding(KaitaiStream p__io, KaitaiStruct p__parent = null, Armor p__root = null) : base(p__io)
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
            private Armor m_root;
            private KaitaiStruct m_parent;
            public byte[] PaddingType { get { return _paddingType; } }
            public Armor M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, Armor p__parent = null, Armor p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _computerName = m_io.ReadS4le();
                _timestamp = m_io.ReadS4le();
                _itemId = m_io.ReadBytes(16);
                _clothingId = m_io.ReadBytes(16);
                _clothing2Id = m_io.ReadBytes(16);
                _armorTypeId = m_io.ReadS4le();
                _armorSubtypeId = m_io.ReadS4le();
                _slashDef = m_io.ReadF4le();
                _stabDef = m_io.ReadF4le();
                _smashDef = m_io.ReadF4le();
                _strReq = m_io.ReadF4le();
                _noise = m_io.ReadF4le();
                _maxStatus = m_io.ReadS4le();
                _superfactionId = m_io.ReadS4le();
                _isUnderwear = m_io.ReadS1();
                _brightness = m_io.ReadF4le();
                _colorHue = m_io.ReadF4le();
                _colorSaturation = m_io.ReadF4le();
                _zone1Brightness = m_io.ReadF4le();
                _zone1Hue = m_io.ReadF4le();
                _zone1Saturation = m_io.ReadF4le();
                _zone2Brightness = m_io.ReadF4le();
                _zone2Hue = m_io.ReadF4le();
                _zone2Saturation = m_io.ReadF4le();
                _zone3Brightness = m_io.ReadF4le();
                _zone3Hue = m_io.ReadF4le();
                _zone3Saturation = m_io.ReadF4le();
                _color = m_io.ReadS4le();
            }
            private int _computerName;
            private int _timestamp;
            private byte[] _itemId;
            private byte[] _clothingId;
            private byte[] _clothing2Id;
            private int _armorTypeId;
            private int _armorSubtypeId;
            private float _slashDef;
            private float _stabDef;
            private float _smashDef;
            private float _strReq;
            private float _noise;
            private int _maxStatus;
            private int _superfactionId;
            private sbyte _isUnderwear;
            private float _brightness;
            private float _colorHue;
            private float _colorSaturation;
            private float _zone1Brightness;
            private float _zone1Hue;
            private float _zone1Saturation;
            private float _zone2Brightness;
            private float _zone2Hue;
            private float _zone2Saturation;
            private float _zone3Brightness;
            private float _zone3Hue;
            private float _zone3Saturation;
            private int _color;
            private Armor m_root;
            private Armor m_parent;
            public int ComputerName { get { return _computerName; } }
            public int Timestamp { get { return _timestamp; } }
            public byte[] ItemId { get { return _itemId; } }
            public byte[] ClothingId { get { return _clothingId; } }
            public byte[] Clothing2Id { get { return _clothing2Id; } }
            public int ArmorTypeId { get { return _armorTypeId; } }
            public int ArmorSubtypeId { get { return _armorSubtypeId; } }
            public float SlashDef { get { return _slashDef; } }
            public float StabDef { get { return _stabDef; } }
            public float SmashDef { get { return _smashDef; } }
            public float StrReq { get { return _strReq; } }
            public float Noise { get { return _noise; } }
            public int MaxStatus { get { return _maxStatus; } }
            public int SuperfactionId { get { return _superfactionId; } }
            public sbyte IsUnderwear { get { return _isUnderwear; } }
            public float Brightness { get { return _brightness; } }
            public float ColorHue { get { return _colorHue; } }
            public float ColorSaturation { get { return _colorSaturation; } }
            public float Zone1Brightness { get { return _zone1Brightness; } }
            public float Zone1Hue { get { return _zone1Hue; } }
            public float Zone1Saturation { get { return _zone1Saturation; } }
            public float Zone2Brightness { get { return _zone2Brightness; } }
            public float Zone2Hue { get { return _zone2Hue; } }
            public float Zone2Saturation { get { return _zone2Saturation; } }
            public float Zone3Brightness { get { return _zone3Brightness; } }
            public float Zone3Hue { get { return _zone3Hue; } }
            public float Zone3Saturation { get { return _zone3Saturation; } }
            public int Color { get { return _color; } }
            public Armor M_Root { get { return m_root; } }
            public Armor M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private Armor m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public Armor M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
