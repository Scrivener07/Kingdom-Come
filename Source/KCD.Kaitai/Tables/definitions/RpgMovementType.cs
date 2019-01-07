// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai.Tables
{
    public partial class RpgMovementType : KaitaiStruct
    {
        public static RpgMovementType FromFile(string fileName)
        {
            return new RpgMovementType(new KaitaiStream(fileName));
        }

        public RpgMovementType(KaitaiStream p__io, KaitaiStruct p__parent = null, RpgMovementType p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, RpgMovementType p__parent = null, RpgMovementType p__root = null) : base(p__io)
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
            private RpgMovementType m_root;
            private RpgMovementType m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public RpgMovementType M_Root { get { return m_root; } }
            public RpgMovementType M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, RpgMovementType p__parent = null, RpgMovementType p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _rpgMovementTypeId = m_io.ReadS4le();
                _rpgMovementTypeName = m_io.ReadS4le();
                _staminaRegen = m_io.ReadF4le();
                _staminaRegenIsRelative = m_io.ReadS1();
                _armorLoadToRegen = m_io.ReadF4le();
                _armorLoadToSpeed = m_io.ReadF4le();
                _visibilityPenalization = m_io.ReadF4le();
                _minSurfaceSpeedMultiplier = m_io.ReadF4le();
            }
            private int _rpgMovementTypeId;
            private int _rpgMovementTypeName;
            private float _staminaRegen;
            private sbyte _staminaRegenIsRelative;
            private float _armorLoadToRegen;
            private float _armorLoadToSpeed;
            private float _visibilityPenalization;
            private float _minSurfaceSpeedMultiplier;
            private RpgMovementType m_root;
            private RpgMovementType m_parent;
            public int RpgMovementTypeId { get { return _rpgMovementTypeId; } }
            public int RpgMovementTypeName { get { return _rpgMovementTypeName; } }
            public float StaminaRegen { get { return _staminaRegen; } }
            public sbyte StaminaRegenIsRelative { get { return _staminaRegenIsRelative; } }
            public float ArmorLoadToRegen { get { return _armorLoadToRegen; } }
            public float ArmorLoadToSpeed { get { return _armorLoadToSpeed; } }
            public float VisibilityPenalization { get { return _visibilityPenalization; } }
            public float MinSurfaceSpeedMultiplier { get { return _minSurfaceSpeedMultiplier; } }
            public RpgMovementType M_Root { get { return m_root; } }
            public RpgMovementType M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private RpgMovementType m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public RpgMovementType M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
