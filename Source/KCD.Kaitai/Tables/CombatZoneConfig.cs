// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class CombatZoneConfig : KaitaiStruct
    {
        public static CombatZoneConfig FromFile(string fileName)
        {
            return new CombatZoneConfig(new KaitaiStream(fileName));
        }

        public CombatZoneConfig(KaitaiStream p__io, KaitaiStruct p__parent = null, CombatZoneConfig p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, CombatZoneConfig p__parent = null, CombatZoneConfig p__root = null) : base(p__io)
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
            private CombatZoneConfig m_root;
            private CombatZoneConfig m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public CombatZoneConfig M_Root { get { return m_root; } }
            public CombatZoneConfig M_Parent { get { return m_parent; } }
        }
        public partial class Padding : KaitaiStruct
        {
            public static Padding FromFile(string fileName)
            {
                return new Padding(new KaitaiStream(fileName));
            }

            public Padding(KaitaiStream p__io, KaitaiStruct p__parent = null, CombatZoneConfig p__root = null) : base(p__io)
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
            private CombatZoneConfig m_root;
            private KaitaiStruct m_parent;
            public byte[] PaddingType { get { return _paddingType; } }
            public CombatZoneConfig M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, CombatZoneConfig p__parent = null, CombatZoneConfig p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _combatZoneConfigId = m_io.ReadS4le();
                _combatZoneId = m_io.ReadS4le();
                _guardStanceId = m_io.ReadS4le();
                _rWeaponClassId = m_io.ReadS4le();
                _lWeaponClassId = m_io.ReadS4le();
                _rCombatWeaponGroupId = m_io.ReadS4le();
                _lCombatWeaponGroupId = m_io.ReadS4le();
                _guardWeight = m_io.ReadF4le();
            }
            private int _combatZoneConfigId;
            private int _combatZoneId;
            private int _guardStanceId;
            private int _rWeaponClassId;
            private int _lWeaponClassId;
            private int _rCombatWeaponGroupId;
            private int _lCombatWeaponGroupId;
            private float _guardWeight;
            private CombatZoneConfig m_root;
            private CombatZoneConfig m_parent;
            public int CombatZoneConfigId { get { return _combatZoneConfigId; } }
            public int CombatZoneId { get { return _combatZoneId; } }
            public int GuardStanceId { get { return _guardStanceId; } }
            public int RWeaponClassId { get { return _rWeaponClassId; } }
            public int LWeaponClassId { get { return _lWeaponClassId; } }
            public int RCombatWeaponGroupId { get { return _rCombatWeaponGroupId; } }
            public int LCombatWeaponGroupId { get { return _lCombatWeaponGroupId; } }
            public float GuardWeight { get { return _guardWeight; } }
            public CombatZoneConfig M_Root { get { return m_root; } }
            public CombatZoneConfig M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private CombatZoneConfig m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public CombatZoneConfig M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
