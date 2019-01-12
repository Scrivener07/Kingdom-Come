// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class ActorActionStandup : KaitaiStruct
    {
        public static ActorActionStandup FromFile(string fileName)
        {
            return new ActorActionStandup(new KaitaiStream(fileName));
        }

        public ActorActionStandup(KaitaiStream p__io, KaitaiStruct p__parent = null, ActorActionStandup p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, ActorActionStandup p__parent = null, ActorActionStandup p__root = null) : base(p__io)
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
            private ActorActionStandup m_root;
            private ActorActionStandup m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public ActorActionStandup M_Root { get { return m_root; } }
            public ActorActionStandup M_Parent { get { return m_parent; } }
        }
        public partial class Padding : KaitaiStruct
        {
            public static Padding FromFile(string fileName)
            {
                return new Padding(new KaitaiStream(fileName));
            }

            public Padding(KaitaiStream p__io, KaitaiStruct p__parent = null, ActorActionStandup p__root = null) : base(p__io)
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
            private ActorActionStandup m_root;
            private KaitaiStruct m_parent;
            public byte[] PaddingType { get { return _paddingType; } }
            public ActorActionStandup M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, ActorActionStandup p__parent = null, ActorActionStandup p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _mounted = m_io.ReadS1();
                _actorActionTypeId = m_io.ReadS4le();
                _actorActionTypeIdRequest = m_io.ReadS4le();
                _actorPoseId = m_io.ReadS4le();
                _actorActivityId = m_io.ReadS4le();
                _actorClassHash = m_io.ReadS4le();
                _timestamp = m_io.ReadS8le();
                _mnFragmentId = m_io.ReadS4le();
                _mnTags = m_io.ReadS4le();
                _mnOptionIndex = m_io.ReadS4le();
                _animationDuration = m_io.ReadF4le();
                _lManId = m_io.ReadS4le();
                _rManId = m_io.ReadS4le();
                _lEquipManId = m_io.ReadS4le();
                _rEquipManId = m_io.ReadS4le();
                _animationId = m_io.ReadS4le();
            }
            private sbyte _mounted;
            private int _actorActionTypeId;
            private int _actorActionTypeIdRequest;
            private int _actorPoseId;
            private int _actorActivityId;
            private int _actorClassHash;
            private long _timestamp;
            private int _mnFragmentId;
            private int _mnTags;
            private int _mnOptionIndex;
            private float _animationDuration;
            private int _lManId;
            private int _rManId;
            private int _lEquipManId;
            private int _rEquipManId;
            private int _animationId;
            private ActorActionStandup m_root;
            private ActorActionStandup m_parent;
            public sbyte Mounted { get { return _mounted; } }
            public int ActorActionTypeId { get { return _actorActionTypeId; } }
            public int ActorActionTypeIdRequest { get { return _actorActionTypeIdRequest; } }
            public int ActorPoseId { get { return _actorPoseId; } }
            public int ActorActivityId { get { return _actorActivityId; } }
            public int ActorClassHash { get { return _actorClassHash; } }
            public long Timestamp { get { return _timestamp; } }
            public int MnFragmentId { get { return _mnFragmentId; } }
            public int MnTags { get { return _mnTags; } }
            public int MnOptionIndex { get { return _mnOptionIndex; } }
            public float AnimationDuration { get { return _animationDuration; } }
            public int LManId { get { return _lManId; } }
            public int RManId { get { return _rManId; } }
            public int LEquipManId { get { return _lEquipManId; } }
            public int REquipManId { get { return _rEquipManId; } }
            public int AnimationId { get { return _animationId; } }
            public ActorActionStandup M_Root { get { return m_root; } }
            public ActorActionStandup M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private ActorActionStandup m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public ActorActionStandup M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
