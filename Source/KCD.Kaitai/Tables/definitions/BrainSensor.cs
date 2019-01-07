// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai.Tables
{
    public partial class BrainSensor : KaitaiStruct
    {
        public static BrainSensor FromFile(string fileName)
        {
            return new BrainSensor(new KaitaiStream(fileName));
        }

        public BrainSensor(KaitaiStream p__io, KaitaiStruct p__parent = null, BrainSensor p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, BrainSensor p__parent = null, BrainSensor p__root = null) : base(p__io)
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
            private BrainSensor m_root;
            private BrainSensor m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public BrainSensor M_Root { get { return m_root; } }
            public BrainSensor M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, BrainSensor p__parent = null, BrainSensor p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _brainSensorId = m_io.ReadBytes(16);
                _brainSensorName = m_io.ReadS4le();
                _brainSensorType = m_io.ReadS4le();
                _range = m_io.ReadF4le();
                _fieldOfView = m_io.ReadF4le();
                _directionX = m_io.ReadF4le();
                _directionY = m_io.ReadF4le();
                _directionZ = m_io.ReadF4le();
                _positionX = m_io.ReadF4le();
                _positionY = m_io.ReadF4le();
                _positionZ = m_io.ReadF4le();
            }
            private byte[] _brainSensorId;
            private int _brainSensorName;
            private int _brainSensorType;
            private float _range;
            private float _fieldOfView;
            private float _directionX;
            private float _directionY;
            private float _directionZ;
            private float _positionX;
            private float _positionY;
            private float _positionZ;
            private BrainSensor m_root;
            private BrainSensor m_parent;
            public byte[] BrainSensorId { get { return _brainSensorId; } }
            public int BrainSensorName { get { return _brainSensorName; } }
            public int BrainSensorType { get { return _brainSensorType; } }
            public float Range { get { return _range; } }
            public float FieldOfView { get { return _fieldOfView; } }
            public float DirectionX { get { return _directionX; } }
            public float DirectionY { get { return _directionY; } }
            public float DirectionZ { get { return _directionZ; } }
            public float PositionX { get { return _positionX; } }
            public float PositionY { get { return _positionY; } }
            public float PositionZ { get { return _positionZ; } }
            public BrainSensor M_Root { get { return m_root; } }
            public BrainSensor M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private BrainSensor m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public BrainSensor M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
