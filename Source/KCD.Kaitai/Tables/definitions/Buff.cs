// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai.Tables
{
    public partial class Buff : KaitaiStruct
    {
        public static Buff FromFile(string fileName)
        {
            return new Buff(new KaitaiStream(fileName));
        }

        public Buff(KaitaiStream p__io, KaitaiStruct p__parent = null, Buff p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, Buff p__parent = null, Buff p__root = null) : base(p__io)
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
            private Buff m_root;
            private Buff m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public Buff M_Root { get { return m_root; } }
            public Buff M_Parent { get { return m_parent; } }
        }
        public partial class Padding : KaitaiStruct
        {
            public static Padding FromFile(string fileName)
            {
                return new Padding(new KaitaiStream(fileName));
            }

            public Padding(KaitaiStream p__io, KaitaiStruct p__parent = null, Buff p__root = null) : base(p__io)
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
            private Buff m_root;
            private KaitaiStruct m_parent;
            public byte[] PaddingType { get { return _paddingType; } }
            public Buff M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, Buff p__parent = null, Buff p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _buffId = m_io.ReadBytes(16);
                _buffName = m_io.ReadS4le();
                _buffDesc = m_io.ReadS4le();
                _buffClassId = m_io.ReadS4le();
                _iconId = m_io.ReadS4le();
                _duration = m_io.ReadF4le();
                _buffExclusivityId = m_io.ReadS4le();
                _implementation = m_io.ReadS4le();
                _params = m_io.ReadS4le();
                _buffUiName = m_io.ReadS4le();
                _buffUiTypeId = m_io.ReadS4le();
                _buffAiTagId = m_io.ReadS4le();
                _buffUiOrder = m_io.ReadS4le();
                _isPersistent = m_io.ReadS1();
                _visualEffect = m_io.ReadS4le();
                _slotIconId = m_io.ReadS4le();
                _slotBuffUiName = m_io.ReadS4le();
                _buffLifetimeId = m_io.ReadS4le();
                _buffUiVisibilityId = m_io.ReadS4le();
            }
            private byte[] _buffId;
            private int _buffName;
            private int _buffDesc;
            private int _buffClassId;
            private int _iconId;
            private float _duration;
            private int _buffExclusivityId;
            private int _implementation;
            private int _params;
            private int _buffUiName;
            private int _buffUiTypeId;
            private int _buffAiTagId;
            private int _buffUiOrder;
            private sbyte _isPersistent;
            private int _visualEffect;
            private int _slotIconId;
            private int _slotBuffUiName;
            private int _buffLifetimeId;
            private int _buffUiVisibilityId;
            private Buff m_root;
            private Buff m_parent;
            public byte[] BuffId { get { return _buffId; } }
            public int BuffName { get { return _buffName; } }
            public int BuffDesc { get { return _buffDesc; } }
            public int BuffClassId { get { return _buffClassId; } }
            public int IconId { get { return _iconId; } }
            public float Duration { get { return _duration; } }
            public int BuffExclusivityId { get { return _buffExclusivityId; } }
            public int Implementation { get { return _implementation; } }
            public int Params { get { return _params; } }
            public int BuffUiName { get { return _buffUiName; } }
            public int BuffUiTypeId { get { return _buffUiTypeId; } }
            public int BuffAiTagId { get { return _buffAiTagId; } }
            public int BuffUiOrder { get { return _buffUiOrder; } }
            public sbyte IsPersistent { get { return _isPersistent; } }
            public int VisualEffect { get { return _visualEffect; } }
            public int SlotIconId { get { return _slotIconId; } }
            public int SlotBuffUiName { get { return _slotBuffUiName; } }
            public int BuffLifetimeId { get { return _buffLifetimeId; } }
            public int BuffUiVisibilityId { get { return _buffUiVisibilityId; } }
            public Buff M_Root { get { return m_root; } }
            public Buff M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private Buff m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public Buff M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
