// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class Skill : KaitaiStruct
    {
        public static Skill FromFile(string fileName)
        {
            return new Skill(new KaitaiStream(fileName));
        }

        public Skill(KaitaiStream p__io, KaitaiStruct p__parent = null, Skill p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, Skill p__parent = null, Skill p__root = null) : base(p__io)
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
            private Skill m_root;
            private Skill m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public Skill M_Root { get { return m_root; } }
            public Skill M_Parent { get { return m_parent; } }
        }
        public partial class Padding : KaitaiStruct
        {
            public static Padding FromFile(string fileName)
            {
                return new Padding(new KaitaiStream(fileName));
            }

            public Padding(KaitaiStream p__io, KaitaiStruct p__parent = null, Skill p__root = null) : base(p__io)
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
            private Skill m_root;
            private KaitaiStruct m_parent;
            public byte[] PaddingType { get { return _paddingType; } }
            public Skill M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, Skill p__parent = null, Skill p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _skillId = m_io.ReadS4le();
                _skillName = m_io.ReadS4le();
                _iconId = m_io.ReadS4le();
                _skillDescNolevel = m_io.ReadS4le();
                _skillDescBeginner = m_io.ReadS4le();
                _skillDescAdept = m_io.ReadS4le();
                _skillDescExpert = m_io.ReadS4le();
                _skillDescMaster = m_io.ReadS4le();
                _uiStringName = m_io.ReadS4le();
                _uiLevelupStringName = m_io.ReadS4le();
                _inducedSkillId = m_io.ReadS4le();
                _hidden = m_io.ReadS1();
            }
            private int _skillId;
            private int _skillName;
            private int _iconId;
            private int _skillDescNolevel;
            private int _skillDescBeginner;
            private int _skillDescAdept;
            private int _skillDescExpert;
            private int _skillDescMaster;
            private int _uiStringName;
            private int _uiLevelupStringName;
            private int _inducedSkillId;
            private sbyte _hidden;
            private Skill m_root;
            private Skill m_parent;
            public int SkillId { get { return _skillId; } }
            public int SkillName { get { return _skillName; } }
            public int IconId { get { return _iconId; } }
            public int SkillDescNolevel { get { return _skillDescNolevel; } }
            public int SkillDescBeginner { get { return _skillDescBeginner; } }
            public int SkillDescAdept { get { return _skillDescAdept; } }
            public int SkillDescExpert { get { return _skillDescExpert; } }
            public int SkillDescMaster { get { return _skillDescMaster; } }
            public int UiStringName { get { return _uiStringName; } }
            public int UiLevelupStringName { get { return _uiLevelupStringName; } }
            public int InducedSkillId { get { return _inducedSkillId; } }
            public sbyte Hidden { get { return _hidden; } }
            public Skill M_Root { get { return m_root; } }
            public Skill M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private Skill m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public Skill M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
