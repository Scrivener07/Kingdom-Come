// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai
{
    public partial class Table : KaitaiStruct
    {
        public static Table FromFile(string fileName)
        {
            return new Table(new KaitaiStream(fileName));
        }

        public Table(KaitaiStream p__io, KaitaiStruct p__parent = null, Table p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _tblHeader = new Header(m_io, this, m_root);
            _lines = new List<Line>((int) (TblHeader.LineCount));
            for (var i = 0; i < TblHeader.LineCount; i++)
            {
                _lines.Add(new Line(m_io, this, m_root));
            }
            _strings = new List<string>((int) (TblHeader.UniqueStringsCount));
            for (var i = 0; i < TblHeader.UniqueStringsCount; i++)
            {
                _strings.Add(System.Text.Encoding.GetEncoding("utf-8").GetString(m_io.ReadBytesTerm(0, false, true, true)));
            }
        }
        public partial class AlignmentType : KaitaiStruct
        {
            public static AlignmentType FromFile(string fileName)
            {
                return new AlignmentType(new KaitaiStream(fileName));
            }

            public AlignmentType(KaitaiStream p__io, KaitaiStruct p__parent = null, Table p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _alignmentId = m_io.ReadBytes(KaitaiStream.Mod((4 - M_Io.Pos), 4));
            }
            private byte[] _alignmentId;
            private Table m_root;
            private KaitaiStruct m_parent;
            public byte[] AlignmentId { get { return _alignmentId; } }
            public Table M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Header : KaitaiStruct
        {
            public static Header FromFile(string fileName)
            {
                return new Header(new KaitaiStream(fileName));
            }

            public Header(KaitaiStream p__io, Table p__parent = null, Table p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _version = m_io.ReadS4le();
                _descriptors = m_io.ReadU4le();
                _layout = m_io.ReadU4le();
                _tableVersion = m_io.ReadS4le();
                _lineCount = m_io.ReadS4le();
                _stringDataSize = m_io.ReadS4le();
                _uniqueStringsCount = m_io.ReadS4le();
            }
            private int _version;
            private uint _descriptors;
            private uint _layout;
            private int _tableVersion;
            private int _lineCount;
            private int _stringDataSize;
            private int _uniqueStringsCount;
            private Table m_root;
            private Table m_parent;
            public int Version { get { return _version; } }
            public uint Descriptors { get { return _descriptors; } }
            public uint Layout { get { return _layout; } }
            public int TableVersion { get { return _tableVersion; } }
            public int LineCount { get { return _lineCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public Table M_Root { get { return m_root; } }
            public Table M_Parent { get { return m_parent; } }
        }
        public partial class Line : KaitaiStruct
        {
            public static Line FromFile(string fileName)
            {
                return new Line(new KaitaiStream(fileName));
            }

            public Line(KaitaiStream p__io, Table p__parent = null, Table p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _id = m_io.ReadS8le();
                _name = m_io.ReadS8le();
                _text = m_io.ReadS8le();
                _type = m_io.ReadS8le();
            }
            private long _id;
            private long _name;
            private long _text;
            private long _type;
            private Table m_root;
            private Table m_parent;
            public long Id { get { return _id; } }
            public long Name { get { return _name; } }
            public long Text { get { return _text; } }
            public long Type { get { return _type; } }
            public Table M_Root { get { return m_root; } }
            public Table M_Parent { get { return m_parent; } }
        }
        private Header _tblHeader;
        private List<Line> _lines;
        private List<string> _strings;
        private Table m_root;
        private KaitaiStruct m_parent;
        public Header TblHeader { get { return _tblHeader; } }
        public List<Line> Lines { get { return _lines; } }
        public List<string> Strings { get { return _strings; } }
        public Table M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
