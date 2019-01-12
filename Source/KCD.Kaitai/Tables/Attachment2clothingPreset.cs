// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class Attachment2clothingPreset : KaitaiStruct
    {
        public static Attachment2clothingPreset FromFile(string fileName)
        {
            return new Attachment2clothingPreset(new KaitaiStream(fileName));
        }

        public Attachment2clothingPreset(KaitaiStream p__io, KaitaiStruct p__parent = null, Attachment2clothingPreset p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, Attachment2clothingPreset p__parent = null, Attachment2clothingPreset p__root = null) : base(p__io)
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
            private Attachment2clothingPreset m_root;
            private Attachment2clothingPreset m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public Attachment2clothingPreset M_Root { get { return m_root; } }
            public Attachment2clothingPreset M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, Attachment2clothingPreset p__parent = null, Attachment2clothingPreset p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _computerName = m_io.ReadS4le();
                _timestamp = m_io.ReadS4le();
                _clothingPresetId = m_io.ReadBytes(16);
                _attachmentBaseId = m_io.ReadBytes(16);
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
            private byte[] _clothingPresetId;
            private byte[] _attachmentBaseId;
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
            private Attachment2clothingPreset m_root;
            private Attachment2clothingPreset m_parent;
            public int ComputerName { get { return _computerName; } }
            public int Timestamp { get { return _timestamp; } }
            public byte[] ClothingPresetId { get { return _clothingPresetId; } }
            public byte[] AttachmentBaseId { get { return _attachmentBaseId; } }
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
            public Attachment2clothingPreset M_Root { get { return m_root; } }
            public Attachment2clothingPreset M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private Attachment2clothingPreset m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public Attachment2clothingPreset M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
