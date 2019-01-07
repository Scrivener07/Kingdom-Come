// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai.Tables
{
    public partial class CombatNativeGuardZone : KaitaiStruct
    {
        public static CombatNativeGuardZone FromFile(string fileName)
        {
            return new CombatNativeGuardZone(new KaitaiStream(fileName));
        }

        public CombatNativeGuardZone(KaitaiStream p__io, KaitaiStruct p__parent = null, CombatNativeGuardZone p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, CombatNativeGuardZone p__parent = null, CombatNativeGuardZone p__root = null) : base(p__io)
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
            private CombatNativeGuardZone m_root;
            private CombatNativeGuardZone m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public CombatNativeGuardZone M_Root { get { return m_root; } }
            public CombatNativeGuardZone M_Parent { get { return m_parent; } }
        }
        public partial class Padding : KaitaiStruct
        {
            public static Padding FromFile(string fileName)
            {
                return new Padding(new KaitaiStream(fileName));
            }

            public Padding(KaitaiStream p__io, KaitaiStruct p__parent = null, CombatNativeGuardZone p__root = null) : base(p__io)
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
            private CombatNativeGuardZone m_root;
            private KaitaiStruct m_parent;
            public byte[] PaddingType { get { return _paddingType; } }
            public CombatNativeGuardZone M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, CombatNativeGuardZone p__parent = null, CombatNativeGuardZone p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _combatGuardStanceId = m_io.ReadS4le();
                _combatZoneId = m_io.ReadS4le();
                _rWeaponClassId = m_io.ReadS4le();
                _lWeaponClassId = m_io.ReadS4le();
                _rCombatWeaponGroupId = m_io.ReadS4le();
                _lCombatWeaponGroupId = m_io.ReadS4le();
            }
            private int _combatGuardStanceId;
            private int _combatZoneId;
            private int _rWeaponClassId;
            private int _lWeaponClassId;
            private int _rCombatWeaponGroupId;
            private int _lCombatWeaponGroupId;
            private CombatNativeGuardZone m_root;
            private CombatNativeGuardZone m_parent;
            public int CombatGuardStanceId { get { return _combatGuardStanceId; } }
            public int CombatZoneId { get { return _combatZoneId; } }
            public int RWeaponClassId { get { return _rWeaponClassId; } }
            public int LWeaponClassId { get { return _lWeaponClassId; } }
            public int RCombatWeaponGroupId { get { return _rCombatWeaponGroupId; } }
            public int LCombatWeaponGroupId { get { return _lCombatWeaponGroupId; } }
            public CombatNativeGuardZone M_Root { get { return m_root; } }
            public CombatNativeGuardZone M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private CombatNativeGuardZone m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public CombatNativeGuardZone M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
