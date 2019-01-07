// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai.Tables
{
    public partial class Perk : KaitaiStruct
    {
        public static Perk FromFile(string fileName)
        {
            return new Perk(new KaitaiStream(fileName));
        }

        public Perk(KaitaiStream p__io, KaitaiStruct p__parent = null, Perk p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, Perk p__parent = null, Perk p__root = null) : base(p__io)
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
            private Perk m_root;
            private Perk m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public Perk M_Root { get { return m_root; } }
            public Perk M_Parent { get { return m_parent; } }
        }
        public partial class Padding : KaitaiStruct
        {
            public static Padding FromFile(string fileName)
            {
                return new Padding(new KaitaiStream(fileName));
            }

            public Padding(KaitaiStream p__io, KaitaiStruct p__parent = null, Perk p__root = null) : base(p__io)
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
            private Perk m_root;
            private KaitaiStruct m_parent;
            public byte[] PaddingType { get { return _paddingType; } }
            public Perk M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, Perk p__parent = null, Perk p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _perkId = m_io.ReadBytes(16);
                _parentId = m_io.ReadBytes(16);
                _perkName = m_io.ReadS4le();
                _perkUiName = m_io.ReadS4le();
                _perkUiDesc = m_io.ReadS4le();
                _iconId = m_io.ReadS4le();
                _statSelector = m_io.ReadS4le();
                _skillSelector = m_io.ReadS4le();
                _level = m_io.ReadS4le();
                _visibility = m_io.ReadS4le();
                _metaperkId = m_io.ReadBytes(16);
                _uiPriority = m_io.ReadS4le();
            }
            private byte[] _perkId;
            private byte[] _parentId;
            private int _perkName;
            private int _perkUiName;
            private int _perkUiDesc;
            private int _iconId;
            private int _statSelector;
            private int _skillSelector;
            private int _level;
            private int _visibility;
            private byte[] _metaperkId;
            private int _uiPriority;
            private Perk m_root;
            private Perk m_parent;
            public byte[] PerkId { get { return _perkId; } }
            public byte[] ParentId { get { return _parentId; } }
            public int PerkName { get { return _perkName; } }
            public int PerkUiName { get { return _perkUiName; } }
            public int PerkUiDesc { get { return _perkUiDesc; } }
            public int IconId { get { return _iconId; } }
            public int StatSelector { get { return _statSelector; } }
            public int SkillSelector { get { return _skillSelector; } }
            public int Level { get { return _level; } }
            public int Visibility { get { return _visibility; } }
            public byte[] MetaperkId { get { return _metaperkId; } }
            public int UiPriority { get { return _uiPriority; } }
            public Perk M_Root { get { return m_root; } }
            public Perk M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private Perk m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public Perk M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
