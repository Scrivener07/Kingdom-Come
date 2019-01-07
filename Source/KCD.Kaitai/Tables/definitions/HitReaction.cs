// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai.Tables
{
    public partial class HitReaction : KaitaiStruct
    {
        public static HitReaction FromFile(string fileName)
        {
            return new HitReaction(new KaitaiStream(fileName));
        }

        public HitReaction(KaitaiStream p__io, KaitaiStruct p__parent = null, HitReaction p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, HitReaction p__parent = null, HitReaction p__root = null) : base(p__io)
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
            private HitReaction m_root;
            private HitReaction m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public HitReaction M_Root { get { return m_root; } }
            public HitReaction M_Parent { get { return m_parent; } }
        }
        public partial class Padding : KaitaiStruct
        {
            public static Padding FromFile(string fileName)
            {
                return new Padding(new KaitaiStream(fileName));
            }

            public Padding(KaitaiStream p__io, KaitaiStruct p__parent = null, HitReaction p__root = null) : base(p__io)
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
            private HitReaction m_root;
            private KaitaiStruct m_parent;
            public byte[] PaddingType { get { return _paddingType; } }
            public HitReaction M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, HitReaction p__parent = null, HitReaction p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _actorClassHash = m_io.ReadS4le();
                _mnFragmentIdStr = m_io.ReadS4le();
                _mnTagStateStr = m_io.ReadS4le();
                _mnOptionIndex = m_io.ReadS4le();
                _timestamp = m_io.ReadS8le();
                _isFullbody = m_io.ReadS1();
                _hitReactionTypeId = m_io.ReadS4le();
                _speedTag = m_io.ReadS4le();
                _stanceTag = m_io.ReadS4le();
                _isMounted = m_io.ReadS1();
                _isCarryCorpse = m_io.ReadS1();
                _isPlayer = m_io.ReadS1();
                _rAttackerManType = m_io.ReadS4le();
                _lAttackerManType = m_io.ReadS4le();
                _rTargetManType = m_io.ReadS4le();
                _lTargetManType = m_io.ReadS4le();
            }
            private int _actorClassHash;
            private int _mnFragmentIdStr;
            private int _mnTagStateStr;
            private int _mnOptionIndex;
            private long _timestamp;
            private sbyte _isFullbody;
            private int _hitReactionTypeId;
            private int _speedTag;
            private int _stanceTag;
            private sbyte _isMounted;
            private sbyte _isCarryCorpse;
            private sbyte _isPlayer;
            private int _rAttackerManType;
            private int _lAttackerManType;
            private int _rTargetManType;
            private int _lTargetManType;
            private HitReaction m_root;
            private HitReaction m_parent;
            public int ActorClassHash { get { return _actorClassHash; } }
            public int MnFragmentIdStr { get { return _mnFragmentIdStr; } }
            public int MnTagStateStr { get { return _mnTagStateStr; } }
            public int MnOptionIndex { get { return _mnOptionIndex; } }
            public long Timestamp { get { return _timestamp; } }
            public sbyte IsFullbody { get { return _isFullbody; } }
            public int HitReactionTypeId { get { return _hitReactionTypeId; } }
            public int SpeedTag { get { return _speedTag; } }
            public int StanceTag { get { return _stanceTag; } }
            public sbyte IsMounted { get { return _isMounted; } }
            public sbyte IsCarryCorpse { get { return _isCarryCorpse; } }
            public sbyte IsPlayer { get { return _isPlayer; } }
            public int RAttackerManType { get { return _rAttackerManType; } }
            public int LAttackerManType { get { return _lAttackerManType; } }
            public int RTargetManType { get { return _rTargetManType; } }
            public int LTargetManType { get { return _lTargetManType; } }
            public HitReaction M_Root { get { return m_root; } }
            public HitReaction M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private HitReaction m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public HitReaction M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
