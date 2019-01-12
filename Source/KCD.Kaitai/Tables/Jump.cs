// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class Jump : KaitaiStruct
    {
        public static Jump FromFile(string fileName)
        {
            return new Jump(new KaitaiStream(fileName));
        }

        public Jump(KaitaiStream p__io, KaitaiStruct p__parent = null, Jump p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, Jump p__parent = null, Jump p__root = null) : base(p__io)
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
            private Jump m_root;
            private Jump m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public Jump M_Root { get { return m_root; } }
            public Jump M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, Jump p__parent = null, Jump p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _mnMoveSpeedTag = m_io.ReadS4le();
                _mnStanceTag = m_io.ReadS4le();
                _jumpHeight = m_io.ReadF4le();
                _jumpTotalTime = m_io.ReadF4le();
                _jumpPeakTime = m_io.ReadF4le();
                _jumpSpeed = m_io.ReadF4le();
                _jumpLength = m_io.ReadF4le();
                _actorClassHash = m_io.ReadS4le();
                _procClipPresent = m_io.ReadS1();
                _mnFragmentId = m_io.ReadS4le();
                _mnTags = m_io.ReadS4le();
                _mnOptionIndex = m_io.ReadS4le();
                _timestamp = m_io.ReadS8le();
            }
            private int _mnMoveSpeedTag;
            private int _mnStanceTag;
            private float _jumpHeight;
            private float _jumpTotalTime;
            private float _jumpPeakTime;
            private float _jumpSpeed;
            private float _jumpLength;
            private int _actorClassHash;
            private sbyte _procClipPresent;
            private int _mnFragmentId;
            private int _mnTags;
            private int _mnOptionIndex;
            private long _timestamp;
            private Jump m_root;
            private Jump m_parent;
            public int MnMoveSpeedTag { get { return _mnMoveSpeedTag; } }
            public int MnStanceTag { get { return _mnStanceTag; } }
            public float JumpHeight { get { return _jumpHeight; } }
            public float JumpTotalTime { get { return _jumpTotalTime; } }
            public float JumpPeakTime { get { return _jumpPeakTime; } }
            public float JumpSpeed { get { return _jumpSpeed; } }
            public float JumpLength { get { return _jumpLength; } }
            public int ActorClassHash { get { return _actorClassHash; } }
            public sbyte ProcClipPresent { get { return _procClipPresent; } }
            public int MnFragmentId { get { return _mnFragmentId; } }
            public int MnTags { get { return _mnTags; } }
            public int MnOptionIndex { get { return _mnOptionIndex; } }
            public long Timestamp { get { return _timestamp; } }
            public Jump M_Root { get { return m_root; } }
            public Jump M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private Jump m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public Jump M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
