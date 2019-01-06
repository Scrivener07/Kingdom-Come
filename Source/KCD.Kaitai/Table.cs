// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai
{

    /// <summary>
    /// Tabular data which represents rows and columns.
    /// </summary>
    /// <remarks>
    /// Reference: <a href="https://wiki.fireundubh.com/kingdomcome">Source</a>
    /// </remarks>
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
            _header = new HeaderType(m_io, this, m_root);
            if (Header.Descriptors == 3684099990) {
                _rowDlc = new List<Dlc>((int) (Header.LineCount));
                for (var i = 0; i < Header.LineCount; i++)
                {
                    _rowDlc.Add(new Dlc(m_io, this, m_root));
                }
            }
            if (Header.Descriptors == 1831475791) {
                _rowGameOver = new List<GameOver>((int) (Header.LineCount));
                for (var i = 0; i < Header.LineCount; i++)
                {
                    _rowGameOver.Add(new GameOver(m_io, this, m_root));
                }
            }
            if (Header.UniqueStringsCount > 0) {
                _strings = new List<KeyValuePair>((int) (Header.LineCount));
                for (var i = 0; i < Header.LineCount; i++)
                {
                    _strings.Add(new KeyValuePair(m_io, this, m_root));
                }
            }
        }
        public partial class TableAlignment : KaitaiStruct
        {
            public static TableAlignment FromFile(string fileName)
            {
                return new TableAlignment(new KaitaiStream(fileName));
            }

            public TableAlignment(KaitaiStream p__io, KaitaiStruct p__parent = null, Table p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _padding = m_io.ReadBytes(KaitaiStream.Mod((4 - M_Io.Pos), 4));
            }
            private byte[] _padding;
            private Table m_root;
            private KaitaiStruct m_parent;
            public byte[] Padding { get { return _padding; } }
            public Table M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class HeaderType : KaitaiStruct
        {
            public static HeaderType FromFile(string fileName)
            {
                return new HeaderType(new KaitaiStream(fileName));
            }

            public HeaderType(KaitaiStream p__io, Table p__parent = null, Table p__root = null) : base(p__io)
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
        public partial class GameOver : KaitaiStruct
        {
            public static GameOver FromFile(string fileName)
            {
                return new GameOver(new KaitaiStream(fileName));
            }

            public GameOver(KaitaiStream p__io, Table p__parent = null, Table p__root = null) : base(p__io)
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
        public partial class KeyValuePair : KaitaiStruct
        {
            public static KeyValuePair FromFile(string fileName)
            {
                return new KeyValuePair(new KaitaiStream(fileName));
            }

            public KeyValuePair(KaitaiStream p__io, Table p__parent = null, Table p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _key = System.Text.Encoding.GetEncoding("utf-8").GetString(m_io.ReadBytesTerm(0, false, true, true));
                _value = System.Text.Encoding.GetEncoding("utf-8").GetString(m_io.ReadBytesTerm(0, false, true, true));
            }
            private string _key;
            private string _value;
            private Table m_root;
            private Table m_parent;
            public string Key { get { return _key; } }
            public string Value { get { return _value; } }
            public Table M_Root { get { return m_root; } }
            public Table M_Parent { get { return m_parent; } }
        }
        public partial class Dlc : KaitaiStruct
        {
            public static Dlc FromFile(string fileName)
            {
                return new Dlc(new KaitaiStream(fileName));
            }

            public Dlc(KaitaiStream p__io, Table p__parent = null, Table p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _dlcId = m_io.ReadS4le();
                _affectsSavegame = m_io.ReadS2le();
                _needMount = m_io.ReadS2le();
            }
            private int _dlcId;
            private short _affectsSavegame;
            private short _needMount;
            private Table m_root;
            private Table m_parent;
            public int DlcId { get { return _dlcId; } }
            public short AffectsSavegame { get { return _affectsSavegame; } }
            public short NeedMount { get { return _needMount; } }
            public Table M_Root { get { return m_root; } }
            public Table M_Parent { get { return m_parent; } }
        }
        private HeaderType _header;
        private List<Dlc> _rowDlc;
        private List<GameOver> _rowGameOver;
        private List<KeyValuePair> _strings;
        private Table m_root;
        private KaitaiStruct m_parent;
        public HeaderType Header { get { return _header; } }
        public List<Dlc> RowDlc { get { return _rowDlc; } }
        public List<GameOver> RowGameOver { get { return _rowGameOver; } }
        public List<KeyValuePair> Strings { get { return _strings; } }
        public Table M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
