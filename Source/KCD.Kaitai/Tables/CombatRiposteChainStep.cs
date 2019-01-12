// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class CombatRiposteChainStep : KaitaiStruct
    {
        public static CombatRiposteChainStep FromFile(string fileName)
        {
            return new CombatRiposteChainStep(new KaitaiStream(fileName));
        }

        public CombatRiposteChainStep(KaitaiStream p__io, KaitaiStruct p__parent = null, CombatRiposteChainStep p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, CombatRiposteChainStep p__parent = null, CombatRiposteChainStep p__root = null) : base(p__io)
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
            private CombatRiposteChainStep m_root;
            private CombatRiposteChainStep m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public CombatRiposteChainStep M_Root { get { return m_root; } }
            public CombatRiposteChainStep M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, CombatRiposteChainStep p__parent = null, CombatRiposteChainStep p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _combatRiposteChainId = m_io.ReadS4le();
                _step = m_io.ReadS4le();
                _inputClassId = m_io.ReadS4le();
                _defenseCombatZoneId = m_io.ReadS4le();
                _atkCombatZoneId = m_io.ReadS4le();
                _attackTypeId = m_io.ReadS4le();
                _actorIndex = m_io.ReadS4le();
            }
            private int _combatRiposteChainId;
            private int _step;
            private int _inputClassId;
            private int _defenseCombatZoneId;
            private int _atkCombatZoneId;
            private int _attackTypeId;
            private int _actorIndex;
            private CombatRiposteChainStep m_root;
            private CombatRiposteChainStep m_parent;
            public int CombatRiposteChainId { get { return _combatRiposteChainId; } }
            public int Step { get { return _step; } }
            public int InputClassId { get { return _inputClassId; } }
            public int DefenseCombatZoneId { get { return _defenseCombatZoneId; } }
            public int AtkCombatZoneId { get { return _atkCombatZoneId; } }
            public int AttackTypeId { get { return _attackTypeId; } }
            public int ActorIndex { get { return _actorIndex; } }
            public CombatRiposteChainStep M_Root { get { return m_root; } }
            public CombatRiposteChainStep M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private CombatRiposteChainStep m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public CombatRiposteChainStep M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
