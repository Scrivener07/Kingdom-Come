// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai.Tables
{
    public partial class RandomEvent : KaitaiStruct
    {
        public static RandomEvent FromFile(string fileName)
        {
            return new RandomEvent(new KaitaiStream(fileName));
        }

        public RandomEvent(KaitaiStream p__io, KaitaiStruct p__parent = null, RandomEvent p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, RandomEvent p__parent = null, RandomEvent p__root = null) : base(p__io)
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
            private RandomEvent m_root;
            private RandomEvent m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public RandomEvent M_Root { get { return m_root; } }
            public RandomEvent M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, RandomEvent p__parent = null, RandomEvent p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _randomEventId = m_io.ReadS4le();
                _uiCaption = m_io.ReadS4le();
                _conditionExpression = m_io.ReadS4le();
                _baseRunChance = m_io.ReadF4le();
                _nightRunChanceModif = m_io.ReadF4le();
                _mapDisappearTime = m_io.ReadF4le();
                _mapGameSpeed = m_io.ReadF4le();
                _mapIconId = m_io.ReadS4le();
                _randomEventOptionSetId = m_io.ReadS4le();
                _cooldown = m_io.ReadS4le();
            }
            private int _randomEventId;
            private int _uiCaption;
            private int _conditionExpression;
            private float _baseRunChance;
            private float _nightRunChanceModif;
            private float _mapDisappearTime;
            private float _mapGameSpeed;
            private int _mapIconId;
            private int _randomEventOptionSetId;
            private int _cooldown;
            private RandomEvent m_root;
            private RandomEvent m_parent;
            public int RandomEventId { get { return _randomEventId; } }
            public int UiCaption { get { return _uiCaption; } }
            public int ConditionExpression { get { return _conditionExpression; } }
            public float BaseRunChance { get { return _baseRunChance; } }
            public float NightRunChanceModif { get { return _nightRunChanceModif; } }
            public float MapDisappearTime { get { return _mapDisappearTime; } }
            public float MapGameSpeed { get { return _mapGameSpeed; } }
            public int MapIconId { get { return _mapIconId; } }
            public int RandomEventOptionSetId { get { return _randomEventOptionSetId; } }
            public int Cooldown { get { return _cooldown; } }
            public RandomEvent M_Root { get { return m_root; } }
            public RandomEvent M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private RandomEvent m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public RandomEvent M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
