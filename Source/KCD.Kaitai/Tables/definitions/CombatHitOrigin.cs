// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai.Tables
{
    public partial class CombatHitOrigin : KaitaiStruct
    {
        public static CombatHitOrigin FromFile(string fileName)
        {
            return new CombatHitOrigin(new KaitaiStream(fileName));
        }

        public CombatHitOrigin(KaitaiStream p__io, KaitaiStruct p__parent = null, CombatHitOrigin p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, CombatHitOrigin p__parent = null, CombatHitOrigin p__root = null) : base(p__io)
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
            private CombatHitOrigin m_root;
            private CombatHitOrigin m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public CombatHitOrigin M_Root { get { return m_root; } }
            public CombatHitOrigin M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, CombatHitOrigin p__parent = null, CombatHitOrigin p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _combatHitOriginId = m_io.ReadS4le();
                _combatHitOriginName = m_io.ReadS4le();
                _mnTag = m_io.ReadS4le();
                _angleFrom = m_io.ReadF4le();
                _angleTo = m_io.ReadF4le();
            }
            private int _combatHitOriginId;
            private int _combatHitOriginName;
            private int _mnTag;
            private float _angleFrom;
            private float _angleTo;
            private CombatHitOrigin m_root;
            private CombatHitOrigin m_parent;
            public int CombatHitOriginId { get { return _combatHitOriginId; } }
            public int CombatHitOriginName { get { return _combatHitOriginName; } }
            public int MnTag { get { return _mnTag; } }
            public float AngleFrom { get { return _angleFrom; } }
            public float AngleTo { get { return _angleTo; } }
            public CombatHitOrigin M_Root { get { return m_root; } }
            public CombatHitOrigin M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private CombatHitOrigin m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public CombatHitOrigin M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
