// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class PickableAreaDesc : KaitaiStruct
    {
        public static PickableAreaDesc FromFile(string fileName)
        {
            return new PickableAreaDesc(new KaitaiStream(fileName));
        }

        public PickableAreaDesc(KaitaiStream p__io, KaitaiStruct p__parent = null, PickableAreaDesc p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, PickableAreaDesc p__parent = null, PickableAreaDesc p__root = null) : base(p__io)
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
            private PickableAreaDesc m_root;
            private PickableAreaDesc m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public PickableAreaDesc M_Root { get { return m_root; } }
            public PickableAreaDesc M_Parent { get { return m_parent; } }
        }
        public partial class Padding : KaitaiStruct
        {
            public static Padding FromFile(string fileName)
            {
                return new Padding(new KaitaiStream(fileName));
            }

            public Padding(KaitaiStream p__io, KaitaiStruct p__parent = null, PickableAreaDesc p__root = null) : base(p__io)
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
            private PickableAreaDesc m_root;
            private KaitaiStruct m_parent;
            public byte[] PaddingType { get { return _paddingType; } }
            public PickableAreaDesc M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, PickableAreaDesc p__parent = null, PickableAreaDesc p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _id = m_io.ReadS4le();
                _name = m_io.ReadS4le();
                _amount = m_io.ReadS4le();
                _respawnTime = m_io.ReadF4le();
                _guidItemPicked = m_io.ReadBytes(16);
                _animSpeed = m_io.ReadF4le();
                _animFragment = m_io.ReadS4le();
                _animTags = m_io.ReadS4le();
            }
            private int _id;
            private int _name;
            private int _amount;
            private float _respawnTime;
            private byte[] _guidItemPicked;
            private float _animSpeed;
            private int _animFragment;
            private int _animTags;
            private PickableAreaDesc m_root;
            private PickableAreaDesc m_parent;
            public int Id { get { return _id; } }
            public int Name { get { return _name; } }
            public int Amount { get { return _amount; } }
            public float RespawnTime { get { return _respawnTime; } }
            public byte[] GuidItemPicked { get { return _guidItemPicked; } }
            public float AnimSpeed { get { return _animSpeed; } }
            public int AnimFragment { get { return _animFragment; } }
            public int AnimTags { get { return _animTags; } }
            public PickableAreaDesc M_Root { get { return m_root; } }
            public PickableAreaDesc M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private PickableAreaDesc m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public PickableAreaDesc M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
