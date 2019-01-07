// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai.Tables
{
    public partial class SoulArchetypeMovement : KaitaiStruct
    {
        public static SoulArchetypeMovement FromFile(string fileName)
        {
            return new SoulArchetypeMovement(new KaitaiStream(fileName));
        }

        public SoulArchetypeMovement(KaitaiStream p__io, KaitaiStruct p__parent = null, SoulArchetypeMovement p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, SoulArchetypeMovement p__parent = null, SoulArchetypeMovement p__root = null) : base(p__io)
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
            private SoulArchetypeMovement m_root;
            private SoulArchetypeMovement m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public SoulArchetypeMovement M_Root { get { return m_root; } }
            public SoulArchetypeMovement M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, SoulArchetypeMovement p__parent = null, SoulArchetypeMovement p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _soulArchetypeId = m_io.ReadS4le();
                _stanceId = m_io.ReadS4le();
                _logicalSpeed = m_io.ReadS4le();
                _rpgMovementTypeId = m_io.ReadS4le();
                _realSpeedMin = m_io.ReadF4le();
                _realSpeedMax = m_io.ReadF4le();
                _realBackwardSpeedMin = m_io.ReadF4le();
                _realBackwardSpeedMax = m_io.ReadF4le();
                _mnTag = m_io.ReadS4le();
            }
            private int _soulArchetypeId;
            private int _stanceId;
            private int _logicalSpeed;
            private int _rpgMovementTypeId;
            private float _realSpeedMin;
            private float _realSpeedMax;
            private float _realBackwardSpeedMin;
            private float _realBackwardSpeedMax;
            private int _mnTag;
            private SoulArchetypeMovement m_root;
            private SoulArchetypeMovement m_parent;
            public int SoulArchetypeId { get { return _soulArchetypeId; } }
            public int StanceId { get { return _stanceId; } }
            public int LogicalSpeed { get { return _logicalSpeed; } }
            public int RpgMovementTypeId { get { return _rpgMovementTypeId; } }
            public float RealSpeedMin { get { return _realSpeedMin; } }
            public float RealSpeedMax { get { return _realSpeedMax; } }
            public float RealBackwardSpeedMin { get { return _realBackwardSpeedMin; } }
            public float RealBackwardSpeedMax { get { return _realBackwardSpeedMax; } }
            public int MnTag { get { return _mnTag; } }
            public SoulArchetypeMovement M_Root { get { return m_root; } }
            public SoulArchetypeMovement M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private SoulArchetypeMovement m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public SoulArchetypeMovement M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
