// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class CombatZone : KaitaiStruct
    {
        public static CombatZone FromFile(string fileName)
        {
            return new CombatZone(new KaitaiStream(fileName));
        }

        public CombatZone(KaitaiStream p__io, KaitaiStruct p__parent = null, CombatZone p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, CombatZone p__parent = null, CombatZone p__root = null) : base(p__io)
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
            private CombatZone m_root;
            private CombatZone m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public CombatZone M_Root { get { return m_root; } }
            public CombatZone M_Parent { get { return m_parent; } }
        }
        public partial class Padding : KaitaiStruct
        {
            public static Padding FromFile(string fileName)
            {
                return new Padding(new KaitaiStream(fileName));
            }

            public Padding(KaitaiStream p__io, KaitaiStruct p__parent = null, CombatZone p__root = null) : base(p__io)
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
            private CombatZone m_root;
            private KaitaiStruct m_parent;
            public byte[] PaddingType { get { return _paddingType; } }
            public CombatZone M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, CombatZone p__parent = null, CombatZone p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _combatZoneId = m_io.ReadS4le();
                _combatZoneName = m_io.ReadS4le();
                _attackMnTag = m_io.ReadS4le();
                _radiusFrom = m_io.ReadF4le();
                _radiusTo = m_io.ReadF4le();
                _angleFrom = m_io.ReadF4le();
                _angleTo = m_io.ReadF4le();
                _cursorIdx = m_io.ReadS4le();
                _defenseMnTag = m_io.ReadS4le();
                _startMnTag = m_io.ReadS4le();
                _endMnTag = m_io.ReadS4le();
                _riposteMnTag = m_io.ReadS4le();
                _defaultZone = m_io.ReadS1();
            }
            private int _combatZoneId;
            private int _combatZoneName;
            private int _attackMnTag;
            private float _radiusFrom;
            private float _radiusTo;
            private float _angleFrom;
            private float _angleTo;
            private int _cursorIdx;
            private int _defenseMnTag;
            private int _startMnTag;
            private int _endMnTag;
            private int _riposteMnTag;
            private sbyte _defaultZone;
            private CombatZone m_root;
            private CombatZone m_parent;
            public int CombatZoneId { get { return _combatZoneId; } }
            public int CombatZoneName { get { return _combatZoneName; } }
            public int AttackMnTag { get { return _attackMnTag; } }
            public float RadiusFrom { get { return _radiusFrom; } }
            public float RadiusTo { get { return _radiusTo; } }
            public float AngleFrom { get { return _angleFrom; } }
            public float AngleTo { get { return _angleTo; } }
            public int CursorIdx { get { return _cursorIdx; } }
            public int DefenseMnTag { get { return _defenseMnTag; } }
            public int StartMnTag { get { return _startMnTag; } }
            public int EndMnTag { get { return _endMnTag; } }
            public int RiposteMnTag { get { return _riposteMnTag; } }
            public sbyte DefaultZone { get { return _defaultZone; } }
            public CombatZone M_Root { get { return m_root; } }
            public CombatZone M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private CombatZone m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public CombatZone M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
