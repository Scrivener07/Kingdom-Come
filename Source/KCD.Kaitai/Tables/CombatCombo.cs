// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class CombatCombo : KaitaiStruct
    {
        public static CombatCombo FromFile(string fileName)
        {
            return new CombatCombo(new KaitaiStream(fileName));
        }

        public CombatCombo(KaitaiStream p__io, KaitaiStruct p__parent = null, CombatCombo p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, CombatCombo p__parent = null, CombatCombo p__root = null) : base(p__io)
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
            private CombatCombo m_root;
            private CombatCombo m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public CombatCombo M_Root { get { return m_root; } }
            public CombatCombo M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, CombatCombo p__parent = null, CombatCombo p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _combatComboId = m_io.ReadS4le();
                _combatComboStrid = m_io.ReadS4le();
                _combatComboName = m_io.ReadS4le();
                _atkRWeaponClassId = m_io.ReadS4le();
                _atkLWeaponClassId = m_io.ReadS4le();
                _atkRWeaponGroupId = m_io.ReadS4le();
                _atkLWeaponGroupId = m_io.ReadS4le();
            }
            private int _combatComboId;
            private int _combatComboStrid;
            private int _combatComboName;
            private int _atkRWeaponClassId;
            private int _atkLWeaponClassId;
            private int _atkRWeaponGroupId;
            private int _atkLWeaponGroupId;
            private CombatCombo m_root;
            private CombatCombo m_parent;
            public int CombatComboId { get { return _combatComboId; } }
            public int CombatComboStrid { get { return _combatComboStrid; } }
            public int CombatComboName { get { return _combatComboName; } }
            public int AtkRWeaponClassId { get { return _atkRWeaponClassId; } }
            public int AtkLWeaponClassId { get { return _atkLWeaponClassId; } }
            public int AtkRWeaponGroupId { get { return _atkRWeaponGroupId; } }
            public int AtkLWeaponGroupId { get { return _atkLWeaponGroupId; } }
            public CombatCombo M_Root { get { return m_root; } }
            public CombatCombo M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private CombatCombo m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public CombatCombo M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
