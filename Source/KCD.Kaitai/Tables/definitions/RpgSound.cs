// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai.Tables
{
    public partial class RpgSound : KaitaiStruct
    {
        public static RpgSound FromFile(string fileName)
        {
            return new RpgSound(new KaitaiStream(fileName));
        }

        public RpgSound(KaitaiStream p__io, KaitaiStruct p__parent = null, RpgSound p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, RpgSound p__parent = null, RpgSound p__root = null) : base(p__io)
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
            private RpgSound m_root;
            private RpgSound m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public RpgSound M_Root { get { return m_root; } }
            public RpgSound M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, RpgSound p__parent = null, RpgSound p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _rpgSoundId = m_io.ReadS4le();
                _rpgSoundName = m_io.ReadS4le();
                _intensityPerSecond = m_io.ReadF4le();
                _intensityOneshot = m_io.ReadF4le();
                _decrementPerSecond = m_io.ReadF4le();
                _notificationCooldown = m_io.ReadF4le();
                _notificationThreshold = m_io.ReadF4le();
                _noisinessMultiplier = m_io.ReadF4le();
            }
            private int _rpgSoundId;
            private int _rpgSoundName;
            private float _intensityPerSecond;
            private float _intensityOneshot;
            private float _decrementPerSecond;
            private float _notificationCooldown;
            private float _notificationThreshold;
            private float _noisinessMultiplier;
            private RpgSound m_root;
            private RpgSound m_parent;
            public int RpgSoundId { get { return _rpgSoundId; } }
            public int RpgSoundName { get { return _rpgSoundName; } }
            public float IntensityPerSecond { get { return _intensityPerSecond; } }
            public float IntensityOneshot { get { return _intensityOneshot; } }
            public float DecrementPerSecond { get { return _decrementPerSecond; } }
            public float NotificationCooldown { get { return _notificationCooldown; } }
            public float NotificationThreshold { get { return _notificationThreshold; } }
            public float NoisinessMultiplier { get { return _noisinessMultiplier; } }
            public RpgSound M_Root { get { return m_root; } }
            public RpgSound M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private RpgSound m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public RpgSound M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
